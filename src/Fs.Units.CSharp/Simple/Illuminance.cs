// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.Illuminance;

public static class FootcandleExtensions
{
    public static double FootcandleToLux(this double x) => Units.Illuminance.Footcandle.toLux(x);
    public static double FootcandleToPhot(this double x) => Units.Illuminance.Footcandle.toPhot(x);
    public static double FootcandleToNox(this double x) => Units.Illuminance.Footcandle.toNox(x);
}

public static class LuxExtensions
{
    public static double LuxToFootcandle(this double x) => Units.Illuminance.Lux.toFootcandle(x);
    public static double LuxToPhot(this double x) => Units.Illuminance.Lux.toPhot(x);
    public static double LuxToNox(this double x) => Units.Illuminance.Lux.toNox(x);
}

public static class PhotExtensions
{
    public static double PhotToFootcandle(this double x) => Units.Illuminance.Phot.toFootcandle(x);
    public static double PhotToLux(this double x) => Units.Illuminance.Phot.toLux(x);
    public static double PhotToNox(this double x) => Units.Illuminance.Phot.toNox(x);
}

public static class NoxExtensions
{
    public static double NoxToFootcandle(this double x) => Units.Illuminance.Nox.toFootcandle(x);
    public static double NoxToLux(this double x) => Units.Illuminance.Nox.toLux(x);
    public static double NoxToPhot(this double x) => Units.Illuminance.Nox.toPhot(x);
}