// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.Current;

public static class MicroampereExtensions
{
    public static double MicroampereToAmperes(this double x) => Microampere.toAmperes(x);
    public static double MicroampereToMilliamperes(this double x) => Microampere.toMilliamperes(x);
    public static double MicroampereToBiots(this double x) => Microampere.toBiots(x);
}

public static class MilliampereExtensions
{
    public static double MilliampereToAmperes(this double x) => Milliampere.toAmperes(x);
    public static double MilliampereToMicroamperes(this double x) => Milliampere.toMicroamperes(x);
    public static double MilliampereToBiots(this double x) => Milliampere.toBiots(x);
}

public static class AmpereExtensions
{
    public static double AmpereToMilliamperes(this double x) => Ampere.toMilliamperes(x);
    public static double AmpereToMicroamperes(this double x) => Ampere.toMicroamperes(x);
    public static double AmpereToBiots(this double x) => Ampere.toBiots(x);
}

public static class BiotExtensions
{
    public static double BiotToAmperes(this double x) => Biot.toAmperes(x);
    public static double BiotToMilliamperes(this double x) => Biot.toMilliamperes(x);
    public static double BiotToMicroamperes(this double x) => Biot.toMicroamperes(x);
}