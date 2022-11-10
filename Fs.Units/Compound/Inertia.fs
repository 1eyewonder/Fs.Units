namespace Fs.Units.Inertia

open Fs.Units

module Units =
    
    [<Measure>] type in4 = Length.Units.inch * Length.Units.inch * Length.Units.inch * Length.Units.inch
    
    [<Measure>]
    type cm4 = Length.Units.cm * Length.Units.cm * Length.Units.cm * Length.Units.cm
    
open Units
open Fs.Units.Length

module QuarticInch =
    
    let create (x:float) = x * 1.0<in4>
    let toQuarticCentimeters (x: float<in4>) =
        let length = Inch.create 1 |> Inch.toCentimeters
        x * length * length * length * length / 1.0<in4>

module QuarticCentimeter =

    let create (x:float) = x * 1.0<cm4>
    let toQuarticInches (x: float<cm4>) =
        let length = Centimeter.create 1 |> Centimeter.toInches
        x * length * length * length * length / 1.0<cm4>