module VolumeTests

open Expecto
open Fs.Units.Volume
open Helpers

[<Tests>]
let tests config =

    let cubicInchConversionTests =
        [
            "From cubic inch to cubic feet and back", (fun x -> CubicInch.create x |> CubicInch.toCubicFeet |> CubicFoot.toCubicInches)
            "From cubic inch to cubic centimeters and back", (fun x -> CubicInch.create x |> CubicInch.toCubicCentimeters |> CubicCentimeter.toCubicInches)
            "From cubic inch to cubic meters and back", (fun x -> CubicInch.create x |> CubicInch.toCubicMeters |> CubicMeter.toCubicInches)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let cubicFootConversionTests =
        [
            "From cubic foot to cubic inches and back", (fun x -> CubicFoot.create x |> CubicFoot.toCubicInches |> CubicInch.toCubicFeet)
            "From cubic foot to cubic centimeters and back", (fun x -> CubicFoot.create x |> CubicFoot.toCubicCentimeters |> CubicCentimeter.toCubicFeet)
            "From cubic foot to cubic meters and back", (fun x -> CubicFoot.create x |> CubicFoot.toCubicMeters |> CubicMeter.toCubicFeet)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let cubicCentimeterConversionTests =
        [
            "From cubic centimeter to cubic inches and back", (fun x -> CubicCentimeter.create x |> CubicCentimeter.toCubicInches |> CubicInch.toCubicCentimeters)
            "From cubic centimeter to cubic feet and back", (fun x -> CubicCentimeter.create x |> CubicCentimeter.toCubicFeet |> CubicFoot.toCubicCentimeters)
            "From cubic centimeter to cubic meters and back", (fun x -> CubicCentimeter.create x |> CubicCentimeter.toCubicMeters |> CubicMeter.toCubicCentimeters)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let cubicMeterConversionTests =
        [
            "From cubic meter to cubic inches and back", (fun x -> CubicMeter.create x |> CubicMeter.toCubicInches |> CubicInch.toCubicMeters)
            "From cubic meter to cubic feet and back", (fun x -> CubicMeter.create x |> CubicMeter.toCubicFeet |> CubicFoot.toCubicMeters)
            "From cubic meter to cubic centimeters and back", (fun x -> CubicMeter.create x |> CubicMeter.toCubicCentimeters |> CubicCentimeter.toCubicMeters)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    testList "Volume tests -> " [
        testList "Cubic inch conversion tests -> " cubicInchConversionTests
        testList "Cubic foot conversion tests -> " cubicFootConversionTests
        testList "Cubic centimeter conversion tests -> " cubicCentimeterConversionTests
        testList "Cubic meter conversion tests -> " cubicMeterConversionTests
    ]