// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.ElectricCharge;

public static class ColoumbExtensions
{
    public static double ColoumbToAmpereHours(this double x) => Coloumb.toAmpereHours(x);
    public static double ColoumbToAmpereSeconds(this double x) => Coloumb.toAmpereSeconds(x);
}

public static class AmpereHourExtensions
{
    public static double AmpereHourToColoumbs(this double x) => AmpereHour.toColoumbs(x);
    public static double AmpereHourToAmpereSeconds(this double x) => AmpereHour.toAmpereSeconds(x);
}

public static class AmpereSecondExtensions
{
    public static double AmpereSecondToColoumbs(this double x) => AmpereSecond.toColoumbs(x);
    public static double AmpereSecondToAmpereHours(this double x) => AmpereSecond.toAmpereHours(x);
}