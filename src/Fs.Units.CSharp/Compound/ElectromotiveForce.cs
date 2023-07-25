// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp;

public static class MicrovoltExtensions
{
    public static double MicrovoltToMillivolts(this double x) => Units.ElectromotiveForce.Microvolt.toMillivolts(x);
    public static double MicrovoltToVolts(this double x) => Units.ElectromotiveForce.Microvolt.toVolts(x);
    public static double MicrovoltToKilovolts(this double x) => Units.ElectromotiveForce.Microvolt.toKilovolts(x);
    public static double MicrovoltToMegavolts(this double x) => Units.ElectromotiveForce.Microvolt.toMegavolts(x);
}

public static class MillivoltExtensions
{
    public static double MillivoltToMicrovolts(this double x) => Units.ElectromotiveForce.Millivolt.toMicrovolts(x);
    public static double MillivoltToVolts(this double x) => Units.ElectromotiveForce.Millivolt.toVolts(x);
    public static double MillivoltToKilovolts(this double x) => Units.ElectromotiveForce.Millivolt.toKilovolts(x);
    public static double MillivoltToMegavolts(this double x) => Units.ElectromotiveForce.Millivolt.toMegavolts(x);
}

public static class VoltExtensions
{
    public static double VoltToMicrovolts(this double x) => Units.ElectromotiveForce.Volt.toMicrovolts(x);
    public static double VoltToMillivolts(this double x) => Units.ElectromotiveForce.Volt.toMillivolts(x);
    public static double VoltToKilovolts(this double x) => Units.ElectromotiveForce.Volt.toKilovolts(x);
    public static double VoltToMegavolts(this double x) => Units.ElectromotiveForce.Volt.toMegavolts(x);
}

public static class KilovoltExtensions
{
    public static double KilovoltToMicrovolts(this double x) => Units.ElectromotiveForce.Kilovolt.toMicrovolts(x);
    public static double KilovoltToMillivolts(this double x) => Units.ElectromotiveForce.Kilovolt.toMillivolts(x);
    public static double KilovoltToVolts(this double x) => Units.ElectromotiveForce.Kilovolt.toVolts(x);
    public static double KilovoltToMegavolts(this double x) => Units.ElectromotiveForce.Kilovolt.toMegavolts(x);
}

public static class MegavoltExtensions
{
    public static double MegavoltToMicrovolts(this double x) => Units.ElectromotiveForce.Megavolt.toMicrovolts(x);
    public static double MegavoltToMillivolts(this double x) => Units.ElectromotiveForce.Megavolt.toMillivolts(x);
    public static double MegavoltToVolts(this double x) => Units.ElectromotiveForce.Megavolt.toVolts(x);
    public static double MegavoltToKilovolts(this double x) => Units.ElectromotiveForce.Megavolt.toKilovolts(x);
}