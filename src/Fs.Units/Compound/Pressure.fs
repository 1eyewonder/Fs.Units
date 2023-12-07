namespace Fs.Units

[<AutoOpen>]
module Pressure =

  /// Pascal
  [<Measure>]
  type Pa = N / m2

  /// Pounds per square inch
  [<Measure>]
  type psi = lbf / in2

  [<RequireQualifiedAccess>]
  module Pascal =

    let create (x: float) = x * 1.0<Pa>

    let toPoundsPerSquareInch (x: float<Pa>) =
      let force = Newton.create 1 |> Newton.toPoundForce
      let length = Meter.create 1 |> Meter.toInches
      x * force / length / length / 1.0<Pa>

  [<RequireQualifiedAccess>]
  module PoundPerSquareInch =

    let create (x: float) = x * 1.0<psi>

    let toPascals (x: float<psi>) =
      let force = PoundForce.create 1 |> PoundForce.toNewtons
      let length = Inch.create 1 |> Inch.toMeters
      x * force / length / length / 1.0<psi>
