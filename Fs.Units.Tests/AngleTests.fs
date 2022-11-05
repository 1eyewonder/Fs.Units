module AngleTests

open Expecto
open Fs.Units.Angle
open Helpers

[<Tests>]
let tests config =
    
    let degreeConversionTests =
        [
            "From degrees to radians and back", (fun x -> Degree.create x |> Degree.toRadians |> Radian.toDegrees)
            "From degrees to gradians and back", (fun x -> Degree.create x |> Degree.toGradians |> Gradian.toDegrees)
            "From degrees to revolutions and back", (fun x -> Degree.create x |> Degree.toRevolutions |> Revolution.toDegrees)
            "From degrees to arcminutes and back", (fun x -> Degree.create x |> Degree.toArcMinutes |> ArcMinute.toDegrees)
            "From degrees to arcseconds and back", (fun x -> Degree.create x |> Degree.toArcSeconds |> ArcSecond.toDegrees)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let radianConversionTests =
        [
            "From radians to degrees and back", (fun x -> Radian.create x |> Radian.toDegrees |> Degree.toRadians)
            "From radians to gradians and back", (fun x -> Radian.create x |> Radian.toGradians |> Gradian.toRadians)
            "From radians to revolutions and back", (fun x -> Radian.create x |> Radian.toRevolutions |> Revolution.toRadians)
            "From radians to arcminutes and back", (fun x -> Radian.create x |> Radian.toArcMinutes |> ArcMinute.toRadians)
            "From radians to arcseconds and back", (fun x -> Radian.create x |> Radian.toArcSeconds |> ArcSecond.toRadians)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let gradianConversionTests =
        [
            "From gradians to degrees and back", (fun x -> Gradian.create x |> Gradian.toDegrees |> Degree.toGradians)
            "From gradians to radians and back", (fun x -> Gradian.create x |> Gradian.toRadians |> Radian.toGradians)
            "From gradians to revolutions and back", (fun x -> Gradian.create x |> Gradian.toRevolutions |> Revolution.toGradians)
            "From gradians to arcminutes and back", (fun x -> Gradian.create x |> Gradian.toArcMinutes |> ArcMinute.toGradians)
            "From gradians to arcseconds and back", (fun x -> Gradian.create x |> Gradian.toArcSeconds |> ArcSecond.toGradians)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let revolutionConversionTests =
        [
            "From revolutions to degrees and back", (fun x -> Revolution.create x |> Revolution.toDegrees |> Degree.toRevolutions)
            "From revolutions to radians and back", (fun x -> Revolution.create x |> Revolution.toRadians |> Radian.toRevolutions)
            "From revolutions to gradians and back", (fun x -> Revolution.create x |> Revolution.toGradians |> Gradian.toRevolutions)
            "From revolutions to arcminutes and back", (fun x -> Revolution.create x |> Revolution.toArcMinutes |> ArcMinute.toRevolutions)
            "From revolutions to arcseconds and back", (fun x -> Revolution.create x |> Revolution.toArcSeconds |> ArcSecond.toRevolutions)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let arcMinuteConversionTests =
        [
            "From arcminutes to degrees and back", (fun x -> ArcMinute.create x |> ArcMinute.toDegrees |> Degree.toArcMinutes)
            "From arcminutes to radians and back", (fun x -> ArcMinute.create x |> ArcMinute.toRadians |> Radian.toArcMinutes)
            "From arcminutes to gradians and back", (fun x -> ArcMinute.create x |> ArcMinute.toGradians |> Gradian.toArcMinutes)
            "From arcminutes to revolutions and back", (fun x -> ArcMinute.create x |> ArcMinute.toRevolutions |> Revolution.toArcMinutes)
            "From arcminutes to arcseconds and back", (fun x -> ArcMinute.create x |> ArcMinute.toArcSeconds |> ArcSecond.toArcMinutes)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    let arcSecondConversionTests =
        [
            "From arcseconds to degrees and back", (fun x -> ArcSecond.create x |> ArcSecond.toDegrees |> Degree.toArcSeconds)
            "From arcseconds to radians and back", (fun x -> ArcSecond.create x |> ArcSecond.toRadians |> Radian.toArcSeconds)
            "From arcseconds to gradians and back", (fun x -> ArcSecond.create x |> ArcSecond.toGradians |> Gradian.toArcSeconds)
            "From arcseconds to revolutions and back", (fun x -> ArcSecond.create x |> ArcSecond.toRevolutions |> Revolution.toArcSeconds)
            "From arcseconds to arcminutes and back", (fun x -> ArcSecond.create x |> ArcSecond.toArcMinutes |> ArcMinute.toArcSeconds)
        ]
        |> List.map (fun (x,y) -> testConversionRoundingError config Accuracy.high x y)
        
    testList "Angle Tests -> " [
        testList "Degree conversion tests -> " degreeConversionTests
        testList "Radian conversion tests -> " radianConversionTests
        testList "Gradian conversion tests -> " gradianConversionTests
        testList "Revolution conversion tests -> " revolutionConversionTests
        testList "ArcMinute conversion tests -> " arcMinuteConversionTests
        testList "ArcSecond conversion tests -> " arcSecondConversionTests
    ]