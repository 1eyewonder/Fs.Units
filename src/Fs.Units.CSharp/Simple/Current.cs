// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.Current;

public static class MicroampereExtensions
{
    public static double MicroampereToAmperes(this double x) => Units.Current.Microampere.toAmperes(x);
    public static double MicroampereToMilliamperes(this double x) => Units.Current.Microampere.toMilliamperes(x);
    public static double MicroampereToBiots(this double x) => Units.Current.Microampere.toBiots(x);
}

public static class MilliampereExtensions
{
    public static double MilliampereToAmperes(this double x) => Units.Current.Milliampere.toAmperes(x);
    public static double MilliampereToMicroamperes(this double x) => Units.Current.Milliampere.toMicroamperes(x);
    public static double MilliampereToBiots(this double x) => Units.Current.Milliampere.toBiots(x);
}

public static class AmpereExtensions
{
    public static double AmpereToMilliamperes(this double x) => Units.Current.Ampere.toMilliamperes(x);
    public static double AmpereToMicroamperes(this double x) => Units.Current.Ampere.toMicroamperes(x);
    public static double AmpereToBiots(this double x) => Units.Current.Ampere.toBiots(x);
}

public static class BiotExtensions
{
    public static double BiotToAmperes(this double x) => Units.Current.Biot.toAmperes(x);
    public static double BiotToMilliamperes(this double x) => Units.Current.Biot.toMilliamperes(x);
    public static double BiotToMicroamperes(this double x) => Units.Current.Biot.toMicroamperes(x);
}