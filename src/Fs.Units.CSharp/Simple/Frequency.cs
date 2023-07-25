// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp;

public static class HertzExtensions
{
    public static double HertzToKilohertz(this double x) => Units.Frequency.Hertz.toKilohertz(x);
    public static double HertzToMegahertz(this double x) => Units.Frequency.Hertz.toMegahertz(x);
    public static double HertzToGigahertz(this double x) => Units.Frequency.Hertz.toGigahertz(x);
}

public static class KilohertzExtensions
{
    public static double KilohertzToHertz(this double x) => Units.Frequency.Kilohertz.toHertz(x);
    public static double KilohertzToMegahertz(this double x) => Units.Frequency.Kilohertz.toMegahertz(x);
    public static double KilohertzToGigahertz(this double x) => Units.Frequency.Kilohertz.toGigahertz(x);
}

public static class MegahertzExtensions
{
    public static double MegahertzToHertz(this double x) => Units.Frequency.Megahertz.toHertz(x);
    public static double MegahertzToKilohertz(this double x) => Units.Frequency.Megahertz.toKilohertz(x);
    public static double MegahertzToGigahertz(this double x) => Units.Frequency.Megahertz.toGigahertz(x);
}

public static class GigahertzExtensions
{
    public static double GigahertzToHertz(this double x) => Units.Frequency.Gigahertz.toHertz(x);
    public static double GigahertzToKilohertz(this double x) => Units.Frequency.Gigahertz.toKilohertz(x);
    public static double GigahertzToMegahertz(this double x) => Units.Frequency.Gigahertz.toMegahertz(x);
}