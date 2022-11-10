namespace Fs.Units.ElectricCharge

open Fs.Units

module Units =
    
    /// Coloumb
    [<Measure>] type C = Current.Units.A * Time.Units.s
    
    /// Ampere-hour
    [<Measure>] type Ah = Current.Units.A * Time.Units.hr
    
    /// Ampere-second
    [<Measure>] type As = Current.Units.A * Time.Units.s

open Units
open Fs.Units.Current
open Fs.Units.Time

module Coloumb =
    
    let create (x: float) = x * 1.0<C>
    let toAmpereHours (x: float<C>) =
        let current = Ampere.create 1
        let time = Second.create 1 |> Second.toHours
        x * current * time / 1.0<C>
    let toAmpereSeconds (x: float<C>) = x * 1.0<As> / 1.0<C>
    
module AmpereHour =
    let create (x: float) = x * 1.0<Ah>
    let toColoumbs (x: float<Ah>) =
        let current = Ampere.create 1
        let time = Hour.create 1 |> Hour.toSeconds
        x * current * time / 1.0<Ah>
    let toAmpereSeconds (x: float<Ah>) =
        let current = Ampere.create 1
        let time = Hour.create 1 |> Hour.toSeconds
        x * current * time / 1.0<Ah>
        
module AmpereSecond =
    
    let create (x: float) = x * 1.0<As>
    let toColoumbs (x: float<As>) = x * 1.0<C> / 1.0<As>
    let toAmpereHours (x: float<As>) =
        let current = Ampere.create 1
        let time = Second.create 1 |> Second.toHours
        x * current * time / 1.0<As>