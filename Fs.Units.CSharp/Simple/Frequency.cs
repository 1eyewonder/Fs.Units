// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.Frequency;

public static class HertzExtensions
{
    public static double HertzToKilohertz(this double x) => Hertz.toKilohertz(x);
    public static double HertzToMegahertz(this double x) => Hertz.toMegahertz(x);
    public static double HertzToGigahertz(this double x) => Hertz.toGigahertz(x);
}

public static class KilohertzExtensions
{
    public static double KilohertzToHertz(this double x) => Kilohertz.toHertz(x);
    public static double KilohertzToMegahertz(this double x) => Kilohertz.toMegahertz(x);
    public static double KilohertzToGigahertz(this double x) => Kilohertz.toGigahertz(x);
}

public static class MegahertzExtensions
{
    public static double MegahertzToHertz(this double x) => Megahertz.toHertz(x);
    public static double MegahertzToKilohertz(this double x) => Megahertz.toKilohertz(x);
    public static double MegahertzToGigahertz(this double x) => Megahertz.toGigahertz(x);
}

public static class GigahertzExtensions
{
    public static double GigahertzToHertz(this double x) => Gigahertz.toHertz(x);
    public static double GigahertzToKilohertz(this double x) => Gigahertz.toKilohertz(x);
    public static double GigahertzToMegahertz(this double x) => Gigahertz.toMegahertz(x);
}