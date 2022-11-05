module FrequencyTests

open Expecto
open Fs.Units.Frequency
open Helpers

[<Tests>]
let tests config =
    
    let hertzConversionTest =
        [
            "From hertz to kilohertz and back", (fun x -> Hertz.create x |> Hertz.toKilohertz |> Kilohertz.toHertz)
            "From hertz to megahertz and back", (fun x -> Hertz.create x |> Hertz.toMegahertz |> Megahertz.toHertz)
            "From hertz to gigahertz and back", (fun x -> Hertz.create x |> Hertz.toGigahertz |> Gigahertz.toHertz)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let kilohertzConversionTest =
        [
            "From kilohertz to hertz and back", (fun x -> Kilohertz.create x |> Kilohertz.toHertz |> Hertz.toKilohertz)
            "From kilohertz to megahertz and back", (fun x -> Kilohertz.create x |> Kilohertz.toMegahertz |> Megahertz.toKilohertz)
            "From kilohertz to gigahertz and back", (fun x -> Kilohertz.create x |> Kilohertz.toGigahertz |> Gigahertz.toKilohertz)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let megahertzConversionTest =
        [
            "From megahertz to hertz and back", (fun x -> Megahertz.create x |> Megahertz.toHertz |> Hertz.toMegahertz)
            "From megahertz to kilohertz and back", (fun x -> Megahertz.create x |> Megahertz.toKilohertz |> Kilohertz.toMegahertz)
            "From megahertz to gigahertz and back", (fun x -> Megahertz.create x |> Megahertz.toGigahertz |> Gigahertz.toMegahertz)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let gigahertzConversionTest =
        [
            "From gigahertz to hertz and back", (fun x -> Gigahertz.create x |> Gigahertz.toHertz |> Hertz.toGigahertz)
            "From gigahertz to kilohertz and back", (fun x -> Gigahertz.create x |> Gigahertz.toKilohertz |> Kilohertz.toGigahertz)
            "From gigahertz to megahertz and back", (fun x -> Gigahertz.create x |> Gigahertz.toMegahertz |> Megahertz.toGigahertz)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    testList "Frequency tests -> " [
       testList "Hertz conversion tests -> " hertzConversionTest
       testList "Kilohertz conversion tests -> " kilohertzConversionTest
       testList "Megahertz conversion tests -> " megahertzConversionTest
       testList "Gigahertz conversion tests -> " gigahertzConversionTest
    ]