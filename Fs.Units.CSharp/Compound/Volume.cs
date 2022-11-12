// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.Volume;

public static class CubicInchExtensions
{
    public static double CubicInchToCubicFeet(this double x) => CubicInch.toCubicFeet(x);
    public static double CubicInchToCubicCentimeters(this double x) => CubicInch.toCubicCentimeters(x);
    public static double CubicInchToCubicMeters(this double x) => CubicInch.toCubicMeters(x);
}

public static class CubicFootExtensions
{
    public static double CubicFootToCubicInches(this double x) => CubicFoot.toCubicInches(x);
    public static double CubicFootToCubicCentimeters(this double x) => CubicFoot.toCubicCentimeters(x);
    public static double CubicFootToCubicMeters(this double x) => CubicFoot.toCubicMeters(x);
}

public static class CubicCentimeterExtensions
{
    public static double CubicCentimeterToCubicInches(this double x) => CubicCentimeter.toCubicInches(x);
    public static double CubicCentimeterToCubicFeet(this double x) => CubicCentimeter.toCubicFeet(x);
    public static double CubicCentimeterToCubicMeters(this double x) => CubicCentimeter.toCubicMeters(x);
}

public static class CubicMeterExtensions
{
    public static double CubicMeterToCubicInches(this double x) => CubicMeter.toCubicInches(x);
    public static double CubicMeterToCubicFeet(this double x) => CubicMeter.toCubicFeet(x);
    public static double CubicMeterToCubicCentimeters(this double x) => CubicMeter.toCubicCentimeters(x);
}