module IlluminanceTests

open Expecto
open Fs.Units.Illuminance
open Helpers

[<Tests>]
let tests config =
    
    let footcandleConversionTests =
        [
            "From footcandle to lux and back", (fun x -> Footcandle.create x |> Footcandle.toLux |> Lux.toFootcandle)
            "From footcandle to phot and back", (fun x -> Footcandle.create x |> Footcandle.toPhot |> Phot.toFootcandle)
            "From footcandle to nox and back", (fun x -> Footcandle.create x |> Footcandle.toNox |> Nox.toFootcandle)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let luxConversionTests =
        [
            "From lux to footcandle and back", (fun x -> Lux.create x |> Lux.toFootcandle |> Footcandle.toLux)
            "From lux to phot and back", (fun x -> Lux.create x |> Lux.toPhot |> Phot.toLux)
            "From lux to nox and back", (fun x -> Lux.create x |> Lux.toNox |> Nox.toLux)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let photConversionTests =
        [
            "From phot to footcandle and back", (fun x -> Phot.create x |> Phot.toFootcandle |> Footcandle.toPhot)
            "From phot to lux and back", (fun x -> Phot.create x |> Phot.toLux |> Lux.toPhot)
            "From phot to nox and back", (fun x -> Phot.create x |> Phot.toNox |> Nox.toPhot)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let noxConversionTests =
        [
            "From nox to footcandle and back", (fun x -> Nox.create x |> Nox.toFootcandle |> Footcandle.toNox)
            "From nox to lux and back", (fun x -> Nox.create x |> Nox.toLux |> Lux.toNox)
            "From nox to phot and back", (fun x -> Nox.create x |> Nox.toPhot |> Phot.toNox)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    testList "Illuminance tests -> " [
        testList "Footcandle conversion tests -> " footcandleConversionTests
        testList "Lux conversion tests -> " luxConversionTests
        testList "Phot conversion tests -> " photConversionTests
        testList "Nox conversion tests -> " noxConversionTests
    ]

