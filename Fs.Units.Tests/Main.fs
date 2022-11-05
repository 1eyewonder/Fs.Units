module Fs.Units.Tests

open Expecto

[<EntryPoint>]
let main _ =   
    let config = {FsCheckConfig.defaultConfig with maxTest = 100; startSize = 100}
    
    [
        LengthTests.tests
        TimeTests.tests
        MassTests.tests
        TemperatureTests.tests
        AngleTests.tests
        DataStorageTests.tests
        FuelEconomyTests.tests
        FrequencyTests.tests
        IlluminanceTests.tests
        CurrentTests.tests
        AreaTests.tests
        VolumeTests.tests
    ]
    |> List.map (fun x -> x config)
    |> testList "Fs.Unit"
    |> Tests.runTestsWithCLIArgs [] [||]