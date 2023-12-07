namespace Fs.Units

[<AutoOpen>]
module FuelEconomy =

  /// Kilometer per liter
  [<Measure>]
  type kml = km / L

  /// Mile per gallon
  [<Measure>]
  type mpg = mi / gal

  [<RequireQualifiedAccess>]
  module KilometerPerLiter =

    let create (x: float) = x * 1.0<kml>
    let toMilesPerGallon (x: float<kml>) = x * 2.35215<mpg> / 1.0<kml>

  [<RequireQualifiedAccess>]
  module MilePerGallon =

    let create (x: float) = x * 1.0<mpg>
    let toKilometersPerLiter (x: float<mpg>) = x / 2.35215<mpg> * 1.0<kml>
