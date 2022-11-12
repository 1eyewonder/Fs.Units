// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.ElectromotiveForce;

public static class MicrovoltExtensions
{
    public static double MicrovoltToMillivolts(this double x) => Microvolt.toMillivolts(x);
    public static double MicrovoltToVolts(this double x) => Microvolt.toVolts(x);
    public static double MicrovoltToKilovolts(this double x) => Microvolt.toKilovolts(x);
    public static double MicrovoltToMegavolts(this double x) => Microvolt.toMegavolts(x);
}

public static class MillivoltExtensions
{
    public static double MillivoltToMicrovolts(this double x) => Millivolt.toMicrovolts(x);
    public static double MillivoltToVolts(this double x) => Millivolt.toVolts(x);
    public static double MillivoltToKilovolts(this double x) => Millivolt.toKilovolts(x);
    public static double MillivoltToMegavolts(this double x) => Millivolt.toMegavolts(x);
}

public static class VoltExtensions
{
    public static double VoltToMicrovolts(this double x) => Volt.toMicrovolts(x);
    public static double VoltToMillivolts(this double x) => Volt.toMillivolts(x);
    public static double VoltToKilovolts(this double x) => Volt.toKilovolts(x);
    public static double VoltToMegavolts(this double x) => Volt.toMegavolts(x);
}

public static class KilovoltExtensions
{
    public static double KilovoltToMicrovolts(this double x) => Kilovolt.toMicrovolts(x);
    public static double KilovoltToMillivolts(this double x) => Kilovolt.toMillivolts(x);
    public static double KilovoltToVolts(this double x) => Kilovolt.toVolts(x);
    public static double KilovoltToMegavolts(this double x) => Kilovolt.toMegavolts(x);
}

public static class MegavoltExtensions
{
    public static double MegavoltToMicrovolts(this double x) => Megavolt.toMicrovolts(x);
    public static double MegavoltToMillivolts(this double x) => Megavolt.toMillivolts(x);
    public static double MegavoltToVolts(this double x) => Megavolt.toVolts(x);
    public static double MegavoltToKilovolts(this double x) => Megavolt.toKilovolts(x);
}