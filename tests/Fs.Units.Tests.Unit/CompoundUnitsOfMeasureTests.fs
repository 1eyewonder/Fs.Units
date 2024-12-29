module CompoundUnitOfMeasureTests

open Expecto
open Fs.Units
open Helpers

let areaTests config =

  let squareInchConversionTests =
    [
      "To square feet and back", (fun x -> x |> SquareInch.toSquareFeet |> SquareFoot.toSquareInches)
      "To square centimeters and back",
      (fun x -> x |> SquareInch.toSquareCentimeters |> SquareCentimeter.toSquareInches)
      "To square meters and back", (fun x -> x |> SquareInch.toSquareMeters |> SquareMeter.toSquareInches)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> SquareInch.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let squareFootConversionTests =
    [
      "To square inches and back", (fun x -> x |> SquareFoot.toSquareInches |> SquareInch.toSquareFeet)
      "To square centimeters and back", (fun x -> x |> SquareFoot.toSquareCentimeters |> SquareCentimeter.toSquareFeet)
      "To square meters and back", (fun x -> x |> SquareFoot.toSquareMeters |> SquareMeter.toSquareFeet)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> SquareFoot.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let squareCentimeterConversionTests =
    [
      "To square inches and back", (fun x -> x |> SquareCentimeter.toSquareInches |> SquareInch.toSquareCentimeters)
      "To square feet and back", (fun x -> x |> SquareCentimeter.toSquareFeet |> SquareFoot.toSquareCentimeters)
      "To square meters and back", (fun x -> x |> SquareCentimeter.toSquareMeters |> SquareMeter.toSquareCentimeters)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> SquareCentimeter.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let squareMeterConversionTests =
    [
      "To square inches and back", (fun x -> x |> SquareMeter.toSquareInches |> SquareInch.toSquareMeters)
      "To square feet and back", (fun x -> x |> SquareMeter.toSquareFeet |> SquareFoot.toSquareMeters)
      "To square centimeters and back",
      (fun x -> x |> SquareMeter.toSquareCentimeters |> SquareCentimeter.toSquareMeters)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> SquareMeter.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  testList "Area tests" [
    testList "Square inch conversions" squareInchConversionTests
    testList "Square foot conversions" squareFootConversionTests
    testList "Square centimeter conversions" squareCentimeterConversionTests
    testList "Square meter conversions" squareMeterConversionTests
  ]

let volumeTests config =

  let cubicInchConversionTests =
    [
      "To cubic feet and back", (fun x -> x |> CubicInch.toCubicFeet |> CubicFoot.toCubicInches)
      "To cubic centimeters and back", (fun x -> x |> CubicInch.toCubicCentimeters |> CubicCentimeter.toCubicInches)
      "To cubic meters and back", (fun x -> x |> CubicInch.toCubicMeters |> CubicMeter.toCubicInches)
      "To liters and back", (fun x -> x |> CubicInch.toLiters |> Liter.toCubicInches)
      "To gallons and back", (fun x -> x |> CubicInch.toGallons |> Gallon.toCubicInches)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> CubicInch.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let cubicFootConversionTests =
    [
      "To cubic inches and back", (fun x -> x |> CubicFoot.toCubicInches |> CubicInch.toCubicFeet)
      "To cubic centimeters and back", (fun x -> x |> CubicFoot.toCubicCentimeters |> CubicCentimeter.toCubicFeet)
      "To cubic meters and back", (fun x -> x |> CubicFoot.toCubicMeters |> CubicMeter.toCubicFeet)
      "To liters and back", (fun x -> x |> CubicFoot.toLiters |> Liter.toCubicFeet)
      "To gallons and back", (fun x -> x |> CubicFoot.toGallons |> Gallon.toCubicFeet)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> CubicFoot.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let cubicCentimeterConversionTests =
    [
      "To cubic inches and back", (fun x -> x |> CubicCentimeter.toCubicInches |> CubicInch.toCubicCentimeters)
      "To cubic feet and back", (fun x -> x |> CubicCentimeter.toCubicFeet |> CubicFoot.toCubicCentimeters)
      "To cubic meters and back", (fun x -> x |> CubicCentimeter.toCubicMeters |> CubicMeter.toCubicCentimeters)
      "To liters and back", (fun x -> x |> CubicCentimeter.toLiters |> Liter.toCubicCentimeters)
      "To gallons and back", (fun x -> x |> CubicCentimeter.toGallons |> Gallon.toCubicCentimeters)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> CubicCentimeter.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let cubicMeterConversionTests =
    [
      "To cubic inches and back", (fun x -> x |> CubicMeter.toCubicInches |> CubicInch.toCubicMeters)
      "To cubic feet and back", (fun x -> x |> CubicMeter.toCubicFeet |> CubicFoot.toCubicMeters)
      "To cubic centimeters and back", (fun x -> x |> CubicMeter.toCubicCentimeters |> CubicCentimeter.toCubicMeters)
      "To liters and back", (fun x -> x |> CubicMeter.toLiters |> Liter.toCubicMeters)
      "To gallons and back", (fun x -> x |> CubicMeter.toGallons |> Gallon.toCubicMeters)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> CubicMeter.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let literConversionTests =
    [
      "To cubic inches and back", (fun x -> x |> Liter.toCubicInches |> CubicInch.toLiters)
      "To cubic feet and back", (fun x -> x |> Liter.toCubicFeet |> CubicFoot.toLiters)
      "To cubic centimeters and back", (fun x -> x |> Liter.toCubicCentimeters |> CubicCentimeter.toLiters)
      "To cubic meters and back", (fun x -> x |> Liter.toCubicMeters |> CubicMeter.toLiters)
      "To gallons and back", (fun x -> x |> Liter.toGallons |> Gallon.toLiters)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Liter.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let gallonConversionTests =
    [
      "To cubic inches and back", (fun x -> x |> Gallon.toCubicInches |> CubicInch.toGallons)
      "To cubic feet and back", (fun x -> x |> Gallon.toCubicFeet |> CubicFoot.toGallons)
      "To cubic centimeters and back", (fun x -> x |> Gallon.toCubicCentimeters |> CubicCentimeter.toGallons)
      "To cubic meters and back", (fun x -> x |> Gallon.toCubicMeters |> CubicMeter.toGallons)
      "To liters and back", (fun x -> x |> Gallon.toLiters |> Liter.toGallons)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Gallon.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  testList "Volume tests" [
    testList "Cubic inch conversions" cubicInchConversionTests
    testList "Cubic foot conversions" cubicFootConversionTests
    testList "Cubic centimeter conversions" cubicCentimeterConversionTests
    testList "Cubic meter conversions" cubicMeterConversionTests
    testList "Liter conversions" literConversionTests
    testList "Gallon conversions" gallonConversionTests
  ]

let inertiaTests config =

  let quarticInchConversionTests =
    [
      "To quartic centimeters and back",
      (fun x -> x |> QuarticInch.toQuarticCentimeters |> QuarticCentimeter.toQuarticInches)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> QuarticInch.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let quarticCentimeterConversionTests =
    [
      "To quartic inches and back",
      (fun x -> x |> QuarticCentimeter.toQuarticInches |> QuarticInch.toQuarticCentimeters)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> QuarticCentimeter.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  testList "Inertia tests" [
    testList "Quartic inch conversions" quarticInchConversionTests
    testList "Quartic centimeter conversions" quarticCentimeterConversionTests
  ]

let speedTests config =

  let feetPerSecondTests =
    [
      "From feet per second to meters per second and back",
      (fun x -> x |> FootPerSecond.toMetersPerSecond |> MeterPerSecond.toFeetPerSecond)
      "From feet per second to kilometers per hour and back",
      (fun x -> x |> FootPerSecond.toKilometersPerHour |> KilometerPerHour.toFeetPerSecond)
      "From feet per second to miles per hour and back",
      (fun x -> x |> FootPerSecond.toMilesPerHour |> MilePerHour.toFeetPerSecond)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> FootPerSecond.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let metersPerSecondTests =
    [
      "From meter per second to feet per second and back",
      (fun x -> x |> MeterPerSecond.toFeetPerSecond |> FootPerSecond.toMetersPerSecond)
      "From meter per second to kilometers per hour and back",
      (fun x -> x |> MeterPerSecond.toKilometersPerHour |> KilometerPerHour.toMetersPerSecond)
      "From meter per second to miles per hour and back",
      (fun x -> x |> MeterPerSecond.toMilesPerHour |> MilePerHour.toMetersPerSecond)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> MeterPerSecond.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let kilometersPerHourTests =
    [
      "From kilometer per hour to feet per second and back",
      (fun x -> x |> KilometerPerHour.toFeetPerSecond |> FootPerSecond.toKilometersPerHour)
      "From kilometer per hour to meters per second and back",
      (fun x -> x |> KilometerPerHour.toMetersPerSecond |> MeterPerSecond.toKilometersPerHour)
      "From kilometer per hour to miles per hour and back",
      (fun x -> x |> KilometerPerHour.toMilesPerHour |> MilePerHour.toKilometersPerHour)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> KilometerPerHour.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let milesPerHourTests =
    [
      "From mile per hour to feet per second and back",
      (fun x -> x |> MilePerHour.toFeetPerSecond |> FootPerSecond.toMilesPerHour)
      "From mile per hour to meters per second and back",
      (fun x -> x |> MilePerHour.toMetersPerSecond |> MeterPerSecond.toMilesPerHour)
      "From mile per hour to kilometers per hour and back",
      (fun x -> x |> MilePerHour.toKilometersPerHour |> KilometerPerHour.toMilesPerHour)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> MilePerHour.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  testList "Speed tests" [
    testList "Feet per second tests" feetPerSecondTests
    testList "Meters per second tests" metersPerSecondTests
    testList "Kilometers per hour tests" kilometersPerHourTests
    testList "Miles per hour tests" milesPerHourTests
  ]

let forceTests config =

  let newtonConversionTests =
    [
      "To pound force and back", (fun x -> x |> Newton.toPoundForce |> PoundForce.toNewtons)
      "To dynes and back", (fun x -> x |> Newton.toDynes |> Dyne.toNewtons)
      "To kips and back", (fun x -> x |> Newton.toKips |> Kip.toNewtons)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Newton.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let poundForceConversionTests =
    [
      "To newtons and back", (fun x -> x |> PoundForce.toNewtons |> Newton.toPoundForce)
      "To dynes and back", (fun x -> x |> PoundForce.toDynes |> Dyne.toPoundForce)
      "To kips and back", (fun x -> x |> PoundForce.toKips |> Kip.toPoundForce)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> PoundForce.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let dyneConversionTests =
    [
      "To newtons and back", (fun x -> x |> Dyne.toNewtons |> Newton.toDynes)
      "To pound force and back", (fun x -> x |> Dyne.toPoundForce |> PoundForce.toDynes)
      "To kips and back", (fun x -> x |> Dyne.toKips |> Kip.toDynes)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Dyne.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let kipConversionTests =
    [
      "To newtons and back", (fun x -> x |> Kip.toNewtons |> Newton.toKips)
      "To pound force and back", (fun x -> x |> Kip.toPoundForce |> PoundForce.toKips)
      "To dynes and back", (fun x -> x |> Kip.toDynes |> Dyne.toKips)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Kip.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  testList "Force tests" [
    testList "Newton conversions" newtonConversionTests
    testList "Pound force conversions" poundForceConversionTests
    testList "Dyne conversions" dyneConversionTests
    testList "Kip conversions" kipConversionTests
  ]

let dataTransferRateTests config =

  let baudPerSecondConversionTests =
    [
      "To bits per second", (fun x -> x |> Baud.toBitsPerSecond |> BitPerSecond.toBauds)
      "To kilobits per second", (fun x -> x |> Baud.toKilobitsPerSecond |> KilobitPerSecond.toBauds)
      "To megabits per second", (fun x -> x |> Baud.toMegabitsPerSecond |> MegabitPerSecond.toBauds)
      "To gigabits per second", (fun x -> x |> Baud.toGigabitsPerSecond |> GigabitPerSecond.toBauds)
      "To terabits per second", (fun x -> x |> Baud.toTerabitsPerSecond |> TerabitPerSecond.toBauds)
      "To petabits per second", (fun x -> x |> Baud.toPetabitsPerSecond |> PetabitPerSecond.toBauds)
      "To bytes per second", (fun x -> x |> Baud.toBytesPerSecond |> BytePerSecond.toBauds)
      "To kilobytes per second", (fun x -> x |> Baud.toKilobytesPerSecond |> KilobytePerSecond.toBauds)
      "To megabytes per second", (fun x -> x |> Baud.toMegabytesPerSecond |> MegabytePerSecond.toBauds)
      "To gigabytes per second", (fun x -> x |> Baud.toGigabytesPerSecond |> GigabytePerSecond.toBauds)
      "To terabytes per second", (fun x -> x |> Baud.toTerabytesPerSecond |> TerabytePerSecond.toBauds)
      "To petabytes per second", (fun x -> x |> Baud.toPetabytesPerSecond |> PetabytePerSecond.toBauds)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Baud.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let bitPerSecondConversionTests =
    [
      "From bit per second to baud", (fun x -> x |> BitPerSecond.toBauds |> Baud.toBitsPerSecond)
      "From bit per second to kilobits per second",
      (fun x -> x |> BitPerSecond.toKilobitsPerSecond |> KilobitPerSecond.toBitsPerSecond)
      "From bit per second to megabits per second",
      (fun x -> x |> BitPerSecond.toMegabitsPerSecond |> MegabitPerSecond.toBitsPerSecond)
      "From bit per second to gigabits per second",
      (fun x -> x |> BitPerSecond.toGigabitsPerSecond |> GigabitPerSecond.toBitsPerSecond)
      "From bit per second to terabits per second",
      (fun x -> x |> BitPerSecond.toTerabitsPerSecond |> TerabitPerSecond.toBitsPerSecond)
      "From bit per second to petabits per second",
      (fun x -> x |> BitPerSecond.toPetabitsPerSecond |> PetabitPerSecond.toBitsPerSecond)
      "From bit per second to bytes per second",
      (fun x -> x |> BitPerSecond.toBytesPerSecond |> BytePerSecond.toBitsPerSecond)
      "From bit per second to kilobytes per second",
      (fun x -> x |> BitPerSecond.toKilobytesPerSecond |> KilobytePerSecond.toBitsPerSecond)
      "From bit per second to megabytes per second",
      (fun x -> x |> BitPerSecond.toMegabytesPerSecond |> MegabytePerSecond.toBitsPerSecond)
      "From bit per second to gigabytes per second",
      (fun x -> x |> BitPerSecond.toGigabytesPerSecond |> GigabytePerSecond.toBitsPerSecond)
      "From bit per second to terabytes per second",
      (fun x -> x |> BitPerSecond.toTerabytesPerSecond |> TerabytePerSecond.toBitsPerSecond)
      "From bit per second to petabytes per second",
      (fun x -> x |> BitPerSecond.toPetabytesPerSecond |> PetabytePerSecond.toBitsPerSecond)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> BitPerSecond.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let kilobitPerSecondConversionTests =
    [
      "From kilobit per second to baud", (fun x -> x |> KilobitPerSecond.toBauds |> Baud.toKilobitsPerSecond)
      "From kilobit per second to bits per second",
      (fun x -> x |> KilobitPerSecond.toBitsPerSecond |> BitPerSecond.toKilobitsPerSecond)
      "From kilobit per second to megabits per second",
      (fun x ->
        x
        |> KilobitPerSecond.toMegabitsPerSecond
        |> MegabitPerSecond.toKilobitsPerSecond)
      "From kilobit per second to gigabits per second",
      (fun x ->
        x
        |> KilobitPerSecond.toGigabitsPerSecond
        |> GigabitPerSecond.toKilobitsPerSecond)
      "From kilobit per second to terabits per second",
      (fun x ->
        x
        |> KilobitPerSecond.toTerabitsPerSecond
        |> TerabitPerSecond.toKilobitsPerSecond)
      "From kilobit per second to petabits per second",
      (fun x ->
        x
        |> KilobitPerSecond.toPetabitsPerSecond
        |> PetabitPerSecond.toKilobitsPerSecond)
      "From kilobit per second to bytes per second",
      (fun x -> x |> KilobitPerSecond.toBytesPerSecond |> BytePerSecond.toKilobitsPerSecond)
      "From kilobit per second to kilobytes per second",
      (fun x ->
        x
        |> KilobitPerSecond.toKilobytesPerSecond
        |> KilobytePerSecond.toKilobitsPerSecond)
      "From kilobit per second to megabytes per second",
      (fun x ->
        x
        |> KilobitPerSecond.toMegabytesPerSecond
        |> MegabytePerSecond.toKilobitsPerSecond)
      "From kilobit per second to gigabytes per second",
      (fun x ->
        x
        |> KilobitPerSecond.toGigabytesPerSecond
        |> GigabytePerSecond.toKilobitsPerSecond)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> KilobitPerSecond.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let megabitPerSecondConversionTests =
    [
      "From megabit per second to baud", (fun x -> x |> MegabitPerSecond.toBauds |> Baud.toMegabitsPerSecond)
      "From megabit per second to bits per second",
      (fun x -> x |> MegabitPerSecond.toBitsPerSecond |> BitPerSecond.toMegabitsPerSecond)
      "From megabit per second to kilobits per second",
      (fun x ->
        x
        |> MegabitPerSecond.toKilobitsPerSecond
        |> KilobitPerSecond.toMegabitsPerSecond)
      "From megabit per second to gigabits per second",
      (fun x ->
        x
        |> MegabitPerSecond.toGigabitsPerSecond
        |> GigabitPerSecond.toMegabitsPerSecond)
      "From megabit per second to terabits per second",
      (fun x ->
        x
        |> MegabitPerSecond.toTerabitsPerSecond
        |> TerabitPerSecond.toMegabitsPerSecond)
      "From megabit per second to petabits per second",
      (fun x ->
        x
        |> MegabitPerSecond.toPetabitsPerSecond
        |> PetabitPerSecond.toMegabitsPerSecond)
      "From megabit per second to bytes per second",
      (fun x -> x |> MegabitPerSecond.toBytesPerSecond |> BytePerSecond.toMegabitsPerSecond)
      "From megabit per second to kilobytes per second",
      (fun x ->
        x
        |> MegabitPerSecond.toKilobytesPerSecond
        |> KilobytePerSecond.toMegabitsPerSecond)
      "From megabit per second to megabytes per second",
      (fun x ->
        x
        |> MegabitPerSecond.toMegabytesPerSecond
        |> MegabytePerSecond.toMegabitsPerSecond)
      "From megabit per second to gigabytes per second",
      (fun x ->
        x
        |> MegabitPerSecond.toGigabytesPerSecond
        |> GigabytePerSecond.toMegabitsPerSecond)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> MegabitPerSecond.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let gigabitPerSecondConversionTests =
    [
      "From gigabit per second to baud", (fun x -> x |> GigabitPerSecond.toBauds |> Baud.toGigabitsPerSecond)
      "From gigabit per second to bits per second",
      (fun x -> x |> GigabitPerSecond.toBitsPerSecond |> BitPerSecond.toGigabitsPerSecond)
      "From gigabit per second to kilobits per second",
      (fun x ->
        x
        |> GigabitPerSecond.toKilobitsPerSecond
        |> KilobitPerSecond.toGigabitsPerSecond)
      "From gigabit per second to megabits per second",
      (fun x ->
        x
        |> GigabitPerSecond.toMegabitsPerSecond
        |> MegabitPerSecond.toGigabitsPerSecond)
      "From gigabit per second to terabits per second",
      (fun x ->
        x
        |> GigabitPerSecond.toTerabitsPerSecond
        |> TerabitPerSecond.toGigabitsPerSecond)
      "From gigabit per second to petabits per second",
      (fun x ->
        x
        |> GigabitPerSecond.toPetabitsPerSecond
        |> PetabitPerSecond.toGigabitsPerSecond)
      "From gigabit per second to bytes per second",
      (fun x -> x |> GigabitPerSecond.toBytesPerSecond |> BytePerSecond.toGigabitsPerSecond)
      "From gigabit per second to kilobytes per second",
      (fun x ->
        x
        |> GigabitPerSecond.toKilobytesPerSecond
        |> KilobytePerSecond.toGigabitsPerSecond)
      "From gigabit per second to megabytes per second",
      (fun x ->
        x
        |> GigabitPerSecond.toMegabytesPerSecond
        |> MegabytePerSecond.toGigabitsPerSecond)
      "From gigabit per second to gigabytes per second",
      (fun x ->
        x
        |> GigabitPerSecond.toGigabytesPerSecond
        |> GigabytePerSecond.toGigabitsPerSecond)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> GigabitPerSecond.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let terabitPerSecondConversionTests =
    [
      "From terabit per second to baud", (fun x -> x |> TerabitPerSecond.toBauds |> Baud.toTerabitsPerSecond)
      "From terabit per second to bits per second",
      (fun x -> x |> TerabitPerSecond.toBitsPerSecond |> BitPerSecond.toTerabitsPerSecond)
      "From terabit per second to kilobits per second",
      (fun x ->
        x
        |> TerabitPerSecond.toKilobitsPerSecond
        |> KilobitPerSecond.toTerabitsPerSecond)
      "From terabit per second to megabits per second",
      (fun x ->
        x
        |> TerabitPerSecond.toMegabitsPerSecond
        |> MegabitPerSecond.toTerabitsPerSecond)
      "From terabit per second to gigabits per second",
      (fun x ->
        x
        |> TerabitPerSecond.toGigabitsPerSecond
        |> GigabitPerSecond.toTerabitsPerSecond)
      "From terabit per second to petabits per second",
      (fun x ->
        x
        |> TerabitPerSecond.toPetabitsPerSecond
        |> PetabitPerSecond.toTerabitsPerSecond)
      "From terabit per second to bytes per second",
      (fun x -> x |> TerabitPerSecond.toBytesPerSecond |> BytePerSecond.toTerabitsPerSecond)
      "From terabit per second to kilobytes per second",
      (fun x ->
        x
        |> TerabitPerSecond.toKilobytesPerSecond
        |> KilobytePerSecond.toTerabitsPerSecond)
      "From terabit per second to megabytes per second",
      (fun x ->
        x
        |> TerabitPerSecond.toMegabytesPerSecond
        |> MegabytePerSecond.toTerabitsPerSecond)
      "From terabit per second to gigabytes per second",
      (fun x ->
        x
        |> TerabitPerSecond.toGigabytesPerSecond
        |> GigabytePerSecond.toTerabitsPerSecond)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> TerabitPerSecond.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let petabitPerSecondConversionTests =
    [
      "From petabit per second to baud", (fun x -> x |> PetabitPerSecond.toBauds |> Baud.toPetabitsPerSecond)
      "From petabit per second to bits per second",
      (fun x -> x |> PetabitPerSecond.toBitsPerSecond |> BitPerSecond.toPetabitsPerSecond)
      "From petabit per second to kilobits per second",
      (fun x ->
        x
        |> PetabitPerSecond.toKilobitsPerSecond
        |> KilobitPerSecond.toPetabitsPerSecond)
      "From petabit per second to megabits per second",
      (fun x ->
        x
        |> PetabitPerSecond.toMegabitsPerSecond
        |> MegabitPerSecond.toPetabitsPerSecond)
      "From petabit per second to gigabits per second",
      (fun x ->
        x
        |> PetabitPerSecond.toGigabitsPerSecond
        |> GigabitPerSecond.toPetabitsPerSecond)
      "From petabit per second to terabits per second",
      (fun x ->
        x
        |> PetabitPerSecond.toTerabitsPerSecond
        |> TerabitPerSecond.toPetabitsPerSecond)
      "From petabit per second to bytes per second",
      (fun x -> x |> PetabitPerSecond.toBytesPerSecond |> BytePerSecond.toPetabitsPerSecond)
      "From petabit per second to kilobytes per second",
      (fun x ->
        x
        |> PetabitPerSecond.toKilobytesPerSecond
        |> KilobytePerSecond.toPetabitsPerSecond)
      "From petabit per second to megabytes per second",
      (fun x ->
        x
        |> PetabitPerSecond.toMegabytesPerSecond
        |> MegabytePerSecond.toPetabitsPerSecond)
      "From petabit per second to gigabytes per second",
      (fun x ->
        x
        |> PetabitPerSecond.toGigabytesPerSecond
        |> GigabytePerSecond.toPetabitsPerSecond)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> PetabitPerSecond.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let bytePerSecondConversionTests =
    [
      "From byte per second to baud", (fun x -> x |> BytePerSecond.toBauds |> Baud.toBytesPerSecond)
      "From byte per second to bits per second",
      (fun x -> x |> BytePerSecond.toBitsPerSecond |> BitPerSecond.toBytesPerSecond)
      "From byte per second to kilobits per second",
      (fun x -> x |> BytePerSecond.toKilobitsPerSecond |> KilobitPerSecond.toBytesPerSecond)
      "From byte per second to megabits per second",
      (fun x -> x |> BytePerSecond.toMegabitsPerSecond |> MegabitPerSecond.toBytesPerSecond)
      "From byte per second to gigabits per second",
      (fun x -> x |> BytePerSecond.toGigabitsPerSecond |> GigabitPerSecond.toBytesPerSecond)
      "From byte per second to terabits per second",
      (fun x -> x |> BytePerSecond.toTerabitsPerSecond |> TerabitPerSecond.toBytesPerSecond)
      "From byte per second to petabits per second",
      (fun x -> x |> BytePerSecond.toPetabitsPerSecond |> PetabitPerSecond.toBytesPerSecond)
      "From byte per second to kilobytes per second",
      (fun x -> x |> BytePerSecond.toKilobytesPerSecond |> KilobytePerSecond.toBytesPerSecond)
      "From byte per second to megabytes per second",
      (fun x -> x |> BytePerSecond.toMegabytesPerSecond |> MegabytePerSecond.toBytesPerSecond)
      "From byte per second to gigabytes per second",
      (fun x -> x |> BytePerSecond.toGigabytesPerSecond |> GigabytePerSecond.toBytesPerSecond)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> BytePerSecond.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let kilobytePerSecondConversionTests =
    [
      "From kilobyte per second to baud", (fun x -> x |> KilobytePerSecond.toBauds |> Baud.toKilobytesPerSecond)
      "From kilobyte per second to bits per second",
      (fun x -> x |> KilobytePerSecond.toBitsPerSecond |> BitPerSecond.toKilobytesPerSecond)
      "From kilobyte per second to kilobits per second",
      (fun x ->
        x
        |> KilobytePerSecond.toKilobitsPerSecond
        |> KilobitPerSecond.toKilobytesPerSecond)
      "From kilobyte per second to megabits per second",
      (fun x ->
        x
        |> KilobytePerSecond.toMegabitsPerSecond
        |> MegabitPerSecond.toKilobytesPerSecond)
      "From kilobyte per second to gigabits per second",
      (fun x ->
        x
        |> KilobytePerSecond.toGigabitsPerSecond
        |> GigabitPerSecond.toKilobytesPerSecond)
      "From kilobyte per second to terabits per second",
      (fun x ->
        x
        |> KilobytePerSecond.toTerabitsPerSecond
        |> TerabitPerSecond.toKilobytesPerSecond)
      "From kilobyte per second to petabits per second",
      (fun x ->
        x
        |> KilobytePerSecond.toPetabitsPerSecond
        |> PetabitPerSecond.toKilobytesPerSecond)
      "From kilobyte per second to bytes per second",
      (fun x -> x |> KilobytePerSecond.toBytesPerSecond |> BytePerSecond.toKilobytesPerSecond)
      "From kilobyte per second to megabytes per second",
      (fun x ->
        x
        |> KilobytePerSecond.toMegabytesPerSecond
        |> MegabytePerSecond.toKilobytesPerSecond)
      "From kilobyte per second to gigabytes per second",
      (fun x ->
        x
        |> KilobytePerSecond.toGigabytesPerSecond
        |> GigabytePerSecond.toKilobytesPerSecond)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> KilobytePerSecond.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let megabytePerSecondConversionTests =
    [
      "From megabyte per second to baud", (fun x -> x |> MegabytePerSecond.toBauds |> Baud.toMegabytesPerSecond)
      "From megabyte per second to bits per second",
      (fun x -> x |> MegabytePerSecond.toBitsPerSecond |> BitPerSecond.toMegabytesPerSecond)
      "From megabyte per second to kilobits per second",
      (fun x ->
        x
        |> MegabytePerSecond.toKilobitsPerSecond
        |> KilobitPerSecond.toMegabytesPerSecond)
      "From megabyte per second to megabits per second",
      (fun x ->
        x
        |> MegabytePerSecond.toMegabitsPerSecond
        |> MegabitPerSecond.toMegabytesPerSecond)
      "From megabyte per second to gigabits per second",
      (fun x ->
        x
        |> MegabytePerSecond.toGigabitsPerSecond
        |> GigabitPerSecond.toMegabytesPerSecond)
      "From megabyte per second to terabits per second",
      (fun x ->
        x
        |> MegabytePerSecond.toTerabitsPerSecond
        |> TerabitPerSecond.toMegabytesPerSecond)
      "From megabyte per second to petabits per second",
      (fun x ->
        x
        |> MegabytePerSecond.toPetabitsPerSecond
        |> PetabitPerSecond.toMegabytesPerSecond)
      "From megabyte per second to bytes per second",
      (fun x -> x |> MegabytePerSecond.toBytesPerSecond |> BytePerSecond.toMegabytesPerSecond)
      "From megabyte per second to kilobytes per second",
      (fun x ->
        x
        |> MegabytePerSecond.toKilobytesPerSecond
        |> KilobytePerSecond.toMegabytesPerSecond)
      "From megabyte per second to gigabytes per second",
      (fun x ->
        x
        |> MegabytePerSecond.toGigabytesPerSecond
        |> GigabytePerSecond.toMegabytesPerSecond)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> MegabytePerSecond.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let gigabytePerSecondConversionTests =
    [
      "From gigabyte per second to baud", (fun x -> x |> GigabytePerSecond.toBauds |> Baud.toGigabytesPerSecond)
      "From gigabyte per second to bits per second",
      (fun x -> x |> GigabytePerSecond.toBitsPerSecond |> BitPerSecond.toGigabytesPerSecond)
      "From gigabyte per second to kilobits per second",
      (fun x ->
        x
        |> GigabytePerSecond.toKilobitsPerSecond
        |> KilobitPerSecond.toGigabytesPerSecond)
      "From gigabyte per second to megabits per second",
      (fun x ->
        x
        |> GigabytePerSecond.toMegabitsPerSecond
        |> MegabitPerSecond.toGigabytesPerSecond)
      "From gigabyte per second to gigabits per second",
      (fun x ->
        x
        |> GigabytePerSecond.toGigabitsPerSecond
        |> GigabitPerSecond.toGigabytesPerSecond)
      "From gigabyte per second to terabits per second",
      (fun x ->
        x
        |> GigabytePerSecond.toTerabitsPerSecond
        |> TerabitPerSecond.toGigabytesPerSecond)
      "From gigabyte per second to petabits per second",
      (fun x ->
        x
        |> GigabytePerSecond.toPetabitsPerSecond
        |> PetabitPerSecond.toGigabytesPerSecond)
      "From gigabyte per second to bytes per second",
      (fun x -> x |> GigabytePerSecond.toBytesPerSecond |> BytePerSecond.toGigabytesPerSecond)
      "From gigabyte per second to kilobytes per second",
      (fun x ->
        x
        |> GigabytePerSecond.toKilobytesPerSecond
        |> KilobytePerSecond.toGigabytesPerSecond)
      "From gigabyte per second to megabytes per second",
      (fun x ->
        x
        |> GigabytePerSecond.toMegabytesPerSecond
        |> MegabytePerSecond.toGigabytesPerSecond)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> GigabytePerSecond.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let terabytePerSecondConversionTests =
    [
      "From terabyte per second to baud", (fun x -> x |> TerabytePerSecond.toBauds |> Baud.toTerabytesPerSecond)
      "From terabyte per second to bits per second",
      (fun x -> x |> TerabytePerSecond.toBitsPerSecond |> BitPerSecond.toTerabytesPerSecond)
      "From terabyte per second to kilobits per second",
      (fun x ->
        x
        |> TerabytePerSecond.toKilobitsPerSecond
        |> KilobitPerSecond.toTerabytesPerSecond)
      "From terabyte per second to megabits per second",
      (fun x ->
        x
        |> TerabytePerSecond.toMegabitsPerSecond
        |> MegabitPerSecond.toTerabytesPerSecond)
      "From terabyte per second to gigabits per second",
      (fun x ->
        x
        |> TerabytePerSecond.toGigabitsPerSecond
        |> GigabitPerSecond.toTerabytesPerSecond)
      "From terabyte per second to terabits per second",
      (fun x ->
        x
        |> TerabytePerSecond.toTerabitsPerSecond
        |> TerabitPerSecond.toTerabytesPerSecond)
      "From terabyte per second to petabits per second",
      (fun x ->
        x
        |> TerabytePerSecond.toPetabitsPerSecond
        |> PetabitPerSecond.toTerabytesPerSecond)
      "From terabyte per second to bytes per second",
      (fun x -> x |> TerabytePerSecond.toBytesPerSecond |> BytePerSecond.toTerabytesPerSecond)
      "From terabyte per second to kilobytes per second",
      (fun x ->
        x
        |> TerabytePerSecond.toKilobytesPerSecond
        |> KilobytePerSecond.toTerabytesPerSecond)
      "From terabyte per second to megabytes per second",
      (fun x ->
        x
        |> TerabytePerSecond.toMegabytesPerSecond
        |> MegabytePerSecond.toTerabytesPerSecond)
      "From terabyte per second to gigabytes per second",
      (fun x ->
        x
        |> TerabytePerSecond.toGigabytesPerSecond
        |> GigabytePerSecond.toTerabytesPerSecond)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> TerabytePerSecond.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let petabytePerSecondConversionTests =
    [
      "From petabyte per second to baud", (fun x -> x |> PetabytePerSecond.toBauds |> Baud.toPetabytesPerSecond)
      "From petabyte per second to bits per second",
      (fun x -> x |> PetabytePerSecond.toBitsPerSecond |> BitPerSecond.toPetabytesPerSecond)
      "From petabyte per second to kilobits per second",
      (fun x ->
        x
        |> PetabytePerSecond.toKilobitsPerSecond
        |> KilobitPerSecond.toPetabytesPerSecond)
      "From petabyte per second to megabits per second",
      (fun x ->
        x
        |> PetabytePerSecond.toMegabitsPerSecond
        |> MegabitPerSecond.toPetabytesPerSecond)
      "From petabyte per second to gigabits per second",
      (fun x ->
        x
        |> PetabytePerSecond.toGigabitsPerSecond
        |> GigabitPerSecond.toPetabytesPerSecond)
      "From petabyte per second to terabits per second",
      (fun x ->
        x
        |> PetabytePerSecond.toTerabitsPerSecond
        |> TerabitPerSecond.toPetabytesPerSecond)
      "From petabyte per second to petabits per second",
      (fun x ->
        x
        |> PetabytePerSecond.toPetabitsPerSecond
        |> PetabitPerSecond.toPetabytesPerSecond)
      "From petabyte per second to bytes per second",
      (fun x -> x |> PetabytePerSecond.toBytesPerSecond |> BytePerSecond.toPetabytesPerSecond)
      "From petabyte per second to kilobytes per second",
      (fun x ->
        x
        |> PetabytePerSecond.toKilobytesPerSecond
        |> KilobytePerSecond.toPetabytesPerSecond)
      "From petabyte per second to megabytes per second",
      (fun x ->
        x
        |> PetabytePerSecond.toMegabytesPerSecond
        |> MegabytePerSecond.toPetabytesPerSecond)
      "From petabyte per second to gigabytes per second",
      (fun x ->
        x
        |> PetabytePerSecond.toGigabytesPerSecond
        |> GigabytePerSecond.toPetabytesPerSecond)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> PetabytePerSecond.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  testList "Data transfer rate tests" [
    testList "Baud per second conversions" baudPerSecondConversionTests
    testList "Bit per second conversions" bitPerSecondConversionTests
    testList "Kilobit per second conversions" kilobitPerSecondConversionTests
    testList "Megabit per second conversions" megabitPerSecondConversionTests
    testList "Gigabit per second conversions" gigabitPerSecondConversionTests
    testList "Terabit per second conversions" terabitPerSecondConversionTests
    testList "Petabit per second conversions" petabitPerSecondConversionTests
    testList "Byte per second conversions" bytePerSecondConversionTests
    testList "Kilobyte per second conversions" kilobytePerSecondConversionTests
    testList "Megabyte per second conversions" megabytePerSecondConversionTests
    testList "Gigabyte per second conversions" gigabytePerSecondConversionTests
    testList "Terabyte per second conversions" terabytePerSecondConversionTests
    testList "Petabyte per second conversions" petabytePerSecondConversionTests
  ]

let densityTests config =

  let kilogramPerCubicMeterConversionTests =
    [
      "From kilogram per cubic meter to grams per cubic centimeter",
      (fun x ->
        x
        |> KilogramPerCubicMeter.toGramsPerCubicCentimeter
        |> GramPerCubicCentimeter.toKilogramsPerCubicMeter)
      "From kilogram per cubic meter to pound mass per cubic foot",
      (fun x ->
        x
        |> KilogramPerCubicMeter.toPoundMassPerCubicFoot
        |> PoundMassPerCubicFoot.toKilogramsPerCubicMeter)
      "From kilogram per cubic meter to pound mass per cubic inch",
      (fun x ->
        x
        |> KilogramPerCubicMeter.toPoundMassPerCubicInch
        |> PoundMassPerCubicInch.toKilogramsPerCubicMeter)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> KilogramPerCubicMeter.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let gramPerCubicCentimeterConversionTests =
    [
      "From gram per cubic centimeter to kilogram per cubic meter",
      (fun x ->
        x
        |> GramPerCubicCentimeter.toKilogramsPerCubicMeter
        |> KilogramPerCubicMeter.toGramsPerCubicCentimeter)
      "From gram per cubic centimeter to pound mass per cubic foot",
      (fun x ->
        x
        |> GramPerCubicCentimeter.toPoundMassPerCubicFoot
        |> PoundMassPerCubicFoot.toGramsPerCubicCentimeter)
      "From gram per cubic centimeter to pound mass per cubic inch",
      (fun x ->
        x
        |> GramPerCubicCentimeter.toPoundMassPerCubicInch
        |> PoundMassPerCubicInch.toGramsPerCubicCentimeter)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> GramPerCubicCentimeter.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let poundMassPerCubicFootConversionTests =
    [
      "From pound mass per cubic foot to kilogram per cubic meter",
      (fun x ->
        x
        |> PoundMassPerCubicFoot.toKilogramsPerCubicMeter
        |> KilogramPerCubicMeter.toPoundMassPerCubicFoot)
      "From pound mass per cubic foot to grams per cubic centimeter",
      (fun x ->
        x
        |> PoundMassPerCubicFoot.toGramsPerCubicCentimeter
        |> GramPerCubicCentimeter.toPoundMassPerCubicFoot)
      "From pound mass per cubic foot to pound mass per cubic inch",
      (fun x ->
        x
        |> PoundMassPerCubicFoot.toPoundMassPerCubicInch
        |> PoundMassPerCubicInch.toPoundMassPerCubicFoot)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> PoundMassPerCubicFoot.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let poundMassPerCubicInchConversionTests =
    [
      "From pound mass per cubic inch to kilogram per cubic meter",
      (fun x ->
        x
        |> PoundMassPerCubicInch.toKilogramsPerCubicMeter
        |> KilogramPerCubicMeter.toPoundMassPerCubicInch)
      "From pound mass per cubic inch to grams per cubic centimeter",
      (fun x ->
        x
        |> PoundMassPerCubicInch.toGramsPerCubicCentimeter
        |> GramPerCubicCentimeter.toPoundMassPerCubicInch)
      "From pound mass per cubic inch to pound mass per cubic foot",
      (fun x ->
        x
        |> PoundMassPerCubicInch.toPoundMassPerCubicFoot
        |> PoundMassPerCubicFoot.toPoundMassPerCubicInch)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> PoundMassPerCubicInch.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  testList "Density tests" [
    testList "Kilogram per cubic meter conversions" kilogramPerCubicMeterConversionTests
    testList "Gram per cubic centimeter conversions" gramPerCubicCentimeterConversionTests
    testList "Pound mass per cubic foot conversions" poundMassPerCubicFootConversionTests
    testList "Pound mass per cubic inch conversions" poundMassPerCubicInchConversionTests
  ]

let pressureTests config =

  let pascalConversionTests =
    [
      "To pounds per square inch", (fun x -> x |> Pascal.toPoundsPerSquareInch |> PoundPerSquareInch.toPascals)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Pascal.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let poundPerSquareInchConversionTests =
    [
      "From pounds per square inch to pascal",
      (fun x -> x |> PoundPerSquareInch.toPascals |> Pascal.toPoundsPerSquareInch)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> PoundPerSquareInch.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  testList "Pressure tests" [
    testList "Pascal conversions" pascalConversionTests
    testList "Pound per square inch conversions" poundPerSquareInchConversionTests
  ]

let powerTests config =

  let wattConversionTests =
    [
      "To kilowatt", (fun x -> x |> Watt.toKilowatts |> Kilowatt.toWatts)
      "To horsepower", (fun x -> x |> Watt.toHorsepower |> Horsepower.toWatts)
      "To tons of refrigeration", (fun x -> x |> Watt.toTonsOfRefrigeration |> TonOfRefrigeration.toWatts)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Watt.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let kilowattConversionTests =
    [
      "To watt", (fun x -> x |> Kilowatt.toWatts |> Watt.toKilowatts)
      "To horsepower", (fun x -> x |> Kilowatt.toHorsepower |> Horsepower.toKilowatts)
      "To tons of refrigeration", (fun x -> x |> Kilowatt.toTonsOfRefrigeration |> TonOfRefrigeration.toKilowatts)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Kilowatt.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let horsepowerConversionTests =
    [
      "To watt", (fun x -> x |> Horsepower.toWatts |> Watt.toHorsepower)
      "To kiloWatt", (fun x -> x |> Horsepower.toKilowatts |> Kilowatt.toHorsepower)
      "To tons of refrigeration", (fun x -> x |> Horsepower.toTonsOfRefrigeration |> TonOfRefrigeration.toHorsepower)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Horsepower.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let tonOfRefrigerationConversionTests =
    [
      "From tons of refrigeration to watt", (fun x -> x |> TonOfRefrigeration.toWatts |> Watt.toTonsOfRefrigeration)
      "From tons of refrigeration to kilowatt",
      (fun x -> x |> TonOfRefrigeration.toKilowatts |> Kilowatt.toTonsOfRefrigeration)
      "From tons of refrigeration to horsepower",
      (fun x -> x |> TonOfRefrigeration.toHorsepower |> Horsepower.toTonsOfRefrigeration)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> TonOfRefrigeration.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  testList "Power tests" [
    testList "Watt conversions" wattConversionTests
    testList "Kilowatt conversions" kilowattConversionTests
    testList "Horsepower conversions" horsepowerConversionTests
    testList "Ton of refrigeration conversions" tonOfRefrigerationConversionTests
  ]

let energyTests config =

  let jouleConversionTests =
    [
      "To kilojoule and back", (fun x -> x |> Joule.toKilojoules |> Kilojoule.toJoules)
      "To british thermal units and back", (fun x -> x |> Joule.toBritishThermalUnits |> BritishThermalUnit.toJoules)
      "To calories and back", (fun x -> x |> Joule.toCalories |> Calorie.toJoules)
      "To quads and back", (fun x -> x |> Joule.toQuads |> Quad.toJoules)
      "To Qs and back", (fun x -> x |> Joule.toQs |> Q.toJoules)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Joule.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let kilojouleConversionTests =
    [
      "To joule and back", (fun x -> x |> Kilojoule.toJoules |> Joule.toKilojoules)
      "To british thermal units and back",
      (fun x -> x |> Kilojoule.toBritishThermalUnits |> BritishThermalUnit.toKilojoules)
      "To calories and back", (fun x -> x |> Kilojoule.toCalories |> Calorie.toKilojoules)
      "To quads and back", (fun x -> x |> Kilojoule.toQuads |> Quad.toKilojoules)
      "To Qs and back", (fun x -> x |> Kilojoule.toQs |> Q.toKilojoules)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Kilojoule.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let britishThermalUnitConversionTests =
    [
      "From british thermal unit to joule and back",
      (fun x -> x |> BritishThermalUnit.toJoules |> Joule.toBritishThermalUnits)
      "From british thermal unit to kilojoule and back",
      (fun x -> x |> BritishThermalUnit.toKilojoules |> Kilojoule.toBritishThermalUnits)
      "From british thermal unit to calories and back",
      (fun x -> x |> BritishThermalUnit.toCalories |> Calorie.toBritishThermalUnits)
      "From british thermal unit to quads and back",
      (fun x -> x |> BritishThermalUnit.toQuads |> Quad.toBritishThermalUnits)
      "From british thermal unit to Qs and back", (fun x -> x |> BritishThermalUnit.toQs |> Q.toBritishThermalUnits)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> BritishThermalUnit.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let calorieConversionTests =
    [
      "To joule and back", (fun x -> x |> Calorie.toJoules |> Joule.toCalories)
      "To kilojoule and back", (fun x -> x |> Calorie.toKilojoules |> Kilojoule.toCalories)
      "To british thermal units and back",
      (fun x -> x |> Calorie.toBritishThermalUnits |> BritishThermalUnit.toCalories)
      "To quads and back", (fun x -> x |> Calorie.toQuads |> Quad.toCalories)
      "To Qs and back", (fun x -> x |> Calorie.toQs |> Q.toCalories)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Calorie.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let quadConversionTests =
    [
      "To joule and back", (fun x -> x |> Quad.toJoules |> Joule.toQuads)
      "To kilojoule and back", (fun x -> x |> Quad.toKilojoules |> Kilojoule.toQuads)
      "To british thermal units and back", (fun x -> x |> Quad.toBritishThermalUnits |> BritishThermalUnit.toQuads)
      "To calories and back", (fun x -> x |> Quad.toCalories |> Calorie.toQuads)
      "To Qs and back", (fun x -> x |> Quad.toQs |> Q.toQuads)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Quad.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let qConversionTests =
    [
      "To joule and back", (fun x -> x |> Q.toJoules |> Joule.toQs)
      "To kilojoule and back", (fun x -> x |> Q.toKilojoules |> Kilojoule.toQs)
      "To british thermal units and back", (fun x -> x |> Q.toBritishThermalUnits |> BritishThermalUnit.toQs)
      "To calories and back", (fun x -> x |> Q.toCalories |> Calorie.toQs)
      "To quads and back", (fun x -> x |> Q.toQuads |> Quad.toQs)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Q.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  testList "Energy tests" [
    testList "Joule conversion tests" jouleConversionTests
    testList "Kilojoule conversions" kilojouleConversionTests
    testList "British thermal unit conversions" britishThermalUnitConversionTests
    testList "Calorie conversions" calorieConversionTests
    testList "Quad conversions" quadConversionTests
    testList "Q conversions" qConversionTests
  ]

let electricChargeTests config =

  let coloumbConversionTests =
    [
      "To ampere hours and back", (fun x -> x |> Coulomb.toAmpereHours |> AmpereHour.toCoulombs)
      "To ampere seconds and back", (fun x -> x |> Coulomb.toAmpereSeconds |> AmpereSecond.toCoulombs)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Coulomb.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let ampereHourConversionTests =
    [
      "To coloumbs and back", (fun x -> x |> AmpereHour.toCoulombs |> Coulomb.toAmpereHours)
      "To ampere seconds and back", (fun x -> x |> AmpereHour.toAmpereSeconds |> AmpereSecond.toAmpereHours)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> AmpereHour.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let ampereSecondConversionTests =
    [
      "To coloumbs and back", (fun x -> x |> AmpereSecond.toCoulombs |> Coulomb.toAmpereSeconds)
      "To ampere hours and back", (fun x -> x |> AmpereSecond.toAmpereHours |> AmpereHour.toAmpereSeconds)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> AmpereSecond.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  testList "Electric charge tests" [
    testList "Coloumb conversion tests" coloumbConversionTests
    testList "Ampere hour conversions" ampereHourConversionTests
    testList "Ampere second conversions" ampereSecondConversionTests
  ]

let electromotiveForceTests config =

  let microvoltConversionTests =
    [
      "To millivolts and back", (fun x -> x |> Microvolt.toMillivolts |> Millivolt.toMicrovolts)
      "To volts and back", (fun x -> x |> Microvolt.toVolts |> Volt.toMicrovolts)
      "To kilovolts and back", (fun x -> x |> Microvolt.toKilovolts |> Kilovolt.toMicrovolts)
      "To megavolts and back", (fun x -> x |> Microvolt.toMegavolts |> Megavolt.toMicrovolts)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Microvolt.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let millivoltConversionTests =
    [
      "To microvolts and back", (fun x -> x |> Millivolt.toMicrovolts |> Microvolt.toMillivolts)
      "To volts and back", (fun x -> x |> Millivolt.toVolts |> Volt.toMillivolts)
      "To kilovolts and back", (fun x -> x |> Millivolt.toKilovolts |> Kilovolt.toMillivolts)
      "To megavolts and back", (fun x -> x |> Millivolt.toMegavolts |> Megavolt.toMillivolts)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Millivolt.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let voltConversionTests =
    [
      "To microvolts and back", (fun x -> x |> Volt.toMicrovolts |> Microvolt.toVolts)
      "To millivolts and back", (fun x -> x |> Volt.toMillivolts |> Millivolt.toVolts)
      "To kilovolts and back", (fun x -> x |> Volt.toKilovolts |> Kilovolt.toVolts)
      "To megavolts and back", (fun x -> x |> Volt.toMegavolts |> Megavolt.toVolts)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Volt.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let kilovoltConversionTests =
    [
      "To microvolts and back", (fun x -> x |> Kilovolt.toMicrovolts |> Microvolt.toKilovolts)
      "To millivolts and back", (fun x -> x |> Kilovolt.toMillivolts |> Millivolt.toKilovolts)
      "To volts and back", (fun x -> x |> Kilovolt.toVolts |> Volt.toKilovolts)
      "To megavolts and back", (fun x -> x |> Kilovolt.toMegavolts |> Megavolt.toKilovolts)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Kilovolt.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let megavoltConversionTests =
    [
      "To microvolts and back", (fun x -> x |> Megavolt.toMicrovolts |> Microvolt.toMegavolts)
      "To millivolts and back", (fun x -> x |> Megavolt.toMillivolts |> Millivolt.toMegavolts)
      "To volts and back", (fun x -> x |> Megavolt.toVolts |> Volt.toMegavolts)
      "To kilovolts and back", (fun x -> x |> Megavolt.toKilovolts |> Kilovolt.toMegavolts)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Megavolt.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  testList "Electromotive force tests" [
    testList "Microvolt conversion tests" microvoltConversionTests
    testList "Millivolt conversions" millivoltConversionTests
    testList "Volt conversions" voltConversionTests
    testList "Kilovolt conversions" kilovoltConversionTests
    testList "Megavolt conversions" megavoltConversionTests
  ]

let inductanceTests config =

  let microHenryConversionTest =
    [
      "To milli Henry and back", (fun x -> x |> MicroHenry.toMilliHenrys |> MilliHenry.toMicroHenrys)
      "To Henry and back", (fun x -> x |> MicroHenry.toHenrys |> Henry.toMicroHenrys)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> MicroHenry.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let milliHenryConversionTest =
    [
      "To micro Henry and back", (fun x -> x |> MilliHenry.toMicroHenrys |> MicroHenry.toMilliHenrys)
      "To Henry and back", (fun x -> x |> MilliHenry.toHenrys |> Henry.toMilliHenrys)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> MilliHenry.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  let henryConversionTest =
    [
      "To micro Henry and back", (fun x -> x |> Henry.toMicroHenrys |> MicroHenry.toHenrys)
      "To milli Henry and back", (fun x -> x |> Henry.toMilliHenrys |> MilliHenry.toHenrys)
    ]
    |> List.map (fun (x, y) -> x, (fun z -> Henry.create z |> y))
    |> List.map (fun (x, y) -> testConversionRoundingError config Accuracy.high x y)

  testList "Inductance tests" [
    testList "MicroHenry conversion tests" microHenryConversionTest
    testList "MilliHenry conversions" milliHenryConversionTest
    testList "Henry conversions" henryConversionTest
  ]
