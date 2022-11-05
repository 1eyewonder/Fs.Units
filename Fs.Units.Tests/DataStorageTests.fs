module DataStorageTests

open Expecto
open Fs.Units.DataStorage
open Helpers

[<Tests>]
let tests config =

    let bitConversionTests =
        [
            "From bit to kilobit and back", (fun x -> Bit.create x |> Bit.toKilobits |> Kilobit.toBits)
            "From bit to megabit and back", (fun x -> Bit.create x |> Bit.toMegabits |> Megabit.toBits)
            "From bit to gigabit and back", (fun x -> Bit.create x |> Bit.toGigabits |> Gigabit.toBits)
            "From bit to terabit and back", (fun x -> Bit.create x |> Bit.toTerabits |> Terabit.toBits)
            "From bit to petabit and back", (fun x -> Bit.create x |> Bit.toPetabits |> Petabit.toBits)
            "From bit to byte and back", (fun x -> Bit.create x |> Bit.toBytes |> Byte.toBits)
            "From bit to kilobyte and back", (fun x -> Bit.create x |> Bit.toKilobytes |> Kilobyte.toBits)
            "From bit to megabyte and back", (fun x -> Bit.create x |> Bit.toMegabytes |> Megabyte.toBits)
            "From bit to gigabyte and back", (fun x -> Bit.create x |> Bit.toGigabytes |> Gigabyte.toBits)
            "From bit to terabyte and back", (fun x -> Bit.create x |> Bit.toTerabytes |> Terabyte.toBits)
            "From bit to petabyte and back", (fun x -> Bit.create x |> Bit.toPetabytes |> Petabyte.toBits)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let kilobitConversionTests =
        [
            "From kilobit to bit and back", (fun x -> Kilobit.create x |> Kilobit.toBits |> Bit.toKilobits)
            "From kilobit to megabit and back", (fun x -> Kilobit.create x |> Kilobit.toMegabits |> Megabit.toKilobits)
            "From kilobit to gigabit and back", (fun x -> Kilobit.create x |> Kilobit.toGigabits |> Gigabit.toKilobits)
            "From kilobit to terabit and back", (fun x -> Kilobit.create x |> Kilobit.toTerabits |> Terabit.toKilobits)
            "From kilobit to petabit and back", (fun x -> Kilobit.create x |> Kilobit.toPetabits |> Petabit.toKilobits)
            "From kilobit to byte and back", (fun x -> Kilobit.create x |> Kilobit.toBytes |> Byte.toKilobits)
            "From kilobit to kilobyte and back", (fun x -> Kilobit.create x |> Kilobit.toKilobytes |> Kilobyte.toKilobits)
            "From kilobit to megabyte and back", (fun x -> Kilobit.create x |> Kilobit.toMegabytes |> Megabyte.toKilobits)
            "From kilobit to gigabyte and back", (fun x -> Kilobit.create x |> Kilobit.toGigabytes |> Gigabyte.toKilobits)
            "From kilobit to terabyte and back", (fun x -> Kilobit.create x |> Kilobit.toTerabytes |> Terabyte.toKilobits)
            "From kilobit to petabyte and back", (fun x -> Kilobit.create x |> Kilobit.toPetabytes |> Petabyte.toKilobits)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let megabitConversionTests =
        [
            "From megabit to bit and back", (fun x -> Megabit.create x |> Megabit.toBits |> Bit.toMegabits)
            "From megabit to kilobit and back", (fun x -> Megabit.create x |> Megabit.toKilobits |> Kilobit.toMegabits)
            "From megabit to gigabit and back", (fun x -> Megabit.create x |> Megabit.toGigabits |> Gigabit.toMegabits)
            "From megabit to terabit and back", (fun x -> Megabit.create x |> Megabit.toTerabits |> Terabit.toMegabits)
            "From megabit to petabit and back", (fun x -> Megabit.create x |> Megabit.toPetabits |> Petabit.toMegabits)
            "From megabit to byte and back", (fun x -> Megabit.create x |> Megabit.toBytes |> Byte.toMegabits)
            "From megabit to kilobyte and back", (fun x -> Megabit.create x |> Megabit.toKilobytes |> Kilobyte.toMegabits)
            "From megabit to megabyte and back", (fun x -> Megabit.create x |> Megabit.toMegabytes |> Megabyte.toMegabits)
            "From megabit to gigabyte and back", (fun x -> Megabit.create x |> Megabit.toGigabytes |> Gigabyte.toMegabits)
            "From megabit to terabyte and back", (fun x -> Megabit.create x |> Megabit.toTerabytes |> Terabyte.toMegabits)
            "From megabit to petabyte and back", (fun x -> Megabit.create x |> Megabit.toPetabytes |> Petabyte.toMegabits)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let gigabitConversionTests =
        [
            "From gigabit to bit and back", (fun x -> Gigabit.create x |> Gigabit.toBits |> Bit.toGigabits)
            "From gigabit to kilobit and back", (fun x -> Gigabit.create x |> Gigabit.toKilobits |> Kilobit.toGigabits)
            "From gigabit to megabit and back", (fun x -> Gigabit.create x |> Gigabit.toMegabits |> Megabit.toGigabits)
            "From gigabit to terabit and back", (fun x -> Gigabit.create x |> Gigabit.toTerabits |> Terabit.toGigabits)
            "From gigabit to petabit and back", (fun x -> Gigabit.create x |> Gigabit.toPetabits |> Petabit.toGigabits)
            "From gigabit to byte and back", (fun x -> Gigabit.create x |> Gigabit.toBytes |> Byte.toGigabits)
            "From gigabit to kilobyte and back", (fun x -> Gigabit.create x |> Gigabit.toKilobytes |> Kilobyte.toGigabits)
            "From gigabit to megabyte and back", (fun x -> Gigabit.create x |> Gigabit.toMegabytes |> Megabyte.toGigabits)
            "From gigabit to gigabyte and back", (fun x -> Gigabit.create x |> Gigabit.toGigabytes |> Gigabyte.toGigabits)
            "From gigabit to terabyte and back", (fun x -> Gigabit.create x |> Gigabit.toTerabytes |> Terabyte.toGigabits)
            "From gigabit to petabyte and back", (fun x -> Gigabit.create x |> Gigabit.toPetabytes |> Petabyte.toGigabits)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let terabitConversionTests =
        [
            "From terabit to bit and back", (fun x -> Terabit.create x |> Terabit.toBits |> Bit.toTerabits)
            "From terabit to kilobit and back", (fun x -> Terabit.create x |> Terabit.toKilobits |> Kilobit.toTerabits)
            "From terabit to megabit and back", (fun x -> Terabit.create x |> Terabit.toMegabits |> Megabit.toTerabits)
            "From terabit to gigabit and back", (fun x -> Terabit.create x |> Terabit.toGigabits |> Gigabit.toTerabits)
            "From terabit to petabit and back", (fun x -> Terabit.create x |> Terabit.toPetabits |> Petabit.toTerabits)
            "From terabit to byte and back", (fun x -> Terabit.create x |> Terabit.toBytes |> Byte.toTerabits)
            "From terabit to kilobyte and back", (fun x -> Terabit.create x |> Terabit.toKilobytes |> Kilobyte.toTerabits)
            "From terabit to megabyte and back", (fun x -> Terabit.create x |> Terabit.toMegabytes |> Megabyte.toTerabits)
            "From terabit to gigabyte and back", (fun x -> Terabit.create x |> Terabit.toGigabytes |> Gigabyte.toTerabits)
            "From terabit to terabyte and back", (fun x -> Terabit.create x |> Terabit.toTerabytes |> Terabyte.toTerabits)
            "From terabit to petabyte and back", (fun x -> Terabit.create x |> Terabit.toPetabytes |> Petabyte.toTerabits)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let petabitConversionTests =
        [
            "From petabit to bit and back", (fun x -> Petabit.create x |> Petabit.toBits |> Bit.toPetabits)
            "From petabit to kilobit and back", (fun x -> Petabit.create x |> Petabit.toKilobits |> Kilobit.toPetabits)
            "From petabit to megabit and back", (fun x -> Petabit.create x |> Petabit.toMegabits |> Megabit.toPetabits)
            "From petabit to gigabit and back", (fun x -> Petabit.create x |> Petabit.toGigabits |> Gigabit.toPetabits)
            "From petabit to terabit and back", (fun x -> Petabit.create x |> Petabit.toTerabits |> Terabit.toPetabits)
            "From petabit to byte and back", (fun x -> Petabit.create x |> Petabit.toBytes |> Byte.toPetabits)
            "From petabit to kilobyte and back", (fun x -> Petabit.create x |> Petabit.toKilobytes |> Kilobyte.toPetabits)
            "From petabit to megabyte and back", (fun x -> Petabit.create x |> Petabit.toMegabytes |> Megabyte.toPetabits)
            "From petabit to gigabyte and back", (fun x -> Petabit.create x |> Petabit.toGigabytes |> Gigabyte.toPetabits)
            "From petabit to terabyte and back", (fun x -> Petabit.create x |> Petabit.toTerabytes |> Terabyte.toPetabits)
            "From petabit to petabyte and back", (fun x -> Petabit.create x |> Petabit.toPetabytes |> Petabyte.toPetabits)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let byteConversionTests =
        [
            "From byte to bit and back", (fun x -> Byte.create x |> Byte.toBits |> Bit.toBytes)
            "From byte to kilobit and back", (fun x -> Byte.create x |> Byte.toKilobits |> Kilobit.toBytes)
            "From byte to megabit and back", (fun x -> Byte.create x |> Byte.toMegabits |> Megabit.toBytes)
            "From byte to gigabit and back", (fun x -> Byte.create x |> Byte.toGigabits |> Gigabit.toBytes)
            "From byte to terabit and back", (fun x -> Byte.create x |> Byte.toTerabits |> Terabit.toBytes)
            "From byte to petabit and back", (fun x -> Byte.create x |> Byte.toPetabits |> Petabit.toBytes)
            "From byte to kilobyte and back", (fun x -> Byte.create x |> Byte.toKilobytes |> Kilobyte.toBytes)
            "From byte to megabyte and back", (fun x -> Byte.create x |> Byte.toMegabytes |> Megabyte.toBytes)
            "From byte to gigabyte and back", (fun x -> Byte.create x |> Byte.toGigabytes |> Gigabyte.toBytes)
            "From byte to terabyte and back", (fun x -> Byte.create x |> Byte.toTerabytes |> Terabyte.toBytes)
            "From byte to petabyte and back", (fun x -> Byte.create x |> Byte.toPetabytes |> Petabyte.toBytes)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let kilobyteConversionTests =
        [
            "From kilobyte to bit and back", (fun x -> Kilobyte.create x |> Kilobyte.toBits |> Bit.toKilobytes)
            "From kilobyte to kilobit and back", (fun x -> Kilobyte.create x |> Kilobyte.toKilobits |> Kilobit.toKilobytes)
            "From kilobyte to megabit and back", (fun x -> Kilobyte.create x |> Kilobyte.toMegabits |> Megabit.toKilobytes)
            "From kilobyte to gigabit and back", (fun x -> Kilobyte.create x |> Kilobyte.toGigabits |> Gigabit.toKilobytes)
            "From kilobyte to terabit and back", (fun x -> Kilobyte.create x |> Kilobyte.toTerabits |> Terabit.toKilobytes)
            "From kilobyte to petabit and back", (fun x -> Kilobyte.create x |> Kilobyte.toPetabits |> Petabit.toKilobytes)
            "From kilobyte to byte and back", (fun x -> Kilobyte.create x |> Kilobyte.toBytes |> Byte.toKilobytes)
            "From kilobyte to megabyte and back", (fun x -> Kilobyte.create x |> Kilobyte.toMegabytes |> Megabyte.toKilobytes)
            "From kilobyte to gigabyte and back", (fun x -> Kilobyte.create x |> Kilobyte.toGigabytes |> Gigabyte.toKilobytes)
            "From kilobyte to terabyte and back", (fun x -> Kilobyte.create x |> Kilobyte.toTerabytes |> Terabyte.toKilobytes)
            "From kilobyte to petabyte and back", (fun x -> Kilobyte.create x |> Kilobyte.toPetabytes |> Petabyte.toKilobytes)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let megabyteConversionTests =
        [
            "From megabyte to bit and back", (fun x -> Megabyte.create x |> Megabyte.toBits |> Bit.toMegabytes)
            "From megabyte to kilobit and back", (fun x -> Megabyte.create x |> Megabyte.toKilobits |> Kilobit.toMegabytes)
            "From megabyte to megabit and back", (fun x -> Megabyte.create x |> Megabyte.toMegabits |> Megabit.toMegabytes)
            "From megabyte to gigabit and back", (fun x -> Megabyte.create x |> Megabyte.toGigabits |> Gigabit.toMegabytes)
            "From megabyte to terabit and back", (fun x -> Megabyte.create x |> Megabyte.toTerabits |> Terabit.toMegabytes)
            "From megabyte to petabit and back", (fun x -> Megabyte.create x |> Megabyte.toPetabits |> Petabit.toMegabytes)
            "From megabyte to byte and back", (fun x -> Megabyte.create x |> Megabyte.toBytes |> Byte.toMegabytes)
            "From megabyte to kilobyte and back", (fun x -> Megabyte.create x |> Megabyte.toKilobytes |> Kilobyte.toMegabytes)
            "From megabyte to gigabyte and back", (fun x -> Megabyte.create x |> Megabyte.toGigabytes |> Gigabyte.toMegabytes)
            "From megabyte to terabyte and back", (fun x -> Megabyte.create x |> Megabyte.toTerabytes |> Terabyte.toMegabytes)
            "From megabyte to petabyte and back", (fun x -> Megabyte.create x |> Megabyte.toPetabytes |> Petabyte.toMegabytes)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let gigabyteConversionTests =
        [
            "From gigabyte to bit and back", (fun x -> Gigabyte.create x |> Gigabyte.toBits |> Bit.toGigabytes)
            "From gigabyte to kilobit and back", (fun x -> Gigabyte.create x |> Gigabyte.toKilobits |> Kilobit.toGigabytes)
            "From gigabyte to megabit and back", (fun x -> Gigabyte.create x |> Gigabyte.toMegabits |> Megabit.toGigabytes)
            "From gigabyte to gigabit and back", (fun x -> Gigabyte.create x |> Gigabyte.toGigabits |> Gigabit.toGigabytes)
            "From gigabyte to terabit and back", (fun x -> Gigabyte.create x |> Gigabyte.toTerabits |> Terabit.toGigabytes)
            "From gigabyte to petabit and back", (fun x -> Gigabyte.create x |> Gigabyte.toPetabits |> Petabit.toGigabytes)
            "From gigabyte to byte and back", (fun x -> Gigabyte.create x |> Gigabyte.toBytes |> Byte.toGigabytes)
            "From gigabyte to kilobyte and back", (fun x -> Gigabyte.create x |> Gigabyte.toKilobytes |> Kilobyte.toGigabytes)
            "From gigabyte to megabyte and back", (fun x -> Gigabyte.create x |> Gigabyte.toMegabytes |> Megabyte.toGigabytes)
            "From gigabyte to terabyte and back", (fun x -> Gigabyte.create x |> Gigabyte.toTerabytes |> Terabyte.toGigabytes)
            "From gigabyte to petabyte and back", (fun x -> Gigabyte.create x |> Gigabyte.toPetabytes |> Petabyte.toGigabytes)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let terabyteConversionTests =
        [
            "From terabyte to bit and back", (fun x -> Terabyte.create x |> Terabyte.toBits |> Bit.toTerabytes)
            "From terabyte to kilobit and back", (fun x -> Terabyte.create x |> Terabyte.toKilobits |> Kilobit.toTerabytes)
            "From terabyte to megabit and back", (fun x -> Terabyte.create x |> Terabyte.toMegabits |> Megabit.toTerabytes)
            "From terabyte to gigabit and back", (fun x -> Terabyte.create x |> Terabyte.toGigabits |> Gigabit.toTerabytes)
            "From terabyte to terabit and back", (fun x -> Terabyte.create x |> Terabyte.toTerabits |> Terabit.toTerabytes)
            "From terabyte to petabit and back", (fun x -> Terabyte.create x |> Terabyte.toPetabits |> Petabit.toTerabytes)
            "From terabyte to byte and back", (fun x -> Terabyte.create x |> Terabyte.toBytes |> Byte.toTerabytes)
            "From terabyte to kilobyte and back", (fun x -> Terabyte.create x |> Terabyte.toKilobytes |> Kilobyte.toTerabytes)
            "From terabyte to megabyte and back", (fun x -> Terabyte.create x |> Terabyte.toMegabytes |> Megabyte.toTerabytes)
            "From terabyte to gigabyte and back", (fun x -> Terabyte.create x |> Terabyte.toGigabytes |> Gigabyte.toTerabytes)
            "From terabyte to petabyte and back", (fun x -> Terabyte.create x |> Terabyte.toPetabytes |> Petabyte.toTerabytes)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let petabyteConversionTests =
        [
            "From petabyte to bit and back", (fun x -> Petabyte.create x |> Petabyte.toBits |> Bit.toPetabytes)
            "From petabyte to kilobit and back", (fun x -> Petabyte.create x |> Petabyte.toKilobits |> Kilobit.toPetabytes)
            "From petabyte to megabit and back", (fun x -> Petabyte.create x |> Petabyte.toMegabits |> Megabit.toPetabytes)
            "From petabyte to gigabit and back", (fun x -> Petabyte.create x |> Petabyte.toGigabits |> Gigabit.toPetabytes)
            "From petabyte to terabit and back", (fun x -> Petabyte.create x |> Petabyte.toTerabits |> Terabit.toPetabytes)
            "From petabyte to petabit and back", (fun x -> Petabyte.create x |> Petabyte.toPetabits |> Petabit.toPetabytes)
            "From petabyte to byte and back", (fun x -> Petabyte.create x |> Petabyte.toBytes |> Byte.toPetabytes)
            "From petabyte to kilobyte and back", (fun x -> Petabyte.create x |> Petabyte.toKilobytes |> Kilobyte.toPetabytes)
            "From petabyte to megabyte and back", (fun x -> Petabyte.create x |> Petabyte.toMegabytes |> Megabyte.toPetabytes)
            "From petabyte to gigabyte and back", (fun x -> Petabyte.create x |> Petabyte.toGigabytes |> Gigabyte.toPetabytes)
            "From petabyte to terabyte and back", (fun x -> Petabyte.create x |> Petabyte.toTerabytes |> Terabyte.toPetabytes)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    testList "Data storage tests -> " [
        testList "Bit conversion tests -> " bitConversionTests
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
        testList "Petabyte conversion tests -> " petabyteConversionTests
    ]