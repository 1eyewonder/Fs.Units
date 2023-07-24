namespace Fs.Units
    
[<AutoOpen>]
module Current =
    
    /// Microampere
    [<Measure>] type uA

    /// Milliampere
    [<Measure>] type mA

    /// Ampere
    [<Measure>] type A

    /// biot
    [<Measure>] type biot

    [<RequireQualifiedAccess>]
    module Microampere =
        
        let create (x: float) = x * 1.0<uA>
        let toAmperes (x: float<uA>) = x * 1e6<A> / 1.0<uA>
        let toMilliamperes (x: float<uA>) = x * 1e3<mA> / 1.0<uA>
        let toBiots (x: float<uA>) = x * 1e-7<biot> / 1.0<uA>
        
    [<RequireQualifiedAccess>]
    module Milliampere =
        
        let create (x: float) = x * 1.0<mA>
        let toAmperes (x: float<mA>) = x * 1e3<A> / 1.0<mA>
        let toMicroamperes (x: float<mA>) = x * 1e-3<uA> / 1.0<mA>
        let toBiots (x: float<mA>) = x * 1e-4<biot> / 1.0<mA>
        
    [<RequireQualifiedAccess>]
    module Ampere =
        
        let create (x: float) = x * 1.0<A>
        let toMilliamperes (x: float<A>) = x * 1e-3<mA> / 1.0<A>
        let toMicroamperes (x: float<A>) = x * 1e-6<uA> / 1.0<A>
        let toBiots (x: float<A>) = x * 0.1<biot> / 1.0<A>

    [<RequireQualifiedAccess>]
    module Biot =
        
        let create (x: float) = x * 1.0<biot>
        let toAmperes (x: float<biot>) = x * 10.0<A> / 1.0<biot>
        let toMilliamperes (x: float<biot>) = x * 1e+4<mA> / 1.0<biot>
        let toMicroamperes (x: float<biot>) = x * 1e+7<uA> / 1.0<biot>
    