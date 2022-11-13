// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.Illuminance;

public static class FootcandleExtensions
{
    public static double FootcandleToLux(this double x) => Footcandle.toLux(x);
    public static double FootcandleToPhot(this double x) => Footcandle.toPhot(x);
    public static double FootcandleToNox(this double x) => Footcandle.toNox(x);
}

public static class LuxExtensions
{
    public static double LuxToFootcandle(this double x) => Lux.toFootcandle(x);
    public static double LuxToPhot(this double x) => Lux.toPhot(x);
    public static double LuxToNox(this double x) => Lux.toNox(x);
}

public static class PhotExtensions
{
    public static double PhotToFootcandle(this double x) => Phot.toFootcandle(x);
    public static double PhotToLux(this double x) => Phot.toLux(x);
    public static double PhotToNox(this double x) => Phot.toNox(x);
}

public static class NoxExtensions
{
    public static double NoxToFootcandle(this double x) => Nox.toFootcandle(x);
    public static double NoxToLux(this double x) => Nox.toLux(x);
    public static double NoxToPhot(this double x) => Nox.toPhot(x);
}