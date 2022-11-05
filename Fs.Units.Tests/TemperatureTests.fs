module TemperatureTests

open Expecto
open Fs.Units.Temperature
open Helpers

[<Tests>]
let tests config =
    
    let kelvinConversionTests =
        [
            "From kelvin to celsius and back", (fun x -> Kelvin.create x |> Kelvin.toCelsius |> Celsius.toKelvin)
            "From kelvin to fahrenheit and back", (fun x -> Kelvin.create x |> Kelvin.toFahrenheit |> Fahrenheit.toKelvin)
            "From kelvin to rankine and back", (fun x -> Kelvin.create x |> Kelvin.toRankine |> Rankine.toKelvin)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let celsiusConversionTests =
        [
            "From celsius to kelvin and back", (fun x -> Celsius.create x |> Celsius.toKelvin |> Kelvin.toCelsius)
            "From celsius to fahrenheit and back", (fun x -> Celsius.create x |> Celsius.toFahrenheit |> Fahrenheit.toCelsius)
            "From celsius to rankine and back", (fun x -> Celsius.create x |> Celsius.toRankine |> Rankine.toCelsius)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let fahrenheitConversionTests =
        [
            "From fahrenheit to kelvin and back", (fun x -> Fahrenheit.create x |> Fahrenheit.toKelvin |> Kelvin.toFahrenheit)
            "From fahrenheit to celsius and back", (fun x -> Fahrenheit.create x |> Fahrenheit.toCelsius |> Celsius.toFahrenheit)
            "From fahrenheit to rankine and back", (fun x -> Fahrenheit.create x |> Fahrenheit.toRankine |> Rankine.toFahrenheit)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let rankineConversionTests =
        [
            "From rankine to kelvin and back", (fun x -> Rankine.create x |> Rankine.toKelvin |> Kelvin.toRankine)
            "From rankine to celsius and back", (fun x -> Rankine.create x |> Rankine.toCelsius |> Celsius.toRankine)
            "From rankine to fahrenheit and back", (fun x -> Rankine.create x |> Rankine.toFahrenheit |> Fahrenheit.toRankine)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    testList "Temperature Tests -> " [
        testList "Kelvin conversion tests -> " kelvinConversionTests
        testList "Celsius conversion tests -> " celsiusConversionTests
        testList "Fahrenheit conversion tests -> " fahrenheitConversionTests
        testList "Rankine conversion tests -> " rankineConversionTests
    ]
