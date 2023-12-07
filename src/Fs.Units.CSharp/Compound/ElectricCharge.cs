// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp;

public static class ColoumbExtensions
{
    public static double ColoumbToAmpereHours(this double x) => Units.ElectricCharge.Coulomb.toAmpereHours(x);
    public static double ColoumbToAmpereSeconds(this double x) => Units.ElectricCharge.Coulomb.toAmpereSeconds(x);
}

public static class AmpereHourExtensions
{
    public static double AmpereHourToColoumbs(this double x) => Units.ElectricCharge.AmpereHour.toCoulombs(x);
    public static double AmpereHourToAmpereSeconds(this double x) => Units.ElectricCharge.AmpereHour.toAmpereSeconds(x);
}

public static class AmpereSecondExtensions
{
    public static double AmpereSecondToColoumbs(this double x) => Units.ElectricCharge.AmpereSecond.toCoulombs(x);
    public static double AmpereSecondToAmpereHours(this double x) => Units.ElectricCharge.AmpereSecond.toAmpereHours(x);
}