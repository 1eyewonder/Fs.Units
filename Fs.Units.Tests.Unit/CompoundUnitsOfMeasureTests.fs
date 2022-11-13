module CompoundUnitOfMeasureTests

open Expecto
open Fs.Units.Area
open Fs.Units.Volume
open Fs.Units.Inertia
open Fs.Units.Speed
open Fs.Units.Force
open Fs.Units.DataTransferRate
open Fs.Units.Density
open Fs.Units.Pressure
open Fs.Units.Power
open Fs.Units.Energy
open Fs.Units.ElectricCharge
open Fs.Units.ElectromotiveForce
open Fs.Units.Inductance
open Helpers

[<Tests>]
let areaTests config =

    let squareInchConversionTests =
        [
            "From square inch to square feet and back", (fun x -> SquareInch.create x |> SquareInch.toSquareFeet |> SquareFoot.toSquareInches)
            "From square inch to square centimeters and back", (fun x -> SquareInch.create x |> SquareInch.toSquareCentimeters |> SquareCentimeter.toSquareInches)
            "From square inch to square meters and back", (fun x -> SquareInch.create x |> SquareInch.toSquareMeters |> SquareMeter.toSquareInches)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let squareFootConversionTests =
        [
            "From square foot to square inches and back", (fun x -> SquareFoot.create x |> SquareFoot.toSquareInches |> SquareInch.toSquareFeet)
            "From square foot to square centimeters and back", (fun x -> SquareFoot.create x |> SquareFoot.toSquareCentimeters |> SquareCentimeter.toSquareFeet)
            "From square foot to square meters and back", (fun x -> SquareFoot.create x |> SquareFoot.toSquareMeters |> SquareMeter.toSquareFeet)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let squareCentimeterConversionTests =
        [
            "From square centimeter to square inches and back", (fun x -> SquareCentimeter.create x |> SquareCentimeter.toSquareInches |> SquareInch.toSquareCentimeters)
            "From square centimeter to square feet and back", (fun x -> SquareCentimeter.create x |> SquareCentimeter.toSquareFeet |> SquareFoot.toSquareCentimeters)
            "From square centimeter to square meters and back", (fun x -> SquareCentimeter.create x |> SquareCentimeter.toSquareMeters |> SquareMeter.toSquareCentimeters)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let squareMeterConversionTests =
        [
            "From square meter to square inches and back", (fun x -> SquareMeter.create x |> SquareMeter.toSquareInches |> SquareInch.toSquareMeters)
            "From square meter to square feet and back", (fun x -> SquareMeter.create x |> SquareMeter.toSquareFeet |> SquareFoot.toSquareMeters)
            "From square meter to square centimeters and back", (fun x -> SquareMeter.create x |> SquareMeter.toSquareCentimeters |> SquareCentimeter.toSquareMeters)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    testList "Area tests -> " [
        testList "Square inch conversion tests -> " squareInchConversionTests
        testList "Square foot conversion tests -> " squareFootConversionTests
        testList "Square centimeter conversion tests -> " squareCentimeterConversionTests
        testList "Square meter conversion tests -> " squareMeterConversionTests
    ]

[<Tests>]
let volumeTests config =

    let cubicInchConversionTests =
        [
            "From cubic inch to cubic feet and back", (fun x -> CubicInch.create x |> CubicInch.toCubicFeet |> CubicFoot.toCubicInches)
            "From cubic inch to cubic centimeters and back", (fun x -> CubicInch.create x |> CubicInch.toCubicCentimeters |> CubicCentimeter.toCubicInches)
            "From cubic inch to cubic meters and back", (fun x -> CubicInch.create x |> CubicInch.toCubicMeters |> CubicMeter.toCubicInches)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let cubicFootConversionTests =
        [
            "From cubic foot to cubic inches and back", (fun x -> CubicFoot.create x |> CubicFoot.toCubicInches |> CubicInch.toCubicFeet)
            "From cubic foot to cubic centimeters and back", (fun x -> CubicFoot.create x |> CubicFoot.toCubicCentimeters |> CubicCentimeter.toCubicFeet)
            "From cubic foot to cubic meters and back", (fun x -> CubicFoot.create x |> CubicFoot.toCubicMeters |> CubicMeter.toCubicFeet)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let cubicCentimeterConversionTests =
        [
            "From cubic centimeter to cubic inches and back", (fun x -> CubicCentimeter.create x |> CubicCentimeter.toCubicInches |> CubicInch.toCubicCentimeters)
            "From cubic centimeter to cubic feet and back", (fun x -> CubicCentimeter.create x |> CubicCentimeter.toCubicFeet |> CubicFoot.toCubicCentimeters)
            "From cubic centimeter to cubic meters and back", (fun x -> CubicCentimeter.create x |> CubicCentimeter.toCubicMeters |> CubicMeter.toCubicCentimeters)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let cubicMeterConversionTests =
        [
            "From cubic meter to cubic inches and back", (fun x -> CubicMeter.create x |> CubicMeter.toCubicInches |> CubicInch.toCubicMeters)
            "From cubic meter to cubic feet and back", (fun x -> CubicMeter.create x |> CubicMeter.toCubicFeet |> CubicFoot.toCubicMeters)
            "From cubic meter to cubic centimeters and back", (fun x -> CubicMeter.create x |> CubicMeter.toCubicCentimeters |> CubicCentimeter.toCubicMeters)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    testList "Volume tests -> " [
        testList "Cubic inch conversion tests -> " cubicInchConversionTests
        testList "Cubic foot conversion tests -> " cubicFootConversionTests
        testList "Cubic centimeter conversion tests -> " cubicCentimeterConversionTests
        testList "Cubic meter conversion tests -> " cubicMeterConversionTests
    ]

[<Tests>]
let inertiaTests config =

    let quarticInchConversionTests =
        [
            "From quartic inch to quartic centimeters and back", (fun x -> QuarticInch.create x |> QuarticInch.toQuarticCentimeters |> QuarticCentimeter.toQuarticInches)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)

    let quarticCentimeterConversionTests =
        [
            "From quartic centimeter to quartic inches and back", (fun x -> QuarticCentimeter.create x |> QuarticCentimeter.toQuarticInches |> QuarticInch.toQuarticCentimeters)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)

    testList "Inertia tests -> " [
        testList "Quartic inch conversion tests -> " quarticInchConversionTests
        testList "Quartic centimeter conversion tests -> " quarticCentimeterConversionTests
    ]
    
[<Tests>]

let speedTests config =
    
    let feetPerSecondTests =
        [
            "From feet per second to meters per second and back", (fun x -> FootPerSecond.create x |> FootPerSecond.toMetersPerSecond |> MeterPerSecond.toFeetPerSecond)
            "From feet per second to kilometers per hour and back", (fun x -> FootPerSecond.create x |> FootPerSecond.toKilometersPerHour |> KilometerPerHour.toFeetPerSecond)
            "From feet per second to miles per hour and back", (fun x -> FootPerSecond.create x |> FootPerSecond.toMilesPerHour |> MilePerHour.toFeetPerSecond)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let metersPerSecondTests =
        [
            "From meter per second to feet per second and back", (fun x -> MeterPerSecond.create x |> MeterPerSecond.toFeetPerSecond |> FootPerSecond.toMetersPerSecond)
            "From meter per second to kilometers per hour and back", (fun x -> MeterPerSecond.create x |> MeterPerSecond.toKilometersPerHour |> KilometerPerHour.toMetersPerSecond)
            "From meter per second to miles per hour and back", (fun x -> MeterPerSecond.create x |> MeterPerSecond.toMilesPerHour |> MilePerHour.toMetersPerSecond)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let kilometersPerHourTests =
        [
            "From kilometer per hour to feet per second and back", (fun x -> KilometerPerHour.create x |> KilometerPerHour.toFeetPerSecond |> FootPerSecond.toKilometersPerHour)
            "From kilometer per hour to meters per second and back", (fun x -> KilometerPerHour.create x |> KilometerPerHour.toMetersPerSecond |> MeterPerSecond.toKilometersPerHour)
            "From kilometer per hour to miles per hour and back", (fun x -> KilometerPerHour.create x |> KilometerPerHour.toMilesPerHour |> MilePerHour.toKilometersPerHour)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let milesPerHourTests =
        [
            "From mile per hour to feet per second and back", (fun x -> MilePerHour.create x |> MilePerHour.toFeetPerSecond |> FootPerSecond.toMilesPerHour)
            "From mile per hour to meters per second and back", (fun x -> MilePerHour.create x |> MilePerHour.toMetersPerSecond |> MeterPerSecond.toMilesPerHour)
            "From mile per hour to kilometers per hour and back", (fun x -> MilePerHour.create x |> MilePerHour.toKilometersPerHour |> KilometerPerHour.toMilesPerHour)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    testList "Speed tests -> " [
        testList "Feet per second tests -> " feetPerSecondTests
        testList "Meters per second tests -> " metersPerSecondTests
        testList "Kilometers per hour tests -> " kilometersPerHourTests
        testList "Miles per hour tests -> " milesPerHourTests
    ]
    
[<Tests>]
let forceTests config =
    
    let newtonConversionTests =
        [
            "From newton to pound force and back", (fun x -> Newton.create x |> Newton.toPoundForce |> PoundForce.toNewtons)
            "From newton to dynes and back", (fun x -> Newton.create x |> Newton.toDynes |> Dyne.toNewtons)
            "From newton to kips and back", (fun x -> Newton.create x |> Newton.toKips |> Kip.toNewtons)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let poundForceConversionTests =
        [
            "From pound force to newtons and back", (fun x -> PoundForce.create x |> PoundForce.toNewtons |> Newton.toPoundForce)
            "From pound force to dynes and back", (fun x -> PoundForce.create x |> PoundForce.toDynes |> Dyne.toPoundForce)
            "From pound force to kips and back", (fun x -> PoundForce.create x |> PoundForce.toKips |> Kip.toPoundForce)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let dyneConversionTests =
        [
            "From dyne to newtons and back", (fun x -> Dyne.create x |> Dyne.toNewtons |> Newton.toDynes)
            "From dyne to pound force and back", (fun x -> Dyne.create x |> Dyne.toPoundForce |> PoundForce.toDynes)
            "From dyne to kips and back", (fun x -> Dyne.create x |> Dyne.toKips |> Kip.toDynes)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let kipConversionTests =
        [
            "From kip to newtons and back", (fun x -> Kip.create x |> Kip.toNewtons |> Newton.toKips)
            "From kip to pound force and back", (fun x -> Kip.create x |> Kip.toPoundForce |> PoundForce.toKips)
            "From kip to dynes and back", (fun x -> Kip.create x |> Kip.toDynes |> Dyne.toKips)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    testList "Force tests -> " [
        testList "Newton conversion tests -> " newtonConversionTests
        testList "Pound force conversion tests -> " poundForceConversionTests
        testList "Dyne conversion tests -> " dyneConversionTests
        testList "Kip conversion tests -> " kipConversionTests
    ]
    
[<Tests>]
let dataTransferRateTests config =
    
    let baudPerSecondConversionTests =
        [
            "From baud to bits per second", (fun x -> Baud.create x |> Baud.toBitsPerSecond |> BitPerSecond.toBauds)
            "From baud to kilobits per second", (fun x -> Baud.create x |> Baud.toKilobitsPerSecond |> KilobitPerSecond.toBauds)
            "From baud to megabits per second", (fun x -> Baud.create x |> Baud.toMegabitsPerSecond |> MegabitPerSecond.toBauds)
            "From baud to gigabits per second", (fun x -> Baud.create x |> Baud.toGigabitsPerSecond |> GigabitPerSecond.toBauds)
            "From baud to terabits per second", (fun x -> Baud.create x |> Baud.toTerabitsPerSecond |> TerabitPerSecond.toBauds)
            "From baud to petabits per second", (fun x -> Baud.create x |> Baud.toPetabitsPerSecond |> PetabitPerSecond.toBauds)
            "From baud to bytes per second", (fun x -> Baud.create x |> Baud.toBytesPerSecond |> BytePerSecond.toBauds)
            "From baud to kilobytes per second", (fun x -> Baud.create x |> Baud.toKilobytesPerSecond |> KilobytePerSecond.toBauds)
            "From baud to megabytes per second", (fun x -> Baud.create x |> Baud.toMegabytesPerSecond |> MegabytePerSecond.toBauds)
            "From baud to gigabytes per second", (fun x -> Baud.create x |> Baud.toGigabytesPerSecond |> GigabytePerSecond.toBauds)
            "From baud to terabytes per second", (fun x -> Baud.create x |> Baud.toTerabytesPerSecond |> TerabytePerSecond.toBauds)
            "From baud to petabytes per second", (fun x -> Baud.create x |> Baud.toPetabytesPerSecond |> PetabytePerSecond.toBauds)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let bitPerSecondConversionTests =
        [
            "From bit per second to baud", (fun x -> BitPerSecond.create x |> BitPerSecond.toBauds |> Baud.toBitsPerSecond)
            "From bit per second to kilobits per second", (fun x -> BitPerSecond.create x |> BitPerSecond.toKilobitsPerSecond |> KilobitPerSecond.toBitsPerSecond)
            "From bit per second to megabits per second", (fun x -> BitPerSecond.create x |> BitPerSecond.toMegabitsPerSecond |> MegabitPerSecond.toBitsPerSecond)
            "From bit per second to gigabits per second", (fun x -> BitPerSecond.create x |> BitPerSecond.toGigabitsPerSecond |> GigabitPerSecond.toBitsPerSecond)
            "From bit per second to terabits per second", (fun x -> BitPerSecond.create x |> BitPerSecond.toTerabitsPerSecond |> TerabitPerSecond.toBitsPerSecond)
            "From bit per second to petabits per second", (fun x -> BitPerSecond.create x |> BitPerSecond.toPetabitsPerSecond |> PetabitPerSecond.toBitsPerSecond)
            "From bit per second to bytes per second", (fun x -> BitPerSecond.create x |> BitPerSecond.toBytesPerSecond |> BytePerSecond.toBitsPerSecond)
            "From bit per second to kilobytes per second", (fun x -> BitPerSecond.create x |> BitPerSecond.toKilobytesPerSecond |> KilobytePerSecond.toBitsPerSecond)
            "From bit per second to megabytes per second", (fun x -> BitPerSecond.create x |> BitPerSecond.toMegabytesPerSecond |> MegabytePerSecond.toBitsPerSecond)
            "From bit per second to gigabytes per second", (fun x -> BitPerSecond.create x |> BitPerSecond.toGigabytesPerSecond |> GigabytePerSecond.toBitsPerSecond)
            "From bit per second to terabytes per second", (fun x -> BitPerSecond.create x |> BitPerSecond.toTerabytesPerSecond |> TerabytePerSecond.toBitsPerSecond)
            "From bit per second to petabytes per second", (fun x -> BitPerSecond.create x |> BitPerSecond.toPetabytesPerSecond |> PetabytePerSecond.toBitsPerSecond)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let kilobitPerSecondConversionTests =
        [
            "From kilobit per second to baud", (fun x -> KilobitPerSecond.create x |> KilobitPerSecond.toBauds |> Baud.toKilobitsPerSecond)
            "From kilobit per second to bits per second", (fun x -> KilobitPerSecond.create x |> KilobitPerSecond.toBitsPerSecond |> BitPerSecond.toKilobitsPerSecond)
            "From kilobit per second to megabits per second", (fun x -> KilobitPerSecond.create x |> KilobitPerSecond.toMegabitsPerSecond |> MegabitPerSecond.toKilobitsPerSecond)
            "From kilobit per second to gigabits per second", (fun x -> KilobitPerSecond.create x |> KilobitPerSecond.toGigabitsPerSecond |> GigabitPerSecond.toKilobitsPerSecond)
            "From kilobit per second to terabits per second", (fun x -> KilobitPerSecond.create x |> KilobitPerSecond.toTerabitsPerSecond |> TerabitPerSecond.toKilobitsPerSecond)
            "From kilobit per second to petabits per second", (fun x -> KilobitPerSecond.create x |> KilobitPerSecond.toPetabitsPerSecond |> PetabitPerSecond.toKilobitsPerSecond)
            "From kilobit per second to bytes per second", (fun x -> KilobitPerSecond.create x |> KilobitPerSecond.toBytesPerSecond |> BytePerSecond.toKilobitsPerSecond)
            "From kilobit per second to kilobytes per second", (fun x -> KilobitPerSecond.create x |> KilobitPerSecond.toKilobytesPerSecond |> KilobytePerSecond.toKilobitsPerSecond)
            "From kilobit per second to megabytes per second", (fun x -> KilobitPerSecond.create x |> KilobitPerSecond.toMegabytesPerSecond |> MegabytePerSecond.toKilobitsPerSecond)
            "From kilobit per second to gigabytes per second", (fun x -> KilobitPerSecond.create x |> KilobitPerSecond.toGigabytesPerSecond |> GigabytePerSecond.toKilobitsPerSecond)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let megabitPerSecondConversionTests =
        [
            "From megabit per second to baud", (fun x -> MegabitPerSecond.create x |> MegabitPerSecond.toBauds |> Baud.toMegabitsPerSecond)
            "From megabit per second to bits per second", (fun x -> MegabitPerSecond.create x |> MegabitPerSecond.toBitsPerSecond |> BitPerSecond.toMegabitsPerSecond)
            "From megabit per second to kilobits per second", (fun x -> MegabitPerSecond.create x |> MegabitPerSecond.toKilobitsPerSecond |> KilobitPerSecond.toMegabitsPerSecond)
            "From megabit per second to gigabits per second", (fun x -> MegabitPerSecond.create x |> MegabitPerSecond.toGigabitsPerSecond |> GigabitPerSecond.toMegabitsPerSecond)
            "From megabit per second to terabits per second", (fun x -> MegabitPerSecond.create x |> MegabitPerSecond.toTerabitsPerSecond |> TerabitPerSecond.toMegabitsPerSecond)
            "From megabit per second to petabits per second", (fun x -> MegabitPerSecond.create x |> MegabitPerSecond.toPetabitsPerSecond |> PetabitPerSecond.toMegabitsPerSecond)
            "From megabit per second to bytes per second", (fun x -> MegabitPerSecond.create x |> MegabitPerSecond.toBytesPerSecond |> BytePerSecond.toMegabitsPerSecond)
            "From megabit per second to kilobytes per second", (fun x -> MegabitPerSecond.create x |> MegabitPerSecond.toKilobytesPerSecond |> KilobytePerSecond.toMegabitsPerSecond)
            "From megabit per second to megabytes per second", (fun x -> MegabitPerSecond.create x |> MegabitPerSecond.toMegabytesPerSecond |> MegabytePerSecond.toMegabitsPerSecond)
            "From megabit per second to gigabytes per second", (fun x -> MegabitPerSecond.create x |> MegabitPerSecond.toGigabytesPerSecond |> GigabytePerSecond.toMegabitsPerSecond)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let gigabitPerSecondConversionTests =
        [
            "From gigabit per second to baud", (fun x -> GigabitPerSecond.create x |> GigabitPerSecond.toBauds |> Baud.toGigabitsPerSecond)
            "From gigabit per second to bits per second", (fun x -> GigabitPerSecond.create x |> GigabitPerSecond.toBitsPerSecond |> BitPerSecond.toGigabitsPerSecond)
            "From gigabit per second to kilobits per second", (fun x -> GigabitPerSecond.create x |> GigabitPerSecond.toKilobitsPerSecond |> KilobitPerSecond.toGigabitsPerSecond)
            "From gigabit per second to megabits per second", (fun x -> GigabitPerSecond.create x |> GigabitPerSecond.toMegabitsPerSecond |> MegabitPerSecond.toGigabitsPerSecond)
            "From gigabit per second to terabits per second", (fun x -> GigabitPerSecond.create x |> GigabitPerSecond.toTerabitsPerSecond |> TerabitPerSecond.toGigabitsPerSecond)
            "From gigabit per second to petabits per second", (fun x -> GigabitPerSecond.create x |> GigabitPerSecond.toPetabitsPerSecond |> PetabitPerSecond.toGigabitsPerSecond)
            "From gigabit per second to bytes per second", (fun x -> GigabitPerSecond.create x |> GigabitPerSecond.toBytesPerSecond |> BytePerSecond.toGigabitsPerSecond)
            "From gigabit per second to kilobytes per second", (fun x -> GigabitPerSecond.create x |> GigabitPerSecond.toKilobytesPerSecond |> KilobytePerSecond.toGigabitsPerSecond)
            "From gigabit per second to megabytes per second", (fun x -> GigabitPerSecond.create x |> GigabitPerSecond.toMegabytesPerSecond |> MegabytePerSecond.toGigabitsPerSecond)
            "From gigabit per second to gigabytes per second", (fun x -> GigabitPerSecond.create x |> GigabitPerSecond.toGigabytesPerSecond |> GigabytePerSecond.toGigabitsPerSecond)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let terabitPerSecondConversionTests =
        [
            "From terabit per second to baud", (fun x -> TerabitPerSecond.create x |> TerabitPerSecond.toBauds |> Baud.toTerabitsPerSecond)
            "From terabit per second to bits per second", (fun x -> TerabitPerSecond.create x |> TerabitPerSecond.toBitsPerSecond |> BitPerSecond.toTerabitsPerSecond)
            "From terabit per second to kilobits per second", (fun x -> TerabitPerSecond.create x |> TerabitPerSecond.toKilobitsPerSecond |> KilobitPerSecond.toTerabitsPerSecond)
            "From terabit per second to megabits per second", (fun x -> TerabitPerSecond.create x |> TerabitPerSecond.toMegabitsPerSecond |> MegabitPerSecond.toTerabitsPerSecond)
            "From terabit per second to gigabits per second", (fun x -> TerabitPerSecond.create x |> TerabitPerSecond.toGigabitsPerSecond |> GigabitPerSecond.toTerabitsPerSecond)
            "From terabit per second to petabits per second", (fun x -> TerabitPerSecond.create x |> TerabitPerSecond.toPetabitsPerSecond |> PetabitPerSecond.toTerabitsPerSecond)
            "From terabit per second to bytes per second", (fun x -> TerabitPerSecond.create x |> TerabitPerSecond.toBytesPerSecond |> BytePerSecond.toTerabitsPerSecond)
            "From terabit per second to kilobytes per second", (fun x -> TerabitPerSecond.create x |> TerabitPerSecond.toKilobytesPerSecond |> KilobytePerSecond.toTerabitsPerSecond)
            "From terabit per second to megabytes per second", (fun x -> TerabitPerSecond.create x |> TerabitPerSecond.toMegabytesPerSecond |> MegabytePerSecond.toTerabitsPerSecond)
            "From terabit per second to gigabytes per second", (fun x -> TerabitPerSecond.create x |> TerabitPerSecond.toGigabytesPerSecond |> GigabytePerSecond.toTerabitsPerSecond)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let petabitPerSecondConversionTests =
        [
            "From petabit per second to baud", (fun x -> PetabitPerSecond.create x |> PetabitPerSecond.toBauds |> Baud.toPetabitsPerSecond)
            "From petabit per second to bits per second", (fun x -> PetabitPerSecond.create x |> PetabitPerSecond.toBitsPerSecond |> BitPerSecond.toPetabitsPerSecond)
            "From petabit per second to kilobits per second", (fun x -> PetabitPerSecond.create x |> PetabitPerSecond.toKilobitsPerSecond |> KilobitPerSecond.toPetabitsPerSecond)
            "From petabit per second to megabits per second", (fun x -> PetabitPerSecond.create x |> PetabitPerSecond.toMegabitsPerSecond |> MegabitPerSecond.toPetabitsPerSecond)
            "From petabit per second to gigabits per second", (fun x -> PetabitPerSecond.create x |> PetabitPerSecond.toGigabitsPerSecond |> GigabitPerSecond.toPetabitsPerSecond)
            "From petabit per second to terabits per second", (fun x -> PetabitPerSecond.create x |> PetabitPerSecond.toTerabitsPerSecond |> TerabitPerSecond.toPetabitsPerSecond)
            "From petabit per second to bytes per second", (fun x -> PetabitPerSecond.create x |> PetabitPerSecond.toBytesPerSecond |> BytePerSecond.toPetabitsPerSecond)
            "From petabit per second to kilobytes per second", (fun x -> PetabitPerSecond.create x |> PetabitPerSecond.toKilobytesPerSecond |> KilobytePerSecond.toPetabitsPerSecond)
            "From petabit per second to megabytes per second", (fun x -> PetabitPerSecond.create x |> PetabitPerSecond.toMegabytesPerSecond |> MegabytePerSecond.toPetabitsPerSecond)
            "From petabit per second to gigabytes per second", (fun x -> PetabitPerSecond.create x |> PetabitPerSecond.toGigabytesPerSecond |> GigabytePerSecond.toPetabitsPerSecond)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let bytePerSecondConversionTests =
        [
            "From byte per second to baud", (fun x -> BytePerSecond.create x |> BytePerSecond.toBauds |> Baud.toBytesPerSecond)
            "From byte per second to bits per second", (fun x -> BytePerSecond.create x |> BytePerSecond.toBitsPerSecond |> BitPerSecond.toBytesPerSecond)
            "From byte per second to kilobits per second", (fun x -> BytePerSecond.create x |> BytePerSecond.toKilobitsPerSecond |> KilobitPerSecond.toBytesPerSecond)
            "From byte per second to megabits per second", (fun x -> BytePerSecond.create x |> BytePerSecond.toMegabitsPerSecond |> MegabitPerSecond.toBytesPerSecond)
            "From byte per second to gigabits per second", (fun x -> BytePerSecond.create x |> BytePerSecond.toGigabitsPerSecond |> GigabitPerSecond.toBytesPerSecond)
            "From byte per second to terabits per second", (fun x -> BytePerSecond.create x |> BytePerSecond.toTerabitsPerSecond |> TerabitPerSecond.toBytesPerSecond)
            "From byte per second to petabits per second", (fun x -> BytePerSecond.create x |> BytePerSecond.toPetabitsPerSecond |> PetabitPerSecond.toBytesPerSecond)
            "From byte per second to kilobytes per second", (fun x -> BytePerSecond.create x |> BytePerSecond.toKilobytesPerSecond |> KilobytePerSecond.toBytesPerSecond)
            "From byte per second to megabytes per second", (fun x -> BytePerSecond.create x |> BytePerSecond.toMegabytesPerSecond |> MegabytePerSecond.toBytesPerSecond)
            "From byte per second to gigabytes per second", (fun x -> BytePerSecond.create x |> BytePerSecond.toGigabytesPerSecond |> GigabytePerSecond.toBytesPerSecond)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let kilobytePerSecondConversionTests =
        [
            "From kilobyte per second to baud", (fun x -> KilobytePerSecond.create x |> KilobytePerSecond.toBauds |> Baud.toKilobytesPerSecond)
            "From kilobyte per second to bits per second", (fun x -> KilobytePerSecond.create x |> KilobytePerSecond.toBitsPerSecond |> BitPerSecond.toKilobytesPerSecond)
            "From kilobyte per second to kilobits per second", (fun x -> KilobytePerSecond.create x |> KilobytePerSecond.toKilobitsPerSecond |> KilobitPerSecond.toKilobytesPerSecond)
            "From kilobyte per second to megabits per second", (fun x -> KilobytePerSecond.create x |> KilobytePerSecond.toMegabitsPerSecond |> MegabitPerSecond.toKilobytesPerSecond)
            "From kilobyte per second to gigabits per second", (fun x -> KilobytePerSecond.create x |> KilobytePerSecond.toGigabitsPerSecond |> GigabitPerSecond.toKilobytesPerSecond)
            "From kilobyte per second to terabits per second", (fun x -> KilobytePerSecond.create x |> KilobytePerSecond.toTerabitsPerSecond |> TerabitPerSecond.toKilobytesPerSecond)
            "From kilobyte per second to petabits per second", (fun x -> KilobytePerSecond.create x |> KilobytePerSecond.toPetabitsPerSecond |> PetabitPerSecond.toKilobytesPerSecond)
            "From kilobyte per second to bytes per second", (fun x -> KilobytePerSecond.create x |> KilobytePerSecond.toBytesPerSecond |> BytePerSecond.toKilobytesPerSecond)
            "From kilobyte per second to megabytes per second", (fun x -> KilobytePerSecond.create x |> KilobytePerSecond.toMegabytesPerSecond |> MegabytePerSecond.toKilobytesPerSecond)
            "From kilobyte per second to gigabytes per second", (fun x -> KilobytePerSecond.create x |> KilobytePerSecond.toGigabytesPerSecond |> GigabytePerSecond.toKilobytesPerSecond)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let megabytePerSecondConversionTests =
        [
            "From megabyte per second to baud", (fun x -> MegabytePerSecond.create x |> MegabytePerSecond.toBauds |> Baud.toMegabytesPerSecond)
            "From megabyte per second to bits per second", (fun x -> MegabytePerSecond.create x |> MegabytePerSecond.toBitsPerSecond |> BitPerSecond.toMegabytesPerSecond)
            "From megabyte per second to kilobits per second", (fun x -> MegabytePerSecond.create x |> MegabytePerSecond.toKilobitsPerSecond |> KilobitPerSecond.toMegabytesPerSecond)
            "From megabyte per second to megabits per second", (fun x -> MegabytePerSecond.create x |> MegabytePerSecond.toMegabitsPerSecond |> MegabitPerSecond.toMegabytesPerSecond)
            "From megabyte per second to gigabits per second", (fun x -> MegabytePerSecond.create x |> MegabytePerSecond.toGigabitsPerSecond |> GigabitPerSecond.toMegabytesPerSecond)
            "From megabyte per second to terabits per second", (fun x -> MegabytePerSecond.create x |> MegabytePerSecond.toTerabitsPerSecond |> TerabitPerSecond.toMegabytesPerSecond)
            "From megabyte per second to petabits per second", (fun x -> MegabytePerSecond.create x |> MegabytePerSecond.toPetabitsPerSecond |> PetabitPerSecond.toMegabytesPerSecond)
            "From megabyte per second to bytes per second", (fun x -> MegabytePerSecond.create x |> MegabytePerSecond.toBytesPerSecond |> BytePerSecond.toMegabytesPerSecond)
            "From megabyte per second to kilobytes per second", (fun x -> MegabytePerSecond.create x |> MegabytePerSecond.toKilobytesPerSecond |> KilobytePerSecond.toMegabytesPerSecond)
            "From megabyte per second to gigabytes per second", (fun x -> MegabytePerSecond.create x |> MegabytePerSecond.toGigabytesPerSecond |> GigabytePerSecond.toMegabytesPerSecond)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let gigabytePerSecondConversionTests =
        [
            "From gigabyte per second to baud", (fun x -> GigabytePerSecond.create x |> GigabytePerSecond.toBauds |> Baud.toGigabytesPerSecond)
            "From gigabyte per second to bits per second", (fun x -> GigabytePerSecond.create x |> GigabytePerSecond.toBitsPerSecond |> BitPerSecond.toGigabytesPerSecond)
            "From gigabyte per second to kilobits per second", (fun x -> GigabytePerSecond.create x |> GigabytePerSecond.toKilobitsPerSecond |> KilobitPerSecond.toGigabytesPerSecond)
            "From gigabyte per second to megabits per second", (fun x -> GigabytePerSecond.create x |> GigabytePerSecond.toMegabitsPerSecond |> MegabitPerSecond.toGigabytesPerSecond)
            "From gigabyte per second to gigabits per second", (fun x -> GigabytePerSecond.create x |> GigabytePerSecond.toGigabitsPerSecond |> GigabitPerSecond.toGigabytesPerSecond)
            "From gigabyte per second to terabits per second", (fun x -> GigabytePerSecond.create x |> GigabytePerSecond.toTerabitsPerSecond |> TerabitPerSecond.toGigabytesPerSecond)
            "From gigabyte per second to petabits per second", (fun x -> GigabytePerSecond.create x |> GigabytePerSecond.toPetabitsPerSecond |> PetabitPerSecond.toGigabytesPerSecond)
            "From gigabyte per second to bytes per second", (fun x -> GigabytePerSecond.create x |> GigabytePerSecond.toBytesPerSecond |> BytePerSecond.toGigabytesPerSecond)
            "From gigabyte per second to kilobytes per second", (fun x -> GigabytePerSecond.create x |> GigabytePerSecond.toKilobytesPerSecond |> KilobytePerSecond.toGigabytesPerSecond)
            "From gigabyte per second to megabytes per second", (fun x -> GigabytePerSecond.create x |> GigabytePerSecond.toMegabytesPerSecond |> MegabytePerSecond.toGigabytesPerSecond)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let terabytePerSecondConversionTests =
        [
            "From terabyte per second to baud", (fun x -> TerabytePerSecond.create x |> TerabytePerSecond.toBauds |> Baud.toTerabytesPerSecond)
            "From terabyte per second to bits per second", (fun x -> TerabytePerSecond.create x |> TerabytePerSecond.toBitsPerSecond |> BitPerSecond.toTerabytesPerSecond)
            "From terabyte per second to kilobits per second", (fun x -> TerabytePerSecond.create x |> TerabytePerSecond.toKilobitsPerSecond |> KilobitPerSecond.toTerabytesPerSecond)
            "From terabyte per second to megabits per second", (fun x -> TerabytePerSecond.create x |> TerabytePerSecond.toMegabitsPerSecond |> MegabitPerSecond.toTerabytesPerSecond)
            "From terabyte per second to gigabits per second", (fun x -> TerabytePerSecond.create x |> TerabytePerSecond.toGigabitsPerSecond |> GigabitPerSecond.toTerabytesPerSecond)
            "From terabyte per second to terabits per second", (fun x -> TerabytePerSecond.create x |> TerabytePerSecond.toTerabitsPerSecond |> TerabitPerSecond.toTerabytesPerSecond)
            "From terabyte per second to petabits per second", (fun x -> TerabytePerSecond.create x |> TerabytePerSecond.toPetabitsPerSecond |> PetabitPerSecond.toTerabytesPerSecond)
            "From terabyte per second to bytes per second", (fun x -> TerabytePerSecond.create x |> TerabytePerSecond.toBytesPerSecond |> BytePerSecond.toTerabytesPerSecond)
            "From terabyte per second to kilobytes per second", (fun x -> TerabytePerSecond.create x |> TerabytePerSecond.toKilobytesPerSecond |> KilobytePerSecond.toTerabytesPerSecond)
            "From terabyte per second to megabytes per second", (fun x -> TerabytePerSecond.create x |> TerabytePerSecond.toMegabytesPerSecond |> MegabytePerSecond.toTerabytesPerSecond)
            "From terabyte per second to gigabytes per second", (fun x -> TerabytePerSecond.create x |> TerabytePerSecond.toGigabytesPerSecond |> GigabytePerSecond.toTerabytesPerSecond)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let petabytePerSecondConversionTests =
        [
            "From petabyte per second to baud", (fun x -> PetabytePerSecond.create x |> PetabytePerSecond.toBauds |> Baud.toPetabytesPerSecond)
            "From petabyte per second to bits per second", (fun x -> PetabytePerSecond.create x |> PetabytePerSecond.toBitsPerSecond |> BitPerSecond.toPetabytesPerSecond)
            "From petabyte per second to kilobits per second", (fun x -> PetabytePerSecond.create x |> PetabytePerSecond.toKilobitsPerSecond |> KilobitPerSecond.toPetabytesPerSecond)
            "From petabyte per second to megabits per second", (fun x -> PetabytePerSecond.create x |> PetabytePerSecond.toMegabitsPerSecond |> MegabitPerSecond.toPetabytesPerSecond)
            "From petabyte per second to gigabits per second", (fun x -> PetabytePerSecond.create x |> PetabytePerSecond.toGigabitsPerSecond |> GigabitPerSecond.toPetabytesPerSecond)
            "From petabyte per second to terabits per second", (fun x -> PetabytePerSecond.create x |> PetabytePerSecond.toTerabitsPerSecond |> TerabitPerSecond.toPetabytesPerSecond)
            "From petabyte per second to petabits per second", (fun x -> PetabytePerSecond.create x |> PetabytePerSecond.toPetabitsPerSecond |> PetabitPerSecond.toPetabytesPerSecond)
            "From petabyte per second to bytes per second", (fun x -> PetabytePerSecond.create x |> PetabytePerSecond.toBytesPerSecond |> BytePerSecond.toPetabytesPerSecond)
            "From petabyte per second to kilobytes per second", (fun x -> PetabytePerSecond.create x |> PetabytePerSecond.toKilobytesPerSecond |> KilobytePerSecond.toPetabytesPerSecond)
            "From petabyte per second to megabytes per second", (fun x -> PetabytePerSecond.create x |> PetabytePerSecond.toMegabytesPerSecond |> MegabytePerSecond.toPetabytesPerSecond)
            "From petabyte per second to gigabytes per second", (fun x -> PetabytePerSecond.create x |> PetabytePerSecond.toGigabytesPerSecond |> GigabytePerSecond.toPetabytesPerSecond)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)

    testList "Data transfer rate tests -> " [
        testList "Baud per second conversion tests -> " baudPerSecondConversionTests
        testList "Bit per second conversion tests -> " bitPerSecondConversionTests
        testList "Kilobit per second conversion tests -> " kilobitPerSecondConversionTests
        testList "Megabit per second conversion tests -> " megabitPerSecondConversionTests
        testList "Gigabit per second conversion tests -> " gigabitPerSecondConversionTests
        testList "Terabit per second conversion tests -> " terabitPerSecondConversionTests
        testList "Petabit per second conversion tests -> " petabitPerSecondConversionTests
        testList "Byte per second conversion tests -> " bytePerSecondConversionTests
        testList "Kilobyte per second conversion tests -> " kilobytePerSecondConversionTests
        testList "Megabyte per second conversion tests -> " megabytePerSecondConversionTests
        testList "Gigabyte per second conversion tests -> " gigabytePerSecondConversionTests
        testList "Terabyte per second conversion tests -> " terabytePerSecondConversionTests
        testList "Petabyte per second conversion tests -> " petabytePerSecondConversionTests
    ]
 
[<Tests>]
let densityTests config =
    
    let kilogramPerCubicMeterConversionTests =
        [
            "From kilogram per cubic meter to grams per cubic centimeter", (fun x -> KilogramPerCubicMeter.create x |> KilogramPerCubicMeter.toGramsPerCubicCentimeter |> GramPerCubicCentimeter.toKilogramsPerCubicMeter)
            "From kilogram per cubic meter to pound mass per cubic foot", (fun x -> KilogramPerCubicMeter.create x |> KilogramPerCubicMeter.toPoundMassPerCubicFoot |> PoundMassPerCubicFoot.toKilogramsPerCubicMeter)
            "From kilogram per cubic meter to pound mass per cubic inch", (fun x -> KilogramPerCubicMeter.create x |> KilogramPerCubicMeter.toPoundMassPerCubicInch |> PoundMassPerCubicInch.toKilogramsPerCubicMeter)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let gramPerCubicCentimeterConversionTests =
        [
            "From gram per cubic centimeter to kilogram per cubic meter", (fun x -> GramPerCubicCentimeter.create x |> GramPerCubicCentimeter.toKilogramsPerCubicMeter |> KilogramPerCubicMeter.toGramsPerCubicCentimeter)
            "From gram per cubic centimeter to pound mass per cubic foot", (fun x -> GramPerCubicCentimeter.create x |> GramPerCubicCentimeter.toPoundMassPerCubicFoot |> PoundMassPerCubicFoot.toGramsPerCubicCentimeter)
            "From gram per cubic centimeter to pound mass per cubic inch", (fun x -> GramPerCubicCentimeter.create x |> GramPerCubicCentimeter.toPoundMassPerCubicInch |> PoundMassPerCubicInch.toGramsPerCubicCentimeter)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let poundMassPerCubicFootConversionTests =
        [
            "From pound mass per cubic foot to kilogram per cubic meter", (fun x -> PoundMassPerCubicFoot.create x |> PoundMassPerCubicFoot.toKilogramsPerCubicMeter |> KilogramPerCubicMeter.toPoundMassPerCubicFoot)
            "From pound mass per cubic foot to grams per cubic centimeter", (fun x -> PoundMassPerCubicFoot.create x |> PoundMassPerCubicFoot.toGramsPerCubicCentimeter |> GramPerCubicCentimeter.toPoundMassPerCubicFoot)
            "From pound mass per cubic foot to pound mass per cubic inch", (fun x -> PoundMassPerCubicFoot.create x |> PoundMassPerCubicFoot.toPoundMassPerCubicInch |> PoundMassPerCubicInch.toPoundMassPerCubicFoot)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let poundMassPerCubicInchConversionTests =
        [
            "From pound mass per cubic inch to kilogram per cubic meter", (fun x -> PoundMassPerCubicInch.create x |> PoundMassPerCubicInch.toKilogramsPerCubicMeter |> KilogramPerCubicMeter.toPoundMassPerCubicInch)
            "From pound mass per cubic inch to grams per cubic centimeter", (fun x -> PoundMassPerCubicInch.create x |> PoundMassPerCubicInch.toGramsPerCubicCentimeter |> GramPerCubicCentimeter.toPoundMassPerCubicInch)
            "From pound mass per cubic inch to pound mass per cubic foot", (fun x -> PoundMassPerCubicInch.create x |> PoundMassPerCubicInch.toPoundMassPerCubicFoot |> PoundMassPerCubicFoot.toPoundMassPerCubicInch)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    testList "Density tests -> " [
        testList "Kilogram per cubic meter conversion tests -> " kilogramPerCubicMeterConversionTests
        testList "Gram per cubic centimeter conversion tests -> " gramPerCubicCentimeterConversionTests
        testList "Pound mass per cubic foot conversion tests -> " poundMassPerCubicFootConversionTests
        testList "Pound mass per cubic inch conversion tests -> " poundMassPerCubicInchConversionTests   
    ]
    
[<Tests>]
let pressureTests config =
    
    let pascalConversionTests =
        [
            "From pascal to pounds per square inch", (fun x -> Pascal.create x |> Pascal.toPoundsPerSquareInch |> PoundPerSquareInch.toPascals)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let poundPerSquareInchConversionTests =
        [
            "From pounds per square inch to pascal", (fun x -> PoundPerSquareInch.create x |> PoundPerSquareInch.toPascals |> Pascal.toPoundsPerSquareInch)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    testList "Pressure tests -> " [
        testList "Pascal conversion tests -> " pascalConversionTests
        testList "Pound per square inch conversion tests -> " poundPerSquareInchConversionTests    
    ]
    
[<Tests>]
let powerTests config =
    
    let wattConversionTests =
        [
            "From watt to kilowatt", (fun x -> Watt.create x |> Watt.toKilowatts |> Kilowatt.toWatts)
            "From watt to horsepower", (fun x -> Watt.create x |> Watt.toHorsepower |> Horsepower.toWatts)
            "From watt to tons of refrigeration", (fun x -> Watt.create x |> Watt.toTonsOfRefrigeration |> TonOfRefrigeration.toWatts)         
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let kilowattConversionTests =
        [
            "From kilowatt to watt", (fun x -> Kilowatt.create x |> Kilowatt.toWatts |> Watt.toKilowatts)
            "From kilowatt to horsepower", (fun x -> Kilowatt.create x |> Kilowatt.toHorsepower |> Horsepower.toKilowatts)
            "From kilowatt to tons of refrigeration", (fun x -> Kilowatt.create x |> Kilowatt.toTonsOfRefrigeration |> TonOfRefrigeration.toKilowatts)         
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let horsepowerConversionTests =
        [
            "From horsepower to watt", (fun x -> Horsepower.create x |> Horsepower.toWatts |> Watt.toHorsepower)
            "From horsepower to kiloWatt", (fun x -> Horsepower.create x |> Horsepower.toKilowatts |> Kilowatt.toHorsepower)
            "From horsepower to tons of refrigeration", (fun x -> Horsepower.create x |> Horsepower.toTonsOfRefrigeration |> TonOfRefrigeration.toHorsepower)         
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let tonOfRefrigerationConversionTests =
        [
            "From tons of refrigeration to watt", (fun x -> TonOfRefrigeration.create x |> TonOfRefrigeration.toWatts |> Watt.toTonsOfRefrigeration)
            "From tons of refrigeration to kilowatt", (fun x -> TonOfRefrigeration.create x |> TonOfRefrigeration.toKilowatts |> Kilowatt.toTonsOfRefrigeration)
            "From tons of refrigeration to horsepower", (fun x -> TonOfRefrigeration.create x |> TonOfRefrigeration.toHorsepower |> Horsepower.toTonsOfRefrigeration)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    testList "Power tests -> " [
        testList "Watt conversion tests -> " wattConversionTests
        testList "Kilowatt conversion tests -> " kilowattConversionTests
        testList "Horsepower conversion tests -> " horsepowerConversionTests
        testList "Ton of refrigeration conversion tests -> " tonOfRefrigerationConversionTests   
    ]
    
[<Tests>]
let energyTests config =
    
    let jouleConversionTests =
        [
            "From joule to kilojoule and back", (fun x -> Joule.create x |> Joule.toKilojoules |> Kilojoule.toJoules)
            "From joule to british thermal units and back", (fun x -> Joule.create x |> Joule.toBritishThermalUnits |> BritishThermalUnit.toJoules)
            "From joule to calories and back", (fun x -> Joule.create x |> Joule.toCalories |> Calorie.toJoules)
            "From joule to quads and back", (fun x -> Joule.create x |> Joule.toQuads |> Quad.toJoules)
            "From joule to Qs and back", (fun x -> Joule.create x |> Joule.toQs |> Q.toJoules)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let kilojouleConversionTests =
        [
            "From kilojoule to joule and back", (fun x -> Kilojoule.create x |> Kilojoule.toJoules |> Joule.toKilojoules)
            "From kilojoule to british thermal units and back", (fun x -> Kilojoule.create x |> Kilojoule.toBritishThermalUnits |> BritishThermalUnit.toKilojoules)
            "From kilojoule to calories and back", (fun x -> Kilojoule.create x |> Kilojoule.toCalories |> Calorie.toKilojoules)
            "From kilojoule to quads and back", (fun x -> Kilojoule.create x |> Kilojoule.toQuads |> Quad.toKilojoules)
            "From kilojoule to Qs and back", (fun x -> Kilojoule.create x |> Kilojoule.toQs |> Q.toKilojoules)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let britishThermalUnitConversionTests =
        [
            "From british thermal unit to joule and back", (fun x -> BritishThermalUnit.create x |> BritishThermalUnit.toJoules |> Joule.toBritishThermalUnits)
            "From british thermal unit to kilojoule and back", (fun x -> BritishThermalUnit.create x |> BritishThermalUnit.toKilojoules |> Kilojoule.toBritishThermalUnits)
            "From british thermal unit to calories and back", (fun x -> BritishThermalUnit.create x |> BritishThermalUnit.toCalories |> Calorie.toBritishThermalUnits)
            "From british thermal unit to quads and back", (fun x -> BritishThermalUnit.create x |> BritishThermalUnit.toQuads |> Quad.toBritishThermalUnits)
            "From british thermal unit to Qs and back", (fun x -> BritishThermalUnit.create x |> BritishThermalUnit.toQs |> Q.toBritishThermalUnits)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let calorieConversionTests =
        [
            "From calorie to joule and back", (fun x -> Calorie.create x |> Calorie.toJoules |> Joule.toCalories)
            "From calorie to kilojoule and back", (fun x -> Calorie.create x |> Calorie.toKilojoules |> Kilojoule.toCalories)
            "From calorie to british thermal units and back", (fun x -> Calorie.create x |> Calorie.toBritishThermalUnits |> BritishThermalUnit.toCalories)
            "From calorie to quads and back", (fun x -> Calorie.create x |> Calorie.toQuads |> Quad.toCalories)
            "From calorie to Qs and back", (fun x -> Calorie.create x |> Calorie.toQs |> Q.toCalories)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let quadConversionTests =
        [
            "From quad to joule and back", (fun x -> Quad.create x |> Quad.toJoules |> Joule.toQuads)
            "From quad to kilojoule and back", (fun x -> Quad.create x |> Quad.toKilojoules |> Kilojoule.toQuads)
            "From quad to british thermal units and back", (fun x -> Quad.create x |> Quad.toBritishThermalUnits |> BritishThermalUnit.toQuads)
            "From quad to calories and back", (fun x -> Quad.create x |> Quad.toCalories |> Calorie.toQuads)
            "From quad to Qs and back", (fun x -> Quad.create x |> Quad.toQs |> Q.toQuads)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let qConversionTests =
        [
            "From Q to joule and back", (fun x -> Q.create x |> Q.toJoules |> Joule.toQs)
            "From Q to kilojoule and back", (fun x -> Q.create x |> Q.toKilojoules |> Kilojoule.toQs)
            "From Q to british thermal units and back", (fun x -> Q.create x |> Q.toBritishThermalUnits |> BritishThermalUnit.toQs)
            "From Q to calories and back", (fun x -> Q.create x |> Q.toCalories |> Calorie.toQs)
            "From Q to quads and back", (fun x -> Q.create x |> Q.toQuads |> Quad.toQs)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    testList "Energy tests-> " [
        testList "Joule conversion tests-> " jouleConversionTests
        testList "Kilojoule conversion tests -> " kilojouleConversionTests
        testList "British thermal unit conversion tests -> " britishThermalUnitConversionTests
        testList "Calorie conversion tests -> " calorieConversionTests
        testList "Quad conversion tests -> " quadConversionTests
        testList "Q conversion tests -> " qConversionTests
    ]
    
[<Tests>]
let electricChargeTests config =
    
    let coloumbConversionTests =
        [
            "From coloumb to ampere hours and back", (fun x -> Coloumb.create x |> Coloumb.toAmpereHours |> AmpereHour.toColoumbs)
            "From coloumb to ampere seconds and back", (fun x -> Coloumb.create x |> Coloumb.toAmpereSeconds |> AmpereSecond.toColoumbs)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let ampereHourConversionTests =
        [
            "From ampere hour to coloumbs and back", (fun x -> AmpereHour.create x |> AmpereHour.toColoumbs |> Coloumb.toAmpereHours)
            "From ampere hour to ampere seconds and back", (fun x -> AmpereHour.create x |> AmpereHour.toAmpereSeconds |> AmpereSecond.toAmpereHours)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let ampereSecondConversionTests =
        [
            "From ampere second to coloumbs and back", (fun x -> AmpereSecond.create x |> AmpereSecond.toColoumbs |> Coloumb.toAmpereSeconds)
            "From ampere second to ampere hours and back", (fun x -> AmpereSecond.create x |> AmpereSecond.toAmpereHours |> AmpereHour.toAmpereSeconds)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    testList "Electric charge tests-> " [
        testList "Coloumb conversion tests-> " coloumbConversionTests
        testList "Ampere hour conversion tests -> " ampereHourConversionTests
        testList "Ampere second conversion tests -> " ampereSecondConversionTests    
    ]
    
[<Tests>]
let electromotiveForceTests config =
    
    let microvoltConversionTests =
        [
            "From microvolt to millivolts and back", (fun x -> Microvolt.create x |> Microvolt.toMillivolts |> Millivolt.toMicrovolts)
            "From microvolt to volts and back", (fun x -> Microvolt.create x |> Microvolt.toVolts |> Volt.toMicrovolts)
            "From microvolt to kilovolts and back", (fun x -> Microvolt.create x |> Microvolt.toKilovolts |> Kilovolt.toMicrovolts)
            "From microvolt to megavolts and back", (fun x -> Microvolt.create x |> Microvolt.toMegavolts |> Megavolt.toMicrovolts)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let millivoltConversionTests =
        [
            "From millivolt to microvolts and back", (fun x -> Millivolt.create x |> Millivolt.toMicrovolts |> Microvolt.toMillivolts)
            "From millivolt to volts and back", (fun x -> Millivolt.create x |> Millivolt.toVolts |> Volt.toMillivolts)
            "From millivolt to kilovolts and back", (fun x -> Millivolt.create x |> Millivolt.toKilovolts |> Kilovolt.toMillivolts)
            "From millivolt to megavolts and back", (fun x -> Millivolt.create x |> Millivolt.toMegavolts |> Megavolt.toMillivolts)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let voltConversionTests =
        [
            "From volt to microvolts and back", (fun x -> Volt.create x |> Volt.toMicrovolts |> Microvolt.toVolts)
            "From volt to millivolts and back", (fun x -> Volt.create x |> Volt.toMillivolts |> Millivolt.toVolts)
            "From volt to kilovolts and back", (fun x -> Volt.create x |> Volt.toKilovolts |> Kilovolt.toVolts)
            "From volt to megavolts and back", (fun x -> Volt.create x |> Volt.toMegavolts |> Megavolt.toVolts)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let kilovoltConversionTests =
        [
            "From kilovolt to microvolts and back", (fun x -> Kilovolt.create x |> Kilovolt.toMicrovolts |> Microvolt.toKilovolts)
            "From kilovolt to millivolts and back", (fun x -> Kilovolt.create x |> Kilovolt.toMillivolts |> Millivolt.toKilovolts)
            "From kilovolt to volts and back", (fun x -> Kilovolt.create x |> Kilovolt.toVolts |> Volt.toKilovolts)
            "From kilovolt to megavolts and back", (fun x -> Kilovolt.create x |> Kilovolt.toMegavolts |> Megavolt.toKilovolts)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let megavoltConversionTests =
        [
            "From megavolt to microvolts and back", (fun x -> Megavolt.create x |> Megavolt.toMicrovolts |> Microvolt.toMegavolts)
            "From megavolt to millivolts and back", (fun x -> Megavolt.create x |> Megavolt.toMillivolts |> Millivolt.toMegavolts)
            "From megavolt to volts and back", (fun x -> Megavolt.create x |> Megavolt.toVolts |> Volt.toMegavolts)
            "From megavolt to kilovolts and back", (fun x -> Megavolt.create x |> Megavolt.toKilovolts |> Kilovolt.toMegavolts)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    testList "Electromotive force tests-> " [
        testList "Microvolt conversion tests-> " microvoltConversionTests
        testList "Millivolt conversion tests -> " millivoltConversionTests
        testList "Volt conversion tests -> " voltConversionTests
        testList "Kilovolt conversion tests -> " kilovoltConversionTests
        testList "Megavolt conversion tests -> " megavoltConversionTests    
    ]
    
[<Tests>]
let inductanceTests config =
    
    let microHenryConversionTest =
        [
            "From micro Henry to milli Henry and back", (fun x -> MicroHenry.create x |> MicroHenry.toMilliHenrys |> MilliHenry.toMicroHenrys)
            "From micro Henry to Henry and back", (fun x -> MicroHenry.create x |> MicroHenry.toHenrys |> Henry.toMicroHenrys)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let milliHenryConversionTest =
        [
            "From milli Henry to micro Henry and back", (fun x -> MilliHenry.create x |> MilliHenry.toMicroHenrys |> MicroHenry.toMilliHenrys)
            "From milli Henry to Henry and back", (fun x -> MilliHenry.create x |> MilliHenry.toHenrys |> Henry.toMilliHenrys)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let henryConversionTest =
        [
            "From Henry to micro Henry and back", (fun x -> Henry.create x |> Henry.toMicroHenrys |> MicroHenry.toHenrys)
            "From Henry to milli Henry and back", (fun x -> Henry.create x |> Henry.toMilliHenrys |> MilliHenry.toHenrys)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    testList "Inductance tests-> " [
        testList "MicroHenry conversion tests-> " microHenryConversionTest
        testList "MilliHenry conversion tests -> " milliHenryConversionTest
        testList "Henry conversion tests -> " henryConversionTest     
    ]