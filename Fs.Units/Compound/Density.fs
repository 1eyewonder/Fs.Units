namespace Fs.Units.Density

open Fs.Units

module Units =
    
    /// Kilogram per cubic meter
    [<Measure>] type kgm3 = Mass.Units.kg / Volume.Units.m3
    
    /// Gram per cubic centimeter
    [<Measure>] type gcm3 = Mass.Units.g / Volume.Units.cm3
    
    /// Pound mass per cubic foot
    [<Measure>] type lbmft3 = Mass.Units.lbm / Volume.Units.ft3
    
    /// Pound mass per cubic inch
    [<Measure>] type lbmin3 = Mass.Units.lbm / Volume.Units.in3