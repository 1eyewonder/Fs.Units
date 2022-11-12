// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.FuelEconomy;

public static class MilePerGallonExtensions
{
    public static double MilePerGallonToKilometersPerLiter(this double x) => MilePerGallon.toKilometersPerLiter(x);
}

public static class KilometerPerLiterExtensions
{
    public static double KilometerPerLiterToMilesPerGallon(this double x) => KilometerPerLiter.toMilesPerGallon(x);
}