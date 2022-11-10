namespace Fs.Units.Speed

open Fs.Units

module Units =
    
    /// Feet per second
    [<Measure>] type fps = Length.Units.ft / Time.Units.s
    
    /// Meter per second
    [<Measure>] type mps = Length.Units.m / Time.Units.s
    
    /// Kilometer per hour
    [<Measure>] type kph = Length.Units.km / Time.Units.hr
    
    /// Mile per hour
    [<Measure>] type mph = Length.Units.mi / Time.Units.hr

open Units
open Fs.Units.Length
open Fs.Units.Time

module FeetPerSecond =

    let create (x: float) = x * 1.0<fps>
    let toMetersPerSecond (x: float<fps>) =
        let length = Foot.create 1 |> Foot.toMeters
        let time = Second.create 1
        x * length / time / 1.0<fps>
    let toKilometersPerHour (x: float<fps>) =
        let length = Foot.create 1 |> Foot.toKilometers
        let time = Second.create 1 |> Second.toHours
        x * length / time / 1.0<fps>
    let toMilesPerHour (x: float<fps>) =
        let length = Foot.create 1 |> Foot.toMiles
        let time = Second.create 1 |> Second.toHours
        x * length / time / 1.0<fps>      

module MeterPerSecond =

    let create (x: float) = x * 1.0<mps>
    let toFeetPerSecond (x: float<mps>) =
        let length = Meter.create 1 |> Meter.toFeet
        let time = Second.create 1
        x * length / time / 1.0<mps>
    let toKilometersPerHour (x: float<mps>) =
        let length = Meter.create 1 |> Meter.toKilometers
        let time = Second.create 1 |> Second.toHours
        x * length / time / 1.0<mps>
    let toMilesPerHour (x: float<mps>) =
        let length = Meter.create 1 |> Meter.toMiles
        let time = Second.create 1 |> Second.toHours
        x * length / time / 1.0<mps>
        
module KilometerPerHour =
    
    let create (x: float) = x * 1.0<kph>
    let toFeetPerSecond (x: float<kph>) =
        let length = Kilometer.create 1 |> Kilometer.toFeet
        let time = Hour.create 1 |> Hour.toSeconds
        x * length / time / 1.0<kph>
    let toMetersPerSecond (x: float<kph>) =
        let length = Kilometer.create 1 |> Kilometer.toMeters
        let time = Hour.create 1 |> Hour.toSeconds
        x * length / time / 1.0<kph>
    let toMilesPerHour (x: float<kph>) =
        let length = Kilometer.create 1 |> Kilometer.toMiles
        let time = Hour.create 1
        x * length / time / 1.0<kph>
        
module MilePerHour =
    
    let create (x: float) = x * 1.0<mph>
    let toFeetPerSecond (x: float<mph>) =
        let length = Mile.create 1 |> Mile.toFeet
        let time = Hour.create 1 |> Hour.toSeconds
        x * length / time / 1.0<mph>
    let toMetersPerSecond (x: float<mph>) =
        let length = Mile.create 1 |> Mile.toMeters
        let time = Hour.create 1 |> Hour.toSeconds
        x * length / time / 1.0<mph>
    let toKilometersPerHour (x: float<mph>) =
        let length = Mile.create 1 |> Mile.toKilometers
        let time = Hour.create 1
        x * length / time / 1.0<mph>