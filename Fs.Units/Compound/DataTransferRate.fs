namespace Fs.Units

[<AutoOpen>]
module DataTransferRate =

    /// Baud
    [<Measure>]
    type baud = b / s

    /// Bit per second
    [<Measure>]
    type bps = b / s

    /// Kilobit per second
    [<Measure>]
    type kbps = kb / s

    /// Megabit per second
    [<Measure>]
    type Mbps = Mb / s

    /// Gigabit per second
    [<Measure>]
    type Gbps = Gb / s

    /// Terabit per second
    [<Measure>]
    type Tbps = Tb / s

    /// Petabit per second
    [<Measure>]
    type Pbps = Pb / s

    /// Byte per second
    [<Measure>]
    type Bps = B / s

    /// Kilobyte per second
    [<Measure>]
    type kBps = kB / s

    /// Megabyte per second
    [<Measure>]
    type MBps = MB / s

    /// Gigabyte per second
    [<Measure>]
    type GBps = GB / s

    /// Terabyte per second
    [<Measure>]
    type TBps = TB / s

    /// Petabyte per second
    [<Measure>]
    type PBps = PB / s

    [<RequireQualifiedAccess>]
    module Baud =

        let create (x: float) = x * 1.0<baud>
        let toBitsPerSecond (x: float<baud>) = x * 1.0<bps> / 1.0<baud>
        let toKilobitsPerSecond (x: float<baud>) = x * 1e-3<kbps> / 1.0<baud>
        let toMegabitsPerSecond (x: float<baud>) = x * 1e-6<Mbps> / 1.0<baud>
        let toGigabitsPerSecond (x: float<baud>) = x * 1e-9<Gbps> / 1.0<baud>
        let toTerabitsPerSecond (x: float<baud>) = x * 1e-12<Tbps> / 1.0<baud>
        let toPetabitsPerSecond (x: float<baud>) = x * 1e-15<Pbps> / 1.0<baud>
        let toBytesPerSecond (x: float<baud>) = x * 1.0<Bps> / 8.0<baud>
        let toKilobytesPerSecond (x: float<baud>) = x * 1.25e-4<kBps> / 1.0<baud>
        let toMegabytesPerSecond (x: float<baud>) = x * 1.25e-7<MBps> / 1.0<baud>
        let toGigabytesPerSecond (x: float<baud>) = x * 1.25e-10<GBps> / 1.0<baud>
        let toTerabytesPerSecond (x: float<baud>) = x * 1.25e-13<TBps> / 1.0<baud>
        let toPetabytesPerSecond (x: float<baud>) = x * 1.25e-16<PBps> / 1.0<baud>

    [<RequireQualifiedAccess>]
    module BitPerSecond =

        let create (x: float) = x * 1.0<bps>
        let toBauds (x: float<bps>) = x * 1.0<baud> / 1.0<bps>
        let toKilobitsPerSecond (x: float<bps>) = x * 1e-3<kbps> / 1.0<bps>
        let toMegabitsPerSecond (x: float<bps>) = x * 1e-6<Mbps> / 1.0<bps>
        let toGigabitsPerSecond (x: float<bps>) = x * 1e-9<Gbps> / 1.0<bps>
        let toTerabitsPerSecond (x: float<bps>) = x * 1e-12<Tbps> / 1.0<bps>
        let toPetabitsPerSecond (x: float<bps>) = x * 1e-15<Pbps> / 1.0<bps>
        let toBytesPerSecond (x: float<bps>) = x * 1.0<Bps> / 8.0<bps>
        let toKilobytesPerSecond (x: float<bps>) = x * 1.25e-4<kBps> / 1.0<bps>
        let toMegabytesPerSecond (x: float<bps>) = x * 1.25e-7<MBps> / 1.0<bps>
        let toGigabytesPerSecond (x: float<bps>) = x * 1.25e-10<GBps> / 1.0<bps>
        let toTerabytesPerSecond (x: float<bps>) = x * 1.25e-13<TBps> / 1.0<bps>
        let toPetabytesPerSecond (x: float<bps>) = x * 1.25e-16<PBps> / 1.0<bps>

    [<RequireQualifiedAccess>]
    module KilobitPerSecond =

        let create (x: float) = x * 1.0<kbps>
        let toBauds (x: float<kbps>) = x * 1e+3<baud> / 1.0<kbps>
        let toBitsPerSecond (x: float<kbps>) = x * 1e+3<bps> / 1.0<kbps>
        let toMegabitsPerSecond (x: float<kbps>) = x * 1e-3<Mbps> / 1.0<kbps>
        let toGigabitsPerSecond (x: float<kbps>) = x * 1e-6<Gbps> / 1.0<kbps>
        let toTerabitsPerSecond (x: float<kbps>) = x * 1e-9<Tbps> / 1.0<kbps>
        let toPetabitsPerSecond (x: float<kbps>) = x * 1e-12<Pbps> / 1.0<kbps>
        let toBytesPerSecond (x: float<kbps>) = x * 1.25e+2<Bps> / 1.0<kbps>
        let toKilobytesPerSecond (x: float<kbps>) = x * 1.25e-1<kBps> / 1.0<kbps>
        let toMegabytesPerSecond (x: float<kbps>) = x * 1.25e-4<MBps> / 1.0<kbps>
        let toGigabytesPerSecond (x: float<kbps>) = x * 1.25e-7<GBps> / 1.0<kbps>
        let toTerabytesPerSecond (x: float<kbps>) = x * 1.25e-10<TBps> / 1.0<kbps>
        let toPetabytesPerSecond (x: float<kbps>) = x * 1.25e-13<PBps> / 1.0<kbps>

    [<RequireQualifiedAccess>]
    module MegabitPerSecond =

        let create (x: float) = x * 1.0<Mbps>
        let toBauds (x: float<Mbps>) = x * 1e+6<baud> / 1.0<Mbps>
        let toBitsPerSecond (x: float<Mbps>) = x * 1e+6<bps> / 1.0<Mbps>
        let toKilobitsPerSecond (x: float<Mbps>) = x * 1e+3<kbps> / 1.0<Mbps>
        let toGigabitsPerSecond (x: float<Mbps>) = x * 1e-3<Gbps> / 1.0<Mbps>
        let toTerabitsPerSecond (x: float<Mbps>) = x * 1e-6<Tbps> / 1.0<Mbps>
        let toPetabitsPerSecond (x: float<Mbps>) = x * 1e-9<Pbps> / 1.0<Mbps>
        let toBytesPerSecond (x: float<Mbps>) = x * 1.25e+5<Bps> / 1.0<Mbps>
        let toKilobytesPerSecond (x: float<Mbps>) = x * 1.25e+2<kBps> / 1.0<Mbps>
        let toMegabytesPerSecond (x: float<Mbps>) = x * 1.25e-1<MBps> / 1.0<Mbps>
        let toGigabytesPerSecond (x: float<Mbps>) = x * 1.25e-4<GBps> / 1.0<Mbps>
        let toTerabytesPerSecond (x: float<Mbps>) = x * 1.25e-7<TBps> / 1.0<Mbps>
        let toPetabytesPerSecond (x: float<Mbps>) = x * 1.25e-10<PBps> / 1.0<Mbps>

    [<RequireQualifiedAccess>]
    module GigabitPerSecond =

        let create (x: float) = x * 1.0<Gbps>
        let toBauds (x: float<Gbps>) = x * 1e+9<baud> / 1.0<Gbps>
        let toBitsPerSecond (x: float<Gbps>) = x * 1e+9<bps> / 1.0<Gbps>
        let toKilobitsPerSecond (x: float<Gbps>) = x * 1e+6<kbps> / 1.0<Gbps>
        let toMegabitsPerSecond (x: float<Gbps>) = x * 1e+3<Mbps> / 1.0<Gbps>
        let toTerabitsPerSecond (x: float<Gbps>) = x * 1e-3<Tbps> / 1.0<Gbps>
        let toPetabitsPerSecond (x: float<Gbps>) = x * 1e-6<Pbps> / 1.0<Gbps>
        let toBytesPerSecond (x: float<Gbps>) = x * 1.25e+8<Bps> / 1.0<Gbps>
        let toKilobytesPerSecond (x: float<Gbps>) = x * 1.25e+5<kBps> / 1.0<Gbps>
        let toMegabytesPerSecond (x: float<Gbps>) = x * 1.25e+2<MBps> / 1.0<Gbps>
        let toGigabytesPerSecond (x: float<Gbps>) = x * 1.25e-1<GBps> / 1.0<Gbps>
        let toTerabytesPerSecond (x: float<Gbps>) = x * 1.25e-4<TBps> / 1.0<Gbps>
        let toPetabytesPerSecond (x: float<Gbps>) = x * 1.25e-7<PBps> / 1.0<Gbps>

    [<RequireQualifiedAccess>]
    module TerabitPerSecond =

        let create (x: float) = x * 1.0<Tbps>
        let toBauds (x: float<Tbps>) = x * 1e+12<baud> / 1.0<Tbps>
        let toBitsPerSecond (x: float<Tbps>) = x * 1e+12<bps> / 1.0<Tbps>
        let toKilobitsPerSecond (x: float<Tbps>) = x * 1e+9<kbps> / 1.0<Tbps>
        let toMegabitsPerSecond (x: float<Tbps>) = x * 1e+6<Mbps> / 1.0<Tbps>
        let toGigabitsPerSecond (x: float<Tbps>) = x * 1e+3<Gbps> / 1.0<Tbps>
        let toPetabitsPerSecond (x: float<Tbps>) = x * 1e-3<Pbps> / 1.0<Tbps>
        let toBytesPerSecond (x: float<Tbps>) = x * 1.25e+11<Bps> / 1.0<Tbps>
        let toKilobytesPerSecond (x: float<Tbps>) = x * 1.25e+8<kBps> / 1.0<Tbps>
        let toMegabytesPerSecond (x: float<Tbps>) = x * 1.25e+5<MBps> / 1.0<Tbps>
        let toGigabytesPerSecond (x: float<Tbps>) = x * 1.25e+2<GBps> / 1.0<Tbps>
        let toTerabytesPerSecond (x: float<Tbps>) = x * 1.25e-1<TBps> / 1.0<Tbps>
        let toPetabytesPerSecond (x: float<Tbps>) = x * 1.25e-4<PBps> / 1.0<Tbps>

    [<RequireQualifiedAccess>]
    module PetabitPerSecond =

        let create (x: float) = x * 1.0<Pbps>
        let toBauds (x: float<Pbps>) = x * 1e+15<baud> / 1.0<Pbps>
        let toBitsPerSecond (x: float<Pbps>) = x * 1e+15<bps> / 1.0<Pbps>
        let toKilobitsPerSecond (x: float<Pbps>) = x * 1e+12<kbps> / 1.0<Pbps>
        let toMegabitsPerSecond (x: float<Pbps>) = x * 1e+9<Mbps> / 1.0<Pbps>
        let toGigabitsPerSecond (x: float<Pbps>) = x * 1e+6<Gbps> / 1.0<Pbps>
        let toTerabitsPerSecond (x: float<Pbps>) = x * 1e+3<Tbps> / 1.0<Pbps>
        let toBytesPerSecond (x: float<Pbps>) = x * 1.25e+14<Bps> / 1.0<Pbps>
        let toKilobytesPerSecond (x: float<Pbps>) = x * 1.25e+11<kBps> / 1.0<Pbps>
        let toMegabytesPerSecond (x: float<Pbps>) = x * 1.25e+8<MBps> / 1.0<Pbps>
        let toGigabytesPerSecond (x: float<Pbps>) = x * 1.25e+5<GBps> / 1.0<Pbps>
        let toTerabytesPerSecond (x: float<Pbps>) = x * 1.25e+2<TBps> / 1.0<Pbps>
        let toPetabytesPerSecond (x: float<Pbps>) = x * 1.25e-1<PBps> / 1.0<Pbps>

    [<RequireQualifiedAccess>]
    module BytePerSecond =

        let create (x: float) = x * 1.0<Bps>
        let toBauds (x: float<Bps>) = x * 8.0<baud> / 1.0<Bps>
        let toBitsPerSecond (x: float<Bps>) = x * 8.0<bps> / 1.0<Bps>
        let toKilobitsPerSecond (x: float<Bps>) = x * 8e-3<kbps> / 1.0<Bps>
        let toMegabitsPerSecond (x: float<Bps>) = x * 8e-6<Mbps> / 1.0<Bps>
        let toGigabitsPerSecond (x: float<Bps>) = x * 8e-9<Gbps> / 1.0<Bps>
        let toTerabitsPerSecond (x: float<Bps>) = x * 8e-12<Tbps> / 1.0<Bps>
        let toPetabitsPerSecond (x: float<Bps>) = x * 8e-15<Pbps> / 1.0<Bps>
        let toKilobytesPerSecond (x: float<Bps>) = x * 1e-3<kBps> / 1.0<Bps>
        let toMegabytesPerSecond (x: float<Bps>) = x * 1e-6<MBps> / 1.0<Bps>
        let toGigabytesPerSecond (x: float<Bps>) = x * 1e-9<GBps> / 1.0<Bps>
        let toTerabytesPerSecond (x: float<Bps>) = x * 1e-12<TBps> / 1.0<Bps>
        let toPetabytesPerSecond (x: float<Bps>) = x * 1e-15<PBps> / 1.0<Bps>

    [<RequireQualifiedAccess>]
    module KilobytePerSecond =

        let create (x: float) = x * 1.0<kBps>
        let toBauds (x: float<kBps>) = x * 8e+3<baud> / 1.0<kBps>
        let toBitsPerSecond (x: float<kBps>) = x * 8e+3<bps> / 1.0<kBps>
        let toKilobitsPerSecond (x: float<kBps>) = x * 8.0<kbps> / 1.0<kBps>
        let toMegabitsPerSecond (x: float<kBps>) = x * 8e-3<Mbps> / 1.0<kBps>
        let toGigabitsPerSecond (x: float<kBps>) = x * 8e-6<Gbps> / 1.0<kBps>
        let toTerabitsPerSecond (x: float<kBps>) = x * 8e-9<Tbps> / 1.0<kBps>
        let toPetabitsPerSecond (x: float<kBps>) = x * 8e-12<Pbps> / 1.0<kBps>
        let toBytesPerSecond (x: float<kBps>) = x * 1e+3<Bps> / 1.0<kBps>
        let toMegabytesPerSecond (x: float<kBps>) = x * 1e-3<MBps> / 1.0<kBps>
        let toGigabytesPerSecond (x: float<kBps>) = x * 1e-6<GBps> / 1.0<kBps>
        let toTerabytesPerSecond (x: float<kBps>) = x * 1e-9<TBps> / 1.0<kBps>
        let toPetabytesPerSecond (x: float<kBps>) = x * 1e-12<PBps> / 1.0<kBps>

    [<RequireQualifiedAccess>]
    module MegabytePerSecond =

        let create (x: float) = x * 1.0<MBps>
        let toBauds (x: float<MBps>) = x * 8e+6<baud> / 1.0<MBps>
        let toBitsPerSecond (x: float<MBps>) = x * 8e+6<bps> / 1.0<MBps>
        let toKilobitsPerSecond (x: float<MBps>) = x * 8e+3<kbps> / 1.0<MBps>
        let toMegabitsPerSecond (x: float<MBps>) = x * 8.0<Mbps> / 1.0<MBps>
        let toGigabitsPerSecond (x: float<MBps>) = x * 8e-3<Gbps> / 1.0<MBps>
        let toTerabitsPerSecond (x: float<MBps>) = x * 8e-6<Tbps> / 1.0<MBps>
        let toPetabitsPerSecond (x: float<MBps>) = x * 8e-9<Pbps> / 1.0<MBps>
        let toBytesPerSecond (x: float<MBps>) = x * 1e+6<Bps> / 1.0<MBps>
        let toKilobytesPerSecond (x: float<MBps>) = x * 1e+3<kBps> / 1.0<MBps>
        let toGigabytesPerSecond (x: float<MBps>) = x * 1e-3<GBps> / 1.0<MBps>
        let toTerabytesPerSecond (x: float<MBps>) = x * 1e-6<TBps> / 1.0<MBps>
        let toPetabytesPerSecond (x: float<MBps>) = x * 1e-9<PBps> / 1.0<MBps>

    [<RequireQualifiedAccess>]
    module GigabytePerSecond =

        let create (x: float) = x * 1.0<GBps>
        let toBauds (x: float<GBps>) = x * 8e+9<baud> / 1.0<GBps>
        let toBitsPerSecond (x: float<GBps>) = x * 8e+9<bps> / 1.0<GBps>
        let toKilobitsPerSecond (x: float<GBps>) = x * 8e+6<kbps> / 1.0<GBps>
        let toMegabitsPerSecond (x: float<GBps>) = x * 8e+3<Mbps> / 1.0<GBps>
        let toGigabitsPerSecond (x: float<GBps>) = x * 8.0<Gbps> / 1.0<GBps>
        let toTerabitsPerSecond (x: float<GBps>) = x * 8e-3<Tbps> / 1.0<GBps>
        let toPetabitsPerSecond (x: float<GBps>) = x * 8e-6<Pbps> / 1.0<GBps>
        let toBytesPerSecond (x: float<GBps>) = x * 1e+9<Bps> / 1.0<GBps>
        let toKilobytesPerSecond (x: float<GBps>) = x * 1e+6<kBps> / 1.0<GBps>
        let toMegabytesPerSecond (x: float<GBps>) = x * 1e+3<MBps> / 1.0<GBps>
        let toTerabytesPerSecond (x: float<GBps>) = x * 1e-3<TBps> / 1.0<GBps>
        let toPetabytesPerSecond (x: float<GBps>) = x * 1e-6<PBps> / 1.0<GBps>

    [<RequireQualifiedAccess>]
    module TerabytePerSecond =

        let create (x: float) = x * 1.0<TBps>
        let toBauds (x: float<TBps>) = x * 8e+12<baud> / 1.0<TBps>
        let toBitsPerSecond (x: float<TBps>) = x * 8e+12<bps> / 1.0<TBps>
        let toKilobitsPerSecond (x: float<TBps>) = x * 8e+9<kbps> / 1.0<TBps>
        let toMegabitsPerSecond (x: float<TBps>) = x * 8e+6<Mbps> / 1.0<TBps>
        let toGigabitsPerSecond (x: float<TBps>) = x * 8e+3<Gbps> / 1.0<TBps>
        let toTerabitsPerSecond (x: float<TBps>) = x * 8.0<Tbps> / 1.0<TBps>
        let toPetabitsPerSecond (x: float<TBps>) = x * 8e-3<Pbps> / 1.0<TBps>
        let toBytesPerSecond (x: float<TBps>) = x * 1e+12<Bps> / 1.0<TBps>
        let toKilobytesPerSecond (x: float<TBps>) = x * 1e+9<kBps> / 1.0<TBps>
        let toMegabytesPerSecond (x: float<TBps>) = x * 1e+6<MBps> / 1.0<TBps>
        let toGigabytesPerSecond (x: float<TBps>) = x * 1e+3<GBps> / 1.0<TBps>
        let toPetabytesPerSecond (x: float<TBps>) = x * 1e-3<PBps> / 1.0<TBps>

    [<RequireQualifiedAccess>]
    module PetabytePerSecond =

        let create (x: float) = x * 1.0<PBps>
        let toBauds (x: float<PBps>) = x * 8e+15<baud> / 1.0<PBps>
        let toBitsPerSecond (x: float<PBps>) = x * 8e+15<bps> / 1.0<PBps>
        let toKilobitsPerSecond (x: float<PBps>) = x * 8e+12<kbps> / 1.0<PBps>
        let toMegabitsPerSecond (x: float<PBps>) = x * 8e+9<Mbps> / 1.0<PBps>
        let toGigabitsPerSecond (x: float<PBps>) = x * 8e+6<Gbps> / 1.0<PBps>
        let toTerabitsPerSecond (x: float<PBps>) = x * 8e+3<Tbps> / 1.0<PBps>
        let toPetabitsPerSecond (x: float<PBps>) = x * 8.0<Pbps> / 1.0<PBps>
        let toBytesPerSecond (x: float<PBps>) = x * 1e+15<Bps> / 1.0<PBps>
        let toKilobytesPerSecond (x: float<PBps>) = x * 1e+12<kBps> / 1.0<PBps>
        let toMegabytesPerSecond (x: float<PBps>) = x * 1e+9<MBps> / 1.0<PBps>
        let toGigabytesPerSecond (x: float<PBps>) = x * 1e+6<GBps> / 1.0<PBps>
        let toTerabytesPerSecond (x: float<PBps>) = x * 1e+3<TBps> / 1.0<PBps>
