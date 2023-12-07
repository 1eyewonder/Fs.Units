namespace Fs.Units

[<AutoOpen>]
module ElectromotiveForce =

  /// Microvolt
  [<Measure>]
  type uV

  /// Millivolt
  [<Measure>]
  type mV

  /// Volt
  [<Measure>]
  type V = J / C

  /// Kilovolt
  [<Measure>]
  type kV

  /// Megavolt
  [<Measure>]
  type MV

  [<RequireQualifiedAccess>]
  module Microvolt =

    let create (x: float) = x * 1.0<uV>
    let toMillivolts (x: float<uV>) = x * 1e-3<mV> / 1.0<uV>
    let toVolts (x: float<uV>) = x * 1e-6<V> / 1.0<uV>
    let toKilovolts (x: float<uV>) = x * 1e-9<kV> / 1.0<uV>
    let toMegavolts (x: float<uV>) = x * 1e-12<MV> / 1.0<uV>

  [<RequireQualifiedAccess>]
  module Millivolt =

    let create (x: float) = x * 1.0<mV>
    let toMicrovolts (x: float<mV>) = x * 1e3<uV> / 1.0<mV>
    let toVolts (x: float<mV>) = x * 1e-3<V> / 1.0<mV>
    let toKilovolts (x: float<mV>) = x * 1e-6<kV> / 1.0<mV>
    let toMegavolts (x: float<mV>) = x * 1e-9<MV> / 1.0<mV>

  [<RequireQualifiedAccess>]
  module Volt =

    let create (x: float) = x * 1.0<V>
    let toMicrovolts (x: float<V>) = x * 1e6<uV> / 1.0<V>
    let toMillivolts (x: float<V>) = x * 1e3<mV> / 1.0<V>
    let toKilovolts (x: float<V>) = x * 1e-3<kV> / 1.0<V>
    let toMegavolts (x: float<V>) = x * 1e-6<MV> / 1.0<V>

  [<RequireQualifiedAccess>]
  module Kilovolt =

    let create (x: float) = x * 1.0<kV>
    let toMicrovolts (x: float<kV>) = x * 1e9<uV> / 1.0<kV>
    let toMillivolts (x: float<kV>) = x * 1e6<mV> / 1.0<kV>
    let toVolts (x: float<kV>) = x * 1e3<V> / 1.0<kV>
    let toMegavolts (x: float<kV>) = x * 1e-3<MV> / 1.0<kV>

  [<RequireQualifiedAccess>]
  module Megavolt =

    let create (x: float) = x * 1.0<MV>
    let toMicrovolts (x: float<MV>) = x * 1e12<uV> / 1.0<MV>
    let toMillivolts (x: float<MV>) = x * 1e9<mV> / 1.0<MV>
    let toVolts (x: float<MV>) = x * 1e6<V> / 1.0<MV>
    let toKilovolts (x: float<MV>) = x * 1e3<kV> / 1.0<MV>
