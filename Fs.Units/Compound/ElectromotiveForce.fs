namespace Fs.Units.ElectromotiveForce

open Fs.Units

module Units =
    
    /// Microvolt
    [<Measure>] type uV
    
    /// Millivolt
    [<Measure>] type mV
    
    /// Volt
    [<Measure>] type V = Energy.Units.J / ElectricCharge.Units.C
    
    /// Kilovolt
    [<Measure>] type kV
    
    /// Megavolt
    [<Measure>] type MV
    