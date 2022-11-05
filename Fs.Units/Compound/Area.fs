namespace Fs.Units.Area

open Fs.Units.Length.Units

module Units =
    
    /// Square inch
    [<Measure>] type in2 = inch * inch
    
    /// Square foot
    [<Measure>] type ft2 = ft * ft
    
    /// Square centimeter
    [<Measure>] type cm2 = cm * cm
    
    /// Square meter
    [<Measure>] type m2 = m * m

open Units

module SquareInch =
    
    let create (x:float) = x * 1.0<in2>
    let toSquareFeet (x: float<in2>) = x / 144.0<in2> * 1.0<ft2>
    let toSquareCentimeters (x: float<in2>) = x * 6.4516<cm2> / 1.0<in2>
    let toSquareMeters (x: float<in2>) = x / 1550.0<in2> * 1.0<m2>
    
module SquareFoot =
    
    let create (x:float) = x * 1.0<ft2>
    let toSquareInches (x: float<ft2>) = x * 144.0<in2> / 1.0<ft2>
    let toSquareCentimeters (x: float<ft2>) = x * 929.03<cm2> / 1.0<ft2>
    let toSquareMeters (x: float<ft2>) = x / 10.7639<ft2> * 1.0<m2>
    
module SquareCentimeter =
    
    let create (x:float) = x * 1.0<cm2>
    let toSquareInches (x: float<cm2>) = x / 6.4516<cm2> * 1.0<in2>
    let toSquareFeet (x: float<cm2>) = x / 929.03<cm2> * 1.0<ft2>
    let toSquareMeters (x: float<cm2>) = x / 10000.0<cm2> * 1.0<m2>
    
module SquareMeter =
    
    let create (x:float) = x * 1.0<m2>
    let toSquareInches (x: float<m2>) = x * 1550.0<in2> / 1.0<m2>
    let toSquareFeet (x: float<m2>) = x * 10.7639<ft2> / 1.0<m2>
    let toSquareCentimeters (x: float<m2>) = x * 10000.0<cm2> / 1.0<m2>
