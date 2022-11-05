namespace Fs.Units.Time

module Units =
    
    /// Nanosecond
    [<Measure>] type ns
    
    /// Microsecond
    [<Measure>] type us
    
    /// Millisecond
    [<Measure>] type ms
    
    /// Second
    [<Measure>] type s
    
    /// Minute
    [<Measure>] type min
    
    /// Hour
    [<Measure>] type hr
    
    /// Day
    [<Measure>] type day
    
    /// Week
    [<Measure>] type week
    
    /// Fortnight
    [<Measure>] type fortnight
    
    /// Month
    [<Measure>] type month
    
    /// Year
    [<Measure>] type year
    
    /// Decade
    [<Measure>] type decade
    
    /// Century
    [<Measure>] type century
    
    /// Millennium
    [<Measure>] type millennium
    
    /// Aeon
    [<Measure>] type eon

open Units

module Nanosecond =
    
    let create (x: float) = x * 1.0<ns>
    let toSeconds (x: float<ns>) = x * 1.0<s> / 1e-9<ns>
    let toMicroSeconds (x: float<ns>) = x * 1e-3<us> / 1.0<ns>
    let toMilliSeconds (x: float<ns>) = x * 1e-6<ms> / 1.0<ns>
    let toMinutes (x: float<ns>) = x * 1.0<min> / 6e+10<ns>
    let toHours (x: float<ns>) = x * 1.0<hr> / 3.6e+12<ns>
    let toDays (x: float<ns>) = x * 1.0<day> / 8.64e+13<ns>
    let toWeeks (x: float<ns>) = x * 1.0<week> / 6.048e+14<ns>
    let toFortnights (x: float<ns>) = x * 1.0<fortnight> / 1.21e+15<ns>
    let toMonths (x: float<ns>) = x * 1.0<month> / 2.628e+15<ns>
    let toYears (x: float<ns>) = x * 1.0<year> / 3.154e+16<ns>
    let toDecades (x: float<ns>) = x * 1.0<decade> / 3.154e+17<ns>
    let toCenturies (x: float<ns>) = x * 1.0<century> / 3.154e+18<ns>
    let toMillennia (x: float<ns>) = x * 1.0<millennium> / 3.154e+19<ns>
    let toEons (x: float<ns>) = x * 1.0<eon> / 3.1536e+25<ns>
    
module Microsecond =
    
    let create (x: float) = x * 1.0<us>
    let toSeconds (x: float<us>) = x * 1.0<s> / 1e-6<us>
    let toNanoSeconds (x: float<us>) = x * 1e+3<ns> / 1.0<us>
    let toMilliSeconds (x: float<us>) = x * 1e-3<ms> / 1.0<us>
    let toMinutes (x: float<us>) = x * 1.0<min> / 6e+7<us>
    let toHours (x: float<us>) = x * 1.0<hr> / 3.6e+9<us>
    let toDays (x: float<us>) = x * 1.0<day> / 8.64e+10<us>
    let toWeeks (x: float<us>) = x * 1.0<week> / 6.048e+11<us>
    let toFortnights (x: float<us>) = x * 1.0<fortnight> / 1.21e+12<us>
    let toMonths (x: float<us>) = x * 1.0<month> / 2.628e+12<us>
    let toYears (x: float<us>) = x * 1.0<year> / 3.154e+13<us>
    let toDecades (x: float<us>) = x * 1.0<decade> / 3.154e+14<us>
    let toCenturies (x: float<us>) = x * 1.0<century> / 3.154e+15<us>
    let toMillennia (x: float<us>) = x * 1.0<millennium> / 3.154e+16<us>
    let toEons (x: float<us>) = x * 1.0<eon> / 3.1536e+22<us>
    
module Millisecond =
    
    let create (x: float) = x * 1.0<ms>
    let toSeconds (x: float<ms>) = x * 1.0<s> / 1e-3<ms>
    let toNanoSeconds (x: float<ms>) = x * 1e+6<ns> / 1.0<ms>
    let toMicroSeconds (x: float<ms>) = x * 1e+3<us> / 1.0<ms>
    let toMinutes (x: float<ms>) = x * 1.0<min> / 6e+4<ms>
    let toHours (x: float<ms>) = x * 1.0<hr> / 3.6e+6<ms>
    let toDays (x: float<ms>) = x * 1.0<day> / 8.64e+7<ms>
    let toWeeks (x: float<ms>) = x * 1.0<week> / 6.048e+8<ms>
    let toFortnights (x: float<ms>) = x * 1.0<fortnight> / 1.21e+9<ms>
    let toMonths (x: float<ms>) = x * 1.0<month> / 2.628e+9<ms>
    let toYears (x: float<ms>) = x * 1.0<year> / 3.154e+10<ms>
    let toDecades (x: float<ms>) = x * 1.0<decade> / 3.154e+11<ms>
    let toCenturies (x: float<ms>) = x * 1.0<century> / 3.154e+12<ms>
    let toMillennia (x: float<ms>) = x * 1.0<millennium> / 3.154e+13<ms>
    let toEons (x: float<ms>) = x * 1.0<eon> / 3.1536e+19<ms>
    
module Second =
    
    let create (x: float) = x * 1.0<s>
    let toNanoSeconds (x: float<s>) = x * 1e-9<ns> / 1.0<s>
    let toMicroSeconds (x: float<s>) = x * 1e-6<us> / 1.0<s>
    let toMilliSeconds (x: float<s>) = x * 1e-3<ms> / 1.0<s>
    let toMinutes (x: float<s>) = x * 1.0<min> / 60.0<s>
    let toHours (x: float<s>) = x * 1.0<hr> / 3600.0<s>
    let toDays (x: float<s>) = x * 1.0<day> / 86400.0<s>
    let toWeeks (x: float<s>) = x * 1.0<week> / 604800.0<s>
    let toFortnights (x: float<s>) = x * 1.0<fortnight> / 1209600.0<s>
    let toMonths (x: float<s>) = x * 1.0<month> / 2.628e+6<s>
    let toYears (x: float<s>) = x * 1.0<year> / 3.154e+7<s>
    let toDecades (x: float<s>) = x * 1.0<decade> / 3.154e+8<s>
    let toCenturies (x: float<s>) = x * 1.0<century> / 3.154e+9<s>
    let toMillennia (x: float<s>) = x * 1.0<millennium> / 3.154e+10<s>
    let toEons (x: float<s>) = x * 1.0<eon> / 3.1536e+16<s>
    
module Minute =
    
    let create (x: float) = x * 1.0<min>
    let toNanoSeconds (x: float<min>) = x * 6e+10<ns> / 1.0<min>
    let toMicroSeconds (x: float<min>) = x * 6e+7<us> / 1.0<min>
    let toMilliSeconds (x: float<min>) = x * 6e+4<ms> / 1.0<min>
    let toSeconds (x: float<min>) = x * 60.0<s> / 1.0<min>
    let toHours (x: float<min>) = x * 1.0<hr> / 60.0<min>
    let toDays (x: float<min>) = x * 1.0<day> / 1440.0<min>
    let toWeeks (x: float<min>) = x * 1.0<week> / 10080.0<min>
    let toFortnights (x: float<min>) = x * 1.0<fortnight> / 20160.0<min>
    let toMonths (x: float<min>) = x * 1.0<month> / 4.38e4<min>
    let toYears (x: float<min>) = x * 1.0<year> / 5.256e5<min>
    let toDecades (x: float<min>) = x * 1.0<decade> / 5.256e+6<min>
    let toCenturies (x: float<min>) = x * 1.0<century> / 5.256e+7<min>
    let toMillennia (x: float<min>) = x * 1.0<millennium> / 5.256e+9<min>
    let toEons (x: float<min>) = x * 1.0<eon> / 5.256e+14<min>
    
module Hour =
    
    let create (x: float) = x * 1.0<hr>
    let toNanoSeconds (x: float<hr>) = x * 3.6e+12<ns> / 1.0<hr>
    let toMicroSeconds (x: float<hr>) = x * 3.6e+9<us> / 1.0<hr>
    let toMilliSeconds (x: float<hr>) = x * 3.6e+6<ms> / 1.0<hr>
    let toSeconds (x: float<hr>) = x * 3600.0<s> / 1.0<hr>
    let toMinutes (x: float<hr>) = x * 60.0<min> / 1.0<hr>
    let toDays (x: float<hr>) = x * 1.0<day> / 24.0<hr>
    let toWeeks (x: float<hr>) = x * 1.0<week> / 168.0<hr>
    let toFortnights (x: float<hr>) = x * 1.0<fortnight> / 336.0<hr>
    let toMonths (x: float<hr>) = x * 1.0<month> / 730.0<hr>
    let toYears (x: float<hr>) = x * 1.0<year> / 8760.0<hr>
    let toDecades (x: float<hr>) = x * 1.0<decade> / 87600.0<hr>
    let toCenturies (x: float<hr>) = x * 1.0<century> / 876_582.0<hr>
    let toMillennia (x: float<hr>) = x * 1.0<millennium> / 8.76e+7<hr>
    let toEons (x: float<hr>) = x * 1.0<eon> / 8.76e+12<hr>
    
module Day =
    
    let create (x: float) = x * 1.0<day>
    let toNanoSeconds (x: float<day>) = x * 8.64e+13<ns> / 1.0<day>
    let toMicroSeconds (x: float<day>) = x * 8.64e+10<us> / 1.0<day>
    let toMilliSeconds (x: float<day>) = x * 8.64e+7<ms> / 1.0<day>
    let toSeconds (x: float<day>) = x * 86400.0<s> / 1.0<day>
    let toMinutes (x: float<day>) = x * 1440.0<min> / 1.0<day>
    let toHours (x: float<day>) = x * 24.0<hr> / 1.0<day>
    let toWeeks (x: float<day>) = x * 1.0<week> / 7.0<day>
    let toFortnights (x: float<day>) = x * 1.0<fortnight> / 14.0<day>
    let toMonths (x: float<day>) = x * 1.0<month> / 30.44<day>
    let toYears (x: float<day>) = x * 1.0<year> / 365.25<day>
    let toDecades (x: float<day>) = x * 1.0<decade> / 3652.5<day>
    let toCenturies (x: float<day>) = x * 1.0<century> / 36525.0<day>
    let toMillennia (x: float<day>) = x * 1.0<millennium> / 3.6525e+6<day>
    let toEons (x: float<day>) = x * 1.0<eon> / 3.65e+11<day>
    
module Week =
    
    let create (x: float) = x * 1.0<week>
    let toNanoSeconds (x: float<week>) = x * 6.048e+14<ns> / 1.0<week>
    let toMicroSeconds (x: float<week>) = x * 6.048e+11<us> / 1.0<week>
    let toMilliSeconds (x: float<week>) = x * 6.048e+8<ms> / 1.0<week>
    let toSeconds (x: float<week>) = x * 604800.0<s> / 1.0<week>
    let toMinutes (x: float<week>) = x * 10080.0<min> / 1.0<week>
    let toHours (x: float<week>) = x * 168.0<hr> / 1.0<week>
    let toDays (x: float<week>) = x * 7.0<day> / 1.0<week>
    let toFortnights (x: float<week>) = x * 1.0<fortnight> / 2.0<week>
    let toMonths (x: float<week>) = x * 1.0<month> / 4.345<week>
    let toYears (x: float<week>) = x * 1.0<year> / 52.143<week>
    let toDecades (x: float<week>) = x * 1.0<decade> / 521.43<week>
    let toCenturies (x: float<week>) = x * 1.0<century> / 5214.3<week>
    let toMillennia (x: float<week>) = x * 1.0<millennium> / 5.2143e+5<week>
    let toEons (x: float<week>) = x * 1.0<eon> / 52142857142.857<week>
    
module Fortnight =
    
    let create (x: float) = x * 1.0<fortnight>
    let toNanoSeconds (x: float<fortnight>) = x * 1.21e+15<ns> / 1.0<fortnight>
    let toMicroSeconds (x: float<fortnight>) = x * 1.21e+12<us> / 1.0<fortnight>
    let toMilliSeconds (x: float<fortnight>) = x * 1.21e+9<ms> / 1.0<fortnight>
    let toSeconds (x: float<fortnight>) = x * 1.2096e+6<s> / 1.0<fortnight>
    let toMinutes (x: float<fortnight>) = x * 20160.0<min> / 1.0<fortnight>
    let toHours (x: float<fortnight>) = x * 336.0<hr> / 1.0<fortnight>
    let toDays (x: float<fortnight>) = x * 14.0<day> / 1.0<fortnight>
    let toWeeks (x: float<fortnight>) = x * 2.0<week> / 1.0<fortnight>
    let toMonths (x: float<fortnight>) = x * 1.0<month> / 2.173<fortnight>
    let toYears (x: float<fortnight>) = x * 1.0<year> / 26.071<fortnight>
    let toDecades (x: float<fortnight>) = x * 1.0<decade> / 260.71<fortnight>
    let toCenturies (x: float<fortnight>) = x * 1.0<century> / 2607.1<fortnight>
    let toMillennia (x: float<fortnight>) = x * 1.0<millennium> / 26066.115702479<fortnight>
    let toEons (x: float<fortnight>) = x * 1.0<eon> /  26062809917.355<fortnight>
    
module Month =
    
    let create (x: float) = x * 1.0<month>
    let toNanoSeconds (x: float<month>) = x * 2.628e+15<ns> / 1.0<month>
    let toMicroSeconds (x: float<month>) = x * 2.628e+12<us> / 1.0<month>
    let toMilliSeconds (x: float<month>) = x * 2.628e+9<ms> / 1.0<month>
    let toSeconds (x: float<month>) = x * 2.628e+6<s> / 1.0<month>
    let toMinutes (x: float<month>) = x * 4.38e4<min> / 1.0<month>
    let toHours (x: float<month>) = x * 730.0<hr> / 1.0<month>
    let toDays (x: float<month>) = x * 30.44<day> / 1.0<month>
    let toWeeks (x: float<month>) = x * 4.345<week> / 1.0<month>
    let toFortnights (x: float<month>) = x * 2.173<fortnight> / 1.0<month>
    let toYears (x: float<month>) = x * 1.0<year> / 12.0<month>
    let toDecades (x: float<month>) = x * 1.0<decade> / 120.0<month>
    let toCenturies (x: float<month>) = x * 1.0<century> / 1200.0<month>
    let toMillennia (x: float<month>) = x * 1.0<millennium> / 1.2e+7<month>
    let toEons (x: float<month>) = x * 1.0<eon> / 1.2e+13<month>
    
module Year =
    
    let create (x: float) = x * 1.0<year>
    let toNanoSeconds (x: float<year>) = x * 3.154e+16<ns> / 1.0<year>
    let toMicroSeconds (x: float<year>) = x * 3.154e+13<us> / 1.0<year>
    let toMilliSeconds (x: float<year>) = x * 3.154e+10<ms> / 1.0<year>
    let toSeconds (x: float<year>) = x * 3.154e+7<s> / 1.0<year>
    let toMinutes (x: float<year>) = x * 5.256e5<min> / 1.0<year>
    let toHours (x: float<year>) = x * 8760.0<hr> / 1.0<year>
    let toDays (x: float<year>) = x * 365.25<day> / 1.0<year>
    let toWeeks (x: float<year>) = x * 52.143<week> / 1.0<year>
    let toFortnights (x: float<year>) = x * 26.071<fortnight> / 1.0<year>
    let toMonths (x: float<year>) = x * 12.0<month> / 1.0<year>
    let toDecades (x: float<year>) = x * 1.0<decade> / 10.0<year>
    let toCenturies (x: float<year>) = x * 1.0<century> / 100.0<year>
    let toMillennia (x: float<year>) = x * 1.0<millennium> / 1000.0<year>
    let toEons (x: float<year>) = x * 1.0<eon> / 1e+12<year>
    
module Decade =
    
    let create (x: float) = x * 1.0<decade>
    let toNanoSeconds (x: float<decade>) = x * 3.154e+17<ns> / 1.0<decade>
    let toMicroSeconds (x: float<decade>) = x * 3.154e+14<us> / 1.0<decade>
    let toMilliSeconds (x: float<decade>) = x * 3.154e+11<ms> / 1.0<decade>
    let toSeconds (x: float<decade>) = x * 3.154e+8<s> / 1.0<decade>
    let toMinutes (x: float<decade>) = x * 5.256e+6<min> / 1.0<decade>
    let toHours (x: float<decade>) = x * 87600.0<hr> / 1.0<decade>
    let toDays (x: float<decade>) = x * 3652.5<day> / 1.0<decade>
    let toWeeks (x: float<decade>) = x * 521.43<week> / 1.0<decade>
    let toFortnights (x: float<decade>) = x * 260.71<fortnight> / 1.0<decade>
    let toMonths (x: float<decade>) = x * 120.0<month> / 1.0<decade>
    let toYears (x: float<decade>) = x * 10.0<year> / 1.0<decade>
    let toCenturies (x: float<decade>) = x * 1.0<century> / 10.0<decade>
    let toMillennia (x: float<decade>) = x * 1.0<millennium> / 100.0<decade>
    let toEons (x: float<decade>) = x * 1.0<eon> / 1e+11<decade>
    
module Century =
    
    let create (x: float) = x * 1.0<century>
    let toNanoSeconds (x: float<century>) = x * 3.154e+18<ns> / 1.0<century>
    let toMicroSeconds (x: float<century>) = x * 3.154e+15<us> / 1.0<century>
    let toMilliSeconds (x: float<century>) = x * 3.154e+12<ms> / 1.0<century>
    let toSeconds (x: float<century>) = x * 3.154e+9<s> / 1.0<century>
    let toMinutes (x: float<century>) = x * 5.256e+7<min> / 1.0<century>
    let toHours (x: float<century>) = x * 876_582.0<hr> / 1.0<century>
    let toDays (x: float<century>) = x * 36525.0<day> / 1.0<century>
    let toWeeks (x: float<century>) = x * 5214.3<week> / 1.0<century>
    let toFortnights (x: float<century>) = x * 2607.1<fortnight> / 1.0<century>
    let toMonths (x: float<century>) = x * 1200.0<month> / 1.0<century>
    let toYears (x: float<century>) = x * 100.0<year> / 1.0<century>
    let toDecades (x: float<century>) = x * 10.0<decade> / 1.0<century>
    let toMillennia (x: float<century>) = x * 1.0<millennium> / 10.0<century>
    let toEons (x: float<century>) = x * 1.0<eon> / 1e+10<century>
    
module Millennium =
    
    let create (x: float) = x * 1.0<millennium>
    let toNanoSeconds (x: float<millennium>) = x * 3.154e+19<ns> / 1.0<millennium>
    let toMicroSeconds (x: float<millennium>) = x * 3.154e+16<us> / 1.0<millennium>
    let toMilliSeconds (x: float<millennium>) = x * 3.154e+13<ms> / 1.0<millennium>
    let toSeconds (x: float<millennium>) = x * 3.154e+10<s> / 1.0<millennium>
    let toMinutes (x: float<millennium>) = x * 5.256e+9<min> / 1.0<millennium>
    let toHours (x: float<millennium>) = x * 8.76e+7<hr> / 1.0<millennium>
    let toDays (x: float<millennium>) = x * 3.6525e+6<day> / 1.0<millennium>
    let toWeeks (x: float<millennium>) = x * 5.2143e+5<week> / 1.0<millennium>
    let toFortnights (x: float<millennium>) = x * 26066.115702479<fortnight> / 1.0<millennium>
    let toMonths (x: float<millennium>) = x * 1.2e+7<month> / 1.0<millennium>
    let toYears (x: float<millennium>) = x * 1000.0<year> / 1.0<millennium>
    let toDecades (x: float<millennium>) = x * 100.0<decade> / 1.0<millennium>
    let toCenturies (x: float<millennium>) = x * 10.0<century> / 1.0<millennium>
    let toEons (x: float<millennium>) = x * 1.0<eon> / 1e+9<millennium>
    
module Eon =
    
    let create (x: float) = x * 1.0<eon>
    let toNanoSeconds (x: float<eon>) = x * 3.1536e+25<ns> / 1.0<eon>
    let toMicroSeconds (x: float<eon>) = x * 3.1536e+22<us> / 1.0<eon>
    let toMilliSeconds (x: float<eon>) = x * 3.1536e+19<ms> / 1.0<eon>
    let toSeconds (x: float<eon>) = x * 3.1536e+16<s> / 1.0<eon>
    let toMinutes (x: float<eon>) = x * 5.256e+14<min> / 1.0<eon>
    let toHours (x: float<eon>) = x * 8.76e+12<hr> / 1.0<eon> 
    let toDays (x: float<eon>) = x * 3.65e+11<day> / 1.0<eon>
    let toWeeks (x: float<eon>) = x * 52142857142.857<week> / 1.0<eon>
    let toFortnights (x: float<eon>) = x *  26062809917.355<fortnight> / 1.0<eon>
    let toMonths (x: float<eon>) = x * 1.2e+13<month> / 1.0<eon>
    let toYears (x: float<eon>) = x * 1e+12<year> / 1.0<eon>
    let toDecades (x: float<eon>) = x * 1e+11<decade> / 1.0<eon>
    let toCenturies (x: float<eon>) = x * 1e+10<century> / 1.0<eon>
    let toMillennia (x: float<eon>) = x * 1e+9<millennium> / 1.0<eon>
