﻿namespace Fs.Units.Capacitance

open Fs.Units

module Units =
    
    /// Farad
    [<Measure>] type F = Time.Units.s * Time.Units.s * Time.Units.s * Time.Units.s * Current.Units.A * Current.Units.A / Length.Units.m / Length.Units.m / Mass.Units.kg

