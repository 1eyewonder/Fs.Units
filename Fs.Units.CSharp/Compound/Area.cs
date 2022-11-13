// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.Area;

public static class SquareInchExtensions
{
    public static double SquareInchToSquareFeet(this double x) => SquareInch.toSquareFeet(x);
    public static double SquareInchToSquareCentimeters(this double x) => SquareInch.toSquareCentimeters(x);
    public static double SquareInchToSquareMeters(this double x) => SquareInch.toSquareMeters(x);
}

public static class SquareFootExtensions
{
    public static double SquareFootToSquareInches(this double x) => SquareFoot.toSquareInches(x);
    public static double SquareFootToSquareCentimeters(this double x) => SquareFoot.toSquareCentimeters(x);
    public static double SquareFootToSquareMeters(this double x) => SquareFoot.toSquareMeters(x);
}

public static class SquareCentimeterExtensions
{
    public static double SquareCentimeterToSquareInches(this double x) => SquareCentimeter.toSquareInches(x);
    public static double SquareCentimeterToSquareFeet(this double x) => SquareCentimeter.toSquareFeet(x);
    public static double SquareCentimeterToSquareMeters(this double x) => SquareCentimeter.toSquareMeters(x);
}

public static class SquareMeterExtensions
{
    public static double SquareMeterToSquareInches(this double x) => SquareMeter.toSquareInches(x);
    public static double SquareMeterToSquareFeet(this double x) => SquareMeter.toSquareFeet(x);
    public static double SquareMeterToSquareCentimeters(this double x) => SquareMeter.toSquareCentimeters(x);
}