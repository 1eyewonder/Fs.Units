namespace Fs.Units
    
[<AutoOpen>]
module Inertia =
    
    [<Measure>] type in4 = inch * inch * inch * inch

    [<Measure>]
    type cm4 = cm * cm * cm * cm

    [<RequireQualifiedAccess>]
    module QuarticInch =
        
        let create (x:float) = x * 1.0<in4>
        let toQuarticCentimeters (x: float<in4>) =
            let length = Inch.create 1 |> Inch.toCentimeters
            x * length * length * length * length / 1.0<in4>

    [<RequireQualifiedAccess>]
    module QuarticCentimeter =

        let create (x:float) = x * 1.0<cm4>
        let toQuarticInches (x: float<cm4>) =
            let length = Centimeter.create 1 |> Centimeter.toInches
            x * length * length * length * length / 1.0<cm4>