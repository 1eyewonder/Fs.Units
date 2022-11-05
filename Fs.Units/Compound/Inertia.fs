namespace Fs.Units.Inertia

open Fs.Units

module Units =
    
    [<Measure>] type in4 = Length.Units.inch * Length.Units.inch * Length.Units.inch * Length.Units.inch
    
    [<Measure>] type cm4 = Length.Units.cm * Length.Units.cm * Length.Units.cm * Length.Units.cm