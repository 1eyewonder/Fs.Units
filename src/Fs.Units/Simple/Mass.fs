namespace Fs.Units

[<AutoOpen>]
module Mass =

  /// Milligram
  [<Measure>]
  type mg

  /// Gram
  [<Measure>]
  type g

  /// Kilogram
  [<Measure>]
  type kg

  /// Pound mass
  [<Measure>]
  type lbm

  [<RequireQualifiedAccess>]
  module Milligram =

    let create (x: float) = x * 1.0<mg>
    let toKilograms (x: float<mg>) = x * 1e-6<kg> / 1.0<mg>
    let toGrams (x: float<mg>) = x * 1e-3<g> / 1.0<mg>
    let toPoundMass (x: float<mg>) = x * 1.0<lbm> / 453592.0<mg>

  [<RequireQualifiedAccess>]
  module Gram =

    let create (x: float) = x * 1.0<g>
    let toMilligrams (x: float<g>) = x * 1e3<mg> / 1.0<g>
    let toKilograms (x: float<g>) = x * 1e-3<kg> / 1.0<g>
    let toPoundMass (x: float<g>) = x * 1.0<lbm> / 453.592<g>

  [<RequireQualifiedAccess>]
  module Kilogram =

    let create (x: float) = x * 1.0<kg>
    let toMilligrams (x: float<kg>) = x * 1e6<mg> / 1.0<kg>
    let toGrams (x: float<kg>) = x * 1e3<g> / 1.0<kg>
    let toPoundMass (x: float<kg>) = x * 2.20462<lbm> / 1.0<kg>

  [<RequireQualifiedAccess>]
  module PoundMass =

    let create (x: float) = x * 1.0<lbm>
    let toMilligrams (x: float<lbm>) = x * 453592.0<mg> / 1.0<lbm>
    let toGrams (x: float<lbm>) = x * 453.592<g> / 1.0<lbm>
    let toKilograms (x: float<lbm>) = x * 1.0<kg> / 2.20462<lbm>
