// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.Inertia;

public static class QuarticInchExtensions
{
    public static double QuarticInchToQuarticCentimeters(this double x) => QuarticInch.toQuarticCentimeters(x);
}

public static class QuarticCentimeterExtensions
{
    public static double QuarticCentimeterToQuarticInches(this double x) => QuarticCentimeter.toQuarticInches(x);
}