namespace Fs.Units

open System

module Helpers =

    let inline max (x: float<'Measure>) (y: float<'Measure>) =
        Math.Max(float x, float y) |> LanguagePrimitives.FloatWithMeasure<'Measure>

    let inline min (x: float<'Measure>) (y: float<'Measure>) =
        Math.Min(float x, float y) |> LanguagePrimitives.FloatWithMeasure<'Measure>

    let inline pow y (x: float<'Measure>) = Math.Pow(float x, float y)

    let inline pow2 (x: float<'Measure>) =
        pow 2 x |> LanguagePrimitives.FloatWithMeasure<'Measure^2>

    let inline pow3 (x: float<'Measure>) =
        pow 3 x |> LanguagePrimitives.FloatWithMeasure<'Measure^3>

    let inline pow4 (x: float<'Measure>) =
        pow 4 x |> LanguagePrimitives.FloatWithMeasure<'Measure^4>

    let inline abs (x: float<'Measure>) =
        Math.Abs(float x) |> LanguagePrimitives.FloatWithMeasure<'Measure>
