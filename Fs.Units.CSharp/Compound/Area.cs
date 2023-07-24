// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.Area;

public static class SquareInchExtensions
{
    public static double SquareInchToSquareFeet(this double x) => Units.Area.SquareInch.toSquareFeet(x);
    public static double SquareInchToSquareCentimeters(this double x) => Units.Area.SquareInch.toSquareCentimeters(x);
    public static double SquareInchToSquareMeters(this double x) => Units.Area.SquareInch.toSquareMeters(x);
}

public static class SquareFootExtensions
{
    public static double SquareFootToSquareInches(this double x) => Units.Area.SquareFoot.toSquareInches(x);
    public static double SquareFootToSquareCentimeters(this double x) => Units.Area.SquareFoot.toSquareCentimeters(x);
    public static double SquareFootToSquareMeters(this double x) => Units.Area.SquareFoot.toSquareMeters(x);
}

public static class SquareCentimeterExtensions
{
    public static double SquareCentimeterToSquareInches(this double x) => Units.Area.SquareCentimeter.toSquareInches(x);
    public static double SquareCentimeterToSquareFeet(this double x) => Units.Area.SquareCentimeter.toSquareFeet(x);
    public static double SquareCentimeterToSquareMeters(this double x) => Units.Area.SquareCentimeter.toSquareMeters(x);
}

public static class SquareMeterExtensions
{
    public static double SquareMeterToSquareInches(this double x) => Units.Area.SquareMeter.toSquareInches(x);
    public static double SquareMeterToSquareFeet(this double x) => Units.Area.SquareMeter.toSquareFeet(x);
    public static double SquareMeterToSquareCentimeters(this double x) => Units.Area.SquareMeter.toSquareCentimeters(x);
}