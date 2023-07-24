namespace Fs.Units

[<AutoOpen>]
module Frequency =

    /// Hertz
    [<Measure>]
    type Hz

    /// Kilohertz
    [<Measure>]
    type kHz

    /// Megahertz
    [<Measure>]
    type MHz

    /// Gigahertz
    [<Measure>]
    type GHz

    [<RequireQualifiedAccess>]
    module Hertz =

        let create (x: float) = x * 1.0<Hz>
        let toKilohertz (x: float<Hz>) = x / 1e+3<Hz> * 1.0<kHz>
        let toMegahertz (x: float<Hz>) = x / 1e+6<Hz> * 1.0<MHz>
        let toGigahertz (x: float<Hz>) = x / 1e+9<Hz> * 1.0<GHz>

    [<RequireQualifiedAccess>]
    module Kilohertz =

        let create (x: float) = x * 1.0<kHz>
        let toHertz (x: float<kHz>) = x * 1e+3<Hz> / 1.0<kHz>
        let toMegahertz (x: float<kHz>) = x / 1e+3<kHz> * 1.0<MHz>
        let toGigahertz (x: float<kHz>) = x / 1e+6<kHz> * 1.0<GHz>

    [<RequireQualifiedAccess>]
    module Megahertz =

        let create (x: float) = x * 1.0<MHz>
        let toHertz (x: float<MHz>) = x * 1e+6<Hz> / 1.0<MHz>
        let toKilohertz (x: float<MHz>) = x * 1e+3<kHz> / 1.0<MHz>
        let toGigahertz (x: float<MHz>) = x / 1e+3<MHz> * 1.0<GHz>

    [<RequireQualifiedAccess>]
    module Gigahertz =

        let create (x: float) = x * 1.0<GHz>
        let toHertz (x: float<GHz>) = x * 1e+9<Hz> / 1.0<GHz>
        let toKilohertz (x: float<GHz>) = x * 1e+6<kHz> / 1.0<GHz>
        let toMegahertz (x: float<GHz>) = x * 1e+3<MHz> / 1.0<GHz>
