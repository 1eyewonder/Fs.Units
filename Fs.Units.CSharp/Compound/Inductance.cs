// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.Inductance;

public static class MicroHenryExtensions
{
    public static double MicroHenryToMilliHenrys(this double x) => Units.Inductance.MicroHenry.toMilliHenrys(x);
    public static double MicroHenryToHenrys(this double x) => Units.Inductance.MicroHenry.toHenrys(x);
}

public static class MilliHenryExtensions
{
    public static double MilliHenryToMicroHenrys(this double x) => Units.Inductance.MilliHenry.toMicroHenrys(x);
    public static double MilliHenryToHenrys(this double x) => Units.Inductance.MilliHenry.toHenrys(x);
}

public static class HenryExtensions
{
    public static double HenryToMicroHenrys(this double x) => Units.Inductance.Henry.toMicroHenrys(x);
    public static double HenryToMilliHenrys(this double x) => Units.Inductance.Henry.toMilliHenrys(x);
}