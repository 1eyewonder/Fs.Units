module CurrentTests

open Expecto
open Fs.Units.Current
open Helpers

[<Tests>]
let tests config =
    
    let ampereConversionTests =
        [
            "From ampere to milliampere and back", (fun x -> Ampere.create x |> Ampere.toMilliampere |> Milliampere.toAmpere)
            "From ampere to microampere and back", (fun x -> Ampere.create x |> Ampere.toMicroampere |> Microampere.toAmpere)
            "From ampere to biot and back", (fun x -> Ampere.create x |> Ampere.toBiot |> Biot.toAmpere)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let milliampereConversionTests =
        [
            "From milliampere to ampere and back", (fun x -> Milliampere.create x |> Milliampere.toAmpere |> Ampere.toMilliampere)
            "From milliampere to microampere and back", (fun x -> Milliampere.create x |> Milliampere.toMicroampere |> Microampere.toMilliampere)
            "From milliampere to biot and back", (fun x -> Milliampere.create x |> Milliampere.toBiot |> Biot.toMilliampere)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let microampereConversionTests =
        [
            "From microampere to ampere and back", (fun x -> Microampere.create x |> Microampere.toAmpere |> Ampere.toMicroampere)
            "From microampere to milliampere and back", (fun x -> Microampere.create x |> Microampere.toMilliampere |> Milliampere.toMicroampere)
            "From microampere to biot and back", (fun x -> Microampere.create x |> Microampere.toBiot |> Biot.toMicroampere)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let biotConversionTests =
        [
            "From biot to ampere and back", (fun x -> Biot.create x |> Biot.toAmpere |> Ampere.toBiot)
            "From biot to milliampere and back", (fun x -> Biot.create x |> Biot.toMilliampere |> Milliampere.toBiot)
            "From biot to microampere and back", (fun x -> Biot.create x |> Biot.toMicroampere |> Microampere.toBiot)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    testList "Current tests -> " [
        testList "Ampere conversion tests -> " ampereConversionTests
        testList "Milliampere conversion tests -> " milliampereConversionTests
        testList "Microampere conversion tests -> " microampereConversionTests
        testList "Biot conversion tests -> " biotConversionTests
    ]