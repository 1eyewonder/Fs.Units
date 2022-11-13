// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.Temperature;

public static class KelvinExtensions
{
    public static double KelvinToCelsius(this double x) => Kelvin.toCelsius(x);
    public static double KelvinToFahrenheit(this double x) => Kelvin.toFahrenheit(x);
    public static double KelvinToRankine(this double x) => Kelvin.toRankine(x);
}

public static class CelsiusExtensions
{
    public static double CelsiusToKelvin(this double x) => Celsius.toKelvin(x);
    public static double CelsiusToFahrenheit(this double x) => Celsius.toFahrenheit(x);
    public static double CelsiusToRankine(this double x) => Celsius.toRankine(x);
}

public static class FahrenheitExtensions
{
    public static double FahrenheitToKelvin(this double x) => Fahrenheit.toKelvin(x);
    public static double FahrenheitToCelsius(this double x) => Fahrenheit.toCelsius(x);
    public static double FahrenheitToRankine(this double x) => Fahrenheit.toRankine(x);
}

public static class RankineExtensions
{
    public static double RankineToKelvin(this double x) => Rankine.toKelvin(x);
    public static double RankineToCelsius(this double x) => Rankine.toCelsius(x);
    public static double RankineToFahrenheit(this double x) => Rankine.toFahrenheit(x);
}