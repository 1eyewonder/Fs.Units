namespace Fs.Units

[<AutoOpen>]
module Illuminance =

    /// Footcandle
    [<Measure>]
    type fc

    /// Lux
    [<Measure>]
    type lx

    /// Phot
    [<Measure>]
    type ph

    /// Nox
    [<Measure>]
    type nox

    [<RequireQualifiedAccess>]
    module Footcandle =

        let create (x: float) = x * 1.0<fc>
        let toLux (x: float<fc>) = x * 10.7639<lx> / 1.0<fc>
        let toPhot (x: float<fc>) = x / 929.03<fc> * 1.0<ph>
        let toNox (x: float<fc>) = x * 10763.9104167<nox> / 1.0<fc>

    [<RequireQualifiedAccess>]
    module Lux =

        let create (x: float) = x * 1.0<lx>
        let toFootcandle (x: float<lx>) = x * 1.0<fc> / 10.7639<lx>
        let toPhot (x: float<lx>) = x * 0.0001<ph> / 1.0<lx>
        let toNox (x: float<lx>) = x * 1000.0<nox> / 1.0<lx>

    [<RequireQualifiedAccess>]
    module Phot =

        let create (x: float) = x * 1.0<ph>
        let toFootcandle (x: float<ph>) = x * 929.03<fc> / 1.0<ph>
        let toLux (x: float<ph>) = x * 1e+4<lx> / 1.0<ph>
        let toNox (x: float<ph>) = x * 1e+7<nox> / 1.0<ph>

    [<RequireQualifiedAccess>]
    module Nox =

        let create (x: float) = x * 1.0<nox>
        let toFootcandle (x: float<nox>) = x * 1.0<fc> / 10763.9104167<nox>
        let toLux (x: float<nox>) = x * 1.0<lx> / 1e+3<nox>
        let toPhot (x: float<nox>) = x * 1.0<ph> / 1e+7<nox>
