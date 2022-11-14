# FS.Units

[![NuGet version (Fs.Units)](https://img.shields.io/nuget/v/Fs.Units.svg?style=flat-square)](https://www.nuget.org/packages/Fs.Units/)
[![NuGet version (Fs.Units.CSharp)](https://img.shields.io/nuget/v/Fs.Units.CSharp.svg?style=flat-square)](https://www.nuget.org/packages/Fs.Units.CSharp/)
[![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/1eyewonder/Fs.Units/blob/main/LICENSE.md)
[![GitHub Releases](https://img.shields.io/github/release/1eyewonder/Fs.Units.svg)](https://github.com/1eyewonder/Fs.Units/releases)
[![GitHub Issues](https://img.shields.io/github/issues/1eyewonder/Fs.Units.svg)](https://github.com/1eyewonder/Fs.Units/issues)

A simple library for working with units of measure in .NET. 

The goal of this library is to assist developers with quick proof of concepts as well as full functioning projects which involve common units of measure.

Feedback and assistance are welcome!

## Unit Types

- **Simple Units:** A basic unit of measure
```fsharp
    [<Measure>] type inch 
```
- **Compound Units:** Derived units of measure consisting of combinations of two or more units of measure
```fsharp
    [<Measure>] type in2 = inch * inch
```

## Project Structure

Fs.Units aims to make things as simple as possible. The project is broken down into two main parts:
- Simple Units
- Compound Units

### F#
- **Fs.Units.[UnitType]** namespace
  - **Fs.Units.[UnitType].Units** module
    - Contains the definition of the unit of measure i.e. inches, kilograms, etc. 

  - **Fs.Units.[UnitType].[UnitName]** module
    - Module containing the conversion methods for the given unit of measure

#### Example
```fsharp
open Fs.Units.Length

let valueInFeet = Inch.create(1.0) |> Inch.toFeet(valueWithUnit) // float<ft>
```

<br/>

### C#
- **Fs.Units.CSharp.[UnitType]** namespace
  - Contains the extension methods for the given type of unit of measure

#### Example
```csharp
using Fs.Units.CSharp.Length;

var valueInFeet = 1d.InchToFeet(); // double
```

<br/>