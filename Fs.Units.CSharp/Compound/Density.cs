// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.Density;

public static class KilogramPerCubicMeterExtensions
{
    public static double KilogramPerCubicMeterToGramsPerCubicCentimeter(this double x) =>
        KilogramPerCubicMeter.toGramsPerCubicCentimeter(x);
    public static double KilogramPerCubicMeterToPoundMassPerCubicFoot(this double x) =>
        KilogramPerCubicMeter.toPoundMassPerCubicFoot(x);
    public static double KilogramPerCubicMeterToPoundMassPerCubicInch(this double x) =>
        KilogramPerCubicMeter.toPoundMassPerCubicInch(x);
}

public static class GramPerCubicCentimeterExtensions
{
    public static double GramPerCubicCentimeterToKilogramsPerCubicMeter(this double x) =>
        GramPerCubicCentimeter.toKilogramsPerCubicMeter(x);
    public static double GramPerCubicCentimeterToPoundMassPerCubicFoot(this double x) =>
        GramPerCubicCentimeter.toPoundMassPerCubicFoot(x);
    public static double GramPerCubicCentimeterToPoundMassPerCubicInch(this double x) =>
        GramPerCubicCentimeter.toPoundMassPerCubicInch(x);
}

public static class PoundMassPerCubicFootExtensions
{
    public static double PoundMassPerCubicFootToKilogramsPerCubicMeter(this double x) =>
        PoundMassPerCubicFoot.toKilogramsPerCubicMeter(x);
    public static double PoundMassPerCubicFootToGramsPerCubicCentimeter(this double x) =>
        PoundMassPerCubicFoot.toGramsPerCubicCentimeter(x);
    public static double PoundMassPerCubicFootToPoundMassPerCubicInch(this double x) =>
        PoundMassPerCubicFoot.toPoundMassPerCubicInch(x);
}

public static class PoundMassPerCubicInchExtensions
{
    public static double PoundMassPerCubicInchToKilogramsPerCubicMeter(this double x) =>
        PoundMassPerCubicInch.toKilogramsPerCubicMeter(x);
    public static double PoundMassPerCubicInchToGramsPerCubicCentimeter(this double x) =>
        PoundMassPerCubicInch.toGramsPerCubicCentimeter(x);
    public static double PoundMassPerCubicInchToPoundMassPerCubicFoot(this double x) =>
        PoundMassPerCubicInch.toPoundMassPerCubicFoot(x);
}