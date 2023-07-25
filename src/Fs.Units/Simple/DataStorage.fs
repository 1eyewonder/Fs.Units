namespace Fs.Units

[<AutoOpen>]
module DataStorage =

    /// Bit
    [<Measure>]
    type b

    /// Kilobit
    [<Measure>]
    type kb

    /// Megabit
    [<Measure>]
    type Mb

    /// Gigabit
    [<Measure>]
    type Gb

    /// Terabit
    [<Measure>]
    type Tb

    /// Petabit
    [<Measure>]
    type Pb

    /// Byte
    [<Measure>]
    type B

    /// Kilobyte
    [<Measure>]
    type kB

    /// Megabyte
    [<Measure>]
    type MB

    /// Gigabyte
    [<Measure>]
    type GB

    /// Terabyte
    [<Measure>]
    type TB

    /// Petabyte
    [<Measure>]
    type PB

    [<RequireQualifiedAccess>]
    module Bit =

        let create (x: float) = x * 1.0<b>
        let toKilobits (x: float<b>) = x / 1e+3<b> * 1.0<kb>
        let toMegabits (x: float<b>) = x / 1e+6<b> * 1.0<Mb>
        let toGigabits (x: float<b>) = x / 1e+9<b> * 1.0<Gb>
        let toTerabits (x: float<b>) = x / 1e+12<b> * 1.0<Tb>
        let toPetabits (x: float<b>) = x / 1e+15<b> * 1.0<Pb>
        let toBytes (x: float<b>) = x / 8.0<b> * 1.0<B>
        let toKilobytes (x: float<b>) = x / 8.0e+3<b> * 1.0<kB>
        let toMegabytes (x: float<b>) = x / 8.0e+6<b> * 1.0<MB>
        let toGigabytes (x: float<b>) = x / 8.0e+9<b> * 1.0<GB>
        let toTerabytes (x: float<b>) = x / 8.0e+12<b> * 1.0<TB>
        let toPetabytes (x: float<b>) = x / 8.0e+15<b> * 1.0<PB>

    [<RequireQualifiedAccess>]
    module Kilobit =

        let create (x: float) = x * 1.0<kb>
        let toBits (x: float<kb>) = x * 1e+3<b> / 1.0<kb>
        let toMegabits (x: float<kb>) = x / 1e+3<kb> * 1.0<Mb>
        let toGigabits (x: float<kb>) = x / 1e+6<kb> * 1.0<Gb>
        let toTerabits (x: float<kb>) = x / 1e+9<kb> * 1.0<Tb>
        let toPetabits (x: float<kb>) = x / 1e+12<kb> * 1.0<Pb>
        let toBytes (x: float<kb>) = x * 125.0<B> / 1.0<kb>
        let toKilobytes (x: float<kb>) = x / 8.0<kb> * 1.0<kB>
        let toMegabytes (x: float<kb>) = x / 8.0e+3<kb> * 1.0<MB>
        let toGigabytes (x: float<kb>) = x / 8.0e+6<kb> * 1.0<GB>
        let toTerabytes (x: float<kb>) = x / 8.0e+9<kb> * 1.0<TB>
        let toPetabytes (x: float<kb>) = x / 8.0e+12<kb> * 1.0<PB>

    [<RequireQualifiedAccess>]
    module Megabit =

        let create (x: float) = x * 1.0<Mb>
        let toBits (x: float<Mb>) = x * 1e+6<b> / 1.0<Mb>
        let toKilobits (x: float<Mb>) = x * 1e+3<kb> / 1.0<Mb>
        let toGigabits (x: float<Mb>) = x / 1e+3<Mb> * 1.0<Gb>
        let toTerabits (x: float<Mb>) = x / 1e+6<Mb> * 1.0<Tb>
        let toPetabits (x: float<Mb>) = x / 1e+9<Mb> * 1.0<Pb>
        let toBytes (x: float<Mb>) = x * 1.25e+5<B> / 1.0<Mb>
        let toKilobytes (x: float<Mb>) = x * 125.0<kB> / 1.0<Mb>
        let toMegabytes (x: float<Mb>) = x / 8.0<Mb> * 1.0<MB>
        let toGigabytes (x: float<Mb>) = x / 8.0e+3<Mb> * 1.0<GB>
        let toTerabytes (x: float<Mb>) = x / 8.0e+6<Mb> * 1.0<TB>
        let toPetabytes (x: float<Mb>) = x / 8.0e+9<Mb> * 1.0<PB>

    [<RequireQualifiedAccess>]
    module Gigabit =

        let create (x: float) = x * 1.0<Gb>
        let toBits (x: float<Gb>) = x * 1e+9<b> / 1.0<Gb>
        let toKilobits (x: float<Gb>) = x * 1e+6<kb> / 1.0<Gb>
        let toMegabits (x: float<Gb>) = x * 1e+3<Mb> / 1.0<Gb>
        let toTerabits (x: float<Gb>) = x / 1e+3<Gb> * 1.0<Tb>
        let toPetabits (x: float<Gb>) = x / 1e+6<Gb> * 1.0<Pb>
        let toBytes (x: float<Gb>) = x * 1.25e+8<B> / 1.0<Gb>
        let toKilobytes (x: float<Gb>) = x * 1.25e+5<kB> / 1.0<Gb>
        let toMegabytes (x: float<Gb>) = x * 125.0<MB> / 1.0<Gb>
        let toGigabytes (x: float<Gb>) = x / 8.0<Gb> * 1.0<GB>
        let toTerabytes (x: float<Gb>) = x / 8.0e+3<Gb> * 1.0<TB>
        let toPetabytes (x: float<Gb>) = x / 8.0e+6<Gb> * 1.0<PB>

    [<RequireQualifiedAccess>]
    module Terabit =

        let create (x: float) = x * 1.0<Tb>
        let toBits (x: float<Tb>) = x * 1e+12<b> / 1.0<Tb>
        let toKilobits (x: float<Tb>) = x * 1e+9<kb> / 1.0<Tb>
        let toMegabits (x: float<Tb>) = x * 1e+6<Mb> / 1.0<Tb>
        let toGigabits (x: float<Tb>) = x * 1e+3<Gb> / 1.0<Tb>
        let toPetabits (x: float<Tb>) = x / 1e+3<Tb> * 1.0<Pb>
        let toBytes (x: float<Tb>) = x * 1.25e+11<B> / 1.0<Tb>
        let toKilobytes (x: float<Tb>) = x * 1.25e+8<kB> / 1.0<Tb>
        let toMegabytes (x: float<Tb>) = x * 1.25e+5<MB> / 1.0<Tb>
        let toGigabytes (x: float<Tb>) = x * 125.0<GB> / 1.0<Tb>
        let toTerabytes (x: float<Tb>) = x / 8.0<Tb> * 1.0<TB>
        let toPetabytes (x: float<Tb>) = x / 8.0e+3<Tb> * 1.0<PB>

    [<RequireQualifiedAccess>]
    module Petabit =

        let create (x: float) = x * 1.0<Pb>
        let toBits (x: float<Pb>) = x * 1e+15<b> / 1.0<Pb>
        let toKilobits (x: float<Pb>) = x * 1e+12<kb> / 1.0<Pb>
        let toMegabits (x: float<Pb>) = x * 1e+9<Mb> / 1.0<Pb>
        let toGigabits (x: float<Pb>) = x * 1e+6<Gb> / 1.0<Pb>
        let toTerabits (x: float<Pb>) = x * 1e+3<Tb> / 1.0<Pb>
        let toBytes (x: float<Pb>) = x * 1.25e+14<B> / 1.0<Pb>
        let toKilobytes (x: float<Pb>) = x * 1.25e+11<kB> / 1.0<Pb>
        let toMegabytes (x: float<Pb>) = x * 1.25e+8<MB> / 1.0<Pb>
        let toGigabytes (x: float<Pb>) = x * 1.25e+5<GB> / 1.0<Pb>
        let toTerabytes (x: float<Pb>) = x * 125.0<TB> / 1.0<Pb>
        let toPetabytes (x: float<Pb>) = x / 8.0<Pb> * 1.0<PB>

    [<RequireQualifiedAccess>]
    module Byte =

        let create (x: float) = x * 1.0<B>
        let toBits (x: float<B>) = x * 8.0<b> / 1.0<B>
        let toKilobits (x: float<B>) = x * 8e-3<kb> / 1.0<B>
        let toMegabits (x: float<B>) = x * 8e-6<Mb> / 1.0<B>
        let toGigabits (x: float<B>) = x * 8e-9<Gb> / 1.0<B>
        let toTerabits (x: float<B>) = x * 8e-12<Tb> / 1.0<B>
        let toPetabits (x: float<B>) = x * 8e-15<Pb> / 1.0<B>
        let toKilobytes (x: float<B>) = x * 1e-3<kB> / 1.0<B>
        let toMegabytes (x: float<B>) = x * 1e-6<MB> / 1.0<B>
        let toGigabytes (x: float<B>) = x * 1e-9<GB> / 1.0<B>
        let toTerabytes (x: float<B>) = x * 1e-12<TB> / 1.0<B>
        let toPetabytes (x: float<B>) = x * 1e-15<PB> / 1.0<B>

    [<RequireQualifiedAccess>]
    module Kilobyte =

        let create (x: float) = x * 1.0<kB>
        let toBits (x: float<kB>) = x * 8e+3<b> / 1.0<kB>
        let toKilobits (x: float<kB>) = x * 8.0<kb> / 1.0<kB>
        let toMegabits (x: float<kB>) = x * 8e-3<Mb> / 1.0<kB>
        let toGigabits (x: float<kB>) = x * 8e-6<Gb> / 1.0<kB>
        let toTerabits (x: float<kB>) = x * 8e-9<Tb> / 1.0<kB>
        let toPetabits (x: float<kB>) = x * 8e-12<Pb> / 1.0<kB>
        let toBytes (x: float<kB>) = x * 1e+3<B> / 1.0<kB>
        let toMegabytes (x: float<kB>) = x * 1e-3<MB> / 1.0<kB>
        let toGigabytes (x: float<kB>) = x * 1e-6<GB> / 1.0<kB>
        let toTerabytes (x: float<kB>) = x * 1e-9<TB> / 1.0<kB>
        let toPetabytes (x: float<kB>) = x * 1e-12<PB> / 1.0<kB>

    [<RequireQualifiedAccess>]
    module Megabyte =

        let create (x: float) = x * 1.0<MB>
        let toBits (x: float<MB>) = x * 8e+6<b> / 1.0<MB>
        let toKilobits (x: float<MB>) = x * 8e+3<kb> / 1.0<MB>
        let toMegabits (x: float<MB>) = x * 8.0<Mb> / 1.0<MB>
        let toGigabits (x: float<MB>) = x * 8e-3<Gb> / 1.0<MB>
        let toTerabits (x: float<MB>) = x * 8e-6<Tb> / 1.0<MB>
        let toPetabits (x: float<MB>) = x * 8e-9<Pb> / 1.0<MB>
        let toBytes (x: float<MB>) = x * 1e+6<B> / 1.0<MB>
        let toKilobytes (x: float<MB>) = x * 1e+3<kB> / 1.0<MB>
        let toGigabytes (x: float<MB>) = x * 1e-3<GB> / 1.0<MB>
        let toTerabytes (x: float<MB>) = x * 1e-6<TB> / 1.0<MB>
        let toPetabytes (x: float<MB>) = x * 1e-9<PB> / 1.0<MB>

    [<RequireQualifiedAccess>]
    module Gigabyte =

        let create (x: float) = x * 1.0<GB>
        let toBits (x: float<GB>) = x * 8e+9<b> / 1.0<GB>
        let toKilobits (x: float<GB>) = x * 8e+6<kb> / 1.0<GB>
        let toMegabits (x: float<GB>) = x * 8e+3<Mb> / 1.0<GB>
        let toGigabits (x: float<GB>) = x * 8.0<Gb> / 1.0<GB>
        let toTerabits (x: float<GB>) = x * 8e-3<Tb> / 1.0<GB>
        let toPetabits (x: float<GB>) = x * 8e-6<Pb> / 1.0<GB>
        let toBytes (x: float<GB>) = x * 1e+9<B> / 1.0<GB>
        let toKilobytes (x: float<GB>) = x * 1e+6<kB> / 1.0<GB>
        let toMegabytes (x: float<GB>) = x * 1e+3<MB> / 1.0<GB>
        let toTerabytes (x: float<GB>) = x * 1e-3<TB> / 1.0<GB>
        let toPetabytes (x: float<GB>) = x * 1e-6<PB> / 1.0<GB>

    [<RequireQualifiedAccess>]
    module Terabyte =

        let create (x: float) = x * 1.0<TB>
        let toBits (x: float<TB>) = x * 8e+12<b> / 1.0<TB>
        let toKilobits (x: float<TB>) = x * 8e+9<kb> / 1.0<TB>
        let toMegabits (x: float<TB>) = x * 8e+6<Mb> / 1.0<TB>
        let toGigabits (x: float<TB>) = x * 8e+3<Gb> / 1.0<TB>
        let toTerabits (x: float<TB>) = x * 8.0<Tb> / 1.0<TB>
        let toPetabits (x: float<TB>) = x * 8e-3<Pb> / 1.0<TB>
        let toBytes (x: float<TB>) = x * 1e+12<B> / 1.0<TB>
        let toKilobytes (x: float<TB>) = x * 1e+9<kB> / 1.0<TB>
        let toMegabytes (x: float<TB>) = x * 1e+6<MB> / 1.0<TB>
        let toGigabytes (x: float<TB>) = x * 1e+3<GB> / 1.0<TB>
        let toPetabytes (x: float<TB>) = x * 1e-3<PB> / 1.0<TB>

    [<RequireQualifiedAccess>]
    module Petabyte =

        let create (x: float) = x * 1.0<PB>
        let toBits (x: float<PB>) = x * 8e+15<b> / 1.0<PB>
        let toKilobits (x: float<PB>) = x * 8e+12<kb> / 1.0<PB>
        let toMegabits (x: float<PB>) = x * 8e+9<Mb> / 1.0<PB>
        let toGigabits (x: float<PB>) = x * 8e+6<Gb> / 1.0<PB>
        let toTerabits (x: float<PB>) = x * 8e+3<Tb> / 1.0<PB>
        let toPetabits (x: float<PB>) = x * 8.0<Pb> / 1.0<PB>
        let toBytes (x: float<PB>) = x * 1e+15<B> / 1.0<PB>
        let toKilobytes (x: float<PB>) = x * 1e+12<kB> / 1.0<PB>
        let toMegabytes (x: float<PB>) = x * 1e+9<MB> / 1.0<PB>
        let toGigabytes (x: float<PB>) = x * 1e+6<GB> / 1.0<PB>
        let toTerabytes (x: float<PB>) = x * 1e+3<TB> / 1.0<PB>
