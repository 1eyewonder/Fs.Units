# Fs.Units

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

## Examples

### F#

#### Explicit Conversion Example

```fsharp
open Fs.Units

let valueInFeet = Inch.create 1.0 |> Inch.toFeet // float<ft>
```

#### Implicit Conversion Example

For some compound units, implicit conversion is supported. This allows for a more natural syntax in certain instances.

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
let plainValue = Foot.create 1. |> removeUnits // float
```

### C#

#### Example
```csharp
using Fs.Units.CSharp;

var valueInFeet = 1d.InchToFeet(); // double
```