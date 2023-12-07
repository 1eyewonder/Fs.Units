open Fake.Api
open Fake.Core
open Fake.IO
open Fake.DotNet
open Fake.IO.FileSystemOperators
open Fake.Core.TargetOperators
open Fake.DotNet.Testing
open Fake.IO.Globbing.Operators
open Fake.Tools
open System
open System.IO
open Fake.BuildServer

let project = "Fs.Units"
let summary = "A simple library for working with units of measure in .NET"
let configuration = "Release"
let solutionFile = "Fs.Units.sln"

let rootDir = __SOURCE_DIRECTORY__ </> ".."

let srcGlob = rootDir </> "src/**/*.??proj"

let testsGlob = rootDir </> "tests/**/*.??proj"

let srcAndTest = !!srcGlob ++ testsGlob

let srcCodeGlob =
  !!(rootDir </> "src/**/*.fs") ++ (rootDir </> "src/**/*.fsx")
  -- (rootDir </> "src/**/obj/**/*.fs")

let testsCodeGlob =
  !!(rootDir </> "tests/**/*.fs") ++ (rootDir </> "tests/**/*.fsx")
  -- (rootDir </> "tests/**/obj/**/*.fs")

let gitOwner = "1eyewonder"

let distDir = rootDir @@ "bin"

let distGlob = distDir @@ "*.nupkg"

let githubToken = Environment.environVarOrNone "GITHUB_TOKEN"

let nugetToken = Environment.environVarOrNone "NUGET_TOKEN"

let failOnBadExitAndPrint (p: ProcessResult) =
  if p.ExitCode <> 0 then
    p.Errors |> Seq.iter Trace.traceError

    failwithf "failed with exitcode %d" p.ExitCode

module dotnet =
  let watch cmdParam program args =
    DotNet.exec cmdParam (sprintf "watch %s" program) args

  let run cmdParam args = DotNet.exec cmdParam "run" args

  let tool optionConfig command args =
    DotNet.exec optionConfig (sprintf "%s" command) args |> failOnBadExitAndPrint

  let fantomas args = DotNet.exec id "fantomas" args

let formatCode _ =
  let result = dotnet.fantomas "."

  if not result.OK then
    Trace.traceErrorfn "Errors while formatting all files: %A" result.Messages

let checkFormatCode _ =
  let result = dotnet.fantomas "--check ."

  if result.ExitCode = 0 then
    Trace.log "No files need formatting"
  elif result.ExitCode = 99 then
    failwith "Some files need formatting, check output for more info"
  else
    Trace.logf "Errors while formatting: %A" result.Errors

let clean _ =
  !! "bin" ++ "src/**/bin" ++ "tests/**/bin" ++ "src/**/obj" ++ "tests/**/obj"
  |> Shell.cleanDirs

  [ "paket-files/paket.restore.cached" ] |> Seq.iter Shell.rm

let build _ =
  let setParams (defaults: DotNet.BuildOptions) =
    { defaults with
        NoRestore = true
        Configuration = DotNet.BuildConfiguration.fromString configuration
    }

  DotNet.build setParams solutionFile

let restore _ =
  Fake.DotNet.Paket.restore (fun p -> { p with ToolType = ToolType.CreateLocalTool() })

  DotNet.restore id solutionFile

let dotnetTest ctx =

  let args = [ "--no-build" ]

  DotNet.test
    (fun c ->

      { c with
          Configuration = DotNet.BuildConfiguration.Release
          Common = c.Common |> DotNet.Options.withAdditionalArgs args
      })
    solutionFile

let release = ReleaseNotes.load (rootDir </> "RELEASE_NOTES.md")

let generateAssemblyInfo _ =
  let getAssemblyInfoAttributes projectName =
    [
      AssemblyInfo.Title(projectName)
      AssemblyInfo.Product project
      AssemblyInfo.Description summary
      AssemblyInfo.Version release.AssemblyVersion
      AssemblyInfo.FileVersion release.AssemblyVersion
      AssemblyInfo.Configuration configuration
    ]

  let getProjectDetails (projectPath: string) =
    let projectName = Path.GetFileNameWithoutExtension(projectPath)

    (projectPath, projectName, Path.GetDirectoryName(projectPath), (getAssemblyInfoAttributes projectName))

  srcAndTest
  |> Seq.map getProjectDetails
  |> Seq.iter (fun (_, _, folderName, attributes) ->
    AssemblyInfoFile.createFSharp (folderName </> "AssemblyInfo.fs") attributes)

let releaseNotes = String.toLines release.Notes

let dotnetPack _ =
  [ solutionFile ]
  |> Seq.iter (
    DotNet.pack (fun p ->
      { p with
          // ./bin from the solution root matching the "PublishNuget" target WorkingDir
          OutputPath = Some distDir
          Configuration = DotNet.BuildConfiguration.Release
          MSBuildParams =
            { MSBuild.CliArguments.Create() with
                // "/p" (property) arguments to MSBuild.exe
                Properties = [ ("Version", release.NugetVersion); ("PackageReleaseNotes", releaseNotes) ]
            }
      })
  )

let publishNuget _ =
  DotNet.nugetPush
    (fun c ->
      { c with
          Common = { c.Common with WorkingDirectory = distDir }
          PushParams =
            { c.PushParams with
                Source = Some "https://www.nuget.org"
                ApiKey = nugetToken
            }
      })
    "*.nupkg"

  Paket.push (fun p ->
    { p with
        ToolType = ToolType.CreateLocalTool()
        PublishUrl = "https://www.nuget.org"
        WorkingDir = distDir
        ApiKey =
          match nugetToken with
          | Some s -> s
          | _ -> p.ApiKey // assume paket-config was set properly
    })

let remote = Environment.environVarOrDefault "FSTK_GIT_REMOTE" "origin"

let gitRelease _ =

  Git.Staging.stageAll ""
  Git.Commit.exec "" (sprintf "Bump version to %s\n\n%s" release.NugetVersion releaseNotes)
  Git.Branches.push ""

  Git.Branches.tag "" release.NugetVersion
  Git.Branches.pushTag "" remote release.NugetVersion

let githubRelease _ =
  let token =
    match githubToken with
    | Some s -> s
    | _ ->
      failwith "please set the github_token environment variable to a github personal access token with repo access."

  let files = !!distGlob

  GitHub.createClientWithToken token
  |> GitHub.draftNewRelease
    gitOwner
    project
    release.NugetVersion
    (release.SemVer.PreRelease <> None)
    (releaseNotes |> Seq.singleton)
  |> GitHub.uploadFiles files
  |> GitHub.publishDraft
  |> Async.RunSynchronously

let initTargets () =

  BuildServer.install [ GitHubActions.Installer ]

  Option.iter (TraceSecrets.register "<GITHUB_TOKEN>") githubToken
  Option.iter (TraceSecrets.register "<NUGET_TOKEN>") nugetToken

  Target.create "Clean" clean
  Target.create "Build" build
  Target.create "Restore" restore
  Target.create "Test" dotnetTest
  Target.create "CheckFormat" checkFormatCode
  Target.create "AssemblyInfo" generateAssemblyInfo
  Target.create "DotnetPack" dotnetPack
  Target.create "PublishNuget" publishNuget
  Target.create "GitRelease" gitRelease
  Target.create "GitHubRelease" githubRelease
  Target.create "Release" ignore

  // *** Define Dependencies ***
  "Clean"
  ==> "AssemblyInfo"
  ==> "Restore"
  ==> "CheckFormat"
  ==> "Build"
  ==> "Test"
  ==> "DotnetPack"
  ==> "PublishNuGet"
  ==> "GitRelease"
  ==> "GitHubRelease"
  ==> "Release"

//-----------------------------------------------------------------------------
// Target Start
//-----------------------------------------------------------------------------
[<EntryPoint>]
let main argv =
  argv
  |> Array.toList
  |> Context.FakeExecutionContext.Create false "build.fsx"
  |> Context.RuntimeContext.Fake
  |> Context.setExecutionContext

  initTargets () |> ignore

  Target.runOrDefaultWithArguments "NuGet"

  0 // return an integer exit code
