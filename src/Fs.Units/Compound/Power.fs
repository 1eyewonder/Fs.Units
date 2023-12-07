namespace Fs.Units

[<AutoOpen>]
module Power =

  /// Watt
  [<Measure>]
  type W = N * m / s

  /// Kilowatt
  [<Measure>]
  type kW

  /// Imperial horsepower
  [<Measure>]
  type hp

  /// Ton of refrigeration
  [<Measure>]
  type TR

  [<RequireQualifiedAccess>]
  module Watt =

    let create (x: float) = x * 1.0<W>
    let toKilowatts (x: float<W>) = x * 1.0<kW> / 1000.0<W>
    let toHorsepower (x: float<W>) = x * 1.0<hp> / 745.7<W>
    let toTonsOfRefrigeration (x: float<W>) = x * 1.0<TR> / 3516.85<W>

  [<RequireQualifiedAccess>]
  module Kilowatt =

    let create (x: float) = x * 1.0<kW>
    let toWatts (x: float<kW>) = x * 1000.0<W> / 1.0<kW>
    let toHorsepower (x: float<kW>) = x * 1000.0<hp> / 745.7<kW>
    let toTonsOfRefrigeration (x: float<kW>) = x * 1000.0<TR> / 3516.85<kW>

  [<RequireQualifiedAccess>]
  module Horsepower =

    let create (x: float) = x * 1.0<hp>
    let toWatts (x: float<hp>) = x * 745.7<W> / 1.0<hp>
    let toKilowatts (x: float<hp>) = x * 745.7<kW> / 1000.0<hp>
    let toTonsOfRefrigeration (x: float<hp>) = x * 745.7<TR> / 3516.85<hp>

  [<RequireQualifiedAccess>]
  module TonOfRefrigeration =

    let create (x: float) = x * 1.0<TR>
    let toWatts (x: float<TR>) = x * 3516.85<W> / 1.0<TR>
    let toKilowatts (x: float<TR>) = x * 3516.85<kW> / 1000.0<TR>
    let toHorsepower (x: float<TR>) = x * 3516.85<hp> / 745.7<TR>
