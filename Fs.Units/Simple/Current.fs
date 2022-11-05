namespace Fs.Units.Current

module Units =
    
    /// Ampere
    [<Measure>] type A
    
    /// Milliampere
    [<Measure>] type mA
    
    /// Microampere
    [<Measure>] type uA
    
    /// biot
    [<Measure>] type biot
    
open Units

module Ampere =
    
    let create (x: float) = x * 1.0<A>
    let toMilliampere (x: float<A>) = x * 1e-3<mA> / 1.0<A>
    let toMicroampere (x: float<A>) = x * 1e-6<uA> / 1.0<A>
    let toBiot (x: float<A>) = x * 0.1<biot> / 1.0<A>
    
module Milliampere =
    
    let create (x: float) = x * 1.0<mA>
    let toAmpere (x: float<mA>) = x * 1e3<A> / 1.0<mA>
    let toMicroampere (x: float<mA>) = x * 1e-3<uA> / 1.0<mA>
    let toBiot (x: float<mA>) = x * 1e-4<biot> / 1.0<mA>
    
module Microampere =
    
    let create (x: float) = x * 1.0<uA>
    let toAmpere (x: float<uA>) = x * 1e6<A> / 1.0<uA>
    let toMilliampere (x: float<uA>) = x * 1e3<mA> / 1.0<uA>
    let toBiot (x: float<uA>) = x * 1e-7<biot> / 1.0<uA>
    
module Biot =
    
    let create (x: float) = x * 1.0<biot>
    let toAmpere (x: float<biot>) = x * 10.0<A> / 1.0<biot>
    let toMilliampere (x: float<biot>) = x * 1e+4<mA> / 1.0<biot>
    let toMicroampere (x: float<biot>) = x * 1e+7<uA> / 1.0<biot>
    