namespace Fs.Units.Pressure

open Fs.Units

module Units =
    
    /// Pascal
    [<Measure>] type Pa = Force.Units.N / Length.Units.m / Length.Units.m
    
    /// Pounds per square inch
    [<Measure>] type psi = Force.Units.lbf / Length.Units.inch / Length.Units.inch
    
open Units
open Fs.Units.Force
open Fs.Units.Length

module Pascal =
    
    let create (x: float) = x * 1.0<Pa>
    let toPoundsPerSquareInch (x: float<Pa>) =
        let force = Newton.create 1 |> Newton.toPoundForce
        let length = Meter.create 1 |> Meter.toInches
        x * force / length / length / 1.0<Pa>
    
module PoundPerSquareInch =
    
    let create (x: float) = x * 1.0<psi>
    let toPascals (x: float<psi>) =
        let force = PoundForce.create 1 |> PoundForce.toNewtons
        let length = Inch.create 1 |> Inch.toMeters
        x * force / length / length / 1.0<psi>