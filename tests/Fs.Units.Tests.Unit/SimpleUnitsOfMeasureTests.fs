module SimpleUnitOfMeasureTests

open Expecto
open Fs.Units
open Helpers

let lengthTests config =
  let inchConversionTests =
    [
      "To feet and back", (fun x -> x |> Inch.toFeet |> Foot.toInches)
      "To yard and back", (fun x -> x |> Inch.toYards |> Yard.toInches)
      "To mile and back", (fun x -> x |> Inch.toMiles |> Mile.toInches)
      "To millimeter and back", (fun x -> x |> Inch.toMillimeters |> Millimeter.toInches)
      "To centimeter and back", (fun x -> x |> Inch.toCentimeters |> Centimeter.toInches)
      "To decimeter and back", (fun x -> x |> Inch.toDecimeters |> Decimeter.toInches)
      "To meter and back", (fun x -> x |> Inch.toMeters |> Meter.toInches)
      "To kilometer and back", (fun x -> x |> Inch.toKilometers |> Kilometer.toInches)
      "To nautical mile and back", (fun x -> x |> Inch.toNauticalMiles |> NauticalMile.toInches)
      "To chain and back", (fun x -> x |> Inch.toChains |> Chain.toInches)
      "To furlong and back", (fun x -> x |> Inch.toFurlongs |> Furlong.toInches)
      "To league and back", (fun x -> x |> Inch.toLeagues |> League.toInches)
      "To hand and back", (fun x -> x |> Inch.toHands |> Hand.toInches)
      "To rod and back", (fun x -> x |> Inch.toRods |> Rod.toInches)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Inch.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let footConversionTests =
    [
      "To inches and back", (fun x -> x |> Foot.toInches |> Inch.toFeet)
      "To yard and back", (fun x -> x |> Foot.toYards |> Yard.toFeet)
      "To mile and back", (fun x -> x |> Foot.toMiles |> Mile.toFeet)
      "To millimeter and back", (fun x -> x |> Foot.toMillimeters |> Millimeter.toFeet)
      "To centimeter and back", (fun x -> x |> Foot.toCentimeters |> Centimeter.toFeet)
      "To decimeter and back", (fun x -> x |> Foot.toDecimeters |> Decimeter.toFeet)
      "To meter and back", (fun x -> x |> Foot.toMeters |> Meter.toFeet)
      "To kilometer and back", (fun x -> x |> Foot.toKilometers |> Kilometer.toFeet)
      "To nautical mile and back", (fun x -> x |> Foot.toNauticalMiles |> NauticalMile.toFeet)
      "To chain and back", (fun x -> x |> Foot.toChains |> Chain.toFeet)
      "To furlong and back", (fun x -> x |> Foot.toFurlongs |> Furlong.toFeet)
      "To league and back", (fun x -> x |> Foot.toLeagues |> League.toFeet)
      "To hand and back", (fun x -> x |> Foot.toHands |> Hand.toFeet)
      "To rod and back", (fun x -> x |> Foot.toRods |> Rod.toFeet)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Foot.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let yardConversionTests =
    [
      "To inches and back", (fun x -> x |> Yard.toInches |> Inch.toYards)
      "To foot and back", (fun x -> x |> Yard.toFeet |> Foot.toYards)
      "To mile and back", (fun x -> x |> Yard.toMiles |> Mile.toYards)
      "To millimeter and back", (fun x -> x |> Yard.toMillimeters |> Millimeter.toYards)
      "To centimeter and back", (fun x -> x |> Yard.toCentimeters |> Centimeter.toYards)
      "To decimeter and back", (fun x -> x |> Yard.toDecimeters |> Decimeter.toYards)
      "To meter and back", (fun x -> x |> Yard.toMeters |> Meter.toYards)
      "To kilometer and back", (fun x -> x |> Yard.toKilometers |> Kilometer.toYards)
      "To nautical mile and back", (fun x -> x |> Yard.toNauticalMiles |> NauticalMile.toYards)
      "To chain and back", (fun x -> x |> Yard.toChains |> Chain.toYards)
      "To furlong and back", (fun x -> x |> Yard.toFurlongs |> Furlong.toYards)
      "To league and back", (fun x -> x |> Yard.toLeagues |> League.toYards)
      "To hand and back", (fun x -> x |> Yard.toHands |> Hand.toYards)
      "To rod and back", (fun x -> x |> Yard.toRods |> Rod.toYards)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Yard.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let mileConversionTests =
    [
      "To inches and back", (fun x -> x |> Mile.toInches |> Inch.toMiles)
      "To foot and back", (fun x -> x |> Mile.toFeet |> Foot.toMiles)
      "To yard and back", (fun x -> x |> Mile.toYards |> Yard.toMiles)
      "To millimeter and back", (fun x -> x |> Mile.toMillimeters |> Millimeter.toMiles)
      "To centimeter and back", (fun x -> x |> Mile.toCentimeters |> Centimeter.toMiles)
      "To decimeter and back", (fun x -> x |> Mile.toDecimeters |> Decimeter.toMiles)
      "To meter and back", (fun x -> x |> Mile.toMeters |> Meter.toMiles)
      "To kilometer and back", (fun x -> x |> Mile.toKilometers |> Kilometer.toMiles)
      "To nautical mile and back", (fun x -> x |> Mile.toNauticalMiles |> NauticalMile.toMiles)
      "To chain and back", (fun x -> x |> Mile.toChains |> Chain.toMiles)
      "To furlong and back", (fun x -> x |> Mile.toFurlongs |> Furlong.toMiles)
      "To league and back", (fun x -> x |> Mile.toLeagues |> League.toMiles)
      "To hand and back", (fun x -> x |> Mile.toHands |> Hand.toMiles)
      "To rod and back", (fun x -> x |> Mile.toRods |> Rod.toMiles)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Mile.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let millimeterConversionTests =
    [
      "To inch and back", (fun x -> x |> Millimeter.toInches |> Inch.toMillimeters)
      "To foot and back", (fun x -> x |> Millimeter.toFeet |> Foot.toMillimeters)
      "To yard and back", (fun x -> x |> Millimeter.toYards |> Yard.toMillimeters)
      "To mile and back", (fun x -> x |> Millimeter.toMiles |> Mile.toMillimeters)
      "To centimeter and back", (fun x -> x |> Millimeter.toCentimeters |> Centimeter.toMillimeters)
      "To decimeter and back", (fun x -> x |> Millimeter.toDecimeters |> Decimeter.toMillimeters)
      "To meter and back", (fun x -> x |> Millimeter.toMeters |> Meter.toMillimeters)
      "To kilometer and back", (fun x -> x |> Millimeter.toKilometers |> Kilometer.toMillimeters)
      "To nautical mile and back", (fun x -> x |> Millimeter.toNauticalMiles |> NauticalMile.toMillimeters)
      "To chain and back", (fun x -> x |> Millimeter.toChains |> Chain.toMillimeters)
      "To furlong and back", (fun x -> x |> Millimeter.toFurlongs |> Furlong.toMillimeters)
      "To league and back", (fun x -> x |> Millimeter.toLeagues |> League.toMillimeters)
      "To hand and back", (fun x -> x |> Millimeter.toHands |> Hand.toMillimeters)
      "To rod and back", (fun x -> x |> Millimeter.toRods |> Rod.toMillimeters)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Millimeter.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let centimeterConversionTests =
    [
      "To inch and back", (fun x -> x |> Centimeter.toInches |> Inch.toCentimeters)
      "To foot and back", (fun x -> x |> Centimeter.toFeet |> Foot.toCentimeters)
      "To yard and back", (fun x -> x |> Centimeter.toYards |> Yard.toCentimeters)
      "To mile and back", (fun x -> x |> Centimeter.toMiles |> Mile.toCentimeters)
      "To millimeter and back", (fun x -> x |> Centimeter.toMillimeters |> Millimeter.toCentimeters)
      "To decimeter and back", (fun x -> x |> Centimeter.toDecimeters |> Decimeter.toCentimeters)
      "To meter and back", (fun x -> x |> Centimeter.toMeters |> Meter.toCentimeters)
      "To kilometer and back", (fun x -> x |> Centimeter.toKilometers |> Kilometer.toCentimeters)
      "To nautical mile and back", (fun x -> x |> Centimeter.toNauticalMiles |> NauticalMile.toCentimeters)
      "To chain and back", (fun x -> x |> Centimeter.toChains |> Chain.toCentimeters)
      "To furlong and back", (fun x -> x |> Centimeter.toFurlongs |> Furlong.toCentimeters)
      "To league and back", (fun x -> x |> Centimeter.toLeagues |> League.toCentimeters)
      "To hand and back", (fun x -> x |> Centimeter.toHands |> Hand.toCentimeters)
      "To rod and back", (fun x -> x |> Centimeter.toRods |> Rod.toCentimeters)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Centimeter.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let decimeterConversionTests =
    [
      "To inches and back", (fun x -> x |> Decimeter.toInches |> Inch.toDecimeters)
      "To foot and back", (fun x -> x |> Decimeter.toFeet |> Foot.toDecimeters)
      "To yard and back", (fun x -> x |> Decimeter.toYards |> Yard.toDecimeters)
      "To mile and back", (fun x -> x |> Decimeter.toMiles |> Mile.toDecimeters)
      "To millimeter and back", (fun x -> x |> Decimeter.toMillimeters |> Millimeter.toDecimeters)
      "To centimeter and back", (fun x -> x |> Decimeter.toCentimeters |> Centimeter.toDecimeters)
      "To meter and back", (fun x -> x |> Decimeter.toMeters |> Meter.toDecimeters)
      "To kilometer and back", (fun x -> x |> Decimeter.toKilometers |> Kilometer.toDecimeters)
      "To nautical mile and back", (fun x -> x |> Decimeter.toNauticalMiles |> NauticalMile.toDecimeters)
      "To chain and back", (fun x -> x |> Decimeter.toChains |> Chain.toDecimeters)
      "To furlong and back", (fun x -> x |> Decimeter.toFurlongs |> Furlong.toDecimeters)
      "To league and back", (fun x -> x |> Decimeter.toLeagues |> League.toDecimeters)
      "To hand and back", (fun x -> x |> Decimeter.toHands |> Hand.toDecimeters)
      "To rod and back", (fun x -> x |> Decimeter.toRods |> Rod.toDecimeters)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Decimeter.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let meterConversionTests =
    [
      "To inches and back", (fun x -> x |> Meter.toInches |> Inch.toMeters)
      "To foot and back", (fun x -> x |> Meter.toFeet |> Foot.toMeters)
      "To yard and back", (fun x -> x |> Meter.toYards |> Yard.toMeters)
      "To mile and back", (fun x -> x |> Meter.toMiles |> Mile.toMeters)
      "To millimeter and back", (fun x -> x |> Meter.toMillimeters |> Millimeter.toMeters)
      "To centimeter and back", (fun x -> x |> Meter.toCentimeters |> Centimeter.toMeters)
      "To kilometer and back", (fun x -> x |> Meter.toKilometers |> Kilometer.toMeters)
      "To nautical mile and back", (fun x -> x |> Meter.toNauticalMiles |> NauticalMile.toMeters)
      "To chain and back", (fun x -> x |> Meter.toChains |> Chain.toMeters)
      "To furlong and back", (fun x -> x |> Meter.toFurlongs |> Furlong.toMeters)
      "To league and back", (fun x -> x |> Meter.toLeagues |> League.toMeters)
      "To hand and back", (fun x -> x |> Meter.toHands |> Hand.toMeters)
      "To rod and back", (fun x -> x |> Meter.toRods |> Rod.toMeters)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Meter.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let kilometerConversionTests =
    [
      "To inches and back", (fun x -> x |> Kilometer.toInches |> Inch.toKilometers)
      "To foot and back", (fun x -> x |> Kilometer.toFeet |> Foot.toKilometers)
      "To yard and back", (fun x -> x |> Kilometer.toYards |> Yard.toKilometers)
      "To mile and back", (fun x -> x |> Kilometer.toMiles |> Mile.toKilometers)
      "To millimeter and back", (fun x -> x |> Kilometer.toMillimeters |> Millimeter.toKilometers)
      "To centimeter and back", (fun x -> x |> Kilometer.toCentimeters |> Centimeter.toKilometers)
      "To meter and back", (fun x -> x |> Kilometer.toMeters |> Meter.toKilometers)
      "To nautical mile and back", (fun x -> x |> Kilometer.toNauticalMiles |> NauticalMile.toKilometers)
      "To chain and back", (fun x -> x |> Kilometer.toChains |> Chain.toKilometers)
      "To furlong and back", (fun x -> x |> Kilometer.toFurlongs |> Furlong.toKilometers)
      "To league and back", (fun x -> x |> Kilometer.toLeagues |> League.toKilometers)
      "To hand and back", (fun x -> x |> Kilometer.toHands |> Hand.toKilometers)
      "To rod and back", (fun x -> x |> Kilometer.toRods |> Rod.toKilometers)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Kilometer.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let nauticalMileConversionTests =
    [
      "From nautical mile to inches and back", (fun x -> x |> NauticalMile.toInches |> Inch.toNauticalMiles)
      "From nautical mile to foot and back", (fun x -> x |> NauticalMile.toFeet |> Foot.toNauticalMiles)
      "From nautical mile to yard and back", (fun x -> x |> NauticalMile.toYards |> Yard.toNauticalMiles)
      "From nautical mile to mile and back", (fun x -> x |> NauticalMile.toMiles |> Mile.toNauticalMiles)
      "From nautical mile to millimeter and back",
      (fun x -> x |> NauticalMile.toMillimeters |> Millimeter.toNauticalMiles)
      "From nautical mile to centimeter and back",
      (fun x -> x |> NauticalMile.toCentimeters |> Centimeter.toNauticalMiles)
      "From nautical mile to meter and back", (fun x -> x |> NauticalMile.toMeters |> Meter.toNauticalMiles)
      "From nautical mile to kilometer and back", (fun x -> x |> NauticalMile.toKilometers |> Kilometer.toNauticalMiles)
      "From nautical mile to chain and back", (fun x -> x |> NauticalMile.toChains |> Chain.toNauticalMiles)
      "From nautical mile to furlong and back", (fun x -> x |> NauticalMile.toFurlongs |> Furlong.toNauticalMiles)
      "From nautical mile to league and back", (fun x -> x |> NauticalMile.toLeagues |> League.toNauticalMiles)
      "From nautical mile to hand and back", (fun x -> x |> NauticalMile.toHands |> Hand.toNauticalMiles)
      "From nautical mile to rod and back", (fun x -> x |> NauticalMile.toRods |> Rod.toNauticalMiles)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> NauticalMile.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let chainConversionTests =
    [
      "To inches and back", (fun x -> x |> Chain.toInches |> Inch.toChains)
      "To foot and back", (fun x -> x |> Chain.toFeet |> Foot.toChains)
      "To yard and back", (fun x -> x |> Chain.toYards |> Yard.toChains)
      "To mile and back", (fun x -> x |> Chain.toMiles |> Mile.toChains)
      "To millimeter and back", (fun x -> x |> Chain.toMillimeters |> Millimeter.toChains)
      "To centimeter and back", (fun x -> x |> Chain.toCentimeters |> Centimeter.toChains)
      "To meter and back", (fun x -> x |> Chain.toMeters |> Meter.toChains)
      "To kilometer and back", (fun x -> x |> Chain.toKilometers |> Kilometer.toChains)
      "To nautical mile and back", (fun x -> x |> Chain.toNauticalMiles |> NauticalMile.toChains)
      "To furlong and back", (fun x -> x |> Chain.toFurlongs |> Furlong.toChains)
      "To league and back", (fun x -> x |> Chain.toLeagues |> League.toChains)
      "To hand and back", (fun x -> x |> Chain.toHands |> Hand.toChains)
      "To rod and back", (fun x -> x |> Chain.toRods |> Rod.toChains)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Chain.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let furlongConversionTests =
    [
      "To inches and back", (fun x -> x |> Furlong.toInches |> Inch.toFurlongs)
      "To foot and back", (fun x -> x |> Furlong.toFeet |> Foot.toFurlongs)
      "To yard and back", (fun x -> x |> Furlong.toYards |> Yard.toFurlongs)
      "To mile and back", (fun x -> x |> Furlong.toMiles |> Mile.toFurlongs)
      "To millimeter and back", (fun x -> x |> Furlong.toMillimeters |> Millimeter.toFurlongs)
      "To centimeter and back", (fun x -> x |> Furlong.toCentimeters |> Centimeter.toFurlongs)
      "To meter and back", (fun x -> x |> Furlong.toMeters |> Meter.toFurlongs)
      "To kilometer and back", (fun x -> x |> Furlong.toKilometers |> Kilometer.toFurlongs)
      "To nautical mile and back", (fun x -> x |> Furlong.toNauticalMiles |> NauticalMile.toFurlongs)
      "To chain and back", (fun x -> x |> Furlong.toChains |> Chain.toFurlongs)
      "To league and back", (fun x -> x |> Furlong.toLeagues |> League.toFurlongs)
      "To hand and back", (fun x -> x |> Furlong.toHands |> Hand.toFurlongs)
      "To rod and back", (fun x -> x |> Furlong.toRods |> Rod.toFurlongs)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Furlong.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let leagueConversionTests =
    [
      "To inches and back", (fun x -> x |> League.toInches |> Inch.toLeagues)
      "To foot and back", (fun x -> x |> League.toFeet |> Foot.toLeagues)
      "To yard and back", (fun x -> x |> League.toYards |> Yard.toLeagues)
      "To mile and back", (fun x -> x |> League.toMiles |> Mile.toLeagues)
      "To millimeter and back", (fun x -> x |> League.toMillimeters |> Millimeter.toLeagues)
      "To centimeter and back", (fun x -> x |> League.toCentimeters |> Centimeter.toLeagues)
      "To meter and back", (fun x -> x |> League.toMeters |> Meter.toLeagues)
      "To kilometer and back", (fun x -> x |> League.toKilometers |> Kilometer.toLeagues)
      "To nautical mile and back", (fun x -> x |> League.toNauticalMiles |> NauticalMile.toLeagues)
      "To chain and back", (fun x -> x |> League.toChains |> Chain.toLeagues)
      "To furlong and back", (fun x -> x |> League.toFurlongs |> Furlong.toLeagues)
      "To hand and back", (fun x -> x |> League.toHands |> Hand.toLeagues)
      "To rod and back", (fun x -> x |> League.toRods |> Rod.toLeagues)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> League.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let handConversionTests =
    [
      "To inches and back", (fun x -> x |> Hand.toInches |> Inch.toHands)
      "To foot and back", (fun x -> x |> Hand.toFeet |> Foot.toHands)
      "To yard and back", (fun x -> x |> Hand.toYards |> Yard.toHands)
      "To mile and back", (fun x -> x |> Hand.toMiles |> Mile.toHands)
      "To millimeter and back", (fun x -> x |> Hand.toMillimeters |> Millimeter.toHands)
      "To centimeter and back", (fun x -> x |> Hand.toCentimeters |> Centimeter.toHands)
      "To meter and back", (fun x -> x |> Hand.toMeters |> Meter.toHands)
      "To kilometer and back", (fun x -> x |> Hand.toKilometers |> Kilometer.toHands)
      "To nautical mile and back", (fun x -> x |> Hand.toNauticalMiles |> NauticalMile.toHands)
      "To chain and back", (fun x -> x |> Hand.toChains |> Chain.toHands)
      "To furlong and back", (fun x -> x |> Hand.toFurlongs |> Furlong.toHands)
      "To league and back", (fun x -> x |> Hand.toLeagues |> League.toHands)
      "To rod and back", (fun x -> x |> Hand.toRods |> Rod.toHands)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Hand.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let rodConversionTests =
    [
      "To inches and back", (fun x -> x |> Rod.toInches |> Inch.toRods)
      "To foot and back", (fun x -> x |> Rod.toFeet |> Foot.toRods)
      "To yard and back", (fun x -> x |> Rod.toYards |> Yard.toRods)
      "To mile and back", (fun x -> x |> Rod.toMiles |> Mile.toRods)
      "To millimeter and back", (fun x -> x |> Rod.toMillimeters |> Millimeter.toRods)
      "To centimeter and back", (fun x -> x |> Rod.toCentimeters |> Centimeter.toRods)
      "To meter and back", (fun x -> x |> Rod.toMeters |> Meter.toRods)
      "To kilometer and back", (fun x -> x |> Rod.toKilometers |> Kilometer.toRods)
      "To nautical mile and back", (fun x -> x |> Rod.toNauticalMiles |> NauticalMile.toRods)
      "To chain and back", (fun x -> x |> Rod.toChains |> Chain.toRods)
      "To furlong and back", (fun x -> x |> Rod.toFurlongs |> Furlong.toRods)
      "To league and back", (fun x -> x |> Rod.toLeagues |> League.toRods)
      "To hand and back", (fun x -> x |> Rod.toHands |> Hand.toRods)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Rod.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  testList
    "Length Tests"
    [
      testList "Convert inch to other and back" inchConversionTests
      testList "Convert foot to other and back" footConversionTests
      testList "Convert yard to other and back" yardConversionTests
      testList "Convert mile to other and back" mileConversionTests
      testList "Convert millimeter to other and back" millimeterConversionTests
      testList "Convert centimeter to other and back" centimeterConversionTests
      testList "Convert decimeter to other and back" decimeterConversionTests
      testList "Convert meter to other and back" meterConversionTests
      testList "Convert kilometer to other and back" kilometerConversionTests
      testList "Convert nautical mile to other and back" nauticalMileConversionTests
      testList "Convert chain to other and back" chainConversionTests
      testList "Convert furlong to other and back" furlongConversionTests
      testList "Convert league to other and back" leagueConversionTests
      testList "Convert hand to other and back" handConversionTests
      testList "Convert rod to other and back" rodConversionTests
    ]

let timeTests config =

  let nanoSecondConversionTests =
    [
      "To microsecond and back", (fun x -> x |> Nanosecond.toMicroSeconds |> Microsecond.toNanoSeconds)
      "To millisecond and back", (fun x -> x |> Nanosecond.toMilliSeconds |> Millisecond.toNanoSeconds)
      "To second and back", (fun x -> x |> Nanosecond.toSeconds |> Second.toNanoSeconds)
      "To minute and back", (fun x -> x |> Nanosecond.toMinutes |> Minute.toNanoSeconds)
      "To hour and back", (fun x -> x |> Nanosecond.toHours |> Hour.toNanoSeconds)
      "To day and back", (fun x -> x |> Nanosecond.toDays |> Day.toNanoSeconds)
      "To week and back", (fun x -> x |> Nanosecond.toWeeks |> Week.toNanoSeconds)
      "To fortnight and back", (fun x -> x |> Nanosecond.toFortnights |> Fortnight.toNanoSeconds)
      "To month and back", (fun x -> x |> Nanosecond.toMonths |> Month.toNanoSeconds)
      "To year and back", (fun x -> x |> Nanosecond.toYears |> Year.toNanoSeconds)
      "To decade and back", (fun x -> x |> Nanosecond.toDecades |> Decade.toNanoSeconds)
      "To century and back", (fun x -> x |> Nanosecond.toCenturies |> Century.toNanoSeconds)
      "To millennium and back", (fun x -> x |> Nanosecond.toMillennia |> Millennium.toNanoSeconds)
      "To eon and back", (fun x -> x |> Nanosecond.toEons |> Eon.toNanoSeconds)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Nanosecond.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let microSecondConversionTests =
    [
      "To nanosecond and back", (fun x -> x |> Microsecond.toNanoSeconds |> Nanosecond.toMicroSeconds)
      "To millisecond and back", (fun x -> x |> Microsecond.toMilliSeconds |> Millisecond.toMicroSeconds)
      "To second and back", (fun x -> x |> Microsecond.toSeconds |> Second.toMicroSeconds)
      "To minute and back", (fun x -> x |> Microsecond.toMinutes |> Minute.toMicroSeconds)
      "To hour and back", (fun x -> x |> Microsecond.toHours |> Hour.toMicroSeconds)
      "To day and back", (fun x -> x |> Microsecond.toDays |> Day.toMicroSeconds)
      "To week and back", (fun x -> x |> Microsecond.toWeeks |> Week.toMicroSeconds)
      "To fortnight and back", (fun x -> x |> Microsecond.toFortnights |> Fortnight.toMicroSeconds)
      "To month and back", (fun x -> x |> Microsecond.toMonths |> Month.toMicroSeconds)
      "To year and back", (fun x -> x |> Microsecond.toYears |> Year.toMicroSeconds)
      "To decade and back", (fun x -> x |> Microsecond.toDecades |> Decade.toMicroSeconds)
      "To century and back", (fun x -> x |> Microsecond.toCenturies |> Century.toMicroSeconds)
      "To millennium and back", (fun x -> x |> Microsecond.toMillennia |> Millennium.toMicroSeconds)
      "To eon and back", (fun x -> x |> Microsecond.toEons |> Eon.toMicroSeconds)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Microsecond.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let milliSecondConversionTests =
    [
      "To nanosecond and back", (fun x -> x |> Millisecond.toNanoSeconds |> Nanosecond.toMilliSeconds)
      "To microsecond and back", (fun x -> x |> Millisecond.toMicroSeconds |> Microsecond.toMilliSeconds)
      "To second and back", (fun x -> x |> Millisecond.toSeconds |> Second.toMilliSeconds)
      "To minute and back", (fun x -> x |> Millisecond.toMinutes |> Minute.toMilliSeconds)
      "To hour and back", (fun x -> x |> Millisecond.toHours |> Hour.toMilliSeconds)
      "To day and back", (fun x -> x |> Millisecond.toDays |> Day.toMilliSeconds)
      "To week and back", (fun x -> x |> Millisecond.toWeeks |> Week.toMilliSeconds)
      "To fortnight and back", (fun x -> x |> Millisecond.toFortnights |> Fortnight.toMilliSeconds)
      "To month and back", (fun x -> x |> Millisecond.toMonths |> Month.toMilliSeconds)
      "To year and back", (fun x -> x |> Millisecond.toYears |> Year.toMilliSeconds)
      "To decade and back", (fun x -> x |> Millisecond.toDecades |> Decade.toMilliSeconds)
      "To century and back", (fun x -> x |> Millisecond.toCenturies |> Century.toMilliSeconds)
      "To millennium and back", (fun x -> x |> Millisecond.toMillennia |> Millennium.toMilliSeconds)
      "To eon and back", (fun x -> x |> Millisecond.toEons |> Eon.toMilliSeconds)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Millisecond.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let secondConversionTests =
    [
      "To nanosecond and back", (fun x -> x |> Second.toNanoSeconds |> Nanosecond.toSeconds)
      "To microsecond and back", (fun x -> x |> Second.toMicroSeconds |> Microsecond.toSeconds)
      "To millisecond and back", (fun x -> x |> Second.toMilliSeconds |> Millisecond.toSeconds)
      "To minute and back", (fun x -> x |> Second.toMinutes |> Minute.toSeconds)
      "To hour and back", (fun x -> x |> Second.toHours |> Hour.toSeconds)
      "To day and back", (fun x -> x |> Second.toDays |> Day.toSeconds)
      "To week and back", (fun x -> x |> Second.toWeeks |> Week.toSeconds)
      "To fortnight and back", (fun x -> x |> Second.toFortnights |> Fortnight.toSeconds)
      "To month and back", (fun x -> x |> Second.toMonths |> Month.toSeconds)
      "To year and back", (fun x -> x |> Second.toYears |> Year.toSeconds)
      "To decade and back", (fun x -> x |> Second.toDecades |> Decade.toSeconds)
      "To century and back", (fun x -> x |> Second.toCenturies |> Century.toSeconds)
      "To millennium and back", (fun x -> x |> Second.toMillennia |> Millennium.toSeconds)
      "To eon and back", (fun x -> x |> Second.toEons |> Eon.toSeconds)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Second.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let minuteConversionTests =
    [
      "To nanosecond and back", (fun x -> x |> Minute.toNanoSeconds |> Nanosecond.toMinutes)
      "To microsecond and back", (fun x -> x |> Minute.toMicroSeconds |> Microsecond.toMinutes)
      "To millisecond and back", (fun x -> x |> Minute.toMilliSeconds |> Millisecond.toMinutes)
      "To second and back", (fun x -> x |> Minute.toSeconds |> Second.toMinutes)
      "To hour and back", (fun x -> x |> Minute.toHours |> Hour.toMinutes)
      "To day and back", (fun x -> x |> Minute.toDays |> Day.toMinutes)
      "To week and back", (fun x -> x |> Minute.toWeeks |> Week.toMinutes)
      "To fortnight and back", (fun x -> x |> Minute.toFortnights |> Fortnight.toMinutes)
      "To month and back", (fun x -> x |> Minute.toMonths |> Month.toMinutes)
      "To year and back", (fun x -> x |> Minute.toYears |> Year.toMinutes)
      "To decade and back", (fun x -> x |> Minute.toDecades |> Decade.toMinutes)
      "To century and back", (fun x -> x |> Minute.toCenturies |> Century.toMinutes)
      "To millennium and back", (fun x -> x |> Minute.toMillennia |> Millennium.toMinutes)
      "To eon and back", (fun x -> x |> Minute.toEons |> Eon.toMinutes)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Minute.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let hourConversionTests =
    [
      "To nanosecond and back", (fun x -> x |> Hour.toNanoSeconds |> Nanosecond.toHours)
      "To microsecond and back", (fun x -> x |> Hour.toMicroSeconds |> Microsecond.toHours)
      "To millisecond and back", (fun x -> x |> Hour.toMilliSeconds |> Millisecond.toHours)
      "To second and back", (fun x -> x |> Hour.toSeconds |> Second.toHours)
      "To minute and back", (fun x -> x |> Hour.toMinutes |> Minute.toHours)
      "To day and back", (fun x -> x |> Hour.toDays |> Day.toHours)
      "To week and back", (fun x -> x |> Hour.toWeeks |> Week.toHours)
      "To fortnight and back", (fun x -> x |> Hour.toFortnights |> Fortnight.toHours)
      "To month and back", (fun x -> x |> Hour.toMonths |> Month.toHours)
      "To year and back", (fun x -> x |> Hour.toYears |> Year.toHours)
      "To decade and back", (fun x -> x |> Hour.toDecades |> Decade.toHours)
      "To century and back", (fun x -> x |> Hour.toCenturies |> Century.toHours)
      "To millennium and back", (fun x -> x |> Hour.toMillennia |> Millennium.toHours)
      "To eon and back", (fun x -> x |> Hour.toEons |> Eon.toHours)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Hour.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let dayConversionTests =
    [
      "To nanosecond and back", (fun x -> x |> Day.toNanoSeconds |> Nanosecond.toDays)
      "To microsecond and back", (fun x -> x |> Day.toMicroSeconds |> Microsecond.toDays)
      "To millisecond and back", (fun x -> x |> Day.toMilliSeconds |> Millisecond.toDays)
      "To second and back", (fun x -> x |> Day.toSeconds |> Second.toDays)
      "To minute and back", (fun x -> x |> Day.toMinutes |> Minute.toDays)
      "To hour and back", (fun x -> x |> Day.toHours |> Hour.toDays)
      "To week and back", (fun x -> x |> Day.toWeeks |> Week.toDays)
      "To fortnight and back", (fun x -> x |> Day.toFortnights |> Fortnight.toDays)
      "To month and back", (fun x -> x |> Day.toMonths |> Month.toDays)
      "To year and back", (fun x -> x |> Day.toYears |> Year.toDays)
      "To decade and back", (fun x -> x |> Day.toDecades |> Decade.toDays)
      "To century and back", (fun x -> x |> Day.toCenturies |> Century.toDays)
      "To millennium and back", (fun x -> x |> Day.toMillennia |> Millennium.toDays)
      "To eon and back", (fun x -> x |> Day.toEons |> Eon.toDays)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Day.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let weekConversionTests =
    [
      "To nanosecond and back", (fun x -> x |> Week.toNanoSeconds |> Nanosecond.toWeeks)
      "To microsecond and back", (fun x -> x |> Week.toMicroSeconds |> Microsecond.toWeeks)
      "To millisecond and back", (fun x -> x |> Week.toMilliSeconds |> Millisecond.toWeeks)
      "To second and back", (fun x -> x |> Week.toSeconds |> Second.toWeeks)
      "To minute and back", (fun x -> x |> Week.toMinutes |> Minute.toWeeks)
      "To hour and back", (fun x -> x |> Week.toHours |> Hour.toWeeks)
      "To day and back", (fun x -> x |> Week.toDays |> Day.toWeeks)
      "To fortnight and back", (fun x -> x |> Week.toFortnights |> Fortnight.toWeeks)
      "To month and back", (fun x -> x |> Week.toMonths |> Month.toWeeks)
      "To year and back", (fun x -> x |> Week.toYears |> Year.toWeeks)
      "To decade and back", (fun x -> x |> Week.toDecades |> Decade.toWeeks)
      "To century and back", (fun x -> x |> Week.toCenturies |> Century.toWeeks)
      "To millennium and back", (fun x -> x |> Week.toMillennia |> Millennium.toWeeks)
      "To eon and back", (fun x -> x |> Week.toEons |> Eon.toWeeks)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Week.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let fortnightConversionTests =
    [
      "To nanosecond and back", (fun x -> x |> Fortnight.toNanoSeconds |> Nanosecond.toFortnights)
      "To microsecond and back", (fun x -> x |> Fortnight.toMicroSeconds |> Microsecond.toFortnights)
      "To millisecond and back", (fun x -> x |> Fortnight.toMilliSeconds |> Millisecond.toFortnights)
      "To second and back", (fun x -> x |> Fortnight.toSeconds |> Second.toFortnights)
      "To minute and back", (fun x -> x |> Fortnight.toMinutes |> Minute.toFortnights)
      "To hour and back", (fun x -> x |> Fortnight.toHours |> Hour.toFortnights)
      "To day and back", (fun x -> x |> Fortnight.toDays |> Day.toFortnights)
      "To week and back", (fun x -> x |> Fortnight.toWeeks |> Week.toFortnights)
      "To month and back", (fun x -> x |> Fortnight.toMonths |> Month.toFortnights)
      "To year and back", (fun x -> x |> Fortnight.toYears |> Year.toFortnights)
      "To decade and back", (fun x -> x |> Fortnight.toDecades |> Decade.toFortnights)
      "To century and back", (fun x -> x |> Fortnight.toCenturies |> Century.toFortnights)
      "To millennium and back", (fun x -> x |> Fortnight.toMillennia |> Millennium.toFortnights)
      "To eon and back", (fun x -> x |> Fortnight.toEons |> Eon.toFortnights)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Fortnight.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let monthConversionTests =
    [
      "To nanosecond and back", (fun x -> x |> Month.toNanoSeconds |> Nanosecond.toMonths)
      "To microsecond and back", (fun x -> x |> Month.toMicroSeconds |> Microsecond.toMonths)
      "To millisecond and back", (fun x -> x |> Month.toMilliSeconds |> Millisecond.toMonths)
      "To second and back", (fun x -> x |> Month.toSeconds |> Second.toMonths)
      "To minute and back", (fun x -> x |> Month.toMinutes |> Minute.toMonths)
      "To hour and back", (fun x -> x |> Month.toHours |> Hour.toMonths)
      "To day and back", (fun x -> x |> Month.toDays |> Day.toMonths)
      "To week and back", (fun x -> x |> Month.toWeeks |> Week.toMonths)
      "To fortnight and back", (fun x -> x |> Month.toFortnights |> Fortnight.toMonths)
      "To year and back", (fun x -> x |> Month.toYears |> Year.toMonths)
      "To decade and back", (fun x -> x |> Month.toDecades |> Decade.toMonths)
      "To century and back", (fun x -> x |> Month.toCenturies |> Century.toMonths)
      "To millennium and back", (fun x -> x |> Month.toMillennia |> Millennium.toMonths)
      "To eon and back", (fun x -> x |> Month.toEons |> Eon.toMonths)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Month.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let yearConversionTests =
    [
      "To nanosecond and back", (fun x -> x |> Year.toNanoSeconds |> Nanosecond.toYears)
      "To microsecond and back", (fun x -> x |> Year.toMicroSeconds |> Microsecond.toYears)
      "To millisecond and back", (fun x -> x |> Year.toMilliSeconds |> Millisecond.toYears)
      "To second and back", (fun x -> x |> Year.toSeconds |> Second.toYears)
      "To minute and back", (fun x -> x |> Year.toMinutes |> Minute.toYears)
      "To hour and back", (fun x -> x |> Year.toHours |> Hour.toYears)
      "To day and back", (fun x -> x |> Year.toDays |> Day.toYears)
      "To week and back", (fun x -> x |> Year.toWeeks |> Week.toYears)
      "To fortnight and back", (fun x -> x |> Year.toFortnights |> Fortnight.toYears)
      "To month and back", (fun x -> x |> Year.toMonths |> Month.toYears)
      "To decade and back", (fun x -> x |> Year.toDecades |> Decade.toYears)
      "To century and back", (fun x -> x |> Year.toCenturies |> Century.toYears)
      "To millennium and back", (fun x -> x |> Year.toMillennia |> Millennium.toYears)
      "To eon and back", (fun x -> x |> Year.toEons |> Eon.toYears)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Year.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let decadeConversionTests =
    [
      "To nanosecond and back", (fun x -> x |> Decade.toNanoSeconds |> Nanosecond.toDecades)
      "To microsecond and back", (fun x -> x |> Decade.toMicroSeconds |> Microsecond.toDecades)
      "To millisecond and back", (fun x -> x |> Decade.toMilliSeconds |> Millisecond.toDecades)
      "To second and back", (fun x -> x |> Decade.toSeconds |> Second.toDecades)
      "To minute and back", (fun x -> x |> Decade.toMinutes |> Minute.toDecades)
      "To hour and back", (fun x -> x |> Decade.toHours |> Hour.toDecades)
      "To day and back", (fun x -> x |> Decade.toDays |> Day.toDecades)
      "To week and back", (fun x -> x |> Decade.toWeeks |> Week.toDecades)
      "To fortnight and back", (fun x -> x |> Decade.toFortnights |> Fortnight.toDecades)
      "To month and back", (fun x -> x |> Decade.toMonths |> Month.toDecades)
      "To year and back", (fun x -> x |> Decade.toYears |> Year.toDecades)
      "To century and back", (fun x -> x |> Decade.toCenturies |> Century.toDecades)
      "To millennium and back", (fun x -> x |> Decade.toMillennia |> Millennium.toDecades)
      "To eon and back", (fun x -> x |> Decade.toEons |> Eon.toDecades)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Decade.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let centuryConversionTests =
    [
      "To nanosecond and back", (fun x -> x |> Century.toNanoSeconds |> Nanosecond.toCenturies)
      "To microsecond and back", (fun x -> x |> Century.toMicroSeconds |> Microsecond.toCenturies)
      "To millisecond and back", (fun x -> x |> Century.toMilliSeconds |> Millisecond.toCenturies)
      "To second and back", (fun x -> x |> Century.toSeconds |> Second.toCenturies)
      "To minute and back", (fun x -> x |> Century.toMinutes |> Minute.toCenturies)
      "To hour and back", (fun x -> x |> Century.toHours |> Hour.toCenturies)
      "To day and back", (fun x -> x |> Century.toDays |> Day.toCenturies)
      "To week and back", (fun x -> x |> Century.toWeeks |> Week.toCenturies)
      "To fortnight and back", (fun x -> x |> Century.toFortnights |> Fortnight.toCenturies)
      "To month and back", (fun x -> x |> Century.toMonths |> Month.toCenturies)
      "To year and back", (fun x -> x |> Century.toYears |> Year.toCenturies)
      "To decade and back", (fun x -> x |> Century.toDecades |> Decade.toCenturies)
      "To millennium and back", (fun x -> x |> Century.toMillennia |> Millennium.toCenturies)
      "To eon and back", (fun x -> x |> Century.toEons |> Eon.toCenturies)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Century.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let millenniumConversionTests =
    [
      "To nanosecond and back", (fun x -> x |> Millennium.toNanoSeconds |> Nanosecond.toMillennia)
      "To microsecond and back", (fun x -> x |> Millennium.toMicroSeconds |> Microsecond.toMillennia)
      "To millisecond and back", (fun x -> x |> Millennium.toMilliSeconds |> Millisecond.toMillennia)
      "To second and back", (fun x -> x |> Millennium.toSeconds |> Second.toMillennia)
      "To minute and back", (fun x -> x |> Millennium.toMinutes |> Minute.toMillennia)
      "To hour and back", (fun x -> x |> Millennium.toHours |> Hour.toMillennia)
      "To day and back", (fun x -> x |> Millennium.toDays |> Day.toMillennia)
      "To week and back", (fun x -> x |> Millennium.toWeeks |> Week.toMillennia)
      "To fortnight and back", (fun x -> x |> Millennium.toFortnights |> Fortnight.toMillennia)
      "To month and back", (fun x -> x |> Millennium.toMonths |> Month.toMillennia)
      "To year and back", (fun x -> x |> Millennium.toYears |> Year.toMillennia)
      "To decade and back", (fun x -> x |> Millennium.toDecades |> Decade.toMillennia)
      "To century and back", (fun x -> x |> Millennium.toCenturies |> Century.toMillennia)
      "To eon and back", (fun x -> x |> Millennium.toEons |> Eon.toMillennia)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Millennium.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let eonConversionTests =
    [
      "To nanosecond and back", (fun x -> x |> Eon.toNanoSeconds |> Nanosecond.toEons)
      "To microsecond and back", (fun x -> x |> Eon.toMicroSeconds |> Microsecond.toEons)
      "To millisecond and back", (fun x -> x |> Eon.toMilliSeconds |> Millisecond.toEons)
      "To second and back", (fun x -> x |> Eon.toSeconds |> Second.toEons)
      "To minute and back", (fun x -> x |> Eon.toMinutes |> Minute.toEons)
      "To hour and back", (fun x -> x |> Eon.toHours |> Hour.toEons)
      "To day and back", (fun x -> x |> Eon.toDays |> Day.toEons)
      "To week and back", (fun x -> x |> Eon.toWeeks |> Week.toEons)
      "To fortnight and back", (fun x -> x |> Eon.toFortnights |> Fortnight.toEons)
      "To month and back", (fun x -> x |> Eon.toMonths |> Month.toEons)
      "To year and back", (fun x -> x |> Eon.toYears |> Year.toEons)
      "To decade and back", (fun x -> x |> Eon.toDecades |> Decade.toEons)
      "To century and back", (fun x -> x |> Eon.toCenturies |> Century.toEons)
      "To millennium and back", (fun x -> x |> Eon.toMillennia |> Millennium.toEons)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Eon.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  testList
    "Time Tests"
    [
      testList "Nanosecond conversions" nanoSecondConversionTests
      testList "Microsecond conversions" microSecondConversionTests
      testList "Millisecond conversions" milliSecondConversionTests
      testList "Second conversions" secondConversionTests
      testList "Minute conversions" minuteConversionTests
      testList "Hour conversions" hourConversionTests
      testList "Day conversions" dayConversionTests
      testList "Week conversions" weekConversionTests
      testList "Fortnight conversions" fortnightConversionTests
      testList "Month conversions" monthConversionTests
      testList "Year conversions" yearConversionTests
      testList "Decade conversions" decadeConversionTests
      testList "Century conversions" centuryConversionTests
      testList "Millennium conversions" millenniumConversionTests
      testList "Eon conversions" eonConversionTests
    ]

let massTests config =

  let milligramConversionTests =
    [
      "To gram and back", (fun x -> x |> Milligram.toGrams |> Gram.toMilligrams)
      "To kilogram and back", (fun x -> x |> Milligram.toKilograms |> Kilogram.toMilligrams)
      "To pound and back", (fun x -> x |> Milligram.toPoundMass |> PoundMass.toMilligrams)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Milligram.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let gramConversionTests =
    [
      "To milligram and back", (fun x -> x |> Gram.toMilligrams |> Milligram.toGrams)
      "To kilogram and back", (fun x -> x |> Gram.toKilograms |> Kilogram.toGrams)
      "To pound and back", (fun x -> x |> Gram.toPoundMass |> PoundMass.toGrams)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Gram.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let kilogramConversionTests =
    [
      "To milligram and back", (fun x -> x |> Kilogram.toMilligrams |> Milligram.toKilograms)
      "To gram and back", (fun x -> x |> Kilogram.toGrams |> Gram.toKilograms)
      "To pound and back", (fun x -> x |> Kilogram.toPoundMass |> PoundMass.toKilograms)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Kilogram.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let poundConversionTests =
    [
      "To milligram and back", (fun x -> x |> PoundMass.toMilligrams |> Milligram.toPoundMass)
      "To gram and back", (fun x -> x |> PoundMass.toGrams |> Gram.toPoundMass)
      "To kilogram and back", (fun x -> x |> PoundMass.toKilograms |> Kilogram.toPoundMass)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> PoundMass.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  testList
    "Mass tests"
    [
      testList "Milligram conversions" milligramConversionTests
      testList "Gram conversions" gramConversionTests
      testList "Kilogram conversions" kilogramConversionTests
      testList "Pound conversions" poundConversionTests
    ]

let temperatureTests config =

  let kelvinConversionTests =
    [
      "To celsius and back", (fun x -> x |> Kelvin.toCelsius |> Celsius.toKelvin)
      "To fahrenheit and back", (fun x -> x |> Kelvin.toFahrenheit |> Fahrenheit.toKelvin)
      "To rankine and back", (fun x -> x |> Kelvin.toRankine |> Rankine.toKelvin)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Kelvin.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let celsiusConversionTests =
    [
      "To kelvin and back", (fun x -> x |> Celsius.toKelvin |> Kelvin.toCelsius)
      "To fahrenheit and back", (fun x -> x |> Celsius.toFahrenheit |> Fahrenheit.toCelsius)
      "To rankine and back", (fun x -> x |> Celsius.toRankine |> Rankine.toCelsius)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Celsius.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let fahrenheitConversionTests =
    [
      "To kelvin and back", (fun x -> x |> Fahrenheit.toKelvin |> Kelvin.toFahrenheit)
      "To celsius and back", (fun x -> x |> Fahrenheit.toCelsius |> Celsius.toFahrenheit)
      "To rankine and back", (fun x -> x |> Fahrenheit.toRankine |> Rankine.toFahrenheit)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Fahrenheit.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let rankineConversionTests =
    [
      "To kelvin and back", (fun x -> x |> Rankine.toKelvin |> Kelvin.toRankine)
      "To celsius and back", (fun x -> x |> Rankine.toCelsius |> Celsius.toRankine)
      "To fahrenheit and back", (fun x -> x |> Rankine.toFahrenheit |> Fahrenheit.toRankine)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Rankine.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  testList
    "Temperature Tests"
    [
      testList "Kelvin conversions" kelvinConversionTests
      testList "Celsius conversions" celsiusConversionTests
      testList "Fahrenheit conversions" fahrenheitConversionTests
      testList "Rankine conversions" rankineConversionTests
    ]

let angleTests config =

  let degreeConversionTests =
    [
      "To radians and back", (fun x -> x |> Degree.toRadians |> Radian.toDegrees)
      "To gradians and back", (fun x -> x |> Degree.toGradians |> Gradian.toDegrees)
      "To revolutions and back", (fun x -> x |> Degree.toRevolutions |> Revolution.toDegrees)
      "To arcminutes and back", (fun x -> x |> Degree.toArcMinutes |> ArcMinute.toDegrees)
      "To arcseconds and back", (fun x -> x |> Degree.toArcSeconds |> ArcSecond.toDegrees)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Degree.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let radianConversionTests =
    [
      "To degrees and back", (fun x -> x |> Radian.toDegrees |> Degree.toRadians)
      "To gradians and back", (fun x -> x |> Radian.toGradians |> Gradian.toRadians)
      "To revolutions and back", (fun x -> x |> Radian.toRevolutions |> Revolution.toRadians)
      "To arcminutes and back", (fun x -> x |> Radian.toArcMinutes |> ArcMinute.toRadians)
      "To arcseconds and back", (fun x -> x |> Radian.toArcSeconds |> ArcSecond.toRadians)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Radian.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let gradianConversionTests =
    [
      "To degrees and back", (fun x -> x |> Gradian.toDegrees |> Degree.toGradians)
      "To radians and back", (fun x -> x |> Gradian.toRadians |> Radian.toGradians)
      "To revolutions and back", (fun x -> x |> Gradian.toRevolutions |> Revolution.toGradians)
      "To arcminutes and back", (fun x -> x |> Gradian.toArcMinutes |> ArcMinute.toGradians)
      "To arcseconds and back", (fun x -> x |> Gradian.toArcSeconds |> ArcSecond.toGradians)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Gradian.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let revolutionConversionTests =
    [
      "To degrees and back", (fun x -> x |> Revolution.toDegrees |> Degree.toRevolutions)
      "To radians and back", (fun x -> x |> Revolution.toRadians |> Radian.toRevolutions)
      "To gradians and back", (fun x -> x |> Revolution.toGradians |> Gradian.toRevolutions)
      "To arcminutes and back", (fun x -> x |> Revolution.toArcMinutes |> ArcMinute.toRevolutions)
      "To arcseconds and back", (fun x -> x |> Revolution.toArcSeconds |> ArcSecond.toRevolutions)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Revolution.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let arcMinuteConversionTests =
    [
      "To degrees and back", (fun x -> x |> ArcMinute.toDegrees |> Degree.toArcMinutes)
      "To radians and back", (fun x -> x |> ArcMinute.toRadians |> Radian.toArcMinutes)
      "To gradians and back", (fun x -> x |> ArcMinute.toGradians |> Gradian.toArcMinutes)
      "To revolutions and back", (fun x -> x |> ArcMinute.toRevolutions |> Revolution.toArcMinutes)
      "To arcseconds and back", (fun x -> x |> ArcMinute.toArcSeconds |> ArcSecond.toArcMinutes)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> ArcMinute.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let arcSecondConversionTests =
    [
      "To degrees and back", (fun x -> x |> ArcSecond.toDegrees |> Degree.toArcSeconds)
      "To radians and back", (fun x -> x |> ArcSecond.toRadians |> Radian.toArcSeconds)
      "To gradians and back", (fun x -> x |> ArcSecond.toGradians |> Gradian.toArcSeconds)
      "To revolutions and back", (fun x -> x |> ArcSecond.toRevolutions |> Revolution.toArcSeconds)
      "To arcminutes and back", (fun x -> x |> ArcSecond.toArcMinutes |> ArcMinute.toArcSeconds)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> ArcSecond.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  testList
    "Angle Tests"
    [
      testList "Degree conversions" degreeConversionTests
      testList "Radian conversions" radianConversionTests
      testList "Gradian conversions" gradianConversionTests
      testList "Revolution conversions" revolutionConversionTests
      testList "ArcMinute conversions" arcMinuteConversionTests
      testList "ArcSecond conversions" arcSecondConversionTests
    ]

let dataStorageTests config =

  let bitConversionTests =
    [
      "To kilobit and back", (fun x -> x |> Bit.toKilobits |> Kilobit.toBits)
      "To megabit and back", (fun x -> x |> Bit.toMegabits |> Megabit.toBits)
      "To gigabit and back", (fun x -> x |> Bit.toGigabits |> Gigabit.toBits)
      "To terabit and back", (fun x -> x |> Bit.toTerabits |> Terabit.toBits)
      "To petabit and back", (fun x -> x |> Bit.toPetabits |> Petabit.toBits)
      "To byte and back", (fun x -> x |> Bit.toBytes |> Byte.toBits)
      "To kilobyte and back", (fun x -> x |> Bit.toKilobytes |> Kilobyte.toBits)
      "To megabyte and back", (fun x -> x |> Bit.toMegabytes |> Megabyte.toBits)
      "To gigabyte and back", (fun x -> x |> Bit.toGigabytes |> Gigabyte.toBits)
      "To terabyte and back", (fun x -> x |> Bit.toTerabytes |> Terabyte.toBits)
      "To petabyte and back", (fun x -> x |> Bit.toPetabytes |> Petabyte.toBits)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Bit.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let kilobitConversionTests =
    [
      "To bit and back", (fun x -> x |> Kilobit.toBits |> Bit.toKilobits)
      "To megabit and back", (fun x -> x |> Kilobit.toMegabits |> Megabit.toKilobits)
      "To gigabit and back", (fun x -> x |> Kilobit.toGigabits |> Gigabit.toKilobits)
      "To terabit and back", (fun x -> x |> Kilobit.toTerabits |> Terabit.toKilobits)
      "To petabit and back", (fun x -> x |> Kilobit.toPetabits |> Petabit.toKilobits)
      "To byte and back", (fun x -> x |> Kilobit.toBytes |> Byte.toKilobits)
      "To kilobyte and back", (fun x -> x |> Kilobit.toKilobytes |> Kilobyte.toKilobits)
      "To megabyte and back", (fun x -> x |> Kilobit.toMegabytes |> Megabyte.toKilobits)
      "To gigabyte and back", (fun x -> x |> Kilobit.toGigabytes |> Gigabyte.toKilobits)
      "To terabyte and back", (fun x -> x |> Kilobit.toTerabytes |> Terabyte.toKilobits)
      "To petabyte and back", (fun x -> x |> Kilobit.toPetabytes |> Petabyte.toKilobits)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Kilobit.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let megabitConversionTests =
    [
      "To bit and back", (fun x -> x |> Megabit.toBits |> Bit.toMegabits)
      "To kilobit and back", (fun x -> x |> Megabit.toKilobits |> Kilobit.toMegabits)
      "To gigabit and back", (fun x -> x |> Megabit.toGigabits |> Gigabit.toMegabits)
      "To terabit and back", (fun x -> x |> Megabit.toTerabits |> Terabit.toMegabits)
      "To petabit and back", (fun x -> x |> Megabit.toPetabits |> Petabit.toMegabits)
      "To byte and back", (fun x -> x |> Megabit.toBytes |> Byte.toMegabits)
      "To kilobyte and back", (fun x -> x |> Megabit.toKilobytes |> Kilobyte.toMegabits)
      "To megabyte and back", (fun x -> x |> Megabit.toMegabytes |> Megabyte.toMegabits)
      "To gigabyte and back", (fun x -> x |> Megabit.toGigabytes |> Gigabyte.toMegabits)
      "To terabyte and back", (fun x -> x |> Megabit.toTerabytes |> Terabyte.toMegabits)
      "To petabyte and back", (fun x -> x |> Megabit.toPetabytes |> Petabyte.toMegabits)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Megabit.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let gigabitConversionTests =
    [
      "To bit and back", (fun x -> x |> Gigabit.toBits |> Bit.toGigabits)
      "To kilobit and back", (fun x -> x |> Gigabit.toKilobits |> Kilobit.toGigabits)
      "To megabit and back", (fun x -> x |> Gigabit.toMegabits |> Megabit.toGigabits)
      "To terabit and back", (fun x -> x |> Gigabit.toTerabits |> Terabit.toGigabits)
      "To petabit and back", (fun x -> x |> Gigabit.toPetabits |> Petabit.toGigabits)
      "To byte and back", (fun x -> x |> Gigabit.toBytes |> Byte.toGigabits)
      "To kilobyte and back", (fun x -> x |> Gigabit.toKilobytes |> Kilobyte.toGigabits)
      "To megabyte and back", (fun x -> x |> Gigabit.toMegabytes |> Megabyte.toGigabits)
      "To gigabyte and back", (fun x -> x |> Gigabit.toGigabytes |> Gigabyte.toGigabits)
      "To terabyte and back", (fun x -> x |> Gigabit.toTerabytes |> Terabyte.toGigabits)
      "To petabyte and back", (fun x -> x |> Gigabit.toPetabytes |> Petabyte.toGigabits)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Gigabit.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let terabitConversionTests =
    [
      "To bit and back", (fun x -> x |> Terabit.toBits |> Bit.toTerabits)
      "To kilobit and back", (fun x -> x |> Terabit.toKilobits |> Kilobit.toTerabits)
      "To megabit and back", (fun x -> x |> Terabit.toMegabits |> Megabit.toTerabits)
      "To gigabit and back", (fun x -> x |> Terabit.toGigabits |> Gigabit.toTerabits)
      "To petabit and back", (fun x -> x |> Terabit.toPetabits |> Petabit.toTerabits)
      "To byte and back", (fun x -> x |> Terabit.toBytes |> Byte.toTerabits)
      "To kilobyte and back", (fun x -> x |> Terabit.toKilobytes |> Kilobyte.toTerabits)
      "To megabyte and back", (fun x -> x |> Terabit.toMegabytes |> Megabyte.toTerabits)
      "To gigabyte and back", (fun x -> x |> Terabit.toGigabytes |> Gigabyte.toTerabits)
      "To terabyte and back", (fun x -> x |> Terabit.toTerabytes |> Terabyte.toTerabits)
      "To petabyte and back", (fun x -> x |> Terabit.toPetabytes |> Petabyte.toTerabits)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Terabit.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let petabitConversionTests =
    [
      "To bit and back", (fun x -> x |> Petabit.toBits |> Bit.toPetabits)
      "To kilobit and back", (fun x -> x |> Petabit.toKilobits |> Kilobit.toPetabits)
      "To megabit and back", (fun x -> x |> Petabit.toMegabits |> Megabit.toPetabits)
      "To gigabit and back", (fun x -> x |> Petabit.toGigabits |> Gigabit.toPetabits)
      "To terabit and back", (fun x -> x |> Petabit.toTerabits |> Terabit.toPetabits)
      "To byte and back", (fun x -> x |> Petabit.toBytes |> Byte.toPetabits)
      "To kilobyte and back", (fun x -> x |> Petabit.toKilobytes |> Kilobyte.toPetabits)
      "To megabyte and back", (fun x -> x |> Petabit.toMegabytes |> Megabyte.toPetabits)
      "To gigabyte and back", (fun x -> x |> Petabit.toGigabytes |> Gigabyte.toPetabits)
      "To terabyte and back", (fun x -> x |> Petabit.toTerabytes |> Terabyte.toPetabits)
      "To petabyte and back", (fun x -> x |> Petabit.toPetabytes |> Petabyte.toPetabits)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Petabit.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let byteConversionTests =
    [
      "To bit and back", (fun x -> x |> Byte.toBits |> Bit.toBytes)
      "To kilobit and back", (fun x -> x |> Byte.toKilobits |> Kilobit.toBytes)
      "To megabit and back", (fun x -> x |> Byte.toMegabits |> Megabit.toBytes)
      "To gigabit and back", (fun x -> x |> Byte.toGigabits |> Gigabit.toBytes)
      "To terabit and back", (fun x -> x |> Byte.toTerabits |> Terabit.toBytes)
      "To petabit and back", (fun x -> x |> Byte.toPetabits |> Petabit.toBytes)
      "To kilobyte and back", (fun x -> x |> Byte.toKilobytes |> Kilobyte.toBytes)
      "To megabyte and back", (fun x -> x |> Byte.toMegabytes |> Megabyte.toBytes)
      "To gigabyte and back", (fun x -> x |> Byte.toGigabytes |> Gigabyte.toBytes)
      "To terabyte and back", (fun x -> x |> Byte.toTerabytes |> Terabyte.toBytes)
      "To petabyte and back", (fun x -> x |> Byte.toPetabytes |> Petabyte.toBytes)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Byte.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let kilobyteConversionTests =
    [
      "To bit and back", (fun x -> x |> Kilobyte.toBits |> Bit.toKilobytes)
      "To kilobit and back", (fun x -> x |> Kilobyte.toKilobits |> Kilobit.toKilobytes)
      "To megabit and back", (fun x -> x |> Kilobyte.toMegabits |> Megabit.toKilobytes)
      "To gigabit and back", (fun x -> x |> Kilobyte.toGigabits |> Gigabit.toKilobytes)
      "To terabit and back", (fun x -> x |> Kilobyte.toTerabits |> Terabit.toKilobytes)
      "To petabit and back", (fun x -> x |> Kilobyte.toPetabits |> Petabit.toKilobytes)
      "To byte and back", (fun x -> x |> Kilobyte.toBytes |> Byte.toKilobytes)
      "To megabyte and back", (fun x -> x |> Kilobyte.toMegabytes |> Megabyte.toKilobytes)
      "To gigabyte and back", (fun x -> x |> Kilobyte.toGigabytes |> Gigabyte.toKilobytes)
      "To terabyte and back", (fun x -> x |> Kilobyte.toTerabytes |> Terabyte.toKilobytes)
      "To petabyte and back", (fun x -> x |> Kilobyte.toPetabytes |> Petabyte.toKilobytes)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Kilobyte.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let megabyteConversionTests =
    [
      "To bit and back", (fun x -> x |> Megabyte.toBits |> Bit.toMegabytes)
      "To kilobit and back", (fun x -> x |> Megabyte.toKilobits |> Kilobit.toMegabytes)
      "To megabit and back", (fun x -> x |> Megabyte.toMegabits |> Megabit.toMegabytes)
      "To gigabit and back", (fun x -> x |> Megabyte.toGigabits |> Gigabit.toMegabytes)
      "To terabit and back", (fun x -> x |> Megabyte.toTerabits |> Terabit.toMegabytes)
      "To petabit and back", (fun x -> x |> Megabyte.toPetabits |> Petabit.toMegabytes)
      "To byte and back", (fun x -> x |> Megabyte.toBytes |> Byte.toMegabytes)
      "To kilobyte and back", (fun x -> x |> Megabyte.toKilobytes |> Kilobyte.toMegabytes)
      "To gigabyte and back", (fun x -> x |> Megabyte.toGigabytes |> Gigabyte.toMegabytes)
      "To terabyte and back", (fun x -> x |> Megabyte.toTerabytes |> Terabyte.toMegabytes)
      "To petabyte and back", (fun x -> x |> Megabyte.toPetabytes |> Petabyte.toMegabytes)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Megabyte.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let gigabyteConversionTests =
    [
      "To bit and back", (fun x -> x |> Gigabyte.toBits |> Bit.toGigabytes)
      "To kilobit and back", (fun x -> x |> Gigabyte.toKilobits |> Kilobit.toGigabytes)
      "To megabit and back", (fun x -> x |> Gigabyte.toMegabits |> Megabit.toGigabytes)
      "To gigabit and back", (fun x -> x |> Gigabyte.toGigabits |> Gigabit.toGigabytes)
      "To terabit and back", (fun x -> x |> Gigabyte.toTerabits |> Terabit.toGigabytes)
      "To petabit and back", (fun x -> x |> Gigabyte.toPetabits |> Petabit.toGigabytes)
      "To byte and back", (fun x -> x |> Gigabyte.toBytes |> Byte.toGigabytes)
      "To kilobyte and back", (fun x -> x |> Gigabyte.toKilobytes |> Kilobyte.toGigabytes)
      "To megabyte and back", (fun x -> x |> Gigabyte.toMegabytes |> Megabyte.toGigabytes)
      "To terabyte and back", (fun x -> x |> Gigabyte.toTerabytes |> Terabyte.toGigabytes)
      "To petabyte and back", (fun x -> x |> Gigabyte.toPetabytes |> Petabyte.toGigabytes)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Gigabyte.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let terabyteConversionTests =
    [
      "To bit and back", (fun x -> x |> Terabyte.toBits |> Bit.toTerabytes)
      "To kilobit and back", (fun x -> x |> Terabyte.toKilobits |> Kilobit.toTerabytes)
      "To megabit and back", (fun x -> x |> Terabyte.toMegabits |> Megabit.toTerabytes)
      "To gigabit and back", (fun x -> x |> Terabyte.toGigabits |> Gigabit.toTerabytes)
      "To terabit and back", (fun x -> x |> Terabyte.toTerabits |> Terabit.toTerabytes)
      "To petabit and back", (fun x -> x |> Terabyte.toPetabits |> Petabit.toTerabytes)
      "To byte and back", (fun x -> x |> Terabyte.toBytes |> Byte.toTerabytes)
      "To kilobyte and back", (fun x -> x |> Terabyte.toKilobytes |> Kilobyte.toTerabytes)
      "To megabyte and back", (fun x -> x |> Terabyte.toMegabytes |> Megabyte.toTerabytes)
      "To gigabyte and back", (fun x -> x |> Terabyte.toGigabytes |> Gigabyte.toTerabytes)
      "To petabyte and back", (fun x -> x |> Terabyte.toPetabytes |> Petabyte.toTerabytes)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Terabyte.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let petabyteConversionTests =
    [
      "To bit and back", (fun x -> x |> Petabyte.toBits |> Bit.toPetabytes)
      "To kilobit and back", (fun x -> x |> Petabyte.toKilobits |> Kilobit.toPetabytes)
      "To megabit and back", (fun x -> x |> Petabyte.toMegabits |> Megabit.toPetabytes)
      "To gigabit and back", (fun x -> x |> Petabyte.toGigabits |> Gigabit.toPetabytes)
      "To terabit and back", (fun x -> x |> Petabyte.toTerabits |> Terabit.toPetabytes)
      "To petabit and back", (fun x -> x |> Petabyte.toPetabits |> Petabit.toPetabytes)
      "To byte and back", (fun x -> x |> Petabyte.toBytes |> Byte.toPetabytes)
      "To kilobyte and back", (fun x -> x |> Petabyte.toKilobytes |> Kilobyte.toPetabytes)
      "To megabyte and back", (fun x -> x |> Petabyte.toMegabytes |> Megabyte.toPetabytes)
      "To gigabyte and back", (fun x -> x |> Petabyte.toGigabytes |> Gigabyte.toPetabytes)
      "To terabyte and back", (fun x -> x |> Petabyte.toTerabytes |> Terabyte.toPetabytes)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Petabyte.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  testList
    "Data storage tests"
    [
      testList "Bit conversions" bitConversionTests
      testList "Kilobit conversions" kilobitConversionTests
      testList "Megabit conversions" megabitConversionTests
      testList "Gigabit conversions" gigabitConversionTests
      testList "Terabit conversions" terabitConversionTests
      testList "Petabit conversions" petabitConversionTests
      testList "Byte conversions" byteConversionTests
      testList "Kilobyte conversions" kilobyteConversionTests
      testList "Megabyte conversions" megabyteConversionTests
      testList "Gigabyte conversions" gigabyteConversionTests
      testList "Terabyte conversions" terabyteConversionTests
      testList "Petabyte conversions" petabyteConversionTests
    ]

let fuelEconomyTests config =

  let kilometerPerLiterConversionTests =
    [
      "From km/l to mpg", (fun x -> x |> KilometerPerLiter.toMilesPerGallon |> MilePerGallon.toKilometersPerLiter)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> KilometerPerLiter.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let milePerGallonConversionTests =
    [
      "To km/l", (fun x -> x |> MilePerGallon.toKilometersPerLiter |> KilometerPerLiter.toMilesPerGallon)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> MilePerGallon.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  testList
    "Fuel economy tests"
    [
      testList "Kilometer per liter conversions" kilometerPerLiterConversionTests
      testList "Mile per gallon conversions" milePerGallonConversionTests
    ]

let frequencyTests config =

  let hertzConversionTest =
    [
      "To kilohertz and back", (fun x -> x |> Hertz.toKilohertz |> Kilohertz.toHertz)
      "To megahertz and back", (fun x -> x |> Hertz.toMegahertz |> Megahertz.toHertz)
      "To gigahertz and back", (fun x -> x |> Hertz.toGigahertz |> Gigahertz.toHertz)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Hertz.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let kilohertzConversionTest =
    [
      "To hertz and back", (fun x -> x |> Kilohertz.toHertz |> Hertz.toKilohertz)
      "To megahertz and back", (fun x -> x |> Kilohertz.toMegahertz |> Megahertz.toKilohertz)
      "To gigahertz and back", (fun x -> x |> Kilohertz.toGigahertz |> Gigahertz.toKilohertz)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Kilohertz.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let megahertzConversionTest =
    [
      "To hertz and back", (fun x -> x |> Megahertz.toHertz |> Hertz.toMegahertz)
      "To kilohertz and back", (fun x -> x |> Megahertz.toKilohertz |> Kilohertz.toMegahertz)
      "To gigahertz and back", (fun x -> x |> Megahertz.toGigahertz |> Gigahertz.toMegahertz)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Megahertz.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let gigahertzConversionTest =
    [
      "To hertz and back", (fun x -> x |> Gigahertz.toHertz |> Hertz.toGigahertz)
      "To kilohertz and back", (fun x -> x |> Gigahertz.toKilohertz |> Kilohertz.toGigahertz)
      "To megahertz and back", (fun x -> x |> Gigahertz.toMegahertz |> Megahertz.toGigahertz)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Gigahertz.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  testList
    "Frequency tests"
    [
      testList "Hertz conversions" hertzConversionTest
      testList "Kilohertz conversions" kilohertzConversionTest
      testList "Megahertz conversions" megahertzConversionTest
      testList "Gigahertz conversions" gigahertzConversionTest
    ]

let illuminanceTests config =

  let footcandleConversionTests =
    [
      "To lux and back", (fun x -> x |> Footcandle.toLux |> Lux.toFootcandle)
      "To phot and back", (fun x -> x |> Footcandle.toPhot |> Phot.toFootcandle)
      "To nox and back", (fun x -> x |> Footcandle.toNox |> Nox.toFootcandle)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Footcandle.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let luxConversionTests =
    [
      "To footcandle and back", (fun x -> x |> Lux.toFootcandle |> Footcandle.toLux)
      "To phot and back", (fun x -> x |> Lux.toPhot |> Phot.toLux)
      "To nox and back", (fun x -> x |> Lux.toNox |> Nox.toLux)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Lux.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let photConversionTests =
    [
      "To footcandle and back", (fun x -> x |> Phot.toFootcandle |> Footcandle.toPhot)
      "To lux and back", (fun x -> x |> Phot.toLux |> Lux.toPhot)
      "To nox and back", (fun x -> x |> Phot.toNox |> Nox.toPhot)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Phot.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let noxConversionTests =
    [
      "To footcandle and back", (fun x -> x |> Nox.toFootcandle |> Footcandle.toNox)
      "To lux and back", (fun x -> x |> Nox.toLux |> Lux.toNox)
      "To phot and back", (fun x -> x |> Nox.toPhot |> Phot.toNox)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Nox.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  testList
    "Illuminance tests"
    [
      testList "Footcandle conversions" footcandleConversionTests
      testList "Lux conversions" luxConversionTests
      testList "Phot conversions" photConversionTests
      testList "Nox conversions" noxConversionTests
    ]

let currentTests config =

  let ampereConversionTests =
    [
      "To milliampere and back", (fun x -> x |> Ampere.toMilliamperes |> Milliampere.toAmperes)
      "To microampere and back", (fun x -> x |> Ampere.toMicroamperes |> Microampere.toAmperes)
      "To biot and back", (fun x -> x |> Ampere.toBiots |> Biot.toAmperes)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Ampere.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let milliampereConversionTests =
    [
      "To ampere and back", (fun x -> x |> Milliampere.toAmperes |> Ampere.toMilliamperes)
      "To microampere and back", (fun x -> x |> Milliampere.toMicroamperes |> Microampere.toMilliamperes)
      "To biot and back", (fun x -> x |> Milliampere.toBiots |> Biot.toMilliamperes)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Milliampere.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let microampereConversionTests =
    [
      "To ampere and back", (fun x -> x |> Microampere.toAmperes |> Ampere.toMicroamperes)
      "To milliampere and back", (fun x -> x |> Microampere.toMilliamperes |> Milliampere.toMicroamperes)
      "To biot and back", (fun x -> x |> Microampere.toBiots |> Biot.toMicroamperes)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Microampere.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let biotConversionTests =
    [
      "To ampere and back", (fun x -> x |> Biot.toAmperes |> Ampere.toBiots)
      "To milliampere and back", (fun x -> x |> Biot.toMilliamperes |> Milliampere.toBiots)
      "To microampere and back", (fun x -> x |> Biot.toMicroamperes |> Microampere.toBiots)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Biot.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  testList
    "Current tests"
    [
      testList "Ampere conversions" ampereConversionTests
      testList "Milliampere conversions" milliampereConversionTests
      testList "Microampere conversions" microampereConversionTests
      testList "Biot conversions" biotConversionTests
    ]
