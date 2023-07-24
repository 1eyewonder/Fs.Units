﻿namespace Fs.Units
    
[<AutoOpen>]
module Density =
    
    /// Kilogram per cubic meter
    [<Measure>] type kgm3 = kg / m3

    /// Gram per cubic centimeter
    [<Measure>] type gcm3 = g / cm3

    /// Pound mass per cubic foot
    [<Measure>] type lbmft3 = lbm / ft3

    /// Pound mass per cubic inch
    [<Measure>] type lbmin3 = lbm / in3

    [<RequireQualifiedAccess>]
    module KilogramPerCubicMeter =
        
        let create (x: float) = x * 1.0<kgm3>
        let toGramsPerCubicCentimeter (x: float<kgm3>) =
            let mass = Kilogram.create 1 |> Kilogram.toGrams
            let volume = CubicMeter.create 1 |> CubicMeter.toCubicCentimeters
            x * mass / volume / 1.0<kgm3>
        let toPoundMassPerCubicFoot (x: float<kgm3>) =
            let mass = Kilogram.create 1 |> Kilogram.toPoundMass
            let volume = CubicMeter.create 1 |> CubicMeter.toCubicFeet
            x * mass / volume / 1.0<kgm3>
        let toPoundMassPerCubicInch (x: float<kgm3>) =
            let mass = Kilogram.create 1 |> Kilogram.toPoundMass
            let volume = CubicMeter.create 1 |> CubicMeter.toCubicInches
            x * mass / volume / 1.0<kgm3>
        
    [<RequireQualifiedAccess>]
    module GramPerCubicCentimeter =
        
        let create (x: float) = x * 1.0<gcm3>
        let toKilogramsPerCubicMeter (x: float<gcm3>) =
            let mass = Gram.create 1 |> Gram.toKilograms
            let volume = CubicCentimeter.create 1 |> CubicCentimeter.toCubicMeters
            x * mass / volume / 1.0<gcm3>
        let toPoundMassPerCubicFoot (x: float<gcm3>) =
            let mass = Gram.create 1 |> Gram.toPoundMass
            let volume = CubicCentimeter.create 1 |> CubicCentimeter.toCubicFeet
            x * mass / volume / 1.0<gcm3>
        let toPoundMassPerCubicInch (x: float<gcm3>) =
            let mass = Gram.create 1 |> Gram.toPoundMass
            let volume = CubicCentimeter.create 1 |> CubicCentimeter.toCubicInches
            x * mass / volume / 1.0<gcm3>
         
    [<RequireQualifiedAccess>]
    module PoundMassPerCubicFoot =
        
        let create (x: float) = x * 1.0<lbmft3>
        let toKilogramsPerCubicMeter (x: float<lbmft3>) =
            let mass = PoundMass.create 1 |> PoundMass.toKilograms
            let volume = CubicFoot.create 1 |> CubicFoot.toCubicMeters
            x * mass / volume / 1.0<lbmft3>
        let toGramsPerCubicCentimeter (x: float<lbmft3>) =
            let mass = PoundMass.create 1 |> PoundMass.toGrams
            let volume = CubicFoot.create 1 |> CubicFoot.toCubicCentimeters
            x * mass / volume / 1.0<lbmft3>
        let toPoundMassPerCubicInch (x: float<lbmft3>) =
            let mass = PoundMass.create 1
            let volume = CubicFoot.create 1 |> CubicFoot.toCubicInches
            x * mass / volume / 1.0<lbmft3>

    [<RequireQualifiedAccess>]
    module PoundMassPerCubicInch =
        
        let create (x: float) = x * 1.0<lbmin3>
        let toKilogramsPerCubicMeter (x: float<lbmin3>) =
            let mass = PoundMass.create 1 |> PoundMass.toKilograms
            let volume = CubicInch.create 1 |> CubicInch.toCubicMeters
            x * mass / volume / 1.0<lbmin3>
        let toGramsPerCubicCentimeter (x: float<lbmin3>) =
            let mass = PoundMass.create 1 |> PoundMass.toGrams
            let volume = CubicInch.create 1 |> CubicInch.toCubicCentimeters
            x * mass / volume / 1.0<lbmin3>
        let toPoundMassPerCubicFoot (x: float<lbmin3>) =
            let mass = PoundMass.create 1
            let volume = CubicInch.create 1 |> CubicInch.toCubicFeet
            x * mass / volume / 1.0<lbmin3>