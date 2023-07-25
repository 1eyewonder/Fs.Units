namespace Fs.Units

[<AutoOpen>]
module Length =

    /// Inch
    [<Measure>]
    type inch

    /// Foot
    [<Measure>]
    type ft

    /// Yard
    [<Measure>]
    type yd

    /// Mile
    [<Measure>]
    type mi

    /// Millimeter
    [<Measure>]
    type mm

    /// Centimeter
    [<Measure>]
    type cm
    
    /// Decimeter
    [<Measure>]
    type dm

    /// Meter
    [<Measure>]
    type m

    /// Kilometer
    [<Measure>]
    type km

    /// Nautical mile
    [<Measure>]
    type nmi

    /// chain
    [<Measure>]
    type chain

    /// furlong
    [<Measure>]
    type fur

    /// league
    [<Measure>]
    type league

    /// hand
    [<Measure>]
    type hand

    /// rod
    [<Measure>]
    type rd

    [<RequireQualifiedAccess>]
    module Inch =

        let create (x: float) = x * 1.0<inch>
        let toFeet (x: float<inch>) = x / 12.0<inch> * 1.0<ft>
        let toYards (x: float<inch>) = x / 36.0<inch> * 1.0<yd>
        let toMiles (x: float<inch>) = x / 63360.0<inch> * 1.0<mi>
        let toMillimeters (x: float<inch>) = x * 25.4<mm> / 1.0<inch>
        let toCentimeters (x: float<inch>) = x * 2.54<cm> / 1.0<inch>
        let toDecimeters (x: float<inch>) = x * 0.254<dm> / 1.0<inch>
        let toMeters (x: float<inch>) = x * 0.0254<m> / 1.0<inch>
        let toKilometers (x: float<inch>) = x * 0.0000254<km> / 1.0<inch>
        let toNauticalMiles (x: float<inch>) = x * 0.0000137<nmi> / 1.0<inch>
        let toChains (x: float<inch>) = x * 0.00126263<chain> / 1.0<inch>
        let toFurlongs (x: float<inch>) = x * 0.000126262<fur> / 1.0<inch>
        let toLeagues (x: float<inch>) = x * 4.5716e-6<league> / 1.0<inch>
        let toHands (x: float<inch>) = x * 0.25<hand> / 1.0<inch>
        let toRods (x: float<inch>) = x * 0.00505051<rd> / 1.0<inch>

    [<RequireQualifiedAccess>]
    module Foot =

        let create (x: float) = x * 1.0<ft>
        let toInches (x: float<ft>) = x * 12.0<inch> / 1.0<ft>
        let toYards (x: float<ft>) = x / 3.0<ft> * 1.0<yd>
        let toMiles (x: float<ft>) = x / 5280.0<ft> * 1.0<mi>
        let toMillimeters (x: float<ft>) = x * 304.8<mm> / 1.0<ft>
        let toCentimeters (x: float<ft>) = x * 30.48<cm> / 1.0<ft>
        let toDecimeters (x: float<ft>) = x * 3.048<dm> / 1.0<ft>
        let toMeters (x: float<ft>) = x * 0.3048<m> / 1.0<ft>
        let toKilometers (x: float<ft>) = x * 0.0003048<km> / 1.0<ft>
        let toNauticalMiles (x: float<ft>) = x * 0.000164579<nmi> / 1.0<ft>
        let toChains (x: float<ft>) = x * 0.0151515<chain> / 1.0<ft>
        let toFurlongs (x: float<ft>) = x * 0.00151515<fur> / 1.0<ft>
        let toLeagues (x: float<ft>) = x * 5.48596e-5<league> / 1.0<ft>
        let toHands (x: float<ft>) = x * 3.0<hand> / 1.0<ft>
        let toRods (x: float<ft>) = x * 0.0606061<rd> / 1.0<ft>

    [<RequireQualifiedAccess>]
    module Yard =

        let create (x: float) = x * 1.0<yd>
        let toInches (x: float<yd>) = x * 36.0<inch> / 1.0<yd>
        let toFeet (x: float<yd>) = x * 3.0<ft> / 1.0<yd>
        let toMiles (x: float<yd>) = x / 1760.0<yd> * 1.0<mi>
        let toMillimeters (x: float<yd>) = x * 914.4<mm> / 1.0<yd>
        let toCentimeters (x: float<yd>) = x * 91.44<cm> / 1.0<yd>
        let toDecimeters (x: float<yd>) = x * 9.144<dm> / 1.0<yd>
        let toMeters (x: float<yd>) = x * 0.9144<m> / 1.0<yd>
        let toKilometers (x: float<yd>) = x * 0.0009144<km> / 1.0<yd>
        let toNauticalMiles (x: float<yd>) = x / 2025.37<yd> * 1.0<nmi>
        let toChains (x: float<yd>) = x / 22.0<yd> * 1.0<chain>
        let toFurlongs (x: float<yd>) = x / 220.0<yd> * 1.0<fur>
        let toLeagues (x: float<yd>) = x / 5280.0<yd> * 1.0<league>
        let toHands (x: float<yd>) = x * 1.0<hand> / 0.111111<yd>
        let toRods (x: float<yd>) = x / 5.5<yd> * 1.0<rd>

    [<RequireQualifiedAccess>]
    module Mile =

        let create (x: float) = x * 1.0<mi>
        let toInches (x: float<mi>) = x * 63360.0<inch> / 1.0<mi>
        let toFeet (x: float<mi>) = x * 5280.0<ft> / 1.0<mi>
        let toYards (x: float<mi>) = x * 1760.0<yd> / 1.0<mi>
        let toMillimeters (x: float<mi>) = x * 1609344.0<mm> / 1.0<mi>
        let toCentimeters (x: float<mi>) = x * 160934.4<cm> / 1.0<mi>
        let toDecimeters (x: float<mi>) = x * 16093.44<dm> / 1.0<mi>
        let toMeters (x: float<mi>) = x * 1609.344<m> / 1.0<mi>
        let toKilometers (x: float<mi>) = x * 1.609344<km> / 1.0<mi>
        let toNauticalMiles (x: float<mi>) = x / 1.15078<mi> * 1.0<nmi>
        let toChains (x: float<mi>) = x * 80.0<chain> / 1.0<mi>
        let toFurlongs (x: float<mi>) = x * 8.0<fur> / 1.0<mi>
        let toLeagues (x: float<mi>) = x / 3.0<mi> * 1.0<league>
        let toHands (x: float<mi>) = x * 1.0<hand> / 6.31313e-5<mi>
        let toRods (x: float<mi>) = x * 1.0<rd> / 0.003125<mi>

    [<RequireQualifiedAccess>]
    module Millimeter =

        let create (x: float) = x * 1.0<mm>
        let toInches (x: float<mm>) = x / 25.4<mm> * 1.0<inch>
        let toFeet (x: float<mm>) = x / 304.8<mm> * 1.0<ft>
        let toYards (x: float<mm>) = x / 914.4<mm> * 1.0<yd>
        let toMiles (x: float<mm>) = x / 1609344.0<mm> * 1.0<mi>
        let toCentimeters (x: float<mm>) = x / 10.0<mm> * 1.0<cm>
        let toDecimeters (x: float<mm>) = x / 100.0<mm> * 1.0<dm>
        let toMeters (x: float<mm>) = x / 1000.0<mm> * 1.0<m>
        let toKilometers (x: float<mm>) = x / 1000000.0<mm> * 1.0<km>
        let toNauticalMiles (x: float<mm>) = x / 1852000.0<mm> * 1.0<nmi>
        let toChains (x: float<mm>) = x / 20116.8<mm> * 1.0<chain>
        let toFurlongs (x: float<mm>) = x / 201168.0<mm> * 1.0<fur>
        let toLeagues (x: float<mm>) = x / 4.828e+6<mm> * 1.0<league>
        let toHands (x: float<mm>) = x / 101.6<mm> * 1.0<hand>
        let toRods (x: float<mm>) = x / 5029.2<mm> * 1.0<rd>

    [<RequireQualifiedAccess>]
    module Centimeter =

        let create (x: float) = x * 1.0<cm>
        let toInches (x: float<cm>) = x / 2.54<cm> * 1.0<inch>
        let toFeet (x: float<cm>) = x / 30.48<cm> * 1.0<ft>
        let toYards (x: float<cm>) = x / 91.44<cm> * 1.0<yd>
        let toMiles (x: float<cm>) = x / 160934.4<cm> * 1.0<mi>
        let toMillimeters (x: float<cm>) = x / 0.1<cm> * 1.0<mm>
        let toDecimeters (x: float<cm>) = x / 10.0<cm> * 1.0<dm>
        let toMeters (x: float<cm>) = x / 100.0<cm> * 1.0<m>
        let toKilometers (x: float<cm>) = x / 100000.0<cm> * 1.0<km>
        let toNauticalMiles (x: float<cm>) = x / 185200.0<cm> * 1.0<nmi>
        let toChains (x: float<cm>) = x / 201.168<cm> * 1.0<chain>
        let toFurlongs (x: float<cm>) = x / 20116.8<cm> * 1.0<fur>
        let toLeagues (x: float<cm>) = x / 482803.2<cm> * 1.0<league>
        let toHands (x: float<cm>) = x / 10.16<cm> * 1.0<hand>
        let toRods (x: float<cm>) = x / 502.92<cm> * 1.0<rd>
        
    [<RequireQualifiedAccess>]
    module Decimeter =
        
        let create (x: float) = x * 1.0<dm>
        let toInches (x: float<dm>) = x / 0.254<dm> * 1.0<inch>
        let toFeet (x: float<dm>) = x / 3.048<dm> * 1.0<ft>
        let toYards (x: float<dm>) = x / 9.144<dm> * 1.0<yd>
        let toMiles (x: float<dm>) = x / 16093.44<dm> * 1.0<mi>
        let toMillimeters (x: float<dm>) = x / 0.01<dm> * 1.0<mm>
        let toCentimeters (x: float<dm>) = x / 0.1<dm> * 1.0<cm>
        let toMeters (x: float<dm>) = x / 10.0<dm> * 1.0<m>
        let toKilometers (x: float<dm>) = x / 10000.0<dm> * 1.0<km>
        let toNauticalMiles (x: float<dm>) = x / 18520.0<dm> * 1.0<nmi>
        let toChains (x: float<dm>) = x / 20.1168<dm> * 1.0<chain>
        let toFurlongs (x: float<dm>) = x / 2011.68<dm> * 1.0<fur>
        let toLeagues (x: float<dm>) = x / 48280.32<dm> * 1.0<league>
        let toHands (x: float<dm>) = x / 1.016<dm> * 1.0<hand>
        let toRods (x: float<dm>) = x / 50.292<dm> * 1.0<rd>

    [<RequireQualifiedAccess>]
    module Meter =

        let create (x: float) = x * 1.0<m>
        let toInches (x: float<m>) = x / 0.0254<m> * 1.0<inch>
        let toFeet (x: float<m>) = x / 0.3048<m> * 1.0<ft>
        let toYards (x: float<m>) = x / 0.9144<m> * 1.0<yd>
        let toMiles (x: float<m>) = x / 1609.344<m> * 1.0<mi>
        let toMillimeters (x: float<m>) = x * 1000.0<mm> / 1.0<m>
        let toCentimeters (x: float<m>) = x * 100.0<cm> / 1.0<m>
        let toDecimeters (x: float<m>) = x * 10.0<dm> / 1.0<m>       
        let toKilometers (x: float<m>) = x / 1000.0<m> * 1.0<km>
        let toNauticalMiles (x: float<m>) = x / 1852.0<m> * 1.0<nmi>
        let toChains (x: float<m>) = x / 20.1168<m> * 1.0<chain>
        let toFurlongs (x: float<m>) = x / 201.168<m> * 1.0<fur>
        let toLeagues (x: float<m>) = x / 4828.032<m> * 1.0<league>
        let toHands (x: float<m>) = x / 0.1016<m> * 1.0<hand>
        let toRods (x: float<m>) = x / 5.0292<m> * 1.0<rd>

    [<RequireQualifiedAccess>]
    module Kilometer =

        let create (x: float) = x * 1.0<km>
        let toInches (x: float<km>) = x / 0.0000254<km> * 1.0<inch>
        let toCentimeters (x: float<km>) = x * 100000.0<cm> / 1.0<km>
        let toDecimeters (x: float<km>) = x * 10000.0<dm> / 1.0<km>
        let toFeet (x: float<km>) = x / 0.0003048<km> * 1.0<ft>
        let toYards (x: float<km>) = x / 0.0009144<km> * 1.0<yd>
        let toMiles (x: float<km>) = x / 1.609344<km> * 1.0<mi>
        let toMillimeters (x: float<km>) = x * 1000000.0<mm> / 1.0<km>
        let toMeters (x: float<km>) = x * 1000.0<m> / 1.0<km>
        let toNauticalMiles (x: float<km>) = x / 1.852<km> * 1.0<nmi>
        let toChains (x: float<km>) = x / 0.0201168<km> * 1.0<chain>
        let toFurlongs (x: float<km>) = x / 0.201168<km> * 1.0<fur>
        let toLeagues (x: float<km>) = x / 4.828032<km> * 1.0<league>
        let toHands (x: float<km>) = x / 0.0001016<km> * 1.0<hand>
        let toRods (x: float<km>) = x / 0.0050292<km> * 1.0<rd>

    [<RequireQualifiedAccess>]
    module NauticalMile =

        let create (x: float) = x * 1.0<nmi>
        let toInches (x: float<nmi>) = x / 0.0000137<nmi> * 1.0<inch>
        let toCentimeters (x: float<nmi>) = x * 185200.0<cm> / 1.0<nmi>
        let toDecimeters (x: float<nmi>) = x * 18520.0<dm> / 1.0<nmi>
        let toFeet (x: float<nmi>) = x / 0.000164579<nmi> * 1.0<ft>
        let toYards (x: float<nmi>) = x * 2025.37<yd> / 1.0<nmi>
        let toMiles (x: float<nmi>) = x * 1.15078<mi> / 1.0<nmi>
        let toMillimeters (x: float<nmi>) = x * 1852000.0<mm> / 1.0<nmi>
        let toMeters (x: float<nmi>) = x * 1852.0<m> / 1.0<nmi>
        let toKilometers (x: float<nmi>) = x * 1.852<km> / 1.0<nmi>
        let toChains (x: float<nmi>) = x / 0.0000373265<nmi> * 1.0<chain>
        let toFurlongs (x: float<nmi>) = x / 0.000373266<nmi> * 1.0<fur>
        let toLeagues (x: float<nmi>) = x / 0.000889984<nmi> * 1.0<league>
        let toHands (x: float<nmi>) = x / 0.0000546807<nmi> * 1.0<hand>
        let toRods (x: float<nmi>) = x * 368.249<rd> / 1.0<nmi>

    [<RequireQualifiedAccess>]
    module Chain =

        let create (x: float) = x * 1.0<chain>
        let toInches (x: float<chain>) = x / 0.00126263<chain> * 1.0<inch>
        let toFeet (x: float<chain>) = x / 0.0151515<chain> * 1.0<ft>
        let toYards (x: float<chain>) = x * 22.0<yd> / 1.0<chain>
        let toMiles (x: float<chain>) = x / 80.0<chain> * 1.0<mi>
        let toMillimeters (x: float<chain>) = x * 20116.8<mm> / 1.0<chain>
        let toCentimeters (x: float<chain>) = x * 201.168<cm> / 1.0<chain>
        let toDecimeters (x: float<chain>) = x * 20.1168<dm> / 1.0<chain>
        let toMeters (x: float<chain>) = x * 20.1168<m> / 1.0<chain>
        let toKilometers (x: float<chain>) = x * 0.0201168<km> / 1.0<chain>
        let toNauticalMiles (x: float<chain>) = x * 0.0000373265<nmi> / 1.0<chain>
        let toFurlongs (x: float<chain>) = x / 10.0<chain> * 1.0<fur>
        let toLeagues (x: float<chain>) = x / 0.00889984<chain> * 1.0<league>
        let toHands (x: float<chain>) = x / 0.000493737<chain> * 1.0<hand>
        let toRods (x: float<chain>) = x / 0.0000905213<chain> * 1.0<rd>

    [<RequireQualifiedAccess>]
    module Furlong =

        let create (x: float) = x * 1.0<fur>
        let toInches (x: float<fur>) = x / 0.000126262<fur> * 1.0<inch>
        let toFeet (x: float<fur>) = x / 0.00151515<fur> * 1.0<ft>
        let toYards (x: float<fur>) = x * 220.0<yd> / 1.0<fur>
        let toMiles (x: float<fur>) = x / 8.0<fur> * 1.0<mi>
        let toMillimeters (x: float<fur>) = x * 201168.0<mm> / 1.0<fur>
        let toCentimeters (x: float<fur>) = x * 20116.8<cm> / 1.0<fur>
        let toDecimeters (x: float<fur>) = x * 2011.68<dm> / 1.0<fur>
        let toMeters (x: float<fur>) = x * 201.168<m> / 1.0<fur>
        let toKilometers (x: float<fur>) = x * 0.201168<km> / 1.0<fur>
        let toNauticalMiles (x: float<fur>) = x * 0.000373266<nmi> / 1.0<fur>
        let toChains (x: float<fur>) = x * 10.0<chain> / 1.0<fur>
        let toLeagues (x: float<fur>) = x / 0.000889984<fur> * 1.0<league>
        let toHands (x: float<fur>) = x / 0.0000493737<fur> * 1.0<hand>
        let toRods (x: float<fur>) = x / 0.00000905213<fur> * 1.0<rd>

    [<RequireQualifiedAccess>]
    module League =

        let create (x: float) = x * 1.0<league>
        let toInches (x: float<league>) = x / 4.5716e-6<league> * 1.0<inch>
        let toFeet (x: float<league>) = x / 5.48596e-5<league> * 1.0<ft>
        let toYards (x: float<league>) = x * 5280.0<yd> / 1.0<league>
        let toMiles (x: float<league>) = x * 3.0<mi> / 1.0<league>
        let toMillimeters (x: float<league>) = x * 4.828e+6<mm> / 1.0<league>
        let toCentimeters (x: float<league>) = x * 482803.2<cm> / 1.0<league>
        let toDecimeters (x: float<league>) = x * 48280.32<dm> / 1.0<league>
        let toMeters (x: float<league>) = x * 4828.032<m> / 1.0<league>
        let toKilometers (x: float<league>) = x * 4.828032<km> / 1.0<league>
        let toNauticalMiles (x: float<league>) = x * 0.000889984<nmi> / 1.0<league>
        let toChains (x: float<league>) = x * 0.00889984<chain> / 1.0<league>
        let toFurlongs (x: float<league>) = x * 0.000889984<fur> / 1.0<league>
        let toHands (x: float<league>) = x / 0.00000493737<league> * 1.0<hand>
        let toRods (x: float<league>) = x / 0.000000905213<league> * 1.0<rd>

    [<RequireQualifiedAccess>]
    module Hand =

        let create (x: float) = x * 1.0<hand>
        let toInches (x: float<hand>) = x / 0.25<hand> * 1.0<inch>
        let toFeet (x: float<hand>) = x / 3.0<hand> * 1.0<ft>
        let toYards (x: float<hand>) = x * 0.111111<yd> / 1.0<hand>
        let toMiles (x: float<hand>) = x * 6.31313e-5<mi> / 1.0<hand>
        let toMillimeters (x: float<hand>) = x * 101.6<mm> / 1.0<hand>
        let toCentimeters (x: float<hand>) = x * 10.16<cm> / 1.0<hand>
        let toDecimeters (x: float<hand>) = x * 1.016<dm> / 1.0<hand>
        let toMeters (x: float<hand>) = x * 0.1016<m> / 1.0<hand>
        let toKilometers (x: float<hand>) = x * 0.0001016<km> / 1.0<hand>
        let toNauticalMiles (x: float<hand>) = x * 0.0000546807<nmi> / 1.0<hand>
        let toChains (x: float<hand>) = x * 0.000493737<chain> / 1.0<hand>
        let toFurlongs (x: float<hand>) = x * 0.0000493737<fur> / 1.0<hand>
        let toLeagues (x: float<hand>) = x * 0.00000493737<league> / 1.0<hand>
        let toRods (x: float<hand>) = x / 0.00000446429<hand> * 1.0<rd>

    [<RequireQualifiedAccess>]
    module Rod =

        let create (x: float) = x * 1.0<rd>
        let toInches (x: float<rd>) = x / 0.00505051<rd> * 1.0<inch>
        let toFeet (x: float<rd>) = x / 0.0606061<rd> * 1.0<ft>
        let toYards (x: float<rd>) = x * 5.5<yd> / 1.0<rd>
        let toMiles (x: float<rd>) = x * 0.003125<mi> / 1.0<rd>
        let toMillimeters (x: float<rd>) = x * 5029.2<mm> / 1.0<rd>
        let toCentimeters (x: float<rd>) = x * 502.92<cm> / 1.0<rd>
        let toDecimeters (x: float<rd>) = x * 50.292<dm> / 1.0<rd>
        let toMeters (x: float<rd>) = x * 5.0292<m> / 1.0<rd>
        let toKilometers (x: float<rd>) = x * 0.0050292<km> / 1.0<rd>
        let toNauticalMiles (x: float<rd>) = x * 1.0<nmi> / 368.249<rd>
        let toChains (x: float<rd>) = x * 0.0000905213<chain> / 1.0<rd>
        let toFurlongs (x: float<rd>) = x * 0.00000905213<fur> / 1.0<rd>
        let toLeagues (x: float<rd>) = x * 0.000000905213<league> / 1.0<rd>
        let toHands (x: float<rd>) = x * 0.00000446429<hand> / 1.0<rd>
