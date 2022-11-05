namespace Fs.Units.ElectricCharge

open Fs.Units

module Units =
    
    /// Coloumb
    [<Measure>] type C = Current.Units.A * Time.Units.s
    
    /// Ampere-hour
    [<Measure>] type Ah = Current.Units.A * Time.Units.hr
    
    /// Ampere-second
    [<Measure>] type As = Current.Units.A * Time.Units.s

