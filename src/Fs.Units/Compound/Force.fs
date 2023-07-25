namespace Fs.Units

[<AutoOpen>]
module Force =

    /// Newton
    [<Measure>]
    type N = kg * m / (s * s)

    /// Pound force
    [<Measure>]
    type lbf = lbm * ft / (s * s)

    /// Dyne
    [<Measure>]
    type dyn = g * cm / (s * s)

    /// Kip
    [<Measure>]
    type kip

    [<RequireQualifiedAccess>]
    module Newton =

        let create (x: float) = x * 1.0<N>

        let toPoundForce (x: float<N>) =
            let mass = Kilogram.create 1 |> Kilogram.toPoundMass
            let length = Meter.create 1 |> Meter.toFeet
            let time = Second.create 1
            x * mass * length / time / time / 1.0<N>

        let toDynes (x: float<N>) =
            let mass = Kilogram.create 1 |> Kilogram.toGrams
            let length = Meter.create 1 |> Meter.toCentimeters
            let time = Second.create 1
            x * mass * length / time / time / 1.0<N>

        let toKips (x: float<N>) = x * 2.24809e-4<kip> / 1.0<N>

    [<RequireQualifiedAccess>]
    module PoundForce =

        let create (x: float) = x * 1.0<lbf>

        let toNewtons (x: float<lbf>) =
            let a = PoundMass.create 1 |> PoundMass.toKilograms
            let b = Foot.create 1 |> Foot.toMeters
            let time = Second.create 1
            x * a * b / time / time / 1.0<lbf>

        let toDynes (x: float<lbf>) =
            let mass = PoundMass.create 1 |> PoundMass.toGrams
            let length = Foot.create 1 |> Foot.toCentimeters
            let time = Second.create 1
            x * mass * length / time / time / 1.0<lbf>

        let toKips (x: float<lbf>) = x * 0.001<kip> / 1.0<lbf>

    [<RequireQualifiedAccess>]
    module Dyne =

        let create (x: float) = x * 1.0<dyn>

        let toNewtons (x: float<dyn>) =
            let mass = Gram.create 1 |> Gram.toKilograms
            let length = Centimeter.create 1 |> Centimeter.toMeters
            let time = Second.create 1
            x * mass * length / time / time / 1.0<dyn>

        let toPoundForce (x: float<dyn>) =
            let mass = Gram.create 1 |> Gram.toPoundMass
            let length = Centimeter.create 1 |> Centimeter.toFeet
            let time = Second.create 1
            x * mass * length / time / time / 1.0<dyn>

        let toKips (x: float<dyn>) = x * 2.24809e-9<kip> / 1.0<dyn>

    [<RequireQualifiedAccess>]
    module Kip =

        let create (x: float) = x * 1.0<kip>
        let toNewtons (x: float<kip>) = x * 1.0<N> / 2.24809e-4<kip>
        let toPoundForce (x: float<kip>) = x * 1.0<lbf> / 0.001<kip>
        let toDynes (x: float<kip>) = x * 1.0<dyn> / 2.24809e-9<kip>
