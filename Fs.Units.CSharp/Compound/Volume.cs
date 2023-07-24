// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.Volume;

public static class CubicInchExtensions
{
    public static double CubicInchToCubicFeet(this double x) => Units.Volume.CubicInch.toCubicFeet(x);
    public static double CubicInchToCubicCentimeters(this double x) => Units.Volume.CubicInch.toCubicCentimeters(x);
    public static double CubicInchToCubicMeters(this double x) => Units.Volume.CubicInch.toCubicMeters(x);
}

public static class CubicFootExtensions
{
    public static double CubicFootToCubicInches(this double x) => Units.Volume.CubicFoot.toCubicInches(x);
    public static double CubicFootToCubicCentimeters(this double x) => Units.Volume.CubicFoot.toCubicCentimeters(x);
    public static double CubicFootToCubicMeters(this double x) => Units.Volume.CubicFoot.toCubicMeters(x);
}

public static class CubicCentimeterExtensions
{
    public static double CubicCentimeterToCubicInches(this double x) => Units.Volume.CubicCentimeter.toCubicInches(x);
    public static double CubicCentimeterToCubicFeet(this double x) => Units.Volume.CubicCentimeter.toCubicFeet(x);
    public static double CubicCentimeterToCubicMeters(this double x) => Units.Volume.CubicCentimeter.toCubicMeters(x);
}

public static class CubicMeterExtensions
{
    public static double CubicMeterToCubicInches(this double x) => Units.Volume.CubicMeter.toCubicInches(x);
    public static double CubicMeterToCubicFeet(this double x) => Units.Volume.CubicMeter.toCubicFeet(x);
    public static double CubicMeterToCubicCentimeters(this double x) => Units.Volume.CubicMeter.toCubicCentimeters(x);
}