# FS.Units

A simple library for working with units of measure in .NET. 

The goal of this library was to assist developers with quick proof of concepts as well as full functioning projects which involve common units of measure.

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

A structure is shared for both of these parts. The structure is as follows:
- **Fs.Units.[UnitType]** namespace
  - **Fs.Units.[UnitType].Units** module
    - Contains the definition of the unit of measure i.e. inches, kilograms, etc.
  - **Fs.Units.[UnitType].[UnitName]** module
    - Module containing the conversion methods for the given unit of measure
