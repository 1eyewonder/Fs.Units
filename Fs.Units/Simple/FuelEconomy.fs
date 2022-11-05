namespace Fs.Units.FuelEconomy

module Units =
    
    /// Kilometer per liter
    [<Measure>] type kml
    
    /// Mile per gallon
    [<Measure>] type mpg
    
open Units

module KilometerPerLiter =
    
    let create (x: float) = x * 1.0<kml>
    let toMilesPerGallon (x: float<kml>) = x * 2.35215<mpg> / 1.0<kml>
    
module MilePerGallon =
    
    let create (x: float) = x * 1.0<mpg>
    let toKilometersPerLiter (x: float<mpg>) = x / 2.35215<mpg> * 1.0<kml>
