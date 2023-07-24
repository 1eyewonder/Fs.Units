namespace Fs.Units

open System

[<AutoOpen>]
module Angle =
    
    /// degree
    [<Measure>] type deg

    /// radian
    [<Measure>] type rad

    /// gradian
    [<Measure>] type grad

    /// revolution
    [<Measure>] type rev

    /// arc-minute
    [<Measure>] type arcmin

    /// arc-second
    [<Measure>] type arcs

    [<RequireQualifiedAccess>]
    module Degree =
        
        let create (x: float) = x * 1.0<deg>
        let toRadians (x: float<deg>) = x * Math.PI * 1.0<rad> / 180.0<deg>
        let toGradians (x: float<deg>) = x * (200.0/180.0) * 1.0<grad> / 1.0<deg>
        let toRevolutions (x: float<deg>) = x * 1.0<rev> / 360.0<deg>
        let toArcMinutes (x: float<deg>) = x * 60.0<arcmin> / 1.0<deg>
        let toArcSeconds (x: float<deg>) = x * 3600.0<arcs> / 1.0<deg>
        
    [<RequireQualifiedAccess>]
    module Radian =
        
        let create (x: float) = x * 1.0<rad>
        let toDegrees (x: float<rad>) = x * 180.0<deg> / (Math.PI * 1.0<rad>)
        let toGradians (x: float<rad>) = x * 200.0<grad> / (Math.PI * 1.0<rad>)
        let toRevolutions (x: float<rad>) = x * 1.0<rev> / (2.0 * Math.PI * 1.0<rad>)
        let toArcMinutes (x: float<rad>) = x * 60.0<arcmin> * 180.0 / Math.PI / 1.0<rad>
        let toArcSeconds (x: float<rad>) = x * 3600.0<arcs> * 180.0 / Math.PI / 1.0<rad>
       
    [<RequireQualifiedAccess>]
    module Gradian =
        
        let create (x: float) = x * 1.0<grad>
        let toDegrees (x: float<grad>) = x * 1.0<deg> / (200.0/180.0) / 1.0<grad>
        let toRadians (x: float<grad>) = x * Math.PI * 1.0<rad> / 200.0<grad>
        let toRevolutions (x: float<grad>) = x * 1.0<rev> / 400.0<grad>
        let toArcMinutes (x: float<grad>) = x * 54.0<arcmin> / 1.0<grad>
        let toArcSeconds (x: float<grad>) = x * 3240.0<arcs> / 1.0<grad>
        
    [<RequireQualifiedAccess>]
    module Revolution =
        
        let create (x: float) = x * 1.0<rev>
        let toDegrees (x: float<rev>) = x * 360.0<deg> / 1.0<rev>
        let toRadians (x: float<rev>) = x * 2.0 * Math.PI * 1.0<rad> / 1.0<rev>
        let toGradians (x: float<rev>) = x * 400.0<grad> / 1.0<rev>
        let toArcMinutes (x: float<rev>) = x * 21600.0<arcmin> / 1.0<rev>
        let toArcSeconds (x: float<rev>) = x * 1296000.0<arcs> / 1.0<rev>
        
    [<RequireQualifiedAccess>]
    module ArcMinute =

        let create (x: float) = x * 1.0<arcmin>
        let toDegrees (x: float<arcmin>) = x * 1.0<deg> / 60.0<arcmin>
        let toRadians (x: float<arcmin>) = x * Math.PI * 1.0<rad> / (180.0 * 60.0) / 1.0<arcmin>
        let toGradians (x: float<arcmin>) = x * 1.0<grad> / 54.0<arcmin>
        let toRevolutions (x: float<arcmin>) = x * 1.0<rev> / 21600.0<arcmin>
        let toArcSeconds (x: float<arcmin>) = x * 60.0<arcs> / 1.0<arcmin>

    [<RequireQualifiedAccess>]
    module ArcSecond =

        let create (x: float) = x * 1.0<arcs>
        let toDegrees (x: float<arcs>) = x * 1.0<deg> / 3600.0<arcs>
        let toRadians (x: float<arcs>) = x * Math.PI * 1.0<rad> / (180.0 * 3600.0) / 1.0<arcs>
        let toGradians (x: float<arcs>) = x * 1.0<grad> / 3240.0<arcs>
        let toRevolutions (x: float<arcs>) = x * 1.0<rev> / 1296000.0<arcs>
        let toArcMinutes (x: float<arcs>) = x * 1.0<arcmin> / 60.0<arcs>