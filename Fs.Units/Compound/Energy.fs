namespace Fs.Units.Energy

open Fs.Units

module Units =
    
    /// Joule
    [<Measure>] type J = Power.Units.W * Time.Units.s
    
    /// Kilojoule
    [<Measure>] type kJ = Power.Units.kW * Time.Units.s
    
    /// British thermal unit
    [<Measure>] type BTU
    
    /// calorie
    [<Measure>] type cal
    
    /// quad
    [<Measure>] type quad
    
    [<Measure>] type Q