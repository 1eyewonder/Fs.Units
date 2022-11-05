module MassTests

open Expecto
open Fs.Units.Mass
open Helpers

[<Tests>]
let tests config =
    
    let milligramConversionTests =
        [
            "From milligram to gram and back", (fun x -> Milligram.create x |> Milligram.toGrams |> Gram.toMilligrams)
            "From milligram to kilogram and back", (fun x -> Milligram.create x |> Milligram.toKilograms |> Kilogram.toMilligrams)
            "From milligram to pound and back", (fun x -> Milligram.create x |> Milligram.toPounds |> Pound.toMilligrams)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let gramConversionTests =
        [
            "From gram to milligram and back", (fun x -> Gram.create x |> Gram.toMilligrams |> Milligram.toGrams)
            "From gram to kilogram and back", (fun x -> Gram.create x |> Gram.toKilograms |> Kilogram.toGrams)
            "From gram to pound and back", (fun x -> Gram.create x |> Gram.toPounds |> Pound.toGrams)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let kilogramConversionTests =
        [
            "From kilogram to milligram and back", (fun x -> Kilogram.create x |> Kilogram.toMilligrams |> Milligram.toKilograms)
            "From kilogram to gram and back", (fun x -> Kilogram.create x |> Kilogram.toGrams |> Gram.toKilograms)
            "From kilogram to pound and back", (fun x -> Kilogram.create x |> Kilogram.toPounds |> Pound.toKilograms)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let poundConversionTests =
        [
            "From pound to milligram and back", (fun x -> Pound.create x |> Pound.toMilligrams |> Milligram.toPounds)
            "From pound to gram and back", (fun x -> Pound.create x |> Pound.toGrams |> Gram.toPounds)
            "From pound to kilogram and back", (fun x -> Pound.create x |> Pound.toKilograms |> Kilogram.toPounds)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    testList "Mass tests -> " [
        testList "Milligram conversion tests -> " milligramConversionTests
        testList "Gram conversion tests -> " gramConversionTests
        testList "Kilogram conversion tests -> " kilogramConversionTests
        testList "Pound conversion tests -> " poundConversionTests
    ]

