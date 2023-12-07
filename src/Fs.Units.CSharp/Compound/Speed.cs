// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp;

public static class FootPerSecondExtensions
{
    public static double FootPerSecondToMetersPerSecond(this double x) => Units.Speed.FootPerSecond.toMetersPerSecond(x);
    public static double FootPerSecondToKilometersPerHour(this double x) => Units.Speed.FootPerSecond.toKilometersPerHour(x);
    public static double FootPerSecondToMilesPerHour(this double x) => Units.Speed.FootPerSecond.toMilesPerHour(x);
}

public static class MeterPerSecondExtensions
{
    public static double MeterPerSecondToFootPerSecond(this double x) => Units.Speed.MeterPerSecond.toFeetPerSecond(x);
    public static double MeterPerSecondToKilometersPerHour(this double x) => Units.Speed.MeterPerSecond.toKilometersPerHour(x);
    public static double MeterPerSecondToMilesPerHour(this double x) => Units.Speed.MeterPerSecond.toMilesPerHour(x);
}

public static class KilometerPerHourExtensions
{
    public static double KilometerPerHourToFootPerSecond(this double x) => Units.Speed.KilometerPerHour.toFeetPerSecond(x);
    public static double KilometerPerHourToMeterPerSecond(this double x) => Units.Speed.KilometerPerHour.toMetersPerSecond(x);
    public static double KilometerPerHourToMilesPerHour(this double x) => Units.Speed.KilometerPerHour.toMilesPerHour(x);
}

public static class MilePerHourExtensions
{
    public static double MilePerHourToFootPerSecond(this double x) => Units.Speed.MilePerHour.toFeetPerSecond(x);
    public static double MilePerHourToMeterPerSecond(this double x) => Units.Speed.MilePerHour.toMetersPerSecond(x);
    public static double MilePerHourToKilometersPerHour(this double x) => Units.Speed.MilePerHour.toKilometersPerHour(x);
}