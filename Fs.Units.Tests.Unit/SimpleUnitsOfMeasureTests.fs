module SimpleUnitOfMeasureTests

open Expecto
open Fs.Units
open Helpers

[<Tests>]
let lengthTests config =
    let inchConversionTests =
        [ "From inch to feet and back", (fun x -> Inch.create x |> Inch.toFeet |> Foot.toInches)
          "From inch to yard and back", (fun x -> Inch.create x |> Inch.toYards |> Yard.toInches)
          "From inch to mile and back", (fun x -> Inch.create x |> Inch.toMiles |> Mile.toInches)
          "From inch to millimeter and back", (fun x -> Inch.create x |> Inch.toMillimeters |> Millimeter.toInches)
          "From inch to centimeter and back", (fun x -> Inch.create x |> Inch.toCentimeters |> Centimeter.toInches)
          "From inch to meter and back", (fun x -> Inch.create x |> Inch.toMeters |> Meter.toInches)
          "From inch to kilometer and back", (fun x -> Inch.create x |> Inch.toKilometers |> Kilometer.toInches)
          "From inch to nautical mile and back",
          (fun x -> Inch.create x |> Inch.toNauticalMiles |> NauticalMile.toInches)
          "From inch to chain and back", (fun x -> Inch.create x |> Inch.toChains |> Chain.toInches)
          "From inch to furlong and back", (fun x -> Inch.create x |> Inch.toFurlongs |> Furlong.toInches)
          "From inch to league and back", (fun x -> Inch.create x |> Inch.toLeagues |> League.toInches)
          "From inch to hand and back", (fun x -> Inch.create x |> Inch.toHands |> Hand.toInches)
          "From inch to rod and back", (fun x -> Inch.create x |> Inch.toRods |> Rod.toInches) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let footConversionTests =
        [ "From foot to inches and back", (fun x -> Foot.create x |> Foot.toInches |> Inch.toFeet)
          "From foot to yard and back", (fun x -> Foot.create x |> Foot.toYards |> Yard.toFeet)
          "From foot to mile and back", (fun x -> Foot.create x |> Foot.toMiles |> Mile.toFeet)
          "From foot to millimeter and back", (fun x -> Foot.create x |> Foot.toMillimeters |> Millimeter.toFeet)
          "From foot to centimeter and back", (fun x -> Foot.create x |> Foot.toCentimeters |> Centimeter.toFeet)
          "From foot to meter and back", (fun x -> Foot.create x |> Foot.toMeters |> Meter.toFeet)
          "From foot to kilometer and back", (fun x -> Foot.create x |> Foot.toKilometers |> Kilometer.toFeet)
          "From foot to nautical mile and back", (fun x -> Foot.create x |> Foot.toNauticalMiles |> NauticalMile.toFeet)
          "From foot to chain and back", (fun x -> Foot.create x |> Foot.toChains |> Chain.toFeet)
          "From foot to furlong and back", (fun x -> Foot.create x |> Foot.toFurlongs |> Furlong.toFeet)
          "From foot to league and back", (fun x -> Foot.create x |> Foot.toLeagues |> League.toFeet)
          "From foot to hand and back", (fun x -> Foot.create x |> Foot.toHands |> Hand.toFeet)
          "From foot to rod and back", (fun x -> Foot.create x |> Foot.toRods |> Rod.toFeet) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let yardConversionTests =
        [ "From yard to inches and back", (fun x -> Yard.create x |> Yard.toInches |> Inch.toYards)
          "From yard to foot and back", (fun x -> Yard.create x |> Yard.toFeet |> Foot.toYards)
          "From yard to mile and back", (fun x -> Yard.create x |> Yard.toMiles |> Mile.toYards)
          "From yard to millimeter and back", (fun x -> Yard.create x |> Yard.toMillimeters |> Millimeter.toYards)
          "From yard to centimeter and back", (fun x -> Yard.create x |> Yard.toCentimeters |> Centimeter.toYards)
          "From yard to meter and back", (fun x -> Yard.create x |> Yard.toMeters |> Meter.toYards)
          "From yard to kilometer and back", (fun x -> Yard.create x |> Yard.toKilometers |> Kilometer.toYards)
          "From yard to nautical mile and back",
          (fun x -> Yard.create x |> Yard.toNauticalMiles |> NauticalMile.toYards)
          "From yard to chain and back", (fun x -> Yard.create x |> Yard.toChains |> Chain.toYards)
          "From yard to furlong and back", (fun x -> Yard.create x |> Yard.toFurlongs |> Furlong.toYards)
          "From yard to league and back", (fun x -> Yard.create x |> Yard.toLeagues |> League.toYards)
          "From yard to hand and back", (fun x -> Yard.create x |> Yard.toHands |> Hand.toYards)
          "From yard to rod and back", (fun x -> Yard.create x |> Yard.toRods |> Rod.toYards) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let mileConversionTests =
        [ "From mile to inches and back", (fun x -> Mile.create x |> Mile.toInches |> Inch.toMiles)
          "From mile to foot and back", (fun x -> Mile.create x |> Mile.toFeet |> Foot.toMiles)
          "From mile to yard and back", (fun x -> Mile.create x |> Mile.toYards |> Yard.toMiles)
          "From mile to millimeter and back", (fun x -> Mile.create x |> Mile.toMillimeters |> Millimeter.toMiles)
          "From mile to centimeter and back", (fun x -> Mile.create x |> Mile.toCentimeters |> Centimeter.toMiles)
          "From mile to meter and back", (fun x -> Mile.create x |> Mile.toMeters |> Meter.toMiles)
          "From mile to kilometer and back", (fun x -> Mile.create x |> Mile.toKilometers |> Kilometer.toMiles)
          "From mile to nautical mile and back",
          (fun x -> Mile.create x |> Mile.toNauticalMiles |> NauticalMile.toMiles)
          "From mile to chain and back", (fun x -> Mile.create x |> Mile.toChains |> Chain.toMiles)
          "From mile to furlong and back", (fun x -> Mile.create x |> Mile.toFurlongs |> Furlong.toMiles)
          "From mile to league and back", (fun x -> Mile.create x |> Mile.toLeagues |> League.toMiles)
          "From mile to hand and back", (fun x -> Mile.create x |> Mile.toHands |> Hand.toMiles)
          "From mile to rod and back", (fun x -> Mile.create x |> Mile.toRods |> Rod.toMiles) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let millimeterConversionTests =
        [ "From millimeter to inches and back",
          (fun x -> Millimeter.create x |> Millimeter.toInches |> Inch.toMillimeters)
          "From millimeter to foot and back", (fun x -> Millimeter.create x |> Millimeter.toFeet |> Foot.toMillimeters)
          "From millimeter to yard and back", (fun x -> Millimeter.create x |> Millimeter.toYards |> Yard.toMillimeters)
          "From millimeter to mile and back", (fun x -> Millimeter.create x |> Millimeter.toMiles |> Mile.toMillimeters)
          "From millimeter to centimeter and back",
          (fun x -> Millimeter.create x |> Millimeter.toCentimeters |> Centimeter.toMillimeters)
          "From millimeter to meter and back",
          (fun x -> Millimeter.create x |> Millimeter.toMeters |> Meter.toMillimeters)
          "From millimeter to kilometer and back",
          (fun x -> Millimeter.create x |> Millimeter.toKilometers |> Kilometer.toMillimeters)
          "From millimeter to nautical mile and back",
          (fun x -> Millimeter.create x |> Millimeter.toNauticalMiles |> NauticalMile.toMillimeters)
          "From millimeter to chain and back",
          (fun x -> Millimeter.create x |> Millimeter.toChains |> Chain.toMillimeters)
          "From millimeter to furlong and back",
          (fun x -> Millimeter.create x |> Millimeter.toFurlongs |> Furlong.toMillimeters)
          "From millimeter to league and back",
          (fun x -> Millimeter.create x |> Millimeter.toLeagues |> League.toMillimeters)
          "From millimeter to hand and back", (fun x -> Millimeter.create x |> Millimeter.toHands |> Hand.toMillimeters)
          "From millimeter to rod and back", (fun x -> Millimeter.create x |> Millimeter.toRods |> Rod.toMillimeters) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let centimeterConversionTests =
        [ "From centimeter to inches and back",
          (fun x -> Centimeter.create x |> Centimeter.toInches |> Inch.toCentimeters)
          "From centimeter to foot and back", (fun x -> Centimeter.create x |> Centimeter.toFeet |> Foot.toCentimeters)
          "From centimeter to yard and back", (fun x -> Centimeter.create x |> Centimeter.toYards |> Yard.toCentimeters)
          "From centimeter to mile and back", (fun x -> Centimeter.create x |> Centimeter.toMiles |> Mile.toCentimeters)
          "From centimeter to millimeter and back",
          (fun x -> Centimeter.create x |> Centimeter.toMillimeters |> Millimeter.toCentimeters)
          "From centimeter to meter and back",
          (fun x -> Centimeter.create x |> Centimeter.toMeters |> Meter.toCentimeters)
          "From centimeter to kilometer and back",
          (fun x -> Centimeter.create x |> Centimeter.toKilometers |> Kilometer.toCentimeters)
          "From centimeter to nautical mile and back",
          (fun x -> Centimeter.create x |> Centimeter.toNauticalMiles |> NauticalMile.toCentimeters)
          "From centimeter to chain and back",
          (fun x -> Centimeter.create x |> Centimeter.toChains |> Chain.toCentimeters)
          "From centimeter to furlong and back",
          (fun x -> Centimeter.create x |> Centimeter.toFurlongs |> Furlong.toCentimeters)
          "From centimeter to league and back",
          (fun x -> Centimeter.create x |> Centimeter.toLeagues |> League.toCentimeters)
          "From centimeter to hand and back", (fun x -> Centimeter.create x |> Centimeter.toHands |> Hand.toCentimeters)
          "From centimeter to rod and back", (fun x -> Centimeter.create x |> Centimeter.toRods |> Rod.toCentimeters) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let meterConversionTests =
        [ "From meter to inches and back", (fun x -> Meter.create x |> Meter.toInches |> Inch.toMeters)
          "From meter to foot and back", (fun x -> Meter.create x |> Meter.toFeet |> Foot.toMeters)
          "From meter to yard and back", (fun x -> Meter.create x |> Meter.toYards |> Yard.toMeters)
          "From meter to mile and back", (fun x -> Meter.create x |> Meter.toMiles |> Mile.toMeters)
          "From meter to millimeter and back", (fun x -> Meter.create x |> Meter.toMillimeters |> Millimeter.toMeters)
          "From meter to centimeter and back", (fun x -> Meter.create x |> Meter.toCentimeters |> Centimeter.toMeters)
          "From meter to kilometer and back", (fun x -> Meter.create x |> Meter.toKilometers |> Kilometer.toMeters)
          "From meter to nautical mile and back",
          (fun x -> Meter.create x |> Meter.toNauticalMiles |> NauticalMile.toMeters)
          "From meter to chain and back", (fun x -> Meter.create x |> Meter.toChains |> Chain.toMeters)
          "From meter to furlong and back", (fun x -> Meter.create x |> Meter.toFurlongs |> Furlong.toMeters)
          "From meter to league and back", (fun x -> Meter.create x |> Meter.toLeagues |> League.toMeters)
          "From meter to hand and back", (fun x -> Meter.create x |> Meter.toHands |> Hand.toMeters)
          "From meter to rod and back", (fun x -> Meter.create x |> Meter.toRods |> Rod.toMeters) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let kilometerConversionTests =
        [ "From kilometer to inches and back", (fun x -> Kilometer.create x |> Kilometer.toInches |> Inch.toKilometers)
          "From kilometer to foot and back", (fun x -> Kilometer.create x |> Kilometer.toFeet |> Foot.toKilometers)
          "From kilometer to yard and back", (fun x -> Kilometer.create x |> Kilometer.toYards |> Yard.toKilometers)
          "From kilometer to mile and back", (fun x -> Kilometer.create x |> Kilometer.toMiles |> Mile.toKilometers)
          "From kilometer to millimeter and back",
          (fun x -> Kilometer.create x |> Kilometer.toMillimeters |> Millimeter.toKilometers)
          "From kilometer to centimeter and back",
          (fun x -> Kilometer.create x |> Kilometer.toCentimeters |> Centimeter.toKilometers)
          "From kilometer to meter and back", (fun x -> Kilometer.create x |> Kilometer.toMeters |> Meter.toKilometers)
          "From kilometer to nautical mile and back",
          (fun x -> Kilometer.create x |> Kilometer.toNauticalMiles |> NauticalMile.toKilometers)
          "From kilometer to chain and back", (fun x -> Kilometer.create x |> Kilometer.toChains |> Chain.toKilometers)
          "From kilometer to furlong and back",
          (fun x -> Kilometer.create x |> Kilometer.toFurlongs |> Furlong.toKilometers)
          "From kilometer to league and back",
          (fun x -> Kilometer.create x |> Kilometer.toLeagues |> League.toKilometers)
          "From kilometer to hand and back", (fun x -> Kilometer.create x |> Kilometer.toHands |> Hand.toKilometers)
          "From kilometer to rod and back", (fun x -> Kilometer.create x |> Kilometer.toRods |> Rod.toKilometers) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let nauticalMileConversionTests =
        [ "From nautical mile to inches and back",
          (fun x -> NauticalMile.create x |> NauticalMile.toInches |> Inch.toNauticalMiles)
          "From nautical mile to foot and back",
          (fun x -> NauticalMile.create x |> NauticalMile.toFeet |> Foot.toNauticalMiles)
          "From nautical mile to yard and back",
          (fun x -> NauticalMile.create x |> NauticalMile.toYards |> Yard.toNauticalMiles)
          "From nautical mile to mile and back",
          (fun x -> NauticalMile.create x |> NauticalMile.toMiles |> Mile.toNauticalMiles)
          "From nautical mile to millimeter and back",
          (fun x ->
              NauticalMile.create x
              |> NauticalMile.toMillimeters
              |> Millimeter.toNauticalMiles)
          "From nautical mile to centimeter and back",
          (fun x ->
              NauticalMile.create x
              |> NauticalMile.toCentimeters
              |> Centimeter.toNauticalMiles)
          "From nautical mile to meter and back",
          (fun x -> NauticalMile.create x |> NauticalMile.toMeters |> Meter.toNauticalMiles)
          "From nautical mile to kilometer and back",
          (fun x -> NauticalMile.create x |> NauticalMile.toKilometers |> Kilometer.toNauticalMiles)
          "From nautical mile to chain and back",
          (fun x -> NauticalMile.create x |> NauticalMile.toChains |> Chain.toNauticalMiles)
          "From nautical mile to furlong and back",
          (fun x -> NauticalMile.create x |> NauticalMile.toFurlongs |> Furlong.toNauticalMiles)
          "From nautical mile to league and back",
          (fun x -> NauticalMile.create x |> NauticalMile.toLeagues |> League.toNauticalMiles)
          "From nautical mile to hand and back",
          (fun x -> NauticalMile.create x |> NauticalMile.toHands |> Hand.toNauticalMiles)
          "From nautical mile to rod and back",
          (fun x -> NauticalMile.create x |> NauticalMile.toRods |> Rod.toNauticalMiles) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let chainConversionTests =
        [ "From chain to inches and back", (fun x -> Chain.create x |> Chain.toInches |> Inch.toChains)
          "From chain to foot and back", (fun x -> Chain.create x |> Chain.toFeet |> Foot.toChains)
          "From chain to yard and back", (fun x -> Chain.create x |> Chain.toYards |> Yard.toChains)
          "From chain to mile and back", (fun x -> Chain.create x |> Chain.toMiles |> Mile.toChains)
          "From chain to millimeter and back", (fun x -> Chain.create x |> Chain.toMillimeters |> Millimeter.toChains)
          "From chain to centimeter and back", (fun x -> Chain.create x |> Chain.toCentimeters |> Centimeter.toChains)
          "From chain to meter and back", (fun x -> Chain.create x |> Chain.toMeters |> Meter.toChains)
          "From chain to kilometer and back", (fun x -> Chain.create x |> Chain.toKilometers |> Kilometer.toChains)
          "From chain to nautical mile and back",
          (fun x -> Chain.create x |> Chain.toNauticalMiles |> NauticalMile.toChains)
          "From chain to furlong and back", (fun x -> Chain.create x |> Chain.toFurlongs |> Furlong.toChains)
          "From chain to league and back", (fun x -> Chain.create x |> Chain.toLeagues |> League.toChains)
          "From chain to hand and back", (fun x -> Chain.create x |> Chain.toHands |> Hand.toChains)
          "From chain to rod and back", (fun x -> Chain.create x |> Chain.toRods |> Rod.toChains) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let furlongConversionTests =
        [ "From furlong to inches and back", (fun x -> Furlong.create x |> Furlong.toInches |> Inch.toFurlongs)
          "From furlong to foot and back", (fun x -> Furlong.create x |> Furlong.toFeet |> Foot.toFurlongs)
          "From furlong to yard and back", (fun x -> Furlong.create x |> Furlong.toYards |> Yard.toFurlongs)
          "From furlong to mile and back", (fun x -> Furlong.create x |> Furlong.toMiles |> Mile.toFurlongs)
          "From furlong to millimeter and back",
          (fun x -> Furlong.create x |> Furlong.toMillimeters |> Millimeter.toFurlongs)
          "From furlong to centimeter and back",
          (fun x -> Furlong.create x |> Furlong.toCentimeters |> Centimeter.toFurlongs)
          "From furlong to meter and back", (fun x -> Furlong.create x |> Furlong.toMeters |> Meter.toFurlongs)
          "From furlong to kilometer and back",
          (fun x -> Furlong.create x |> Furlong.toKilometers |> Kilometer.toFurlongs)
          "From furlong to nautical mile and back",
          (fun x -> Furlong.create x |> Furlong.toNauticalMiles |> NauticalMile.toFurlongs)
          "From furlong to chain and back", (fun x -> Furlong.create x |> Furlong.toChains |> Chain.toFurlongs)
          "From furlong to league and back", (fun x -> Furlong.create x |> Furlong.toLeagues |> League.toFurlongs)
          "From furlong to hand and back", (fun x -> Furlong.create x |> Furlong.toHands |> Hand.toFurlongs)
          "From furlong to rod and back", (fun x -> Furlong.create x |> Furlong.toRods |> Rod.toFurlongs) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let leagueConversionTests =
        [ "From league to inches and back", (fun x -> League.create x |> League.toInches |> Inch.toLeagues)
          "From league to foot and back", (fun x -> League.create x |> League.toFeet |> Foot.toLeagues)
          "From league to yard and back", (fun x -> League.create x |> League.toYards |> Yard.toLeagues)
          "From league to mile and back", (fun x -> League.create x |> League.toMiles |> Mile.toLeagues)
          "From league to millimeter and back",
          (fun x -> League.create x |> League.toMillimeters |> Millimeter.toLeagues)
          "From league to centimeter and back",
          (fun x -> League.create x |> League.toCentimeters |> Centimeter.toLeagues)
          "From league to meter and back", (fun x -> League.create x |> League.toMeters |> Meter.toLeagues)
          "From league to kilometer and back", (fun x -> League.create x |> League.toKilometers |> Kilometer.toLeagues)
          "From league to nautical mile and back",
          (fun x -> League.create x |> League.toNauticalMiles |> NauticalMile.toLeagues)
          "From league to chain and back", (fun x -> League.create x |> League.toChains |> Chain.toLeagues)
          "From league to furlong and back", (fun x -> League.create x |> League.toFurlongs |> Furlong.toLeagues)
          "From league to hand and back", (fun x -> League.create x |> League.toHands |> Hand.toLeagues)
          "From league to rod and back", (fun x -> League.create x |> League.toRods |> Rod.toLeagues) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let handConversionTests =
        [ "From hand to inches and back", (fun x -> Hand.create x |> Hand.toInches |> Inch.toHands)
          "From hand to foot and back", (fun x -> Hand.create x |> Hand.toFeet |> Foot.toHands)
          "From hand to yard and back", (fun x -> Hand.create x |> Hand.toYards |> Yard.toHands)
          "From hand to mile and back", (fun x -> Hand.create x |> Hand.toMiles |> Mile.toHands)
          "From hand to millimeter and back", (fun x -> Hand.create x |> Hand.toMillimeters |> Millimeter.toHands)
          "From hand to centimeter and back", (fun x -> Hand.create x |> Hand.toCentimeters |> Centimeter.toHands)
          "From hand to meter and back", (fun x -> Hand.create x |> Hand.toMeters |> Meter.toHands)
          "From hand to kilometer and back", (fun x -> Hand.create x |> Hand.toKilometers |> Kilometer.toHands)
          "From hand to nautical mile and back",
          (fun x -> Hand.create x |> Hand.toNauticalMiles |> NauticalMile.toHands)
          "From hand to chain and back", (fun x -> Hand.create x |> Hand.toChains |> Chain.toHands)
          "From hand to furlong and back", (fun x -> Hand.create x |> Hand.toFurlongs |> Furlong.toHands)
          "From hand to league and back", (fun x -> Hand.create x |> Hand.toLeagues |> League.toHands)
          "From hand to rod and back", (fun x -> Hand.create x |> Hand.toRods |> Rod.toHands) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let rodConversionTests =
        [ "From rod to inches and back", (fun x -> Rod.create x |> Rod.toInches |> Inch.toRods)
          "From rod to foot and back", (fun x -> Rod.create x |> Rod.toFeet |> Foot.toRods)
          "From rod to yard and back", (fun x -> Rod.create x |> Rod.toYards |> Yard.toRods)
          "From rod to mile and back", (fun x -> Rod.create x |> Rod.toMiles |> Mile.toRods)
          "From rod to millimeter and back", (fun x -> Rod.create x |> Rod.toMillimeters |> Millimeter.toRods)
          "From rod to centimeter and back", (fun x -> Rod.create x |> Rod.toCentimeters |> Centimeter.toRods)
          "From rod to meter and back", (fun x -> Rod.create x |> Rod.toMeters |> Meter.toRods)
          "From rod to kilometer and back", (fun x -> Rod.create x |> Rod.toKilometers |> Kilometer.toRods)
          "From rod to nautical mile and back", (fun x -> Rod.create x |> Rod.toNauticalMiles |> NauticalMile.toRods)
          "From rod to chain and back", (fun x -> Rod.create x |> Rod.toChains |> Chain.toRods)
          "From rod to furlong and back", (fun x -> Rod.create x |> Rod.toFurlongs |> Furlong.toRods)
          "From rod to league and back", (fun x -> Rod.create x |> Rod.toLeagues |> League.toRods)
          "From rod to hand and back", (fun x -> Rod.create x |> Rod.toHands |> Hand.toRods) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    testList
        "Length Tests -> "
        [ testList "Convert inch to other and back -> " inchConversionTests
          testList "Convert foot to other and back -> " footConversionTests
          testList "Convert yard to other and back -> " yardConversionTests
          testList "Convert mile to other and back -> " mileConversionTests
          testList "Convert millimeter to other and back -> " millimeterConversionTests
          testList "Convert centimeter to other and back -> " centimeterConversionTests
          testList "Convert meter to other and back -> " meterConversionTests
          testList "Convert kilometer to other and back -> " kilometerConversionTests
          testList "Convert nautical mile to other and back -> " nauticalMileConversionTests
          testList "Convert chain to other and back -> " chainConversionTests
          testList "Convert furlong to other and back -> " furlongConversionTests
          testList "Convert league to other and back -> " leagueConversionTests
          testList "Convert hand to other and back -> " handConversionTests
          testList "Convert rod to other and back -> " rodConversionTests ]

[<Tests>]
let timeTests config =

    let nanoSecondConversionTests =
        [ "From nanosecond to microsecond and back",
          (fun x -> Nanosecond.create x |> Nanosecond.toMicroSeconds |> Microsecond.toNanoSeconds)
          "From nanosecond to millisecond and back",
          (fun x -> Nanosecond.create x |> Nanosecond.toMilliSeconds |> Millisecond.toNanoSeconds)
          "From nanosecond to second and back",
          (fun x -> Nanosecond.create x |> Nanosecond.toSeconds |> Second.toNanoSeconds)
          "From nanosecond to minute and back",
          (fun x -> Nanosecond.create x |> Nanosecond.toMinutes |> Minute.toNanoSeconds)
          "From nanosecond to hour and back", (fun x -> Nanosecond.create x |> Nanosecond.toHours |> Hour.toNanoSeconds)
          "From nanosecond to day and back", (fun x -> Nanosecond.create x |> Nanosecond.toDays |> Day.toNanoSeconds)
          "From nanosecond to week and back", (fun x -> Nanosecond.create x |> Nanosecond.toWeeks |> Week.toNanoSeconds)
          "From nanosecond to fortnight and back",
          (fun x -> Nanosecond.create x |> Nanosecond.toFortnights |> Fortnight.toNanoSeconds)
          "From nanosecond to month and back",
          (fun x -> Nanosecond.create x |> Nanosecond.toMonths |> Month.toNanoSeconds)
          "From nanosecond to year and back", (fun x -> Nanosecond.create x |> Nanosecond.toYears |> Year.toNanoSeconds)
          "From nanosecond to decade and back",
          (fun x -> Nanosecond.create x |> Nanosecond.toDecades |> Decade.toNanoSeconds)
          "From nanosecond to century and back",
          (fun x -> Nanosecond.create x |> Nanosecond.toCenturies |> Century.toNanoSeconds)
          "From nanosecond to millennium and back",
          (fun x -> Nanosecond.create x |> Nanosecond.toMillennia |> Millennium.toNanoSeconds)
          "From nanosecond to eon and back", (fun x -> Nanosecond.create x |> Nanosecond.toEons |> Eon.toNanoSeconds) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let microSecondConversionTests =
        [ "From microsecond to nanosecond and back",
          (fun x -> Microsecond.create x |> Microsecond.toNanoSeconds |> Nanosecond.toMicroSeconds)
          "From microsecond to millisecond and back",
          (fun x -> Microsecond.create x |> Microsecond.toMilliSeconds |> Millisecond.toMicroSeconds)
          "From microsecond to second and back",
          (fun x -> Microsecond.create x |> Microsecond.toSeconds |> Second.toMicroSeconds)
          "From microsecond to minute and back",
          (fun x -> Microsecond.create x |> Microsecond.toMinutes |> Minute.toMicroSeconds)
          "From microsecond to hour and back",
          (fun x -> Microsecond.create x |> Microsecond.toHours |> Hour.toMicroSeconds)
          "From microsecond to day and back",
          (fun x -> Microsecond.create x |> Microsecond.toDays |> Day.toMicroSeconds)
          "From microsecond to week and back",
          (fun x -> Microsecond.create x |> Microsecond.toWeeks |> Week.toMicroSeconds)
          "From microsecond to fortnight and back",
          (fun x -> Microsecond.create x |> Microsecond.toFortnights |> Fortnight.toMicroSeconds)
          "From microsecond to month and back",
          (fun x -> Microsecond.create x |> Microsecond.toMonths |> Month.toMicroSeconds)
          "From microsecond to year and back",
          (fun x -> Microsecond.create x |> Microsecond.toYears |> Year.toMicroSeconds)
          "From microsecond to decade and back",
          (fun x -> Microsecond.create x |> Microsecond.toDecades |> Decade.toMicroSeconds)
          "From microsecond to century and back",
          (fun x -> Microsecond.create x |> Microsecond.toCenturies |> Century.toMicroSeconds)
          "From microsecond to millennium and back",
          (fun x -> Microsecond.create x |> Microsecond.toMillennia |> Millennium.toMicroSeconds)
          "From microsecond to eon and back",
          (fun x -> Microsecond.create x |> Microsecond.toEons |> Eon.toMicroSeconds) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let milliSecondConversionTests =
        [ "From millisecond to nanosecond and back",
          (fun x -> Millisecond.create x |> Millisecond.toNanoSeconds |> Nanosecond.toMilliSeconds)
          "From millisecond to microsecond and back",
          (fun x -> Millisecond.create x |> Millisecond.toMicroSeconds |> Microsecond.toMilliSeconds)
          "From millisecond to second and back",
          (fun x -> Millisecond.create x |> Millisecond.toSeconds |> Second.toMilliSeconds)
          "From millisecond to minute and back",
          (fun x -> Millisecond.create x |> Millisecond.toMinutes |> Minute.toMilliSeconds)
          "From millisecond to hour and back",
          (fun x -> Millisecond.create x |> Millisecond.toHours |> Hour.toMilliSeconds)
          "From millisecond to day and back",
          (fun x -> Millisecond.create x |> Millisecond.toDays |> Day.toMilliSeconds)
          "From millisecond to week and back",
          (fun x -> Millisecond.create x |> Millisecond.toWeeks |> Week.toMilliSeconds)
          "From millisecond to fortnight and back",
          (fun x -> Millisecond.create x |> Millisecond.toFortnights |> Fortnight.toMilliSeconds)
          "From millisecond to month and back",
          (fun x -> Millisecond.create x |> Millisecond.toMonths |> Month.toMilliSeconds)
          "From millisecond to year and back",
          (fun x -> Millisecond.create x |> Millisecond.toYears |> Year.toMilliSeconds)
          "From millisecond to decade and back",
          (fun x -> Millisecond.create x |> Millisecond.toDecades |> Decade.toMilliSeconds)
          "From millisecond to century and back",
          (fun x -> Millisecond.create x |> Millisecond.toCenturies |> Century.toMilliSeconds)
          "From millisecond to millennium and back",
          (fun x -> Millisecond.create x |> Millisecond.toMillennia |> Millennium.toMilliSeconds)
          "From millisecond to eon and back",
          (fun x -> Millisecond.create x |> Millisecond.toEons |> Eon.toMilliSeconds) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let secondConversionTests =
        [ "From second to nanosecond and back",
          (fun x -> Second.create x |> Second.toNanoSeconds |> Nanosecond.toSeconds)
          "From second to microsecond and back",
          (fun x -> Second.create x |> Second.toMicroSeconds |> Microsecond.toSeconds)
          "From second to millisecond and back",
          (fun x -> Second.create x |> Second.toMilliSeconds |> Millisecond.toSeconds)
          "From second to minute and back", (fun x -> Second.create x |> Second.toMinutes |> Minute.toSeconds)
          "From second to hour and back", (fun x -> Second.create x |> Second.toHours |> Hour.toSeconds)
          "From second to day and back", (fun x -> Second.create x |> Second.toDays |> Day.toSeconds)
          "From second to week and back", (fun x -> Second.create x |> Second.toWeeks |> Week.toSeconds)
          "From second to fortnight and back", (fun x -> Second.create x |> Second.toFortnights |> Fortnight.toSeconds)
          "From second to month and back", (fun x -> Second.create x |> Second.toMonths |> Month.toSeconds)
          "From second to year and back", (fun x -> Second.create x |> Second.toYears |> Year.toSeconds)
          "From second to decade and back", (fun x -> Second.create x |> Second.toDecades |> Decade.toSeconds)
          "From second to century and back", (fun x -> Second.create x |> Second.toCenturies |> Century.toSeconds)
          "From second to millennium and back", (fun x -> Second.create x |> Second.toMillennia |> Millennium.toSeconds)
          "From second to eon and back", (fun x -> Second.create x |> Second.toEons |> Eon.toSeconds) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let minuteConversionTests =
        [ "From minute to nanosecond and back",
          (fun x -> Minute.create x |> Minute.toNanoSeconds |> Nanosecond.toMinutes)
          "From minute to microsecond and back",
          (fun x -> Minute.create x |> Minute.toMicroSeconds |> Microsecond.toMinutes)
          "From minute to millisecond and back",
          (fun x -> Minute.create x |> Minute.toMilliSeconds |> Millisecond.toMinutes)
          "From minute to second and back", (fun x -> Minute.create x |> Minute.toSeconds |> Second.toMinutes)
          "From minute to hour and back", (fun x -> Minute.create x |> Minute.toHours |> Hour.toMinutes)
          "From minute to day and back", (fun x -> Minute.create x |> Minute.toDays |> Day.toMinutes)
          "From minute to week and back", (fun x -> Minute.create x |> Minute.toWeeks |> Week.toMinutes)
          "From minute to fortnight and back", (fun x -> Minute.create x |> Minute.toFortnights |> Fortnight.toMinutes)
          "From minute to month and back", (fun x -> Minute.create x |> Minute.toMonths |> Month.toMinutes)
          "From minute to year and back", (fun x -> Minute.create x |> Minute.toYears |> Year.toMinutes)
          "From minute to decade and back", (fun x -> Minute.create x |> Minute.toDecades |> Decade.toMinutes)
          "From minute to century and back", (fun x -> Minute.create x |> Minute.toCenturies |> Century.toMinutes)
          "From minute to millennium and back", (fun x -> Minute.create x |> Minute.toMillennia |> Millennium.toMinutes)
          "From minute to eon and back", (fun x -> Minute.create x |> Minute.toEons |> Eon.toMinutes) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let hourConversionTests =
        [ "From hour to nanosecond and back", (fun x -> Hour.create x |> Hour.toNanoSeconds |> Nanosecond.toHours)
          "From hour to microsecond and back", (fun x -> Hour.create x |> Hour.toMicroSeconds |> Microsecond.toHours)
          "From hour to millisecond and back", (fun x -> Hour.create x |> Hour.toMilliSeconds |> Millisecond.toHours)
          "From hour to second and back", (fun x -> Hour.create x |> Hour.toSeconds |> Second.toHours)
          "From hour to minute and back", (fun x -> Hour.create x |> Hour.toMinutes |> Minute.toHours)
          "From hour to day and back", (fun x -> Hour.create x |> Hour.toDays |> Day.toHours)
          "From hour to week and back", (fun x -> Hour.create x |> Hour.toWeeks |> Week.toHours)
          "From hour to fortnight and back", (fun x -> Hour.create x |> Hour.toFortnights |> Fortnight.toHours)
          "From hour to month and back", (fun x -> Hour.create x |> Hour.toMonths |> Month.toHours)
          "From hour to year and back", (fun x -> Hour.create x |> Hour.toYears |> Year.toHours)
          "From hour to decade and back", (fun x -> Hour.create x |> Hour.toDecades |> Decade.toHours)
          "From hour to century and back", (fun x -> Hour.create x |> Hour.toCenturies |> Century.toHours)
          "From hour to millennium and back", (fun x -> Hour.create x |> Hour.toMillennia |> Millennium.toHours)
          "From hour to eon and back", (fun x -> Hour.create x |> Hour.toEons |> Eon.toHours) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let dayConversionTests =
        [ "From day to nanosecond and back", (fun x -> Day.create x |> Day.toNanoSeconds |> Nanosecond.toDays)
          "From day to microsecond and back", (fun x -> Day.create x |> Day.toMicroSeconds |> Microsecond.toDays)
          "From day to millisecond and back", (fun x -> Day.create x |> Day.toMilliSeconds |> Millisecond.toDays)
          "From day to second and back", (fun x -> Day.create x |> Day.toSeconds |> Second.toDays)
          "From day to minute and back", (fun x -> Day.create x |> Day.toMinutes |> Minute.toDays)
          "From day to hour and back", (fun x -> Day.create x |> Day.toHours |> Hour.toDays)
          "From day to week and back", (fun x -> Day.create x |> Day.toWeeks |> Week.toDays)
          "From day to fortnight and back", (fun x -> Day.create x |> Day.toFortnights |> Fortnight.toDays)
          "From day to month and back", (fun x -> Day.create x |> Day.toMonths |> Month.toDays)
          "From day to year and back", (fun x -> Day.create x |> Day.toYears |> Year.toDays)
          "From day to decade and back", (fun x -> Day.create x |> Day.toDecades |> Decade.toDays)
          "From day to century and back", (fun x -> Day.create x |> Day.toCenturies |> Century.toDays)
          "From day to millennium and back", (fun x -> Day.create x |> Day.toMillennia |> Millennium.toDays)
          "From day to eon and back", (fun x -> Day.create x |> Day.toEons |> Eon.toDays) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let weekConversionTests =
        [ "From week to nanosecond and back", (fun x -> Week.create x |> Week.toNanoSeconds |> Nanosecond.toWeeks)
          "From week to microsecond and back", (fun x -> Week.create x |> Week.toMicroSeconds |> Microsecond.toWeeks)
          "From week to millisecond and back", (fun x -> Week.create x |> Week.toMilliSeconds |> Millisecond.toWeeks)
          "From week to second and back", (fun x -> Week.create x |> Week.toSeconds |> Second.toWeeks)
          "From week to minute and back", (fun x -> Week.create x |> Week.toMinutes |> Minute.toWeeks)
          "From week to hour and back", (fun x -> Week.create x |> Week.toHours |> Hour.toWeeks)
          "From week to day and back", (fun x -> Week.create x |> Week.toDays |> Day.toWeeks)
          "From week to fortnight and back", (fun x -> Week.create x |> Week.toFortnights |> Fortnight.toWeeks)
          "From week to month and back", (fun x -> Week.create x |> Week.toMonths |> Month.toWeeks)
          "From week to year and back", (fun x -> Week.create x |> Week.toYears |> Year.toWeeks)
          "From week to decade and back", (fun x -> Week.create x |> Week.toDecades |> Decade.toWeeks)
          "From week to century and back", (fun x -> Week.create x |> Week.toCenturies |> Century.toWeeks)
          "From week to millennium and back", (fun x -> Week.create x |> Week.toMillennia |> Millennium.toWeeks)
          "From week to eon and back", (fun x -> Week.create x |> Week.toEons |> Eon.toWeeks) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let fortnightConversionTests =
        [ "From fortnight to nanosecond and back",
          (fun x -> Fortnight.create x |> Fortnight.toNanoSeconds |> Nanosecond.toFortnights)
          "From fortnight to microsecond and back",
          (fun x -> Fortnight.create x |> Fortnight.toMicroSeconds |> Microsecond.toFortnights)
          "From fortnight to millisecond and back",
          (fun x -> Fortnight.create x |> Fortnight.toMilliSeconds |> Millisecond.toFortnights)
          "From fortnight to second and back",
          (fun x -> Fortnight.create x |> Fortnight.toSeconds |> Second.toFortnights)
          "From fortnight to minute and back",
          (fun x -> Fortnight.create x |> Fortnight.toMinutes |> Minute.toFortnights)
          "From fortnight to hour and back", (fun x -> Fortnight.create x |> Fortnight.toHours |> Hour.toFortnights)
          "From fortnight to day and back", (fun x -> Fortnight.create x |> Fortnight.toDays |> Day.toFortnights)
          "From fortnight to week and back", (fun x -> Fortnight.create x |> Fortnight.toWeeks |> Week.toFortnights)
          "From fortnight to month and back", (fun x -> Fortnight.create x |> Fortnight.toMonths |> Month.toFortnights)
          "From fortnight to year and back", (fun x -> Fortnight.create x |> Fortnight.toYears |> Year.toFortnights)
          "From fortnight to decade and back",
          (fun x -> Fortnight.create x |> Fortnight.toDecades |> Decade.toFortnights)
          "From fortnight to century and back",
          (fun x -> Fortnight.create x |> Fortnight.toCenturies |> Century.toFortnights)
          "From fortnight to millennium and back",
          (fun x -> Fortnight.create x |> Fortnight.toMillennia |> Millennium.toFortnights)
          "From fortnight to eon and back", (fun x -> Fortnight.create x |> Fortnight.toEons |> Eon.toFortnights) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let monthConversionTests =
        [ "From month to nanosecond and back", (fun x -> Month.create x |> Month.toNanoSeconds |> Nanosecond.toMonths)
          "From month to microsecond and back",
          (fun x -> Month.create x |> Month.toMicroSeconds |> Microsecond.toMonths)
          "From month to millisecond and back",
          (fun x -> Month.create x |> Month.toMilliSeconds |> Millisecond.toMonths)
          "From month to second and back", (fun x -> Month.create x |> Month.toSeconds |> Second.toMonths)
          "From month to minute and back", (fun x -> Month.create x |> Month.toMinutes |> Minute.toMonths)
          "From month to hour and back", (fun x -> Month.create x |> Month.toHours |> Hour.toMonths)
          "From month to day and back", (fun x -> Month.create x |> Month.toDays |> Day.toMonths)
          "From month to week and back", (fun x -> Month.create x |> Month.toWeeks |> Week.toMonths)
          "From month to fortnight and back", (fun x -> Month.create x |> Month.toFortnights |> Fortnight.toMonths)
          "From month to year and back", (fun x -> Month.create x |> Month.toYears |> Year.toMonths)
          "From month to decade and back", (fun x -> Month.create x |> Month.toDecades |> Decade.toMonths)
          "From month to century and back", (fun x -> Month.create x |> Month.toCenturies |> Century.toMonths)
          "From month to millennium and back", (fun x -> Month.create x |> Month.toMillennia |> Millennium.toMonths)
          "From month to eon and back", (fun x -> Month.create x |> Month.toEons |> Eon.toMonths) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let yearConversionTests =
        [ "From year to nanosecond and back", (fun x -> Year.create x |> Year.toNanoSeconds |> Nanosecond.toYears)
          "From year to microsecond and back", (fun x -> Year.create x |> Year.toMicroSeconds |> Microsecond.toYears)
          "From year to millisecond and back", (fun x -> Year.create x |> Year.toMilliSeconds |> Millisecond.toYears)
          "From year to second and back", (fun x -> Year.create x |> Year.toSeconds |> Second.toYears)
          "From year to minute and back", (fun x -> Year.create x |> Year.toMinutes |> Minute.toYears)
          "From year to hour and back", (fun x -> Year.create x |> Year.toHours |> Hour.toYears)
          "From year to day and back", (fun x -> Year.create x |> Year.toDays |> Day.toYears)
          "From year to week and back", (fun x -> Year.create x |> Year.toWeeks |> Week.toYears)
          "From year to fortnight and back", (fun x -> Year.create x |> Year.toFortnights |> Fortnight.toYears)
          "From year to month and back", (fun x -> Year.create x |> Year.toMonths |> Month.toYears)
          "From year to decade and back", (fun x -> Year.create x |> Year.toDecades |> Decade.toYears)
          "From year to century and back", (fun x -> Year.create x |> Year.toCenturies |> Century.toYears)
          "From year to millennium and back", (fun x -> Year.create x |> Year.toMillennia |> Millennium.toYears)
          "From year to eon and back", (fun x -> Year.create x |> Year.toEons |> Eon.toYears) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let decadeConversionTests =
        [ "From decade to nanosecond and back",
          (fun x -> Decade.create x |> Decade.toNanoSeconds |> Nanosecond.toDecades)
          "From decade to microsecond and back",
          (fun x -> Decade.create x |> Decade.toMicroSeconds |> Microsecond.toDecades)
          "From decade to millisecond and back",
          (fun x -> Decade.create x |> Decade.toMilliSeconds |> Millisecond.toDecades)
          "From decade to second and back", (fun x -> Decade.create x |> Decade.toSeconds |> Second.toDecades)
          "From decade to minute and back", (fun x -> Decade.create x |> Decade.toMinutes |> Minute.toDecades)
          "From decade to hour and back", (fun x -> Decade.create x |> Decade.toHours |> Hour.toDecades)
          "From decade to day and back", (fun x -> Decade.create x |> Decade.toDays |> Day.toDecades)
          "From decade to week and back", (fun x -> Decade.create x |> Decade.toWeeks |> Week.toDecades)
          "From decade to fortnight and back", (fun x -> Decade.create x |> Decade.toFortnights |> Fortnight.toDecades)
          "From decade to month and back", (fun x -> Decade.create x |> Decade.toMonths |> Month.toDecades)
          "From decade to year and back", (fun x -> Decade.create x |> Decade.toYears |> Year.toDecades)
          "From decade to century and back", (fun x -> Decade.create x |> Decade.toCenturies |> Century.toDecades)
          "From decade to millennium and back", (fun x -> Decade.create x |> Decade.toMillennia |> Millennium.toDecades)
          "From decade to eon and back", (fun x -> Decade.create x |> Decade.toEons |> Eon.toDecades) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let centuryConversionTests =
        [ "From century to nanosecond and back",
          (fun x -> Century.create x |> Century.toNanoSeconds |> Nanosecond.toCenturies)
          "From century to microsecond and back",
          (fun x -> Century.create x |> Century.toMicroSeconds |> Microsecond.toCenturies)
          "From century to millisecond and back",
          (fun x -> Century.create x |> Century.toMilliSeconds |> Millisecond.toCenturies)
          "From century to second and back", (fun x -> Century.create x |> Century.toSeconds |> Second.toCenturies)
          "From century to minute and back", (fun x -> Century.create x |> Century.toMinutes |> Minute.toCenturies)
          "From century to hour and back", (fun x -> Century.create x |> Century.toHours |> Hour.toCenturies)
          "From century to day and back", (fun x -> Century.create x |> Century.toDays |> Day.toCenturies)
          "From century to week and back", (fun x -> Century.create x |> Century.toWeeks |> Week.toCenturies)
          "From century to fortnight and back",
          (fun x -> Century.create x |> Century.toFortnights |> Fortnight.toCenturies)
          "From century to month and back", (fun x -> Century.create x |> Century.toMonths |> Month.toCenturies)
          "From century to year and back", (fun x -> Century.create x |> Century.toYears |> Year.toCenturies)
          "From century to decade and back", (fun x -> Century.create x |> Century.toDecades |> Decade.toCenturies)
          "From century to millennium and back",
          (fun x -> Century.create x |> Century.toMillennia |> Millennium.toCenturies)
          "From century to eon and back", (fun x -> Century.create x |> Century.toEons |> Eon.toCenturies) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let millenniumConversionTests =
        [ "From millennium to nanosecond and back",
          (fun x -> Millennium.create x |> Millennium.toNanoSeconds |> Nanosecond.toMillennia)
          "From millennium to microsecond and back",
          (fun x -> Millennium.create x |> Millennium.toMicroSeconds |> Microsecond.toMillennia)
          "From millennium to millisecond and back",
          (fun x -> Millennium.create x |> Millennium.toMilliSeconds |> Millisecond.toMillennia)
          "From millennium to second and back",
          (fun x -> Millennium.create x |> Millennium.toSeconds |> Second.toMillennia)
          "From millennium to minute and back",
          (fun x -> Millennium.create x |> Millennium.toMinutes |> Minute.toMillennia)
          "From millennium to hour and back", (fun x -> Millennium.create x |> Millennium.toHours |> Hour.toMillennia)
          "From millennium to day and back", (fun x -> Millennium.create x |> Millennium.toDays |> Day.toMillennia)
          "From millennium to week and back", (fun x -> Millennium.create x |> Millennium.toWeeks |> Week.toMillennia)
          "From millennium to fortnight and back",
          (fun x -> Millennium.create x |> Millennium.toFortnights |> Fortnight.toMillennia)
          "From millennium to month and back",
          (fun x -> Millennium.create x |> Millennium.toMonths |> Month.toMillennia)
          "From millennium to year and back", (fun x -> Millennium.create x |> Millennium.toYears |> Year.toMillennia)
          "From millennium to decade and back",
          (fun x -> Millennium.create x |> Millennium.toDecades |> Decade.toMillennia)
          "From millennium to century and back",
          (fun x -> Millennium.create x |> Millennium.toCenturies |> Century.toMillennia)
          "From millennium to eon and back", (fun x -> Millennium.create x |> Millennium.toEons |> Eon.toMillennia) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let eonConversionTests =
        [ "From eon to nanosecond and back", (fun x -> Eon.create x |> Eon.toNanoSeconds |> Nanosecond.toEons)
          "From eon to microsecond and back", (fun x -> Eon.create x |> Eon.toMicroSeconds |> Microsecond.toEons)
          "From eon to millisecond and back", (fun x -> Eon.create x |> Eon.toMilliSeconds |> Millisecond.toEons)
          "From eon to second and back", (fun x -> Eon.create x |> Eon.toSeconds |> Second.toEons)
          "From eon to minute and back", (fun x -> Eon.create x |> Eon.toMinutes |> Minute.toEons)
          "From eon to hour and back", (fun x -> Eon.create x |> Eon.toHours |> Hour.toEons)
          "From eon to day and back", (fun x -> Eon.create x |> Eon.toDays |> Day.toEons)
          "From eon to week and back", (fun x -> Eon.create x |> Eon.toWeeks |> Week.toEons)
          "From eon to fortnight and back", (fun x -> Eon.create x |> Eon.toFortnights |> Fortnight.toEons)
          "From eon to month and back", (fun x -> Eon.create x |> Eon.toMonths |> Month.toEons)
          "From eon to year and back", (fun x -> Eon.create x |> Eon.toYears |> Year.toEons)
          "From eon to decade and back", (fun x -> Eon.create x |> Eon.toDecades |> Decade.toEons)
          "From eon to century and back", (fun x -> Eon.create x |> Eon.toCenturies |> Century.toEons)
          "From eon to millennium and back", (fun x -> Eon.create x |> Eon.toMillennia |> Millennium.toEons) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)


    testList
        "Time Tests -> "
        [ testList "Nanosecond conversion tests -> " nanoSecondConversionTests
          testList "Microsecond conversion tests -> " microSecondConversionTests
          testList "Millisecond conversion tests -> " milliSecondConversionTests
          testList "Second conversion tests -> " secondConversionTests
          testList "Minute conversion tests -> " minuteConversionTests
          testList "Hour conversion tests -> " hourConversionTests
          testList "Day conversion tests -> " dayConversionTests
          testList "Week conversion tests -> " weekConversionTests
          testList "Fortnight conversion tests -> " fortnightConversionTests
          testList "Month conversion tests -> " monthConversionTests
          testList "Year conversion tests -> " yearConversionTests
          testList "Decade conversion tests -> " decadeConversionTests
          testList "Century conversion tests -> " centuryConversionTests
          testList "Millennium conversion tests -> " millenniumConversionTests
          testList "Eon conversion tests -> " eonConversionTests ]

[<Tests>]
let massTests config =

    let milligramConversionTests =
        [ "From milligram to gram and back", (fun x -> Milligram.create x |> Milligram.toGrams |> Gram.toMilligrams)
          "From milligram to kilogram and back",
          (fun x -> Milligram.create x |> Milligram.toKilograms |> Kilogram.toMilligrams)
          "From milligram to pound and back",
          (fun x -> Milligram.create x |> Milligram.toPoundMass |> PoundMass.toMilligrams) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let gramConversionTests =
        [ "From gram to milligram and back", (fun x -> Gram.create x |> Gram.toMilligrams |> Milligram.toGrams)
          "From gram to kilogram and back", (fun x -> Gram.create x |> Gram.toKilograms |> Kilogram.toGrams)
          "From gram to pound and back", (fun x -> Gram.create x |> Gram.toPoundMass |> PoundMass.toGrams) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let kilogramConversionTests =
        [ "From kilogram to milligram and back",
          (fun x -> Kilogram.create x |> Kilogram.toMilligrams |> Milligram.toKilograms)
          "From kilogram to gram and back", (fun x -> Kilogram.create x |> Kilogram.toGrams |> Gram.toKilograms)
          "From kilogram to pound and back",
          (fun x -> Kilogram.create x |> Kilogram.toPoundMass |> PoundMass.toKilograms) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let poundConversionTests =
        [ "From pound to milligram and back",
          (fun x -> PoundMass.create x |> PoundMass.toMilligrams |> Milligram.toPoundMass)
          "From pound to gram and back", (fun x -> PoundMass.create x |> PoundMass.toGrams |> Gram.toPoundMass)
          "From pound to kilogram and back",
          (fun x -> PoundMass.create x |> PoundMass.toKilograms |> Kilogram.toPoundMass) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    testList
        "Mass tests -> "
        [ testList "Milligram conversion tests -> " milligramConversionTests
          testList "Gram conversion tests -> " gramConversionTests
          testList "Kilogram conversion tests -> " kilogramConversionTests
          testList "Pound conversion tests -> " poundConversionTests ]

[<Tests>]
let temperatureTests config =

    let kelvinConversionTests =
        [ "From kelvin to celsius and back", (fun x -> Kelvin.create x |> Kelvin.toCelsius |> Celsius.toKelvin)
          "From kelvin to fahrenheit and back", (fun x -> Kelvin.create x |> Kelvin.toFahrenheit |> Fahrenheit.toKelvin)
          "From kelvin to rankine and back", (fun x -> Kelvin.create x |> Kelvin.toRankine |> Rankine.toKelvin) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let celsiusConversionTests =
        [ "From celsius to kelvin and back", (fun x -> Celsius.create x |> Celsius.toKelvin |> Kelvin.toCelsius)
          "From celsius to fahrenheit and back",
          (fun x -> Celsius.create x |> Celsius.toFahrenheit |> Fahrenheit.toCelsius)
          "From celsius to rankine and back", (fun x -> Celsius.create x |> Celsius.toRankine |> Rankine.toCelsius) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let fahrenheitConversionTests =
        [ "From fahrenheit to kelvin and back",
          (fun x -> Fahrenheit.create x |> Fahrenheit.toKelvin |> Kelvin.toFahrenheit)
          "From fahrenheit to celsius and back",
          (fun x -> Fahrenheit.create x |> Fahrenheit.toCelsius |> Celsius.toFahrenheit)
          "From fahrenheit to rankine and back",
          (fun x -> Fahrenheit.create x |> Fahrenheit.toRankine |> Rankine.toFahrenheit) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let rankineConversionTests =
        [ "From rankine to kelvin and back", (fun x -> Rankine.create x |> Rankine.toKelvin |> Kelvin.toRankine)
          "From rankine to celsius and back", (fun x -> Rankine.create x |> Rankine.toCelsius |> Celsius.toRankine)
          "From rankine to fahrenheit and back",
          (fun x -> Rankine.create x |> Rankine.toFahrenheit |> Fahrenheit.toRankine) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    testList
        "Temperature Tests -> "
        [ testList "Kelvin conversion tests -> " kelvinConversionTests
          testList "Celsius conversion tests -> " celsiusConversionTests
          testList "Fahrenheit conversion tests -> " fahrenheitConversionTests
          testList "Rankine conversion tests -> " rankineConversionTests ]

[<Tests>]
let angleTests config =

    let degreeConversionTests =
        [ "From degrees to radians and back", (fun x -> Degree.create x |> Degree.toRadians |> Radian.toDegrees)
          "From degrees to gradians and back", (fun x -> Degree.create x |> Degree.toGradians |> Gradian.toDegrees)
          "From degrees to revolutions and back",
          (fun x -> Degree.create x |> Degree.toRevolutions |> Revolution.toDegrees)
          "From degrees to arcminutes and back",
          (fun x -> Degree.create x |> Degree.toArcMinutes |> ArcMinute.toDegrees)
          "From degrees to arcseconds and back",
          (fun x -> Degree.create x |> Degree.toArcSeconds |> ArcSecond.toDegrees) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let radianConversionTests =
        [ "From radians to degrees and back", (fun x -> Radian.create x |> Radian.toDegrees |> Degree.toRadians)
          "From radians to gradians and back", (fun x -> Radian.create x |> Radian.toGradians |> Gradian.toRadians)
          "From radians to revolutions and back",
          (fun x -> Radian.create x |> Radian.toRevolutions |> Revolution.toRadians)
          "From radians to arcminutes and back",
          (fun x -> Radian.create x |> Radian.toArcMinutes |> ArcMinute.toRadians)
          "From radians to arcseconds and back",
          (fun x -> Radian.create x |> Radian.toArcSeconds |> ArcSecond.toRadians) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let gradianConversionTests =
        [ "From gradians to degrees and back", (fun x -> Gradian.create x |> Gradian.toDegrees |> Degree.toGradians)
          "From gradians to radians and back", (fun x -> Gradian.create x |> Gradian.toRadians |> Radian.toGradians)
          "From gradians to revolutions and back",
          (fun x -> Gradian.create x |> Gradian.toRevolutions |> Revolution.toGradians)
          "From gradians to arcminutes and back",
          (fun x -> Gradian.create x |> Gradian.toArcMinutes |> ArcMinute.toGradians)
          "From gradians to arcseconds and back",
          (fun x -> Gradian.create x |> Gradian.toArcSeconds |> ArcSecond.toGradians) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let revolutionConversionTests =
        [ "From revolutions to degrees and back",
          (fun x -> Revolution.create x |> Revolution.toDegrees |> Degree.toRevolutions)
          "From revolutions to radians and back",
          (fun x -> Revolution.create x |> Revolution.toRadians |> Radian.toRevolutions)
          "From revolutions to gradians and back",
          (fun x -> Revolution.create x |> Revolution.toGradians |> Gradian.toRevolutions)
          "From revolutions to arcminutes and back",
          (fun x -> Revolution.create x |> Revolution.toArcMinutes |> ArcMinute.toRevolutions)
          "From revolutions to arcseconds and back",
          (fun x -> Revolution.create x |> Revolution.toArcSeconds |> ArcSecond.toRevolutions) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let arcMinuteConversionTests =
        [ "From arcminutes to degrees and back",
          (fun x -> ArcMinute.create x |> ArcMinute.toDegrees |> Degree.toArcMinutes)
          "From arcminutes to radians and back",
          (fun x -> ArcMinute.create x |> ArcMinute.toRadians |> Radian.toArcMinutes)
          "From arcminutes to gradians and back",
          (fun x -> ArcMinute.create x |> ArcMinute.toGradians |> Gradian.toArcMinutes)
          "From arcminutes to revolutions and back",
          (fun x -> ArcMinute.create x |> ArcMinute.toRevolutions |> Revolution.toArcMinutes)
          "From arcminutes to arcseconds and back",
          (fun x -> ArcMinute.create x |> ArcMinute.toArcSeconds |> ArcSecond.toArcMinutes) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let arcSecondConversionTests =
        [ "From arcseconds to degrees and back",
          (fun x -> ArcSecond.create x |> ArcSecond.toDegrees |> Degree.toArcSeconds)
          "From arcseconds to radians and back",
          (fun x -> ArcSecond.create x |> ArcSecond.toRadians |> Radian.toArcSeconds)
          "From arcseconds to gradians and back",
          (fun x -> ArcSecond.create x |> ArcSecond.toGradians |> Gradian.toArcSeconds)
          "From arcseconds to revolutions and back",
          (fun x -> ArcSecond.create x |> ArcSecond.toRevolutions |> Revolution.toArcSeconds)
          "From arcseconds to arcminutes and back",
          (fun x -> ArcSecond.create x |> ArcSecond.toArcMinutes |> ArcMinute.toArcSeconds) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    testList
        "Angle Tests -> "
        [ testList "Degree conversion tests -> " degreeConversionTests
          testList "Radian conversion tests -> " radianConversionTests
          testList "Gradian conversion tests -> " gradianConversionTests
          testList "Revolution conversion tests -> " revolutionConversionTests
          testList "ArcMinute conversion tests -> " arcMinuteConversionTests
          testList "ArcSecond conversion tests -> " arcSecondConversionTests ]

[<Tests>]
let dataStorageTests config =

    let bitConversionTests =
        [ "From bit to kilobit and back", (fun x -> Bit.create x |> Bit.toKilobits |> Kilobit.toBits)
          "From bit to megabit and back", (fun x -> Bit.create x |> Bit.toMegabits |> Megabit.toBits)
          "From bit to gigabit and back", (fun x -> Bit.create x |> Bit.toGigabits |> Gigabit.toBits)
          "From bit to terabit and back", (fun x -> Bit.create x |> Bit.toTerabits |> Terabit.toBits)
          "From bit to petabit and back", (fun x -> Bit.create x |> Bit.toPetabits |> Petabit.toBits)
          "From bit to byte and back", (fun x -> Bit.create x |> Bit.toBytes |> Byte.toBits)
          "From bit to kilobyte and back", (fun x -> Bit.create x |> Bit.toKilobytes |> Kilobyte.toBits)
          "From bit to megabyte and back", (fun x -> Bit.create x |> Bit.toMegabytes |> Megabyte.toBits)
          "From bit to gigabyte and back", (fun x -> Bit.create x |> Bit.toGigabytes |> Gigabyte.toBits)
          "From bit to terabyte and back", (fun x -> Bit.create x |> Bit.toTerabytes |> Terabyte.toBits)
          "From bit to petabyte and back", (fun x -> Bit.create x |> Bit.toPetabytes |> Petabyte.toBits) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let kilobitConversionTests =
        [ "From kilobit to bit and back", (fun x -> Kilobit.create x |> Kilobit.toBits |> Bit.toKilobits)
          "From kilobit to megabit and back", (fun x -> Kilobit.create x |> Kilobit.toMegabits |> Megabit.toKilobits)
          "From kilobit to gigabit and back", (fun x -> Kilobit.create x |> Kilobit.toGigabits |> Gigabit.toKilobits)
          "From kilobit to terabit and back", (fun x -> Kilobit.create x |> Kilobit.toTerabits |> Terabit.toKilobits)
          "From kilobit to petabit and back", (fun x -> Kilobit.create x |> Kilobit.toPetabits |> Petabit.toKilobits)
          "From kilobit to byte and back", (fun x -> Kilobit.create x |> Kilobit.toBytes |> Byte.toKilobits)
          "From kilobit to kilobyte and back", (fun x -> Kilobit.create x |> Kilobit.toKilobytes |> Kilobyte.toKilobits)
          "From kilobit to megabyte and back", (fun x -> Kilobit.create x |> Kilobit.toMegabytes |> Megabyte.toKilobits)
          "From kilobit to gigabyte and back", (fun x -> Kilobit.create x |> Kilobit.toGigabytes |> Gigabyte.toKilobits)
          "From kilobit to terabyte and back", (fun x -> Kilobit.create x |> Kilobit.toTerabytes |> Terabyte.toKilobits)
          "From kilobit to petabyte and back", (fun x -> Kilobit.create x |> Kilobit.toPetabytes |> Petabyte.toKilobits) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let megabitConversionTests =
        [ "From megabit to bit and back", (fun x -> Megabit.create x |> Megabit.toBits |> Bit.toMegabits)
          "From megabit to kilobit and back", (fun x -> Megabit.create x |> Megabit.toKilobits |> Kilobit.toMegabits)
          "From megabit to gigabit and back", (fun x -> Megabit.create x |> Megabit.toGigabits |> Gigabit.toMegabits)
          "From megabit to terabit and back", (fun x -> Megabit.create x |> Megabit.toTerabits |> Terabit.toMegabits)
          "From megabit to petabit and back", (fun x -> Megabit.create x |> Megabit.toPetabits |> Petabit.toMegabits)
          "From megabit to byte and back", (fun x -> Megabit.create x |> Megabit.toBytes |> Byte.toMegabits)
          "From megabit to kilobyte and back", (fun x -> Megabit.create x |> Megabit.toKilobytes |> Kilobyte.toMegabits)
          "From megabit to megabyte and back", (fun x -> Megabit.create x |> Megabit.toMegabytes |> Megabyte.toMegabits)
          "From megabit to gigabyte and back", (fun x -> Megabit.create x |> Megabit.toGigabytes |> Gigabyte.toMegabits)
          "From megabit to terabyte and back", (fun x -> Megabit.create x |> Megabit.toTerabytes |> Terabyte.toMegabits)
          "From megabit to petabyte and back", (fun x -> Megabit.create x |> Megabit.toPetabytes |> Petabyte.toMegabits) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let gigabitConversionTests =
        [ "From gigabit to bit and back", (fun x -> Gigabit.create x |> Gigabit.toBits |> Bit.toGigabits)
          "From gigabit to kilobit and back", (fun x -> Gigabit.create x |> Gigabit.toKilobits |> Kilobit.toGigabits)
          "From gigabit to megabit and back", (fun x -> Gigabit.create x |> Gigabit.toMegabits |> Megabit.toGigabits)
          "From gigabit to terabit and back", (fun x -> Gigabit.create x |> Gigabit.toTerabits |> Terabit.toGigabits)
          "From gigabit to petabit and back", (fun x -> Gigabit.create x |> Gigabit.toPetabits |> Petabit.toGigabits)
          "From gigabit to byte and back", (fun x -> Gigabit.create x |> Gigabit.toBytes |> Byte.toGigabits)
          "From gigabit to kilobyte and back", (fun x -> Gigabit.create x |> Gigabit.toKilobytes |> Kilobyte.toGigabits)
          "From gigabit to megabyte and back", (fun x -> Gigabit.create x |> Gigabit.toMegabytes |> Megabyte.toGigabits)
          "From gigabit to gigabyte and back", (fun x -> Gigabit.create x |> Gigabit.toGigabytes |> Gigabyte.toGigabits)
          "From gigabit to terabyte and back", (fun x -> Gigabit.create x |> Gigabit.toTerabytes |> Terabyte.toGigabits)
          "From gigabit to petabyte and back", (fun x -> Gigabit.create x |> Gigabit.toPetabytes |> Petabyte.toGigabits) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let terabitConversionTests =
        [ "From terabit to bit and back", (fun x -> Terabit.create x |> Terabit.toBits |> Bit.toTerabits)
          "From terabit to kilobit and back", (fun x -> Terabit.create x |> Terabit.toKilobits |> Kilobit.toTerabits)
          "From terabit to megabit and back", (fun x -> Terabit.create x |> Terabit.toMegabits |> Megabit.toTerabits)
          "From terabit to gigabit and back", (fun x -> Terabit.create x |> Terabit.toGigabits |> Gigabit.toTerabits)
          "From terabit to petabit and back", (fun x -> Terabit.create x |> Terabit.toPetabits |> Petabit.toTerabits)
          "From terabit to byte and back", (fun x -> Terabit.create x |> Terabit.toBytes |> Byte.toTerabits)
          "From terabit to kilobyte and back", (fun x -> Terabit.create x |> Terabit.toKilobytes |> Kilobyte.toTerabits)
          "From terabit to megabyte and back", (fun x -> Terabit.create x |> Terabit.toMegabytes |> Megabyte.toTerabits)
          "From terabit to gigabyte and back", (fun x -> Terabit.create x |> Terabit.toGigabytes |> Gigabyte.toTerabits)
          "From terabit to terabyte and back", (fun x -> Terabit.create x |> Terabit.toTerabytes |> Terabyte.toTerabits)
          "From terabit to petabyte and back", (fun x -> Terabit.create x |> Terabit.toPetabytes |> Petabyte.toTerabits) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let petabitConversionTests =
        [ "From petabit to bit and back", (fun x -> Petabit.create x |> Petabit.toBits |> Bit.toPetabits)
          "From petabit to kilobit and back", (fun x -> Petabit.create x |> Petabit.toKilobits |> Kilobit.toPetabits)
          "From petabit to megabit and back", (fun x -> Petabit.create x |> Petabit.toMegabits |> Megabit.toPetabits)
          "From petabit to gigabit and back", (fun x -> Petabit.create x |> Petabit.toGigabits |> Gigabit.toPetabits)
          "From petabit to terabit and back", (fun x -> Petabit.create x |> Petabit.toTerabits |> Terabit.toPetabits)
          "From petabit to byte and back", (fun x -> Petabit.create x |> Petabit.toBytes |> Byte.toPetabits)
          "From petabit to kilobyte and back", (fun x -> Petabit.create x |> Petabit.toKilobytes |> Kilobyte.toPetabits)
          "From petabit to megabyte and back", (fun x -> Petabit.create x |> Petabit.toMegabytes |> Megabyte.toPetabits)
          "From petabit to gigabyte and back", (fun x -> Petabit.create x |> Petabit.toGigabytes |> Gigabyte.toPetabits)
          "From petabit to terabyte and back", (fun x -> Petabit.create x |> Petabit.toTerabytes |> Terabyte.toPetabits)
          "From petabit to petabyte and back", (fun x -> Petabit.create x |> Petabit.toPetabytes |> Petabyte.toPetabits) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let byteConversionTests =
        [ "From byte to bit and back", (fun x -> Byte.create x |> Byte.toBits |> Bit.toBytes)
          "From byte to kilobit and back", (fun x -> Byte.create x |> Byte.toKilobits |> Kilobit.toBytes)
          "From byte to megabit and back", (fun x -> Byte.create x |> Byte.toMegabits |> Megabit.toBytes)
          "From byte to gigabit and back", (fun x -> Byte.create x |> Byte.toGigabits |> Gigabit.toBytes)
          "From byte to terabit and back", (fun x -> Byte.create x |> Byte.toTerabits |> Terabit.toBytes)
          "From byte to petabit and back", (fun x -> Byte.create x |> Byte.toPetabits |> Petabit.toBytes)
          "From byte to kilobyte and back", (fun x -> Byte.create x |> Byte.toKilobytes |> Kilobyte.toBytes)
          "From byte to megabyte and back", (fun x -> Byte.create x |> Byte.toMegabytes |> Megabyte.toBytes)
          "From byte to gigabyte and back", (fun x -> Byte.create x |> Byte.toGigabytes |> Gigabyte.toBytes)
          "From byte to terabyte and back", (fun x -> Byte.create x |> Byte.toTerabytes |> Terabyte.toBytes)
          "From byte to petabyte and back", (fun x -> Byte.create x |> Byte.toPetabytes |> Petabyte.toBytes) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let kilobyteConversionTests =
        [ "From kilobyte to bit and back", (fun x -> Kilobyte.create x |> Kilobyte.toBits |> Bit.toKilobytes)
          "From kilobyte to kilobit and back",
          (fun x -> Kilobyte.create x |> Kilobyte.toKilobits |> Kilobit.toKilobytes)
          "From kilobyte to megabit and back",
          (fun x -> Kilobyte.create x |> Kilobyte.toMegabits |> Megabit.toKilobytes)
          "From kilobyte to gigabit and back",
          (fun x -> Kilobyte.create x |> Kilobyte.toGigabits |> Gigabit.toKilobytes)
          "From kilobyte to terabit and back",
          (fun x -> Kilobyte.create x |> Kilobyte.toTerabits |> Terabit.toKilobytes)
          "From kilobyte to petabit and back",
          (fun x -> Kilobyte.create x |> Kilobyte.toPetabits |> Petabit.toKilobytes)
          "From kilobyte to byte and back", (fun x -> Kilobyte.create x |> Kilobyte.toBytes |> Byte.toKilobytes)
          "From kilobyte to megabyte and back",
          (fun x -> Kilobyte.create x |> Kilobyte.toMegabytes |> Megabyte.toKilobytes)
          "From kilobyte to gigabyte and back",
          (fun x -> Kilobyte.create x |> Kilobyte.toGigabytes |> Gigabyte.toKilobytes)
          "From kilobyte to terabyte and back",
          (fun x -> Kilobyte.create x |> Kilobyte.toTerabytes |> Terabyte.toKilobytes)
          "From kilobyte to petabyte and back",
          (fun x -> Kilobyte.create x |> Kilobyte.toPetabytes |> Petabyte.toKilobytes) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let megabyteConversionTests =
        [ "From megabyte to bit and back", (fun x -> Megabyte.create x |> Megabyte.toBits |> Bit.toMegabytes)
          "From megabyte to kilobit and back",
          (fun x -> Megabyte.create x |> Megabyte.toKilobits |> Kilobit.toMegabytes)
          "From megabyte to megabit and back",
          (fun x -> Megabyte.create x |> Megabyte.toMegabits |> Megabit.toMegabytes)
          "From megabyte to gigabit and back",
          (fun x -> Megabyte.create x |> Megabyte.toGigabits |> Gigabit.toMegabytes)
          "From megabyte to terabit and back",
          (fun x -> Megabyte.create x |> Megabyte.toTerabits |> Terabit.toMegabytes)
          "From megabyte to petabit and back",
          (fun x -> Megabyte.create x |> Megabyte.toPetabits |> Petabit.toMegabytes)
          "From megabyte to byte and back", (fun x -> Megabyte.create x |> Megabyte.toBytes |> Byte.toMegabytes)
          "From megabyte to kilobyte and back",
          (fun x -> Megabyte.create x |> Megabyte.toKilobytes |> Kilobyte.toMegabytes)
          "From megabyte to gigabyte and back",
          (fun x -> Megabyte.create x |> Megabyte.toGigabytes |> Gigabyte.toMegabytes)
          "From megabyte to terabyte and back",
          (fun x -> Megabyte.create x |> Megabyte.toTerabytes |> Terabyte.toMegabytes)
          "From megabyte to petabyte and back",
          (fun x -> Megabyte.create x |> Megabyte.toPetabytes |> Petabyte.toMegabytes) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let gigabyteConversionTests =
        [ "From gigabyte to bit and back", (fun x -> Gigabyte.create x |> Gigabyte.toBits |> Bit.toGigabytes)
          "From gigabyte to kilobit and back",
          (fun x -> Gigabyte.create x |> Gigabyte.toKilobits |> Kilobit.toGigabytes)
          "From gigabyte to megabit and back",
          (fun x -> Gigabyte.create x |> Gigabyte.toMegabits |> Megabit.toGigabytes)
          "From gigabyte to gigabit and back",
          (fun x -> Gigabyte.create x |> Gigabyte.toGigabits |> Gigabit.toGigabytes)
          "From gigabyte to terabit and back",
          (fun x -> Gigabyte.create x |> Gigabyte.toTerabits |> Terabit.toGigabytes)
          "From gigabyte to petabit and back",
          (fun x -> Gigabyte.create x |> Gigabyte.toPetabits |> Petabit.toGigabytes)
          "From gigabyte to byte and back", (fun x -> Gigabyte.create x |> Gigabyte.toBytes |> Byte.toGigabytes)
          "From gigabyte to kilobyte and back",
          (fun x -> Gigabyte.create x |> Gigabyte.toKilobytes |> Kilobyte.toGigabytes)
          "From gigabyte to megabyte and back",
          (fun x -> Gigabyte.create x |> Gigabyte.toMegabytes |> Megabyte.toGigabytes)
          "From gigabyte to terabyte and back",
          (fun x -> Gigabyte.create x |> Gigabyte.toTerabytes |> Terabyte.toGigabytes)
          "From gigabyte to petabyte and back",
          (fun x -> Gigabyte.create x |> Gigabyte.toPetabytes |> Petabyte.toGigabytes) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let terabyteConversionTests =
        [ "From terabyte to bit and back", (fun x -> Terabyte.create x |> Terabyte.toBits |> Bit.toTerabytes)
          "From terabyte to kilobit and back",
          (fun x -> Terabyte.create x |> Terabyte.toKilobits |> Kilobit.toTerabytes)
          "From terabyte to megabit and back",
          (fun x -> Terabyte.create x |> Terabyte.toMegabits |> Megabit.toTerabytes)
          "From terabyte to gigabit and back",
          (fun x -> Terabyte.create x |> Terabyte.toGigabits |> Gigabit.toTerabytes)
          "From terabyte to terabit and back",
          (fun x -> Terabyte.create x |> Terabyte.toTerabits |> Terabit.toTerabytes)
          "From terabyte to petabit and back",
          (fun x -> Terabyte.create x |> Terabyte.toPetabits |> Petabit.toTerabytes)
          "From terabyte to byte and back", (fun x -> Terabyte.create x |> Terabyte.toBytes |> Byte.toTerabytes)
          "From terabyte to kilobyte and back",
          (fun x -> Terabyte.create x |> Terabyte.toKilobytes |> Kilobyte.toTerabytes)
          "From terabyte to megabyte and back",
          (fun x -> Terabyte.create x |> Terabyte.toMegabytes |> Megabyte.toTerabytes)
          "From terabyte to gigabyte and back",
          (fun x -> Terabyte.create x |> Terabyte.toGigabytes |> Gigabyte.toTerabytes)
          "From terabyte to petabyte and back",
          (fun x -> Terabyte.create x |> Terabyte.toPetabytes |> Petabyte.toTerabytes) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let petabyteConversionTests =
        [ "From petabyte to bit and back", (fun x -> Petabyte.create x |> Petabyte.toBits |> Bit.toPetabytes)
          "From petabyte to kilobit and back",
          (fun x -> Petabyte.create x |> Petabyte.toKilobits |> Kilobit.toPetabytes)
          "From petabyte to megabit and back",
          (fun x -> Petabyte.create x |> Petabyte.toMegabits |> Megabit.toPetabytes)
          "From petabyte to gigabit and back",
          (fun x -> Petabyte.create x |> Petabyte.toGigabits |> Gigabit.toPetabytes)
          "From petabyte to terabit and back",
          (fun x -> Petabyte.create x |> Petabyte.toTerabits |> Terabit.toPetabytes)
          "From petabyte to petabit and back",
          (fun x -> Petabyte.create x |> Petabyte.toPetabits |> Petabit.toPetabytes)
          "From petabyte to byte and back", (fun x -> Petabyte.create x |> Petabyte.toBytes |> Byte.toPetabytes)
          "From petabyte to kilobyte and back",
          (fun x -> Petabyte.create x |> Petabyte.toKilobytes |> Kilobyte.toPetabytes)
          "From petabyte to megabyte and back",
          (fun x -> Petabyte.create x |> Petabyte.toMegabytes |> Megabyte.toPetabytes)
          "From petabyte to gigabyte and back",
          (fun x -> Petabyte.create x |> Petabyte.toGigabytes |> Gigabyte.toPetabytes)
          "From petabyte to terabyte and back",
          (fun x -> Petabyte.create x |> Petabyte.toTerabytes |> Terabyte.toPetabytes) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    testList
        "Data storage tests -> "
        [ testList "Bit conversion tests -> " bitConversionTests
          testList "Kilobit conversion tests -> " kilobitConversionTests
          testList "Megabit conversion tests -> " megabitConversionTests
          testList "Gigabit conversion tests -> " gigabitConversionTests
          testList "Terabit conversion tests -> " terabitConversionTests
          testList "Petabit conversion tests -> " petabitConversionTests
          testList "Byte conversion tests -> " byteConversionTests
          testList "Kilobyte conversion tests -> " kilobyteConversionTests
          testList "Megabyte conversion tests -> " megabyteConversionTests
          testList "Gigabyte conversion tests -> " gigabyteConversionTests
          testList "Terabyte conversion tests -> " terabyteConversionTests
          testList "Petabyte conversion tests -> " petabyteConversionTests ]

[<Tests>]
let fuelEconomyTests config =

    let kilometerPerLiterConversionTests =
        [ "From km/l to mpg",
          (fun x ->
              KilometerPerLiter.create x
              |> KilometerPerLiter.toMilesPerGallon
              |> MilePerGallon.toKilometersPerLiter) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let milePerGallonConversionTests =
        [ "From mpg to km/l",
          (fun x ->
              MilePerGallon.create x
              |> MilePerGallon.toKilometersPerLiter
              |> KilometerPerLiter.toMilesPerGallon) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    testList
        "Fuel economy tests -> "
        [ testList "Kilometer per liter tests -> " kilometerPerLiterConversionTests
          testList "Mile per gallon tests -> " milePerGallonConversionTests ]

[<Tests>]
let frequencyTests config =

    let hertzConversionTest =
        [ "From hertz to kilohertz and back", (fun x -> Hertz.create x |> Hertz.toKilohertz |> Kilohertz.toHertz)
          "From hertz to megahertz and back", (fun x -> Hertz.create x |> Hertz.toMegahertz |> Megahertz.toHertz)
          "From hertz to gigahertz and back", (fun x -> Hertz.create x |> Hertz.toGigahertz |> Gigahertz.toHertz) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let kilohertzConversionTest =
        [ "From kilohertz to hertz and back", (fun x -> Kilohertz.create x |> Kilohertz.toHertz |> Hertz.toKilohertz)
          "From kilohertz to megahertz and back",
          (fun x -> Kilohertz.create x |> Kilohertz.toMegahertz |> Megahertz.toKilohertz)
          "From kilohertz to gigahertz and back",
          (fun x -> Kilohertz.create x |> Kilohertz.toGigahertz |> Gigahertz.toKilohertz) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let megahertzConversionTest =
        [ "From megahertz to hertz and back", (fun x -> Megahertz.create x |> Megahertz.toHertz |> Hertz.toMegahertz)
          "From megahertz to kilohertz and back",
          (fun x -> Megahertz.create x |> Megahertz.toKilohertz |> Kilohertz.toMegahertz)
          "From megahertz to gigahertz and back",
          (fun x -> Megahertz.create x |> Megahertz.toGigahertz |> Gigahertz.toMegahertz) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let gigahertzConversionTest =
        [ "From gigahertz to hertz and back", (fun x -> Gigahertz.create x |> Gigahertz.toHertz |> Hertz.toGigahertz)
          "From gigahertz to kilohertz and back",
          (fun x -> Gigahertz.create x |> Gigahertz.toKilohertz |> Kilohertz.toGigahertz)
          "From gigahertz to megahertz and back",
          (fun x -> Gigahertz.create x |> Gigahertz.toMegahertz |> Megahertz.toGigahertz) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    testList
        "Frequency tests -> "
        [ testList "Hertz conversion tests -> " hertzConversionTest
          testList "Kilohertz conversion tests -> " kilohertzConversionTest
          testList "Megahertz conversion tests -> " megahertzConversionTest
          testList "Gigahertz conversion tests -> " gigahertzConversionTest ]

[<Tests>]
let illuminanceTests config =

    let footcandleConversionTests =
        [ "From footcandle to lux and back", (fun x -> Footcandle.create x |> Footcandle.toLux |> Lux.toFootcandle)
          "From footcandle to phot and back", (fun x -> Footcandle.create x |> Footcandle.toPhot |> Phot.toFootcandle)
          "From footcandle to nox and back", (fun x -> Footcandle.create x |> Footcandle.toNox |> Nox.toFootcandle) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let luxConversionTests =
        [ "From lux to footcandle and back", (fun x -> Lux.create x |> Lux.toFootcandle |> Footcandle.toLux)
          "From lux to phot and back", (fun x -> Lux.create x |> Lux.toPhot |> Phot.toLux)
          "From lux to nox and back", (fun x -> Lux.create x |> Lux.toNox |> Nox.toLux) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let photConversionTests =
        [ "From phot to footcandle and back", (fun x -> Phot.create x |> Phot.toFootcandle |> Footcandle.toPhot)
          "From phot to lux and back", (fun x -> Phot.create x |> Phot.toLux |> Lux.toPhot)
          "From phot to nox and back", (fun x -> Phot.create x |> Phot.toNox |> Nox.toPhot) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let noxConversionTests =
        [ "From nox to footcandle and back", (fun x -> Nox.create x |> Nox.toFootcandle |> Footcandle.toNox)
          "From nox to lux and back", (fun x -> Nox.create x |> Nox.toLux |> Lux.toNox)
          "From nox to phot and back", (fun x -> Nox.create x |> Nox.toPhot |> Phot.toNox) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    testList
        "Illuminance tests -> "
        [ testList "Footcandle conversion tests -> " footcandleConversionTests
          testList "Lux conversion tests -> " luxConversionTests
          testList "Phot conversion tests -> " photConversionTests
          testList "Nox conversion tests -> " noxConversionTests ]

[<Tests>]
let currentTests config =

    let ampereConversionTests =
        [ "From ampere to milliampere and back",
          (fun x -> Ampere.create x |> Ampere.toMilliamperes |> Milliampere.toAmperes)
          "From ampere to microampere and back",
          (fun x -> Ampere.create x |> Ampere.toMicroamperes |> Microampere.toAmperes)
          "From ampere to biot and back", (fun x -> Ampere.create x |> Ampere.toBiots |> Biot.toAmperes) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let milliampereConversionTests =
        [ "From milliampere to ampere and back",
          (fun x -> Milliampere.create x |> Milliampere.toAmperes |> Ampere.toMilliamperes)
          "From milliampere to microampere and back",
          (fun x -> Milliampere.create x |> Milliampere.toMicroamperes |> Microampere.toMilliamperes)
          "From milliampere to biot and back",
          (fun x -> Milliampere.create x |> Milliampere.toBiots |> Biot.toMilliamperes) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let microampereConversionTests =
        [ "From microampere to ampere and back",
          (fun x -> Microampere.create x |> Microampere.toAmperes |> Ampere.toMicroamperes)
          "From microampere to milliampere and back",
          (fun x -> Microampere.create x |> Microampere.toMilliamperes |> Milliampere.toMicroamperes)
          "From microampere to biot and back",
          (fun x -> Microampere.create x |> Microampere.toBiots |> Biot.toMicroamperes) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    let biotConversionTests =
        [ "From biot to ampere and back", (fun x -> Biot.create x |> Biot.toAmperes |> Ampere.toBiots)
          "From biot to milliampere and back", (fun x -> Biot.create x |> Biot.toMilliamperes |> Milliampere.toBiots)
          "From biot to microampere and back", (fun x -> Biot.create x |> Biot.toMicroamperes |> Microampere.toBiots) ]
        |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

    testList
        "Current tests -> "
        [ testList "Ampere conversion tests -> " ampereConversionTests
          testList "Milliampere conversion tests -> " milliampereConversionTests
          testList "Microampere conversion tests -> " microampereConversionTests
          testList "Biot conversion tests -> " biotConversionTests ]
