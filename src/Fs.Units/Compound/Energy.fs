namespace Fs.Units

[<AutoOpen>]
module Energy =

    /// Joule
    [<Measure>]
    type J = W * s

    /// Kilojoule
    [<Measure>]
    type kJ = kW * s

    /// British thermal unit
    [<Measure>]
    type BTU

    /// calorie (not kilocalorie - Calorie)
    [<Measure>]
    type cal

    /// quad
    [<Measure>]
    type quad

    /// 1000 quads
    [<Measure>]
    type Q

    [<RequireQualifiedAccess>]
    module Joule =

        let create (x: float) = x * 1.0<J>
        let toKilojoules (x: float<J>) = x * 1.0<kJ> / 1000.0<J>
        let toBritishThermalUnits (x: float<J>) = x * 1.0<BTU> / 1055.06<J>
        let toCalories (x: float<J>) = x * 1.0<cal> / 4.184<J>
        let toQuads (x: float<J>) = x * 1.0<quad> / 1.055e+18<J>
        let toQs (x: float<J>) = x * 1.0<Q> / 1.055e+21<J>

    [<RequireQualifiedAccess>]
    module Kilojoule =

        let create (x: float) = x * 1.0<kJ>
        let toJoules (x: float<kJ>) = x * 1000.0<J> / 1.0<kJ>
        let toBritishThermalUnits (x: float<kJ>) = x * 1.0<BTU> / 1.05506<kJ>
        let toCalories (x: float<kJ>) = x * 1000.0<cal> / 4.184<kJ>
        let toQuads (x: float<kJ>) = x * 1.0<quad> / 1.055e+15<kJ>
        let toQs (x: float<kJ>) = x * 1.0<Q> / 1.055e+18<kJ>

    [<RequireQualifiedAccess>]
    module BritishThermalUnit =

        let create (x: float) = x * 1.0<BTU>
        let toJoules (x: float<BTU>) = x * 1055.06<J> / 1.0<BTU>
        let toKilojoules (x: float<BTU>) = x * 1.05506<kJ> / 1.0<BTU>
        let toCalories (x: float<BTU>) = x * 252.164<cal> / 1.0<BTU>
        let toQuads (x: float<BTU>) = x * 1e-15<quad> / 1.0<BTU>
        let toQs (x: float<BTU>) = x * 1.0<Q> / 1.00e+18<BTU>

    [<RequireQualifiedAccess>]
    module Calorie =

        let create (x: float) = x * 1.0<cal>
        let toJoules (x: float<cal>) = x * 4.184<J> / 1.0<cal>
        let toKilojoules (x: float<cal>) = x * 4.184e-3<kJ> / 1.0<cal>
        let toBritishThermalUnits (x: float<cal>) = x * 1.0<BTU> / 252.164<cal>
        let toQuads (x: float<cal>) = x * 1.0<quad> / 4.184e+21<cal>
        let toQs (x: float<cal>) = x * 1.0<Q> / 4.184e+24<cal>

    [<RequireQualifiedAccess>]
    module Quad =

        let create (x: float) = x * 1.0<quad>
        let toJoules (x: float<quad>) = x * 1.055e+18<J> / 1.0<quad>
        let toKilojoules (x: float<quad>) = x * 1.055e+15<kJ> / 1.0<quad>
        let toBritishThermalUnits (x: float<quad>) = x * 1e+15<BTU> / 1.0<quad>
        let toCalories (x: float<quad>) = x * 4.184e+21<cal> / 1.0<quad>
        let toQs (x: float<quad>) = x * 1e-3<Q> / 1.0<quad>

    [<RequireQualifiedAccess>]
    module Q =

        let create (x: float) = x * 1.0<Q>
        let toJoules (x: float<Q>) = x * 1.055e+21<J> / 1.0<Q>
        let toKilojoules (x: float<Q>) = x * 1.055e+18<kJ> / 1.0<Q>
        let toBritishThermalUnits (x: float<Q>) = x * 1.00e+18<BTU> / 1.0<Q>
        let toCalories (x: float<Q>) = x * 4.184e+24<cal> / 1.0<Q>
        let toQuads (x: float<Q>) = x * 1e+3<quad> / 1.0<Q>
