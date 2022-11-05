namespace Fs.Units.Power

open Fs.Units

module Units =
    
    /// Watt
    [<Measure>] type W = Force.Units.N * Length.Units.m / Time.Units.s
    
    /// Kilowatt
    [<Measure>] type kW
    
    /// Imperial horsepower
    [<Measure>] type hp
    
    /// Metric horsepower
    [<Measure>] type hk
    
    /// Ton of refrigeration
    [<Measure>] type TR
    
    