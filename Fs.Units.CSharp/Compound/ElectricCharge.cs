// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.ElectricCharge;

public static class ColoumbExtensions
{
    public static double ColoumbToAmpereHours(this double x) => Units.ElectricCharge.Coloumb.toAmpereHours(x);
    public static double ColoumbToAmpereSeconds(this double x) => Units.ElectricCharge.Coloumb.toAmpereSeconds(x);
}

public static class AmpereHourExtensions
{
    public static double AmpereHourToColoumbs(this double x) => Units.ElectricCharge.AmpereHour.toColoumbs(x);
    public static double AmpereHourToAmpereSeconds(this double x) => Units.ElectricCharge.AmpereHour.toAmpereSeconds(x);
}

public static class AmpereSecondExtensions
{
    public static double AmpereSecondToColoumbs(this double x) => Units.ElectricCharge.AmpereSecond.toColoumbs(x);
    public static double AmpereSecondToAmpereHours(this double x) => Units.ElectricCharge.AmpereSecond.toAmpereHours(x);
}