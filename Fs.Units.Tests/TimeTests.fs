module TimeTests

open Expecto
open Fs.Units.Time
open Helpers

[<Tests>]
let tests config =
    
    let nanoSecondConversionTests =
        [
            "From nanosecond to microsecond and back", (fun x -> Nanosecond.create x |> Nanosecond.toMicroSeconds |> Microsecond.toNanoSeconds)
            "From nanosecond to millisecond and back", (fun x -> Nanosecond.create x |> Nanosecond.toMilliSeconds |> Millisecond.toNanoSeconds)
            "From nanosecond to second and back", (fun x -> Nanosecond.create x |> Nanosecond.toSeconds |> Second.toNanoSeconds)
            "From nanosecond to minute and back", (fun x -> Nanosecond.create x |> Nanosecond.toMinutes |> Minute.toNanoSeconds)
            "From nanosecond to hour and back", (fun x -> Nanosecond.create x |> Nanosecond.toHours |> Hour.toNanoSeconds)
            "From nanosecond to day and back", (fun x -> Nanosecond.create x |> Nanosecond.toDays |> Day.toNanoSeconds)
            "From nanosecond to week and back", (fun x -> Nanosecond.create x |> Nanosecond.toWeeks |> Week.toNanoSeconds)
            "From nanosecond to fortnight and back", (fun x -> Nanosecond.create x |> Nanosecond.toFortnights |> Fortnight.toNanoSeconds)
            "From nanosecond to month and back", (fun x -> Nanosecond.create x |> Nanosecond.toMonths |> Month.toNanoSeconds)
            "From nanosecond to year and back", (fun x -> Nanosecond.create x |> Nanosecond.toYears |> Year.toNanoSeconds)
            "From nanosecond to decade and back", (fun x -> Nanosecond.create x |> Nanosecond.toDecades |> Decade.toNanoSeconds)
            "From nanosecond to century and back", (fun x -> Nanosecond.create x |> Nanosecond.toCenturies |> Century.toNanoSeconds)
            "From nanosecond to millennium and back", (fun x -> Nanosecond.create x |> Nanosecond.toMillennia |> Millennium.toNanoSeconds)
            "From nanosecond to eon and back", (fun x -> Nanosecond.create x |> Nanosecond.toEons |> Eon.toNanoSeconds)          
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let microSecondConversionTests =
        [
            "From microsecond to nanosecond and back", (fun x -> Microsecond.create x |> Microsecond.toNanoSeconds |> Nanosecond.toMicroSeconds)
            "From microsecond to millisecond and back", (fun x -> Microsecond.create x |> Microsecond.toMilliSeconds |> Millisecond.toMicroSeconds)
            "From microsecond to second and back", (fun x -> Microsecond.create x |> Microsecond.toSeconds |> Second.toMicroSeconds)
            "From microsecond to minute and back", (fun x -> Microsecond.create x |> Microsecond.toMinutes |> Minute.toMicroSeconds)
            "From microsecond to hour and back", (fun x -> Microsecond.create x |> Microsecond.toHours |> Hour.toMicroSeconds)
            "From microsecond to day and back", (fun x -> Microsecond.create x |> Microsecond.toDays |> Day.toMicroSeconds)
            "From microsecond to week and back", (fun x -> Microsecond.create x |> Microsecond.toWeeks |> Week.toMicroSeconds)
            "From microsecond to fortnight and back", (fun x -> Microsecond.create x |> Microsecond.toFortnights |> Fortnight.toMicroSeconds)
            "From microsecond to month and back", (fun x -> Microsecond.create x |> Microsecond.toMonths |> Month.toMicroSeconds)
            "From microsecond to year and back", (fun x -> Microsecond.create x |> Microsecond.toYears |> Year.toMicroSeconds)
            "From microsecond to decade and back", (fun x -> Microsecond.create x |> Microsecond.toDecades |> Decade.toMicroSeconds)
            "From microsecond to century and back", (fun x -> Microsecond.create x |> Microsecond.toCenturies |> Century.toMicroSeconds)
            "From microsecond to millennium and back", (fun x -> Microsecond.create x |> Microsecond.toMillennia |> Millennium.toMicroSeconds)
            "From microsecond to eon and back", (fun x -> Microsecond.create x |> Microsecond.toEons |> Eon.toMicroSeconds)          
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
    
    let milliSecondConversionTests =
        [
            "From millisecond to nanosecond and back", (fun x -> Millisecond.create x |> Millisecond.toNanoSeconds |> Nanosecond.toMilliSeconds)
            "From millisecond to microsecond and back", (fun x -> Millisecond.create x |> Millisecond.toMicroSeconds |> Microsecond.toMilliSeconds)
            "From millisecond to second and back", (fun x -> Millisecond.create x |> Millisecond.toSeconds |> Second.toMilliSeconds)
            "From millisecond to minute and back", (fun x -> Millisecond.create x |> Millisecond.toMinutes |> Minute.toMilliSeconds)
            "From millisecond to hour and back", (fun x -> Millisecond.create x |> Millisecond.toHours |> Hour.toMilliSeconds)
            "From millisecond to day and back", (fun x -> Millisecond.create x |> Millisecond.toDays |> Day.toMilliSeconds)
            "From millisecond to week and back", (fun x -> Millisecond.create x |> Millisecond.toWeeks |> Week.toMilliSeconds)
            "From millisecond to fortnight and back", (fun x -> Millisecond.create x |> Millisecond.toFortnights |> Fortnight.toMilliSeconds)
            "From millisecond to month and back", (fun x -> Millisecond.create x |> Millisecond.toMonths |> Month.toMilliSeconds)
            "From millisecond to year and back", (fun x -> Millisecond.create x |> Millisecond.toYears |> Year.toMilliSeconds)
            "From millisecond to decade and back", (fun x -> Millisecond.create x |> Millisecond.toDecades |> Decade.toMilliSeconds)
            "From millisecond to century and back", (fun x -> Millisecond.create x |> Millisecond.toCenturies |> Century.toMilliSeconds)
            "From millisecond to millennium and back", (fun x -> Millisecond.create x |> Millisecond.toMillennia |> Millennium.toMilliSeconds)
            "From millisecond to eon and back", (fun x -> Millisecond.create x |> Millisecond.toEons |> Eon.toMilliSeconds)          
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let secondConversionTests =
        [
            "From second to nanosecond and back", (fun x -> Second.create x |> Second.toNanoSeconds |> Nanosecond.toSeconds)
            "From second to microsecond and back", (fun x -> Second.create x |> Second.toMicroSeconds |> Microsecond.toSeconds)
            "From second to millisecond and back", (fun x -> Second.create x |> Second.toMilliSeconds |> Millisecond.toSeconds)
            "From second to minute and back", (fun x -> Second.create x |> Second.toMinutes |> Minute.toSeconds)
            "From second to hour and back", (fun x -> Second.create x |> Second.toHours |> Hour.toSeconds)
            "From second to day and back", (fun x -> Second.create x |> Second.toDays |> Day.toSeconds)
            "From second to week and back", (fun x -> Second.create x |> Second.toWeeks |> Week.toSeconds)
            "From second to fortnight and back", (fun x -> Second.create x |> Second.toFortnights |> Fortnight.toSeconds)
            "From second to month and back", (fun x -> Second.create x |> Second.toMonths |> Month.toSeconds)
            "From second to year and back", (fun x -> Second.create x |> Second.toYears |> Year.toSeconds)
            "From second to decade and back", (fun x -> Second.create x |> Second.toDecades |> Decade.toSeconds)
            "From second to century and back", (fun x -> Second.create x |> Second.toCenturies |> Century.toSeconds)
            "From second to millennium and back", (fun x -> Second.create x |> Second.toMillennia |> Millennium.toSeconds)
            "From second to eon and back", (fun x -> Second.create x |> Second.toEons |> Eon.toSeconds)          
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let minuteConversionTests =
        [
            "From minute to nanosecond and back", (fun x -> Minute.create x |> Minute.toNanoSeconds |> Nanosecond.toMinutes)
            "From minute to microsecond and back", (fun x -> Minute.create x |> Minute.toMicroSeconds |> Microsecond.toMinutes)
            "From minute to millisecond and back", (fun x -> Minute.create x |> Minute.toMilliSeconds |> Millisecond.toMinutes)
            "From minute to second and back", (fun x -> Minute.create x |> Minute.toSeconds |> Second.toMinutes)
            "From minute to hour and back", (fun x -> Minute.create x |> Minute.toHours |> Hour.toMinutes)
            "From minute to day and back", (fun x -> Minute.create x |> Minute.toDays |> Day.toMinutes)
            "From minute to week and back", (fun x -> Minute.create x |> Minute.toWeeks |> Week.toMinutes)
            "From minute to fortnight and back", (fun x -> Minute.create x |> Minute.toFortnights |> Fortnight.toMinutes)
            "From minute to month and back", (fun x -> Minute.create x |> Minute.toMonths |> Month.toMinutes)
            "From minute to year and back", (fun x -> Minute.create x |> Minute.toYears |> Year.toMinutes)
            "From minute to decade and back", (fun x -> Minute.create x |> Minute.toDecades |> Decade.toMinutes)
            "From minute to century and back", (fun x -> Minute.create x |> Minute.toCenturies |> Century.toMinutes)
            "From minute to millennium and back", (fun x -> Minute.create x |> Minute.toMillennia |> Millennium.toMinutes)
            "From minute to eon and back", (fun x -> Minute.create x |> Minute.toEons |> Eon.toMinutes)          
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let hourConversionTests =
        [
            "From hour to nanosecond and back", (fun x -> Hour.create x |> Hour.toNanoSeconds |> Nanosecond.toHours)
            "From hour to microsecond and back", (fun x -> Hour.create x |> Hour.toMicroSeconds |> Microsecond.toHours)
            "From hour to millisecond and back", (fun x -> Hour.create x |> Hour.toMilliSeconds |> Millisecond.toHours)
            "From hour to second and back", (fun x -> Hour.create x |> Hour.toSeconds |> Second.toHours)
            "From hour to minute and back", (fun x -> Hour.create x |> Hour.toMinutes |> Minute.toHours)
            "From hour to day and back", (fun x -> Hour.create x |> Hour.toDays |> Day.toHours)
            "From hour to week and back", (fun x -> Hour.create x |> Hour.toWeeks |> Week.toHours)
            "From hour to fortnight and back", (fun x -> Hour.create x |> Hour.toFortnights |> Fortnight.toHours)
            "From hour to month and back", (fun x -> Hour.create x |> Hour.toMonths |> Month.toHours)
            "From hour to year and back", (fun x -> Hour.create x |> Hour.toYears |> Year.toHours)
            "From hour to decade and back", (fun x -> Hour.create x |> Hour.toDecades |> Decade.toHours)
            "From hour to century and back", (fun x -> Hour.create x |> Hour.toCenturies |> Century.toHours)
            "From hour to millennium and back", (fun x -> Hour.create x |> Hour.toMillennia |> Millennium.toHours)
            "From hour to eon and back", (fun x -> Hour.create x |> Hour.toEons |> Eon.toHours)          
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let dayConversionTests =
        [
            "From day to nanosecond and back", (fun x -> Day.create x |> Day.toNanoSeconds |> Nanosecond.toDays)
            "From day to microsecond and back", (fun x -> Day.create x |> Day.toMicroSeconds |> Microsecond.toDays)
            "From day to millisecond and back", (fun x -> Day.create x |> Day.toMilliSeconds |> Millisecond.toDays)
            "From day to second and back", (fun x -> Day.create x |> Day.toSeconds |> Second.toDays)
            "From day to minute and back", (fun x -> Day.create x |> Day.toMinutes |> Minute.toDays)
            "From day to hour and back", (fun x -> Day.create x |> Day.toHours |> Hour.toDays)
            "From day to week and back", (fun x -> Day.create x |> Day.toWeeks |> Week.toDays)
            "From day to fortnight and back", (fun x -> Day.create x |> Day.toFortnights |> Fortnight.toDays)
            "From day to month and back", (fun x -> Day.create x |> Day.toMonths |> Month.toDays)
            "From day to year and back", (fun x -> Day.create x |> Day.toYears |> Year.toDays)
            "From day to decade and back", (fun x -> Day.create x |> Day.toDecades |> Decade.toDays)
            "From day to century and back", (fun x -> Day.create x |> Day.toCenturies |> Century.toDays)
            "From day to millennium and back", (fun x -> Day.create x |> Day.toMillennia |> Millennium.toDays)
            "From day to eon and back", (fun x -> Day.create x |> Day.toEons |> Eon.toDays)          
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let weekConversionTests =
        [
            "From week to nanosecond and back", (fun x -> Week.create x |> Week.toNanoSeconds |> Nanosecond.toWeeks)
            "From week to microsecond and back", (fun x -> Week.create x |> Week.toMicroSeconds |> Microsecond.toWeeks)
            "From week to millisecond and back", (fun x -> Week.create x |> Week.toMilliSeconds |> Millisecond.toWeeks)
            "From week to second and back", (fun x -> Week.create x |> Week.toSeconds |> Second.toWeeks)
            "From week to minute and back", (fun x -> Week.create x |> Week.toMinutes |> Minute.toWeeks)
            "From week to hour and back", (fun x -> Week.create x |> Week.toHours |> Hour.toWeeks)
            "From week to day and back", (fun x -> Week.create x |> Week.toDays |> Day.toWeeks)
            "From week to fortnight and back", (fun x -> Week.create x |> Week.toFortnights |> Fortnight.toWeeks)
            "From week to month and back", (fun x -> Week.create x |> Week.toMonths |> Month.toWeeks)
            "From week to year and back", (fun x -> Week.create x |> Week.toYears |> Year.toWeeks)
            "From week to decade and back", (fun x -> Week.create x |> Week.toDecades |> Decade.toWeeks)
            "From week to century and back", (fun x -> Week.create x |> Week.toCenturies |> Century.toWeeks)
            "From week to millennium and back", (fun x -> Week.create x |> Week.toMillennia |> Millennium.toWeeks)
            "From week to eon and back", (fun x -> Week.create x |> Week.toEons |> Eon.toWeeks)          
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let fortnightConversionTests =
        [
            "From fortnight to nanosecond and back", (fun x -> Fortnight.create x |> Fortnight.toNanoSeconds |> Nanosecond.toFortnights)
            "From fortnight to microsecond and back", (fun x -> Fortnight.create x |> Fortnight.toMicroSeconds |> Microsecond.toFortnights)
            "From fortnight to millisecond and back", (fun x -> Fortnight.create x |> Fortnight.toMilliSeconds |> Millisecond.toFortnights)
            "From fortnight to second and back", (fun x -> Fortnight.create x |> Fortnight.toSeconds |> Second.toFortnights)
            "From fortnight to minute and back", (fun x -> Fortnight.create x |> Fortnight.toMinutes |> Minute.toFortnights)
            "From fortnight to hour and back", (fun x -> Fortnight.create x |> Fortnight.toHours |> Hour.toFortnights)
            "From fortnight to day and back", (fun x -> Fortnight.create x |> Fortnight.toDays |> Day.toFortnights)
            "From fortnight to week and back", (fun x -> Fortnight.create x |> Fortnight.toWeeks |> Week.toFortnights)
            "From fortnight to month and back", (fun x -> Fortnight.create x |> Fortnight.toMonths |> Month.toFortnights)
            "From fortnight to year and back", (fun x -> Fortnight.create x |> Fortnight.toYears |> Year.toFortnights)
            "From fortnight to decade and back", (fun x -> Fortnight.create x |> Fortnight.toDecades |> Decade.toFortnights)
            "From fortnight to century and back", (fun x -> Fortnight.create x |> Fortnight.toCenturies |> Century.toFortnights)
            "From fortnight to millennium and back", (fun x -> Fortnight.create x |> Fortnight.toMillennia |> Millennium.toFortnights)
            "From fortnight to eon and back", (fun x -> Fortnight.create x |> Fortnight.toEons |> Eon.toFortnights)          
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let monthConversionTests =
        [
            "From month to nanosecond and back", (fun x -> Month.create x |> Month.toNanoSeconds |> Nanosecond.toMonths)
            "From month to microsecond and back", (fun x -> Month.create x |> Month.toMicroSeconds |> Microsecond.toMonths)
            "From month to millisecond and back", (fun x -> Month.create x |> Month.toMilliSeconds |> Millisecond.toMonths)
            "From month to second and back", (fun x -> Month.create x |> Month.toSeconds |> Second.toMonths)
            "From month to minute and back", (fun x -> Month.create x |> Month.toMinutes |> Minute.toMonths)
            "From month to hour and back", (fun x -> Month.create x |> Month.toHours |> Hour.toMonths)
            "From month to day and back", (fun x -> Month.create x |> Month.toDays |> Day.toMonths)
            "From month to week and back", (fun x -> Month.create x |> Month.toWeeks |> Week.toMonths)
            "From month to fortnight and back", (fun x -> Month.create x |> Month.toFortnights |> Fortnight.toMonths)
            "From month to year and back", (fun x -> Month.create x |> Month.toYears |> Year.toMonths)
            "From month to decade and back", (fun x -> Month.create x |> Month.toDecades |> Decade.toMonths)
            "From month to century and back", (fun x -> Month.create x |> Month.toCenturies |> Century.toMonths)
            "From month to millennium and back", (fun x -> Month.create x |> Month.toMillennia |> Millennium.toMonths)
            "From month to eon and back", (fun x -> Month.create x |> Month.toEons |> Eon.toMonths)          
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let yearConversionTests =
        [
            "From year to nanosecond and back", (fun x -> Year.create x |> Year.toNanoSeconds |> Nanosecond.toYears)
            "From year to microsecond and back", (fun x -> Year.create x |> Year.toMicroSeconds |> Microsecond.toYears)
            "From year to millisecond and back", (fun x -> Year.create x |> Year.toMilliSeconds |> Millisecond.toYears)
            "From year to second and back", (fun x -> Year.create x |> Year.toSeconds |> Second.toYears)
            "From year to minute and back", (fun x -> Year.create x |> Year.toMinutes |> Minute.toYears)
            "From year to hour and back", (fun x -> Year.create x |> Year.toHours |> Hour.toYears)
            "From year to day and back", (fun x -> Year.create x |> Year.toDays |> Day.toYears)
            "From year to week and back", (fun x -> Year.create x |> Year.toWeeks |> Week.toYears)
            "From year to fortnight and back", (fun x -> Year.create x |> Year.toFortnights |> Fortnight.toYears)
            "From year to month and back", (fun x -> Year.create x |> Year.toMonths |> Month.toYears)
            "From year to decade and back", (fun x -> Year.create x |> Year.toDecades |> Decade.toYears)
            "From year to century and back", (fun x -> Year.create x |> Year.toCenturies |> Century.toYears)
            "From year to millennium and back", (fun x -> Year.create x |> Year.toMillennia |> Millennium.toYears)
            "From year to eon and back", (fun x -> Year.create x |> Year.toEons |> Eon.toYears)          
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let decadeConversionTests =
        [
            "From decade to nanosecond and back", (fun x -> Decade.create x |> Decade.toNanoSeconds |> Nanosecond.toDecades)
            "From decade to microsecond and back", (fun x -> Decade.create x |> Decade.toMicroSeconds |> Microsecond.toDecades)
            "From decade to millisecond and back", (fun x -> Decade.create x |> Decade.toMilliSeconds |> Millisecond.toDecades)
            "From decade to second and back", (fun x -> Decade.create x |> Decade.toSeconds |> Second.toDecades)
            "From decade to minute and back", (fun x -> Decade.create x |> Decade.toMinutes |> Minute.toDecades)
            "From decade to hour and back", (fun x -> Decade.create x |> Decade.toHours |> Hour.toDecades)
            "From decade to day and back", (fun x -> Decade.create x |> Decade.toDays |> Day.toDecades)
            "From decade to week and back", (fun x -> Decade.create x |> Decade.toWeeks |> Week.toDecades)
            "From decade to fortnight and back", (fun x -> Decade.create x |> Decade.toFortnights |> Fortnight.toDecades)
            "From decade to month and back", (fun x -> Decade.create x |> Decade.toMonths |> Month.toDecades)
            "From decade to year and back", (fun x -> Decade.create x |> Decade.toYears |> Year.toDecades)
            "From decade to century and back", (fun x -> Decade.create x |> Decade.toCenturies |> Century.toDecades)
            "From decade to millennium and back", (fun x -> Decade.create x |> Decade.toMillennia |> Millennium.toDecades)
            "From decade to eon and back", (fun x -> Decade.create x |> Decade.toEons |> Eon.toDecades)          
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let centuryConversionTests =
        [
            "From century to nanosecond and back", (fun x -> Century.create x |> Century.toNanoSeconds |> Nanosecond.toCenturies)
            "From century to microsecond and back", (fun x -> Century.create x |> Century.toMicroSeconds |> Microsecond.toCenturies)
            "From century to millisecond and back", (fun x -> Century.create x |> Century.toMilliSeconds |> Millisecond.toCenturies)
            "From century to second and back", (fun x -> Century.create x |> Century.toSeconds |> Second.toCenturies)
            "From century to minute and back", (fun x -> Century.create x |> Century.toMinutes |> Minute.toCenturies)
            "From century to hour and back", (fun x -> Century.create x |> Century.toHours |> Hour.toCenturies)
            "From century to day and back", (fun x -> Century.create x |> Century.toDays |> Day.toCenturies)
            "From century to week and back", (fun x -> Century.create x |> Century.toWeeks |> Week.toCenturies)
            "From century to fortnight and back", (fun x -> Century.create x |> Century.toFortnights |> Fortnight.toCenturies)
            "From century to month and back", (fun x -> Century.create x |> Century.toMonths |> Month.toCenturies)
            "From century to year and back", (fun x -> Century.create x |> Century.toYears |> Year.toCenturies)
            "From century to decade and back", (fun x -> Century.create x |> Century.toDecades |> Decade.toCenturies)
            "From century to millennium and back", (fun x -> Century.create x |> Century.toMillennia |> Millennium.toCenturies)
            "From century to eon and back", (fun x -> Century.create x |> Century.toEons |> Eon.toCenturies)          
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let millenniumConversionTests =
        [
            "From millennium to nanosecond and back", (fun x -> Millennium.create x |> Millennium.toNanoSeconds |> Nanosecond.toMillennia)
            "From millennium to microsecond and back", (fun x -> Millennium.create x |> Millennium.toMicroSeconds |> Microsecond.toMillennia)
            "From millennium to millisecond and back", (fun x -> Millennium.create x |> Millennium.toMilliSeconds |> Millisecond.toMillennia)
            "From millennium to second and back", (fun x -> Millennium.create x |> Millennium.toSeconds |> Second.toMillennia)
            "From millennium to minute and back", (fun x -> Millennium.create x |> Millennium.toMinutes |> Minute.toMillennia)
            "From millennium to hour and back", (fun x -> Millennium.create x |> Millennium.toHours |> Hour.toMillennia)
            "From millennium to day and back", (fun x -> Millennium.create x |> Millennium.toDays |> Day.toMillennia)
            "From millennium to week and back", (fun x -> Millennium.create x |> Millennium.toWeeks |> Week.toMillennia)
            "From millennium to fortnight and back", (fun x -> Millennium.create x |> Millennium.toFortnights |> Fortnight.toMillennia)
            "From millennium to month and back", (fun x -> Millennium.create x |> Millennium.toMonths |> Month.toMillennia)
            "From millennium to year and back", (fun x -> Millennium.create x |> Millennium.toYears |> Year.toMillennia)
            "From millennium to decade and back", (fun x -> Millennium.create x |> Millennium.toDecades |> Decade.toMillennia)
            "From millennium to century and back", (fun x -> Millennium.create x |> Millennium.toCenturies |> Century.toMillennia)
            "From millennium to eon and back", (fun x -> Millennium.create x |> Millennium.toEons |> Eon.toMillennia)          
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let eonConversionTests =
        [
            "From eon to nanosecond and back", (fun x -> Eon.create x |> Eon.toNanoSeconds |> Nanosecond.toEons)
            "From eon to microsecond and back", (fun x -> Eon.create x |> Eon.toMicroSeconds |> Microsecond.toEons)
            "From eon to millisecond and back", (fun x -> Eon.create x |> Eon.toMilliSeconds |> Millisecond.toEons)
            "From eon to second and back", (fun x -> Eon.create x |> Eon.toSeconds |> Second.toEons)
            "From eon to minute and back", (fun x -> Eon.create x |> Eon.toMinutes |> Minute.toEons)
            "From eon to hour and back", (fun x -> Eon.create x |> Eon.toHours |> Hour.toEons)
            "From eon to day and back", (fun x -> Eon.create x |> Eon.toDays |> Day.toEons)
            "From eon to week and back", (fun x -> Eon.create x |> Eon.toWeeks |> Week.toEons)
            "From eon to fortnight and back", (fun x -> Eon.create x |> Eon.toFortnights |> Fortnight.toEons)
            "From eon to month and back", (fun x -> Eon.create x |> Eon.toMonths |> Month.toEons)
            "From eon to year and back", (fun x -> Eon.create x |> Eon.toYears |> Year.toEons)
            "From eon to decade and back", (fun x -> Eon.create x |> Eon.toDecades |> Decade.toEons)
            "From eon to century and back", (fun x -> Eon.create x |> Eon.toCenturies |> Century.toEons)
            "From eon to millennium and back", (fun x -> Eon.create x |> Eon.toMillennia |> Millennium.toEons)          
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
    
       
    testList "Time Tests -> " [
        testList "Nanosecond conversion tests -> " nanoSecondConversionTests
        testList "Microsecond conversion tests -> " microSecondConversionTests
        testList "Millisecond conversion tests -> " milliSecondConversionTests
        testList "Second conversion tests -> " secondConversionTests
        testList "Minute conversion tests -> " minuteConversionTests
        testList "Hour conversion tests -> " hourConversionTests
        testList "Day conversion tests -> " dayConversionTests
        testList "Week conversion tests -> " weekConversionTests
        testList "Fortnight conversion tests -> " fortnightConversionTests
        testList "Month conversion tests -> " monthConversionTests
        testList "Year conversion tests -> " yearConversionTests
        testList "Decade conversion tests -> " decadeConversionTests
        testList "Century conversion tests -> " centuryConversionTests
        testList "Millennium conversion tests -> " millenniumConversionTests
        testList "Eon conversion tests -> " eonConversionTests
    ]