namespace Fs.Units

[<AutoOpen>]
module ElectricCharge =

  /// Coulomb
  [<Measure>]
  type C = A * s

  /// Ampere-hour
  [<Measure>]
  type Ah = A * hr

  /// Ampere-second
  [<Measure>]
  type As = C

  [<RequireQualifiedAccess>]
  module Coulomb =

    let create (x: float) = x * 1.0<C>

    let toAmpereHours (x: float<C>) =
      let current = Ampere.create 1
      let time = Second.create 1 |> Second.toHours
      x * current * time / 1.0<C>

    let toAmpereSeconds (x: float<C>) = x * 1.0<As> / 1.0<C>

  [<RequireQualifiedAccess>]
  module AmpereHour =
    let create (x: float) = x * 1.0<Ah>

    let toCoulombs (x: float<Ah>) =
      let current = Ampere.create 1
      let time = Hour.create 1 |> Hour.toSeconds
      x * current * time / 1.0<Ah>

    let toAmpereSeconds (x: float<Ah>) =
      let current = Ampere.create 1
      let time = Hour.create 1 |> Hour.toSeconds
      x * current * time / 1.0<Ah>

  [<RequireQualifiedAccess>]
  module AmpereSecond =

    let create (x: float) = x * 1.0<As>
    let toCoulombs (x: float<As>) = x * 1.0<C> / 1.0<As>

    let toAmpereHours (x: float<As>) =
      let current = Ampere.create 1
      let time = Second.create 1 |> Second.toHours
      x * current * time / 1.0<As>
