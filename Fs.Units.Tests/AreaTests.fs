module AreaTests

open Expecto
open Fs.Units.Area
open Helpers

[<Tests>]
let tests config =

    let squareInchConversionTests =
        [
            "From square inch to square feet and back", (fun x -> SquareInch.create x |> SquareInch.toSquareFeet |> SquareFoot.toSquareInches)
            "From square inch to square centimeters and back", (fun x -> SquareInch.create x |> SquareInch.toSquareCentimeters |> SquareCentimeter.toSquareInches)
            "From square inch to square meters and back", (fun x -> SquareInch.create x |> SquareInch.toSquareMeters |> SquareMeter.toSquareInches)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let squareFootConversionTests =
        [
            "From square foot to square inches and back", (fun x -> SquareFoot.create x |> SquareFoot.toSquareInches |> SquareInch.toSquareFeet)
            "From square foot to square centimeters and back", (fun x -> SquareFoot.create x |> SquareFoot.toSquareCentimeters |> SquareCentimeter.toSquareFeet)
            "From square foot to square meters and back", (fun x -> SquareFoot.create x |> SquareFoot.toSquareMeters |> SquareMeter.toSquareFeet)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let squareCentimeterConversionTests =
        [
            "From square centimeter to square inches and back", (fun x -> SquareCentimeter.create x |> SquareCentimeter.toSquareInches |> SquareInch.toSquareCentimeters)
            "From square centimeter to square feet and back", (fun x -> SquareCentimeter.create x |> SquareCentimeter.toSquareFeet |> SquareFoot.toSquareCentimeters)
            "From square centimeter to square meters and back", (fun x -> SquareCentimeter.create x |> SquareCentimeter.toSquareMeters |> SquareMeter.toSquareCentimeters)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let squareMeterConversionTests =
        [
            "From square meter to square inches and back", (fun x -> SquareMeter.create x |> SquareMeter.toSquareInches |> SquareInch.toSquareMeters)
            "From square meter to square feet and back", (fun x -> SquareMeter.create x |> SquareMeter.toSquareFeet |> SquareFoot.toSquareMeters)
            "From square meter to square centimeters and back", (fun x -> SquareMeter.create x |> SquareMeter.toSquareCentimeters |> SquareCentimeter.toSquareMeters)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    testList "Area tests -> " [
        testList "Square inch conversion tests -> " squareInchConversionTests
        testList "Square foot conversion tests -> " squareFootConversionTests
        testList "Square centimeter conversion tests -> " squareCentimeterConversionTests
        testList "Square meter conversion tests -> " squareMeterConversionTests
    ]