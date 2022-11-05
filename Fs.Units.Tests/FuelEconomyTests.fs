module FuelEconomyTests

open Expecto
open Fs.Units.FuelEconomy
open Helpers

[<Tests>]
let tests config =

    let kilometerPerLiterConversionTests =
        [
            "From km/l to mpg", (fun x -> KilometerPerLiter.create x |> KilometerPerLiter.toMilesPerGallon |> MilePerGallon.toKilometersPerLiter)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let milePerGallonConversionTests =
        [
            "From mpg to km/l", (fun x -> MilePerGallon.create x |> MilePerGallon.toKilometersPerLiter |> KilometerPerLiter.toMilesPerGallon)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    testList "Fuel economy tests -> " [
       testList "Kilometer per liter tests -> " kilometerPerLiterConversionTests
       testList "Mile per gallon tests -> " milePerGallonConversionTests
    ]