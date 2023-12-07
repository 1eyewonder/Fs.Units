// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp;

public static class CubicInchExtensions
{
    public static double CubicInchToCubicFeet(this double x) => Units.Volume.CubicInch.toCubicFeet(x);
    public static double CubicInchToCubicCentimeters(this double x) => Units.Volume.CubicInch.toCubicCentimeters(x);
    public static double CubicInchToCubicMeters(this double x) => Units.Volume.CubicInch.toCubicMeters(x);
    public static double CubicInchToLiters(this double x) => Units.Volume.CubicInch.toLiters(x);
    public static double CubicInchToGallons(this double x) => Units.Volume.CubicInch.toGallons(x);
}

public static class CubicFootExtensions
{
    public static double CubicFootToCubicInches(this double x) => Units.Volume.CubicFoot.toCubicInches(x);
    public static double CubicFootToCubicCentimeters(this double x) => Units.Volume.CubicFoot.toCubicCentimeters(x);
    public static double CubicFootToCubicMeters(this double x) => Units.Volume.CubicFoot.toCubicMeters(x);
    public static double CubicFootToLiters(this double x) => Units.Volume.CubicFoot.toLiters(x);
    public static double CubicFootToGallons(this double x) => Units.Volume.CubicFoot.toGallons(x);
}

public static class CubicCentimeterExtensions
{
    public static double CubicCentimeterToCubicInches(this double x) => Units.Volume.CubicCentimeter.toCubicInches(x);
    public static double CubicCentimeterToCubicFeet(this double x) => Units.Volume.CubicCentimeter.toCubicFeet(x);
    public static double CubicCentimeterToCubicMeters(this double x) => Units.Volume.CubicCentimeter.toCubicMeters(x);
    public static double CubicCentimeterToLiters(this double x) => Units.Volume.CubicCentimeter.toLiters(x);
    public static double CubicCentimeterToGallons(this double x) => Units.Volume.CubicCentimeter.toGallons(x);
}

public static class CubicMeterExtensions
{
    public static double CubicMeterToCubicInches(this double x) => Units.Volume.CubicMeter.toCubicInches(x);
    public static double CubicMeterToCubicFeet(this double x) => Units.Volume.CubicMeter.toCubicFeet(x);
    public static double CubicMeterToCubicCentimeters(this double x) => Units.Volume.CubicMeter.toCubicCentimeters(x);
    public static double CubicMeterToLiters(this double x) => Units.Volume.CubicMeter.toLiters(x);
    public static double CubicMeterToGallons(this double x) => Units.Volume.CubicMeter.toGallons(x);
}

public static class LiterExtensions
{
    public static double LiterToCubicInches(this double x) => Units.Volume.Liter.toCubicInches(x);
    public static double LiterToCubicFeet(this double x) => Units.Volume.Liter.toCubicFeet(x);
    public static double LiterToCubicCentimeters(this double x) => Units.Volume.Liter.toCubicCentimeters(x);
    public static double LiterToCubicMeters(this double x) => Units.Volume.Liter.toCubicMeters(x);
    public static double LiterToGallons(this double x) => Units.Volume.Liter.toGallons(x);
}

public static class GallonExtensions
{
    public static double GallonToCubicInches(this double x) => Units.Volume.Gallon.toCubicInches(x);
    public static double GallonToCubicFeet(this double x) => Units.Volume.Gallon.toCubicFeet(x);
    public static double GallonToCubicCentimeters(this double x) => Units.Volume.Gallon.toCubicCentimeters(x);
    public static double GallonToCubicMeters(this double x) => Units.Volume.Gallon.toCubicMeters(x);
    public static double GallonToLiters(this double x) => Units.Volume.Gallon.toLiters(x);
}