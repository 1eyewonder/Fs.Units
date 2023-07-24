// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.Temperature;

public static class KelvinExtensions
{
    public static double KelvinToCelsius(this double x) => Units.Temperature.Kelvin.toCelsius(x);
    public static double KelvinToFahrenheit(this double x) => Units.Temperature.Kelvin.toFahrenheit(x);
    public static double KelvinToRankine(this double x) => Units.Temperature.Kelvin.toRankine(x);
}

public static class CelsiusExtensions
{
    public static double CelsiusToKelvin(this double x) => Units.Temperature.Celsius.toKelvin(x);
    public static double CelsiusToFahrenheit(this double x) => Units.Temperature.Celsius.toFahrenheit(x);
    public static double CelsiusToRankine(this double x) => Units.Temperature.Celsius.toRankine(x);
}

public static class FahrenheitExtensions
{
    public static double FahrenheitToKelvin(this double x) => Units.Temperature.Fahrenheit.toKelvin(x);
    public static double FahrenheitToCelsius(this double x) => Units.Temperature.Fahrenheit.toCelsius(x);
    public static double FahrenheitToRankine(this double x) => Units.Temperature.Fahrenheit.toRankine(x);
}

public static class RankineExtensions
{
    public static double RankineToKelvin(this double x) => Units.Temperature.Rankine.toKelvin(x);
    public static double RankineToCelsius(this double x) => Units.Temperature.Rankine.toCelsius(x);
    public static double RankineToFahrenheit(this double x) => Units.Temperature.Rankine.toFahrenheit(x);
}