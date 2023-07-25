open BenchmarkDotNet.Attributes
open BenchmarkDotNet.Running
open Fs.Units

let myTestData = [ 1.; 2.; 3.; 4.; 5. ]
let ft2Data = myTestData |> List.map SquareFoot.create

let newtonData = myTestData |> List.map Newton.create

[<MemoryDiagnoser>]
type Benchmarks() =

    //ft2 to in2
    let testFunction1 (x: float<ft2>) = x * 144.0<in2> / 1.0<ft2>

    //ft2 to in2
    let testFunction2 (x: float<ft2>) =
        let a = Foot.create 1 |> Foot.toInches
        x * (a * a) / 1.0<ft2>

    // newton to lbf
    let testFunction3 (x: float<N>) =
        let mass = Kilogram.create 1 |> Kilogram.toPoundMass
        let length = Meter.create 1 |> Meter.toFeet
        let time = Second.create 1
        x * mass * length / time / time / 1.0<N>

    [<Benchmark>]
    member _.CompoundUnitOfMeasureConvert1() = ft2Data |> List.map testFunction1

    [<Benchmark>]
    member _.CompoundUnitOfMeasureConvert2() = ft2Data |> List.map testFunction2

    [<Benchmark>]
    member _.CompoundUnitOfMeasureConvert3() = newtonData |> List.map testFunction3

[<EntryPoint>]
let main _ =
    let _ = BenchmarkRunner.Run<Benchmarks>()
    0
