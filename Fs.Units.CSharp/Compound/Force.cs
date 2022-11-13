// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.Force;

public static class NewtonExtensions
{
    public static double NewtonToPoundForce(this double x) => Newton.toPoundForce(x);
    public static double NewtonToDynes(this double x) => Newton.toDynes(x);
    public static double NewtonToKips(this double x) => Newton.toKips(x);
}

public static class PoundForceExtensions
{
    public static double PoundForceToNewtons(this double x) => PoundForce.toNewtons(x);
    public static double PoundForceToDynes(this double x) => PoundForce.toDynes(x);
    public static double PoundForceToKips(this double x) => PoundForce.toKips(x);
}

public static class DyneExtensions
{
    public static double DyneToNewtons(this double x) => Dyne.toNewtons(x);
    public static double DyneToPoundForce(this double x) => Dyne.toPoundForce(x);
    public static double DyneToKips(this double x) => Dyne.toKips(x);
}

public static class KipExtensions
{
    public static double KipToNewtons(this double x) => Kip.toNewtons(x);
    public static double KipToPoundForce(this double x) => Kip.toPoundForce(x);
    public static double KipToDynes(this double x) => Kip.toDynes(x);
}