namespace Fs.Units

[<AutoOpen>]
module Capacitance =

    /// Farad
    [<Measure>]
    type F = s * s * s * s * A * A / m / m / kg

    [<RequireQualifiedAccess>]
    module Farad =

        let create (x: float) = x * 1.0<F>
