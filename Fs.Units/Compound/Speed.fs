namespace Fs.Units.Speed

open Fs.Units

module Units =
    
    /// Feet per second
    [<Measure>] type fps = Length.Units.ft / Time.Units.s
    
    /// Meter per second
    [<Measure>] type mps = Length.Units.m / Time.Units.s
    
    /// Kilometer per hour
    [<Measure>] type kph = Length.Units.km / Time.Units.s
    
    /// Mile per hour
    [<Measure>] type mph = Length.Units.mi / Time.Units.s