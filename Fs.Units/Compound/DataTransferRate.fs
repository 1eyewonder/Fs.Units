namespace Fs.Units.DataTransferRate

open Fs.Units

module Units =
    
    /// Baud
    [<Measure>] type baud = DataStorage.Units.b / Time.Units.s
    
    /// Bit per second
    [<Measure>] type bps = DataStorage.Units.b / Time.Units.s
    
    /// Kilobit per second
    [<Measure>] type kbps = DataStorage.Units.kb / Time.Units.s
    
    /// Megabit per second
    [<Measure>] type Mbps = DataStorage.Units.Mb / Time.Units.s
    
    /// Gigabit per second
    [<Measure>] type Gbps = DataStorage.Units.Gb / Time.Units.s
    
    /// Terabit per second
    [<Measure>] type Tbps = DataStorage.Units.Tb / Time.Units.s
    
    /// Petabit per second
    [<Measure>] type Pbps = DataStorage.Units.Pb / Time.Units.s
    
    /// Byte per second
    [<Measure>] type Bps = DataStorage.Units.B / Time.Units.s
    
    /// Kilobyte per second
    [<Measure>] type kBps = DataStorage.Units.kB / Time.Units.s
    
    /// Megabyte per second
    [<Measure>] type MBps = DataStorage.Units.MB / Time.Units.s
    
    /// Gigabyte per second
    [<Measure>] type GBps = DataStorage.Units.GB / Time.Units.s
    
    /// Terabyte per second
    [<Measure>] type TBps = DataStorage.Units.TB / Time.Units.s
    
    /// Petabyte per second
    [<Measure>] type PBps = DataStorage.Units.PB / Time.Units.s

