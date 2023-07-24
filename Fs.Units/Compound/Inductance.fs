namespace Fs.Units
    
[<AutoOpen>]
module Inductance =
    
    /// Microhenry
    [<Measure>] type uH

    /// Millihenry
    [<Measure>] type mH

    /// Henry
    [<Measure>] type H

    [<RequireQualifiedAccess>]
    module MicroHenry =
        
        let create (x: float) = x * 1.0<uH>
        let toMilliHenrys (x: float<uH>) = x * 1.0<mH> / 1e+3<uH>
        let toHenrys (x: float<uH>) = x * 1.0<H> / 1e+6<uH>
        
    [<RequireQualifiedAccess>]
    module MilliHenry =
        
        let create (x: float) = x * 1.0<mH>
        let toMicroHenrys (x: float<mH>) = x * 1.0<uH> / 1e-3<mH>
        let toHenrys (x: float<mH>) = x * 1.0<H> / 1e+3<mH>
        
    [<RequireQualifiedAccess>]
    module Henry =
        
        let create (x: float) = x * 1.0<H>
        let toMicroHenrys (x: float<H>) = x * 1.0<uH> / 1e-6<H>
        let toMilliHenrys (x: float<H>) = x * 1.0<mH> / 1e-3<H>
    
