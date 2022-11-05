module LengthTests

open Expecto
open Fs.Units.Length
open Helpers

[<Tests>]
let tests config =
    let inchConversionTests =
        [
            "From inch to feet and back", (fun x -> Inch.create x |> Inch.toFeet |> Foot.toInches)
            "From inch to yard and back", (fun x -> Inch.create x |> Inch.toYards |> Yard.toInches)
            "From inch to mile and back", (fun x -> Inch.create x |> Inch.toMiles |> Mile.toInches)
            "From inch to millimeter and back", (fun x -> Inch.create x |> Inch.toMillimeters |> Millimeter.toInches)
            "From inch to centimeter and back", (fun x -> Inch.create x |> Inch.toCentimeters |> Centimeter.toInches)
            "From inch to meter and back", (fun x -> Inch.create x |> Inch.toMeters |> Meter.toInches)
            "From inch to kilometer and back", (fun x -> Inch.create x |> Inch.toKilometers |> Kilometer.toInches)
            "From inch to nautical mile and back", (fun x -> Inch.create x |> Inch.toNauticalMiles |> NauticalMile.toInches)
            "From inch to chain and back", (fun x -> Inch.create x |> Inch.toChains |> Chain.toInches)
            "From inch to furlong and back", (fun x -> Inch.create x |> Inch.toFurlongs |> Furlong.toInches)
            "From inch to league and back", (fun x -> Inch.create x |> Inch.toLeagues |> League.toInches)
            "From inch to hand and back", (fun x -> Inch.create x |> Inch.toHands |> Hand.toInches)
            "From inch to rod and back", (fun x -> Inch.create x |> Inch.toRods |> Rod.toInches)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
       
    let footConversionTests =
        [
            "From foot to inches and back", (fun x -> Foot.create x |> Foot.toInches |> Inch.toFeet)
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
            "From foot to rod and back", (fun x -> Foot.create x |> Foot.toRods |> Rod.toFeet)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let yardConversionTests =
        [
            "From yard to inches and back", (fun x -> Yard.create x |> Yard.toInches |> Inch.toYards)
            "From yard to foot and back", (fun x -> Yard.create x |> Yard.toFeet |> Foot.toYards)
            "From yard to mile and back", (fun x -> Yard.create x |> Yard.toMiles |> Mile.toYards)
            "From yard to millimeter and back", (fun x -> Yard.create x |> Yard.toMillimeters |> Millimeter.toYards)
            "From yard to centimeter and back", (fun x -> Yard.create x |> Yard.toCentimeters |> Centimeter.toYards)
            "From yard to meter and back", (fun x -> Yard.create x |> Yard.toMeters |> Meter.toYards)
            "From yard to kilometer and back", (fun x -> Yard.create x |> Yard.toKilometers |> Kilometer.toYards)
            "From yard to nautical mile and back", (fun x -> Yard.create x |> Yard.toNauticalMiles |> NauticalMile.toYards)
            "From yard to chain and back", (fun x -> Yard.create x |> Yard.toChains |> Chain.toYards)
            "From yard to furlong and back", (fun x -> Yard.create x |> Yard.toFurlongs |> Furlong.toYards)
            "From yard to league and back", (fun x -> Yard.create x |> Yard.toLeagues |> League.toYards)
            "From yard to hand and back", (fun x -> Yard.create x |> Yard.toHands |> Hand.toYards)
            "From yard to rod and back", (fun x -> Yard.create x |> Yard.toRods |> Rod.toYards)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let mileConversionTests =
        [
            "From mile to inches and back", (fun x -> Mile.create x |> Mile.toInches |> Inch.toMiles)
            "From mile to foot and back", (fun x -> Mile.create x |> Mile.toFeet |> Foot.toMiles)
            "From mile to yard and back", (fun x -> Mile.create x |> Mile.toYards |> Yard.toMiles)
            "From mile to millimeter and back", (fun x -> Mile.create x |> Mile.toMillimeters |> Millimeter.toMiles)
            "From mile to centimeter and back", (fun x -> Mile.create x |> Mile.toCentimeters |> Centimeter.toMiles)
            "From mile to meter and back", (fun x -> Mile.create x |> Mile.toMeters |> Meter.toMiles)
            "From mile to kilometer and back", (fun x -> Mile.create x |> Mile.toKilometers |> Kilometer.toMiles)
            "From mile to nautical mile and back", (fun x -> Mile.create x |> Mile.toNauticalMiles |> NauticalMile.toMiles)
            "From mile to chain and back", (fun x -> Mile.create x |> Mile.toChains |> Chain.toMiles)
            "From mile to furlong and back", (fun x -> Mile.create x |> Mile.toFurlongs |> Furlong.toMiles)
            "From mile to league and back", (fun x -> Mile.create x |> Mile.toLeagues |> League.toMiles)
            "From mile to hand and back", (fun x -> Mile.create x |> Mile.toHands |> Hand.toMiles)
            "From mile to rod and back", (fun x -> Mile.create x |> Mile.toRods |> Rod.toMiles)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let millimeterConversionTests =
        [
            "From millimeter to inches and back", (fun x -> Millimeter.create x |> Millimeter.toInches |> Inch.toMillimeters)
            "From millimeter to foot and back", (fun x -> Millimeter.create x |> Millimeter.toFeet |> Foot.toMillimeters)
            "From millimeter to yard and back", (fun x -> Millimeter.create x |> Millimeter.toYards |> Yard.toMillimeters)
            "From millimeter to mile and back", (fun x -> Millimeter.create x |> Millimeter.toMiles |> Mile.toMillimeters)
            "From millimeter to centimeter and back", (fun x -> Millimeter.create x |> Millimeter.toCentimeters |> Centimeter.toMillimeters)
            "From millimeter to meter and back", (fun x -> Millimeter.create x |> Millimeter.toMeters |> Meter.toMillimeters)
            "From millimeter to kilometer and back", (fun x -> Millimeter.create x |> Millimeter.toKilometers |> Kilometer.toMillimeters)
            "From millimeter to nautical mile and back", (fun x -> Millimeter.create x |> Millimeter.toNauticalMiles |> NauticalMile.toMillimeters)
            "From millimeter to chain and back", (fun x -> Millimeter.create x |> Millimeter.toChains |> Chain.toMillimeters)
            "From millimeter to furlong and back", (fun x -> Millimeter.create x |> Millimeter.toFurlongs |> Furlong.toMillimeters)
            "From millimeter to league and back", (fun x -> Millimeter.create x |> Millimeter.toLeagues |> League.toMillimeters)
            "From millimeter to hand and back", (fun x -> Millimeter.create x |> Millimeter.toHands |> Hand.toMillimeters)
            "From millimeter to rod and back", (fun x -> Millimeter.create x |> Millimeter.toRods |> Rod.toMillimeters)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let centimeterConversionTests =
        [
            "From centimeter to inches and back", (fun x -> Centimeter.create x |> Centimeter.toInches |> Inch.toCentimeters)
            "From centimeter to foot and back", (fun x -> Centimeter.create x |> Centimeter.toFeet |> Foot.toCentimeters)
            "From centimeter to yard and back", (fun x -> Centimeter.create x |> Centimeter.toYards |> Yard.toCentimeters)
            "From centimeter to mile and back", (fun x -> Centimeter.create x |> Centimeter.toMiles |> Mile.toCentimeters)
            "From centimeter to millimeter and back", (fun x -> Centimeter.create x |> Centimeter.toMillimeters |> Millimeter.toCentimeters)
            "From centimeter to meter and back", (fun x -> Centimeter.create x |> Centimeter.toMeters |> Meter.toCentimeters)
            "From centimeter to kilometer and back", (fun x -> Centimeter.create x |> Centimeter.toKilometers |> Kilometer.toCentimeters)
            "From centimeter to nautical mile and back", (fun x -> Centimeter.create x |> Centimeter.toNauticalMiles |> NauticalMile.toCentimeters)
            "From centimeter to chain and back", (fun x -> Centimeter.create x |> Centimeter.toChains |> Chain.toCentimeters)
            "From centimeter to furlong and back", (fun x -> Centimeter.create x |> Centimeter.toFurlongs |> Furlong.toCentimeters)
            "From centimeter to league and back", (fun x -> Centimeter.create x |> Centimeter.toLeagues |> League.toCentimeters)
            "From centimeter to hand and back", (fun x -> Centimeter.create x |> Centimeter.toHands |> Hand.toCentimeters)
            "From centimeter to rod and back", (fun x -> Centimeter.create x |> Centimeter.toRods |> Rod.toCentimeters)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let meterConversionTests =
        [
            "From meter to inches and back", (fun x -> Meter.create x |> Meter.toInches |> Inch.toMeters)
            "From meter to foot and back", (fun x -> Meter.create x |> Meter.toFeet |> Foot.toMeters)
            "From meter to yard and back", (fun x -> Meter.create x |> Meter.toYards |> Yard.toMeters)
            "From meter to mile and back", (fun x -> Meter.create x |> Meter.toMiles |> Mile.toMeters)
            "From meter to millimeter and back", (fun x -> Meter.create x |> Meter.toMillimeters |> Millimeter.toMeters)
            "From meter to centimeter and back", (fun x -> Meter.create x |> Meter.toCentimeters |> Centimeter.toMeters)
            "From meter to kilometer and back", (fun x -> Meter.create x |> Meter.toKilometers |> Kilometer.toMeters)
            "From meter to nautical mile and back", (fun x -> Meter.create x |> Meter.toNauticalMiles |> NauticalMile.toMeters)
            "From meter to chain and back", (fun x -> Meter.create x |> Meter.toChains |> Chain.toMeters)
            "From meter to furlong and back", (fun x -> Meter.create x |> Meter.toFurlongs |> Furlong.toMeters)
            "From meter to league and back", (fun x -> Meter.create x |> Meter.toLeagues |> League.toMeters)
            "From meter to hand and back", (fun x -> Meter.create x |> Meter.toHands |> Hand.toMeters)
            "From meter to rod and back", (fun x -> Meter.create x |> Meter.toRods |> Rod.toMeters)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let kilometerConversionTests =
        [
            "From kilometer to inches and back", (fun x -> Kilometer.create x |> Kilometer.toInches |> Inch.toKilometers)
            "From kilometer to foot and back", (fun x -> Kilometer.create x |> Kilometer.toFeet |> Foot.toKilometers)
            "From kilometer to yard and back", (fun x -> Kilometer.create x |> Kilometer.toYards |> Yard.toKilometers)
            "From kilometer to mile and back", (fun x -> Kilometer.create x |> Kilometer.toMiles |> Mile.toKilometers)
            "From kilometer to millimeter and back", (fun x -> Kilometer.create x |> Kilometer.toMillimeters |> Millimeter.toKilometers)
            "From kilometer to centimeter and back", (fun x -> Kilometer.create x |> Kilometer.toCentimeters |> Centimeter.toKilometers)
            "From kilometer to meter and back", (fun x -> Kilometer.create x |> Kilometer.toMeters |> Meter.toKilometers)
            "From kilometer to nautical mile and back", (fun x -> Kilometer.create x |> Kilometer.toNauticalMiles |> NauticalMile.toKilometers)
            "From kilometer to chain and back", (fun x -> Kilometer.create x |> Kilometer.toChains |> Chain.toKilometers)
            "From kilometer to furlong and back", (fun x -> Kilometer.create x |> Kilometer.toFurlongs |> Furlong.toKilometers)
            "From kilometer to league and back", (fun x -> Kilometer.create x |> Kilometer.toLeagues |> League.toKilometers)
            "From kilometer to hand and back", (fun x -> Kilometer.create x |> Kilometer.toHands |> Hand.toKilometers)
            "From kilometer to rod and back", (fun x -> Kilometer.create x |> Kilometer.toRods |> Rod.toKilometers)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let nauticalMileConversionTests =
        [
            "From nautical mile to inches and back", (fun x -> NauticalMile.create x |> NauticalMile.toInches |> Inch.toNauticalMiles)
            "From nautical mile to foot and back", (fun x -> NauticalMile.create x |> NauticalMile.toFeet |> Foot.toNauticalMiles)
            "From nautical mile to yard and back", (fun x -> NauticalMile.create x |> NauticalMile.toYards |> Yard.toNauticalMiles)
            "From nautical mile to mile and back", (fun x -> NauticalMile.create x |> NauticalMile.toMiles |> Mile.toNauticalMiles)
            "From nautical mile to millimeter and back", (fun x -> NauticalMile.create x |> NauticalMile.toMillimeters |> Millimeter.toNauticalMiles)
            "From nautical mile to centimeter and back", (fun x -> NauticalMile.create x |> NauticalMile.toCentimeters |> Centimeter.toNauticalMiles)
            "From nautical mile to meter and back", (fun x -> NauticalMile.create x |> NauticalMile.toMeters |> Meter.toNauticalMiles)
            "From nautical mile to kilometer and back", (fun x -> NauticalMile.create x |> NauticalMile.toKilometers |> Kilometer.toNauticalMiles)
            "From nautical mile to chain and back", (fun x -> NauticalMile.create x |> NauticalMile.toChains |> Chain.toNauticalMiles)
            "From nautical mile to furlong and back", (fun x -> NauticalMile.create x |> NauticalMile.toFurlongs |> Furlong.toNauticalMiles)
            "From nautical mile to league and back", (fun x -> NauticalMile.create x |> NauticalMile.toLeagues |> League.toNauticalMiles)
            "From nautical mile to hand and back", (fun x -> NauticalMile.create x |> NauticalMile.toHands |> Hand.toNauticalMiles)
            "From nautical mile to rod and back", (fun x -> NauticalMile.create x |> NauticalMile.toRods |> Rod.toNauticalMiles)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let chainConversionTests =
        [
            "From chain to inches and back", (fun x -> Chain.create x |> Chain.toInches |> Inch.toChains)
            "From chain to foot and back", (fun x -> Chain.create x |> Chain.toFeet |> Foot.toChains)
            "From chain to yard and back", (fun x -> Chain.create x |> Chain.toYards |> Yard.toChains)
            "From chain to mile and back", (fun x -> Chain.create x |> Chain.toMiles |> Mile.toChains)
            "From chain to millimeter and back", (fun x -> Chain.create x |> Chain.toMillimeters |> Millimeter.toChains)
            "From chain to centimeter and back", (fun x -> Chain.create x |> Chain.toCentimeters |> Centimeter.toChains)
            "From chain to meter and back", (fun x -> Chain.create x |> Chain.toMeters |> Meter.toChains)
            "From chain to kilometer and back", (fun x -> Chain.create x |> Chain.toKilometers |> Kilometer.toChains)
            "From chain to nautical mile and back", (fun x -> Chain.create x |> Chain.toNauticalMiles |> NauticalMile.toChains)
            "From chain to furlong and back", (fun x -> Chain.create x |> Chain.toFurlongs |> Furlong.toChains)
            "From chain to league and back", (fun x -> Chain.create x |> Chain.toLeagues |> League.toChains)
            "From chain to hand and back", (fun x -> Chain.create x |> Chain.toHands |> Hand.toChains)
            "From chain to rod and back", (fun x -> Chain.create x |> Chain.toRods |> Rod.toChains)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let furlongConversionTests =
        [
            "From furlong to inches and back", (fun x -> Furlong.create x |> Furlong.toInches |> Inch.toFurlongs)
            "From furlong to foot and back", (fun x -> Furlong.create x |> Furlong.toFeet |> Foot.toFurlongs)
            "From furlong to yard and back", (fun x -> Furlong.create x |> Furlong.toYards |> Yard.toFurlongs)
            "From furlong to mile and back", (fun x -> Furlong.create x |> Furlong.toMiles |> Mile.toFurlongs)
            "From furlong to millimeter and back", (fun x -> Furlong.create x |> Furlong.toMillimeters |> Millimeter.toFurlongs)
            "From furlong to centimeter and back", (fun x -> Furlong.create x |> Furlong.toCentimeters |> Centimeter.toFurlongs)
            "From furlong to meter and back", (fun x -> Furlong.create x |> Furlong.toMeters |> Meter.toFurlongs)
            "From furlong to kilometer and back", (fun x -> Furlong.create x |> Furlong.toKilometers |> Kilometer.toFurlongs)
            "From furlong to nautical mile and back", (fun x -> Furlong.create x |> Furlong.toNauticalMiles |> NauticalMile.toFurlongs)
            "From furlong to chain and back", (fun x -> Furlong.create x |> Furlong.toChains |> Chain.toFurlongs)
            "From furlong to league and back", (fun x -> Furlong.create x |> Furlong.toLeagues |> League.toFurlongs)
            "From furlong to hand and back", (fun x -> Furlong.create x |> Furlong.toHands |> Hand.toFurlongs)
            "From furlong to rod and back", (fun x -> Furlong.create x |> Furlong.toRods |> Rod.toFurlongs)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let leagueConversionTests =
        [
            "From league to inches and back", (fun x -> League.create x |> League.toInches |> Inch.toLeagues)
            "From league to foot and back", (fun x -> League.create x |> League.toFeet |> Foot.toLeagues)
            "From league to yard and back", (fun x -> League.create x |> League.toYards |> Yard.toLeagues)
            "From league to mile and back", (fun x -> League.create x |> League.toMiles |> Mile.toLeagues)
            "From league to millimeter and back", (fun x -> League.create x |> League.toMillimeters |> Millimeter.toLeagues)
            "From league to centimeter and back", (fun x -> League.create x |> League.toCentimeters |> Centimeter.toLeagues)
            "From league to meter and back", (fun x -> League.create x |> League.toMeters |> Meter.toLeagues)
            "From league to kilometer and back", (fun x -> League.create x |> League.toKilometers |> Kilometer.toLeagues)
            "From league to nautical mile and back", (fun x -> League.create x |> League.toNauticalMiles |> NauticalMile.toLeagues)
            "From league to chain and back", (fun x -> League.create x |> League.toChains |> Chain.toLeagues)
            "From league to furlong and back", (fun x -> League.create x |> League.toFurlongs |> Furlong.toLeagues)
            "From league to hand and back", (fun x -> League.create x |> League.toHands |> Hand.toLeagues)
            "From league to rod and back", (fun x -> League.create x |> League.toRods |> Rod.toLeagues)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let handConversionTests =
        [
            "From hand to inches and back", (fun x -> Hand.create x |> Hand.toInches |> Inch.toHands)
            "From hand to foot and back", (fun x -> Hand.create x |> Hand.toFeet |> Foot.toHands)
            "From hand to yard and back", (fun x -> Hand.create x |> Hand.toYards |> Yard.toHands)
            "From hand to mile and back", (fun x -> Hand.create x |> Hand.toMiles |> Mile.toHands)
            "From hand to millimeter and back", (fun x -> Hand.create x |> Hand.toMillimeters |> Millimeter.toHands)
            "From hand to centimeter and back", (fun x -> Hand.create x |> Hand.toCentimeters |> Centimeter.toHands)
            "From hand to meter and back", (fun x -> Hand.create x |> Hand.toMeters |> Meter.toHands)
            "From hand to kilometer and back", (fun x -> Hand.create x |> Hand.toKilometers |> Kilometer.toHands)
            "From hand to nautical mile and back", (fun x -> Hand.create x |> Hand.toNauticalMiles |> NauticalMile.toHands)
            "From hand to chain and back", (fun x -> Hand.create x |> Hand.toChains |> Chain.toHands)
            "From hand to furlong and back", (fun x -> Hand.create x |> Hand.toFurlongs |> Furlong.toHands)
            "From hand to league and back", (fun x -> Hand.create x |> Hand.toLeagues |> League.toHands)
            "From hand to rod and back", (fun x -> Hand.create x |> Hand.toRods |> Rod.toHands)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let rodConversionTests =
        [
            "From rod to inches and back", (fun x -> Rod.create x |> Rod.toInches |> Inch.toRods)
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
            "From rod to hand and back", (fun x -> Rod.create x |> Rod.toHands |> Hand.toRods)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
    
    testList "Length Tests -> " [
        testList "Convert inch to other and back -> " inchConversionTests
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
        testList "Convert rod to other and back -> " rodConversionTests
    ]
    