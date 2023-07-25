// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp;

public static class KilogramPerCubicMeterExtensions
{
    public static double KilogramPerCubicMeterToGramsPerCubicCentimeter(this double x) =>
        Units.Density.KilogramPerCubicMeter.toGramsPerCubicCentimeter(x);
    public static double KilogramPerCubicMeterToPoundMassPerCubicFoot(this double x) =>
        Units.Density.KilogramPerCubicMeter.toPoundMassPerCubicFoot(x);
    public static double KilogramPerCubicMeterToPoundMassPerCubicInch(this double x) =>
        Units.Density.KilogramPerCubicMeter.toPoundMassPerCubicInch(x);
}

public static class GramPerCubicCentimeterExtensions
{
    public static double GramPerCubicCentimeterToKilogramsPerCubicMeter(this double x) =>
        Units.Density.GramPerCubicCentimeter.toKilogramsPerCubicMeter(x);
    public static double GramPerCubicCentimeterToPoundMassPerCubicFoot(this double x) =>
        Units.Density.GramPerCubicCentimeter.toPoundMassPerCubicFoot(x);
    public static double GramPerCubicCentimeterToPoundMassPerCubicInch(this double x) =>
        Units.Density.GramPerCubicCentimeter.toPoundMassPerCubicInch(x);
}

public static class PoundMassPerCubicFootExtensions
{
    public static double PoundMassPerCubicFootToKilogramsPerCubicMeter(this double x) =>
        Units.Density.PoundMassPerCubicFoot.toKilogramsPerCubicMeter(x);
    public static double PoundMassPerCubicFootToGramsPerCubicCentimeter(this double x) =>
        Units.Density.PoundMassPerCubicFoot.toGramsPerCubicCentimeter(x);
    public static double PoundMassPerCubicFootToPoundMassPerCubicInch(this double x) =>
        Units.Density.PoundMassPerCubicFoot.toPoundMassPerCubicInch(x);
}

public static class PoundMassPerCubicInchExtensions
{
    public static double PoundMassPerCubicInchToKilogramsPerCubicMeter(this double x) =>
        Units.Density.PoundMassPerCubicInch.toKilogramsPerCubicMeter(x);
    public static double PoundMassPerCubicInchToGramsPerCubicCentimeter(this double x) =>
        Units.Density.PoundMassPerCubicInch.toGramsPerCubicCentimeter(x);
    public static double PoundMassPerCubicInchToPoundMassPerCubicFoot(this double x) =>
        Units.Density.PoundMassPerCubicInch.toPoundMassPerCubicFoot(x);
}