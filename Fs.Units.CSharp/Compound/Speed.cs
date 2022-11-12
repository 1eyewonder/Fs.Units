// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.Speed;

public static class FootPerSecondExtensions
{
    public static double FootPerSecondToMetersPerSecond(this double x) => FootPerSecond.toMetersPerSecond(x);
    public static double FootPerSecondToKilometersPerHour(this double x) => FootPerSecond.toKilometersPerHour(x);
    public static double FootPerSecondToMilesPerHour(this double x) => FootPerSecond.toMilesPerHour(x);
}

public static class MeterPerSecondExtensions
{
    public static double MeterPerSecondToFootPerSecond(this double x) => MeterPerSecond.toFeetPerSecond(x);
    public static double MeterPerSecondToKilometersPerHour(this double x) => MeterPerSecond.toKilometersPerHour(x);
    public static double MeterPerSecondToMilesPerHour(this double x) => MeterPerSecond.toMilesPerHour(x);
}

public static class KilometerPerHourExtensions
{
    public static double KilometerPerHourToFootPerSecond(this double x) => KilometerPerHour.toFeetPerSecond(x);
    public static double KilometerPerHourToMeterPerSecond(this double x) => KilometerPerHour.toMetersPerSecond(x);
    public static double KilometerPerHourToMilesPerHour(this double x) => KilometerPerHour.toMilesPerHour(x);
}

public static class MilePerHourExtensions
{
    public static double MilePerHourToFootPerSecond(this double x) => MilePerHour.toFeetPerSecond(x);
    public static double MilePerHourToMeterPerSecond(this double x) => MilePerHour.toMetersPerSecond(x);
    public static double MilePerHourToKilometersPerHour(this double x) => MilePerHour.toKilometersPerHour(x);
}