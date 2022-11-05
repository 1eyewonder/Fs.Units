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

module CubicInch =
    
    let create (x: float) = x * 1.0<in3>
    let toCubicFeet (x: float<in3>) = x / 1728.0<in3> * 1.0<ft3>
    let toCubicCentimeters (x: float<in3>) = x * 16.387064<cm3> / 1.0<in3>
    let toCubicMeters (x: float<in3>) = x / 61023.7<in3> * 1.0<m3>
    
module CubicFoot =
    
    let create (x: float) = x * 1.0<ft3>
    let toCubicInches (x: float<ft3>) = x * 1728.0<in3> / 1.0<ft3>
    let toCubicCentimeters (x: float<ft3>) = x * 28316.8<cm3> / 1.0<ft3>
    let toCubicMeters (x: float<ft3>) = x / 35.3147<ft3> * 1.0<m3>
    
module CubicCentimeter =
    
    let create (x: float) = x * 1.0<cm3>
    let toCubicInches (x: float<cm3>) = x / 16.387064<cm3> * 1.0<in3>
    let toCubicFeet (x: float<cm3>) = x / 28316.8<cm3> * 1.0<ft3>
    let toCubicMeters (x: float<cm3>) = x / 1000000.0<cm3> * 1.0<m3>
    
module CubicMeter =
    
    let create (x: float) = x * 1.0<m3>
    let toCubicInches (x: float<m3>) = x * 61023.7<in3> / 1.0<m3>
    let toCubicFeet (x: float<m3>) = x * 35.3147<ft3> / 1.0<m3>
    let toCubicCentimeters (x: float<m3>) = x * 1000000.0<cm3> / 1.0<m3>
