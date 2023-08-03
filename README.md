# Fs.Units

A simple library for working with units of measure in .NET.

The goal of this library is to assist developers with quick proof of concepts as well as full functioning projects which involve common units of measure.

Feedback and assistance are welcome!

## NuGet

| Package | Release                                                                                                                              | Pre-Release                                                                                                                                      | License                                                                                                                              |
| ------- |--------------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------|
| Fs.Units | [![NuGet version (Fs.Units)](https://buildstats.info/nuget/Fs.Units)](https://www.nuget.org/packages/Fs.Units/)                      | [![NuGet](https://buildstats.info/nuget/Fs.Units?includePreReleases=true)](https://www.nuget.org/packages/Fs.Units/absoluteLatest)               | [![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/1eyewonder/Fs.Units/blob/main/LICENSE.md)  |
| Fs.Units.CSharp | [![NuGet version (Fs.Units.CSharp)](https://buildstats.info/nuget/Fs.Units.CSharp)](https://www.nuget.org/packages/Fs.Units.CSharp/) | [![NuGet](https://buildstats.info/nuget/Fs.Units.CSharp?includePreReleases=true)](https://www.nuget.org/packages/Fs.Units.CSharp/absoluteLatest) |  [![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/1eyewonder/Fs.Units/blob/main/LICENSE.md) |

## Builds

|                                                                          GitHub Actions                                                                          |
|:----------------------------------------------------------------------------------------------------------------------------------------------------------------:|
| [![GitHub Actions](https://github.com/1eyewonder/Fs.Units/workflows/Build%20main/badge.svg)](https://github.com/1eyewonder/Fs.Units/actions?query=branch%3Amain) |
|   [![Build History](https://buildstats.info/github/chart/1eyewonder/Fs.Units?branch=main)](https://github.com/1eyewonder/Fs.Units/actions?query=branch%3Amain)   |

## Table of Contents

- [Fs.Units](#fsunits)
  - [NuGet](#nuget)
  - [Builds](#builds)
  - [Table of Contents](#table-of-contents)
  - [Unit Types](#unit-types)
  - [Examples](#examples)
    - [F#](#f)
      - [Explicit Conversion Example](#explicit-conversion-example)
      - [Implicit Conversion Example](#implicit-conversion-example)
    - [C#](#c)
      - [Example](#example)
  - [Supported Unit Categories](#supported-unit-categories)
    - [Simple](#simple)
      - [Length](#length)
      - [Time](#time)
      - [Mass](#mass)
      - [Temperature](#temperature)
      - [Angle](#angle)
      - [DataStorage](#datastorage)
      - [Frequency](#frequency)
      - [Illuminance](#illuminance)
      - [Current](#current)
    - [Compound](#compound)
      - [Area](#area)
      - [Volume](#volume)
      - [FuelEconomy](#fueleconomy)
      - [Inertia](#inertia)
      - [Speed](#speed)
      - [Force](#force)
      - [DataTransferRate](#datatransferrate)
      - [Density](#density)
      - [Pressure](#pressure)
      - [Power](#power)
      - [Energy](#energy)
      - [ElectricCharge](#electriccharge)
      - [ElectromotiveForce](#electromotiveforce)
      - [Capacitance](#capacitance)
      - [Inductance](#inductance)

## Unit Types

- **Simple Units:** A basic unit of measure
```fsharp
    [<Measure>] type inch 
```
- **Compound Units:** Derived units of measure consisting of combinations of two or more units of measure
```fsharp
    [<Measure>] type in2 = inch * inch
```

## Examples

### F#

#### Explicit Conversion Example

```fsharp
open Fs.Units

let valueInFeet = Inch.create 1.0 |> Inch.toFeet // float<ft>
```

#### Implicit Conversion Example

For some compound units, implicit conversion is supported. This allows for a more natural syntax.

```fsharp
open Fs.Units

let thing1 = Coulomb.create 1.0 // float<ElectricCharge.C>
let thing2 = 1.<A> * 1.<s> // float<A*s>

let totalThing = area1 + area2 // float<ElectricCharge.C>
```

```fsharp
open Fs.Units

let thing1 = Liter.create 1.0 // float<L>
let thing2 = 1.<dm> * 1.<dm> * 1.<dm> // float<dm * dm * dm>

let totalThing = area1 + area2 // float<L>
```

#### Helper Functions

Some helper functions are provided to prevent boilerplate code for common math operations such as min, max, abs, etc.

```fsharp
open Fs.Units
open Fs.Units.Helpers

let value1 = Foot.create 1.0 // float<ft>
let value2 = Foot.create 2.0 // float<ft>
let maxValue = max value1 value2 // float<ft>
```

### C#

#### Example
```csharp
using Fs.Units.CSharp;

var valueInFeet = 1d.InchToFeet(); // double
```

## Supported Unit Categories

### Simple

#### Length
  - Inch
  - Foot
  - Yard
  - Mile
  - Millimeter
  - Centimeter
  - Decimeter
  - Meter
  - Kilometer
  - NauticalMile
  - Chain
  - Furlong
  - League
  - Hand
  - Rod
#### Time
  - Nanosecond
  - Microsecond
  - Millisecond
  - Second
  - Minute
  - Hour
  - Day
  - Week
  - Fortnight
  - Month
  - Year
  - Decade
  - Century
  - Millenium
  - Eon
#### Mass
  - Milligram
  - Gram
  - Kilogram
  - Pound mass
#### Temperature
  - Kelvin
  - Celsius
  - Fahrenheit
  - Rankine
#### Angle
  - Degree
  - Radian
  - Gradian
  - Revolution
  - Arcminute
  - Arcsecond
#### DataStorage
  - Bit
  - Kilobit
  - Megabit
  - Gigabit
  - Terabit
  - Petabit
  - Byte
  - Kilobyte
  - Megabyte
  - Gigabyte
  - Terabyte
  - Petabyte
#### Frequency
  - Hertz
  - Kilohertz
  - Megahertz
  - Gigahertz
#### Illuminance
  - Footcandle
  - Lux
  - Phot
  - Nox
#### Current
  - Microampere
  - Milliampere
  - Ampere
  - Biot

### Compound

#### Area
  - SquareInch
  - SquareFoot
  - SquareCentimeter
  - SquareMeter
#### Volume
  - CubicInch
  - CubicFoot
  - CubicCentimeter
  - CubicMeter
  - Liter
  - Gallon
#### FuelEconomy
  - MilesPerGallon
  - KilometersPerLiter
#### Inertia
  - QuarticInch
  - QuarticCentimeter
#### Speed
  - FeetPerSecond
  - MetersPerSecond
  - MilesPerHour
  - KilometersPerHour
#### Force
  - Newton
  - PoundForce
  - Dyne
  - Kip
#### DataTransferRate
  - Baud
  - BitsPerSecond
  - KilobitsPerSecond
  - MegabitsPerSecond
  - GigabitsPerSecond
  - TerabitsPerSecond
  - PetabitsPerSecond
  - BytesPerSecond
  - KilobytesPerSecond
  - MegabytesPerSecond
  - GigabytesPerSecond
  - TerabytesPerSecond
  - PetabytesPerSecond
#### Density
  - KilogramsPerCubicMeter
  - GramsPerCubicCentimeter
  - PoundMassPerCubicFoot
  - PoundMassPerCubicInch
#### Pressure
  - Pascal
  - PoundsPerSquareInch
#### Power
  - Watt
  - KiloWatt
  - ImperialHorsepower
  - TonOfRefrigeration
#### Energy
  - Joules
  - KiloJoules
  - BritishThermalUnits
  - calories
  - Quads
  - Q
#### ElectricCharge
  - Coulomb
  - AmpereHour
  - AmpereSecond
#### ElectromotiveForce
  - Microvolts
  - Millivolts
  - Volts
  - Kilovolts
  - Megavolts
#### Capacitance
  - Farads
#### Inductance
  - MicroHenrys
  - MilliHenrys
  - Henrys