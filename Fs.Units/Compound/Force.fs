namespace Fs.Units.Force

open Fs.Units

module Units =
    
    /// Newton
    [<Measure>] type N = Mass.Units.kg * Length.Units.m / (Time.Units.s * Time.Units.s)
    
    /// Pound force
    [<Measure>] type lbf = Mass.Units.lbm * Length.Units.ft / (Time.Units.s * Time.Units.s)
    
    /// Dyne
    [<Measure>] type dyn = Mass.Units.g * Length.Units.cm / (Time.Units.s * Time.Units.s)
    
    /// Kip
    [<Measure>] type kip

open Units
module Newton =
    
    let create (x: float) = x * 1.0<N>