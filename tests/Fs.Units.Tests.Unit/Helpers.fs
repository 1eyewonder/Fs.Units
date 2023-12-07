module Helpers

open FsCheck
open Expecto

let testRange f value =
  let inRange v = (v > -1E+10) && (v < 1E+10)
  inRange value ==> lazy (f value)

let removeUnits<[<Measure>] 'u> value = float value

let unwrapFloat a =
  match a with
  | NormalFloat v -> v

let testNormalFloat x f =
  let y = x |> unwrapFloat
  f y

let testConversionRoundingError config accuracy testName (f: float -> float<'Measure>) =
  testPropertyWithConfig config testName
  <| fun (input: NormalFloat) ->
    testNormalFloat input
    <| fun x ->
      let convert = f x
      Expect.floatClose accuracy (float convert) x "There is some rounding error"
