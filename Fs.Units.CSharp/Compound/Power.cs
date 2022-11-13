// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.Power;

public static class WattExtensions
{
    public static double WattToKilowatts(this double x) => Watt.toKilowatts(x);
    public static double WattToHorsepower(this double x) => Watt.toHorsepower(x);
    public static double WattToTonsOfRefrigeration(this double x) => Watt.toTonsOfRefrigeration(x);
}

public static class KilowattExtensions
{
    public static double KilowattToWatts(this double x) => Kilowatt.toWatts(x);
    public static double KilowattToHorsepower(this double x) => Kilowatt.toHorsepower(x);
    public static double KilowattToTonsOfRefrigeration(this double x) => Kilowatt.toTonsOfRefrigeration(x);
}

public static class HorsepowerExtensions
{
    public static double HorsepowerToWatts(this double x) => Horsepower.toWatts(x);
    public static double HorsepowerToKilowatts(this double x) => Horsepower.toKilowatts(x);
    public static double HorsepowerToTonsOfRefrigeration(this double x) => Horsepower.toTonsOfRefrigeration(x);
}

public static class TonOfRefrigerationExtensions
{
    public static double TonOfRefrigerationToWatts(this double x) => TonOfRefrigeration.toWatts(x);
    public static double TonOfRefrigerationToKilowatts(this double x) => TonOfRefrigeration.toKilowatts(x);
    public static double TonOfRefrigerationToHorsepower(this double x) => TonOfRefrigeration.toHorsepower(x);
}