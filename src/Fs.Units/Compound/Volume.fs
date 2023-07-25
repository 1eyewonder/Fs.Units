namespace Fs.Units

[<AutoOpen>]
module Volume =

    /// Cubic inch
    [<Measure>]
    type in3 = inch * inch * inch

    /// Cubic foot
    [<Measure>]
    type ft3 = ft * ft * ft

    /// Cubic centimeter
    [<Measure>]
    type cm3 = cm * cm * cm

    /// Cubic meter
    [<Measure>]
    type m3 = m * m * m
    
    /// Liter (Litre)
    [<Measure>]
    type L = dm * dm * dm

    [<RequireQualifiedAccess>]
    module CubicInch =

        let create (x: float) = x * 1.0<in3>

        let toCubicFeet (x: float<in3>) =
            let length = Inch.create 1 |> Inch.toFeet
            x * length * length * length / 1.0<in3>

        let toCubicCentimeters (x: float<in3>) =
            let length = Inch.create 1 |> Inch.toCentimeters
            x * length * length * length / 1.0<in3>

        let toCubicMeters (x: float<in3>) =
            let length = Inch.create 1 |> Inch.toMeters
            x * length * length * length / 1.0<in3>
            
        let toLiters (x: float<in3>) : float<L> =
            let length = Inch.create 1 |> Inch.toDecimeters
            x * length * length * length / 1.0<in3>

    [<RequireQualifiedAccess>]
    module CubicFoot =

        let create (x: float) = x * 1.0<ft3>

        let toCubicInches (x: float<ft3>) =
            let length = Foot.create 1 |> Foot.toInches
            x * length * length * length / 1.0<ft3>

        let toCubicCentimeters (x: float<ft3>) =
            let length = Foot.create 1 |> Foot.toCentimeters
            x * length * length * length / 1.0<ft3>

        let toCubicMeters (x: float<ft3>) =
            let length = Foot.create 1 |> Foot.toMeters
            x * length * length * length / 1.0<ft3>
            
        let toLiters (x: float<ft3>) : float<L> =
            let length = Foot.create 1 |> Foot.toDecimeters
            x * length * length * length / 1.0<ft3>

    [<RequireQualifiedAccess>]
    module CubicCentimeter =

        let create (x: float) = x * 1.0<cm3>

        let toCubicInches (x: float<cm3>) =
            let length = Centimeter.create 1 |> Centimeter.toInches
            x * length * length * length / 1.0<cm3>

        let toCubicFeet (x: float<cm3>) =
            let length = Centimeter.create 1 |> Centimeter.toFeet
            x * length * length * length / 1.0<cm3>

        let toCubicMeters (x: float<cm3>) =
            let length = Centimeter.create 1 |> Centimeter.toMeters
            x * length * length * length / 1.0<cm3>
            
        let toLiters (x: float<cm3>) : float<L> =
            let length = Centimeter.create 1 |> Centimeter.toDecimeters
            x * length * length * length / 1.0<cm3>

    [<RequireQualifiedAccess>]
    module CubicMeter =

        let create (x: float) = x * 1.0<m3>

        let toCubicInches (x: float<m3>) =
            let length = Meter.create 1 |> Meter.toInches
            x * length * length * length / 1.0<m3>

        let toCubicFeet (x: float<m3>) =
            let length = Meter.create 1 |> Meter.toFeet
            x * length * length * length / 1.0<m3>

        let toCubicCentimeters (x: float<m3>) =
            let length = Meter.create 1 |> Meter.toCentimeters
            x * length * length * length / 1.0<m3>
            
        let toLiters (x: float<m3>) : float<L> =
            let length = Meter.create 1 |> Meter.toDecimeters
            x * length * length * length / 1.0<m3>
            
    [<RequireQualifiedAccess>]
    module Liter =
        
        let create (x: float) = x * 1.0<L>

        let toCubicInches (x: float<L>) =
            let length = Decimeter.create 1 |> Decimeter.toInches
            x * length * length * length / 1.0<L>

        let toCubicFeet (x: float<L>) =
            let length = Decimeter.create 1 |> Decimeter.toFeet
            x * length * length * length / 1.0<L>

        let toCubicCentimeters (x: float<L>) =
            let length = Decimeter.create 1 |> Decimeter.toCentimeters
            x * length * length * length / 1.0<L>

        let toCubicMeters (x: float<L>) =
            let length = Decimeter.create 1 |> Decimeter.toMeters
            x * length * length * length / 1.0<L>
