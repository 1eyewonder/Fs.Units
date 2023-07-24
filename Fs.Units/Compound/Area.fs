namespace Fs.Units

[<AutoOpen>]
module Area =

    /// Square inch
    [<Measure>]
    type in2 = inch * inch

    /// Square foot
    [<Measure>]
    type ft2 = ft * ft

    /// Square centimeter
    [<Measure>]
    type cm2 = cm * cm

    /// Square meter
    [<Measure>]
    type m2 = m * m

    [<RequireQualifiedAccess>]
    module SquareInch =

        let create (x: float) = x * 1.0<in2>

        let toSquareFeet (x: float<in2>) =
            let length = Inch.create 1 |> Inch.toFeet
            x * length * length / 1.0<in2>

        let toSquareCentimeters (x: float<in2>) =
            let length = Inch.create 1 |> Inch.toCentimeters
            x * length * length / 1.0<in2>

        let toSquareMeters (x: float<in2>) =
            let length = Inch.create 1 |> Inch.toMeters
            x * length * length / 1.0<in2>

    [<RequireQualifiedAccess>]
    module SquareFoot =

        let create (x: float) = x * 1.0<ft2>

        let toSquareInches (x: float<ft2>) =
            let length = Foot.create 1 |> Foot.toInches
            x * (length * length) / 1.0<ft2>

        let toSquareCentimeters (x: float<ft2>) =
            let length = Foot.create 1 |> Foot.toCentimeters
            x * length * length / 1.0<ft2>

        let toSquareMeters (x: float<ft2>) =
            let length = Foot.create 1 |> Foot.toMeters
            x * length * length / 1.0<ft2>

    [<RequireQualifiedAccess>]
    module SquareCentimeter =

        let create (x: float) = x * 1.0<cm2>

        let toSquareInches (x: float<cm2>) =
            let length = Centimeter.create 1 |> Centimeter.toInches
            x * length * length / 1.0<cm2>

        let toSquareFeet (x: float<cm2>) =
            let length = Centimeter.create 1 |> Centimeter.toFeet
            x * length * length / 1.0<cm2>

        let toSquareMeters (x: float<cm2>) =
            let length = Centimeter.create 1 |> Centimeter.toMeters
            x * length * length / 1.0<cm2>

    [<RequireQualifiedAccess>]
    module SquareMeter =

        let create (x: float) = x * 1.0<m2>

        let toSquareInches (x: float<m2>) =
            let length = Meter.create 1 |> Meter.toInches
            x * length * length / 1.0<m2>

        let toSquareFeet (x: float<m2>) =
            let length = Meter.create 1 |> Meter.toFeet
            x * length * length / 1.0<m2>

        let toSquareCentimeters (x: float<m2>) =
            let length = Meter.create 1 |> Meter.toCentimeters
            x * length * length / 1.0<m2>
