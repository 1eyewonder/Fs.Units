namespace Fs.Units

[<AutoOpen>]
module Temperature =

  /// Kelvin
  [<Measure>]
  type K

  /// Celsius
  [<Measure>]
  type C

  /// Fahrenheit
  [<Measure>]
  type F

  /// Rankine
  [<Measure>]
  type R

  [<RequireQualifiedAccess>]
  module Kelvin =

    let create (x: float) = x * 1.0<K>
    let toCelsius (x: float<K>) = (x - 273.15<K>) / 1.0<K> * 1.0<C>

    let toFahrenheit (x: float<K>) =
      ((x - 273.15<K>) * (9.0 / 5.0) + 32.0<K>) / 1.0<K> * 1.0<F>

    let toRankine (x: float<K>) = (x * 1.8) / 1.0<K> * 1.0<R>

  [<RequireQualifiedAccess>]
  module Celsius =

    let create (x: float) = x * 1.0<C>
    let toKelvin (x: float<C>) = (x + 273.15<C>) / 1.0<C> * 1.0<K>

    let toFahrenheit (x: float<C>) =
      ((x * (9.0 / 5.0)) + 32.0<C>) / 1.0<C> * 1.0<F>

    let toRankine (x: float<C>) =
      ((x + 273.15<C>) * 1.8) / 1.0<C> * 1.0<R>

  [<RequireQualifiedAccess>]
  module Fahrenheit =

    let create (x: float) = x * 1.0<F>

    let toKelvin (x: float<F>) =
      ((x - 32.0<F>) * (5.0 / 9.0) + 273.15<F>) / 1.0<F> * 1.0<K>

    let toCelsius (x: float<F>) =
      ((x - 32.0<F>) * (5.0 / 9.0)) / 1.0<F> * 1.0<C>

    let toRankine (x: float<F>) = (x + 459.67<F>) / 1.0<F> * 1.0<R>

  [<RequireQualifiedAccess>]
  module Rankine =

    let create (x: float) = x * 1.0<R>
    let toKelvin (x: float<R>) = (x * (5.0 / 9.0)) / 1.0<R> * 1.0<K>

    let toCelsius (x: float<R>) =
      ((x - 491.67<R>) * (5.0 / 9.0)) / 1.0<R> * 1.0<C>

    let toFahrenheit (x: float<R>) = (x - 459.67<R>) / 1.0<R> * 1.0<F>
