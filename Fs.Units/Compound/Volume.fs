namespace Fs.Units.Volume

open Fs.Units

module Units =
    
    /// Cubic inch
    [<Measure>] type in3 = Length.Units.inch * Length.Units.inch * Length.Units.inch
    
    /// Cubic foot
    [<Measure>] type ft3 = Length.Units.ft * Length.Units.ft * Length.Units.ft
    
    /// Cubic centimeter
    [<Measure>] type cm3 = Length.Units.cm * Length.Units.cm * Length.Units.cm
    
    /// Cubic meter
    [<Measure>] type m3 = Length.Units.m * Length.Units.m * Length.Units.m
    
open Units
open Fs.Units.Length

module CubicInch =
    
    let create (x: float) = x * 1.0<in3>
    let toCubicFeet (x: float<in3>) =
        let length = Inch.create 1 |> Inch.toFeet
        x * length * length * length / 1.0<in3>
    let toCubicCentimeters (x: float<in3>) =
        let length = Inch.create 1 |> Inch.toCentimeters
        x * length * length * length / 1.0<in3>
    let toCubicMeters (x: float<in3>) =
        let length = Inch.create 1 |> Inch.toMeters
        x * length * length * length / 1.0<in3>
        
module CubicFoot =
    
    let create (x: float) = x * 1.0<ft3>
    let toCubicInches (x: float<ft3>) =
        let length = Foot.create 1 |> Foot.toInches
        x * length * length * length / 1.0<ft3>
    let toCubicCentimeters (x: float<ft3>) =
        let length = Foot.create 1 |> Foot.toCentimeters
        x * length * length * length / 1.0<ft3>
    let toCubicMeters (x: float<ft3>) =
        let length = Foot.create 1 |> Foot.toMeters
        x * length * length * length / 1.0<ft3>
        
module CubicCentimeter =
    
    let create (x: float) = x * 1.0<cm3>
    let toCubicInches (x: float<cm3>) =
        let length = Centimeter.create 1 |> Centimeter.toInches
        x * length * length * length / 1.0<cm3>
    let toCubicFeet (x: float<cm3>) =
        let length = Centimeter.create 1 |> Centimeter.toFeet
        x * length * length * length / 1.0<cm3>
    let toCubicMeters (x: float<cm3>) =
        let length = Centimeter.create 1 |> Centimeter.toMeters
        x * length * length * length / 1.0<cm3>
        
module CubicMeter =
    
    let create (x: float) = x * 1.0<m3>
    let toCubicInches (x: float<m3>) =
        let length = Meter.create 1 |> Meter.toInches
        x * length * length * length / 1.0<m3>
    let toCubicFeet (x: float<m3>) =
        let length = Meter.create 1 |> Meter.toFeet
        x * length * length * length / 1.0<m3>
    let toCubicCentimeters (x: float<m3>) =
        let length = Meter.create 1 |> Meter.toCentimeters
        x * length * length * length / 1.0<m3>

