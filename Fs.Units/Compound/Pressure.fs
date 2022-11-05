namespace Fs.Units.Pressure

open Fs.Units

module Units =
    
    /// Pascal
    [<Measure>] type Pa = Force.Units.N / Length.Units.m / Length.Units.m
    
    /// Pounds per square inch
    [<Measure>] type psi = Force.Units.lbf / Length.Units.inch / Length.Units.inch
    
