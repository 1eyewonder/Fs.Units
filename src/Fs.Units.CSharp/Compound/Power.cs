// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp;

public static class WattExtensions
{
    public static double WattToKilowatts(this double x) => Units.Power.Watt.toKilowatts(x);
    public static double WattToHorsepower(this double x) => Units.Power.Watt.toHorsepower(x);
    public static double WattToTonsOfRefrigeration(this double x) => Units.Power.Watt.toTonsOfRefrigeration(x);
}

public static class KilowattExtensions
{
    public static double KilowattToWatts(this double x) => Units.Power.Kilowatt.toWatts(x);
    public static double KilowattToHorsepower(this double x) => Units.Power.Kilowatt.toHorsepower(x);
    public static double KilowattToTonsOfRefrigeration(this double x) => Units.Power.Kilowatt.toTonsOfRefrigeration(x);
}

public static class HorsepowerExtensions
{
    public static double HorsepowerToWatts(this double x) => Units.Power.Horsepower.toWatts(x);
    public static double HorsepowerToKilowatts(this double x) => Units.Power.Horsepower.toKilowatts(x);
    public static double HorsepowerToTonsOfRefrigeration(this double x) => Units.Power.Horsepower.toTonsOfRefrigeration(x);
}

public static class TonOfRefrigerationExtensions
{
    public static double TonOfRefrigerationToWatts(this double x) => Units.Power.TonOfRefrigeration.toWatts(x);
    public static double TonOfRefrigerationToKilowatts(this double x) => Units.Power.TonOfRefrigeration.toKilowatts(x);
    public static double TonOfRefrigerationToHorsepower(this double x) => Units.Power.TonOfRefrigeration.toHorsepower(x);
}