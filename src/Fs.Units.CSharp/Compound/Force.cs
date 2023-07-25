// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.Force;

public static class NewtonExtensions
{
    public static double NewtonToPoundForce(this double x) => Units.Force.Newton.toPoundForce(x);
    public static double NewtonToDynes(this double x) => Units.Force.Newton.toDynes(x);
    public static double NewtonToKips(this double x) => Units.Force.Newton.toKips(x);
}

public static class PoundForceExtensions
{
    public static double PoundForceToNewtons(this double x) => Units.Force.PoundForce.toNewtons(x);
    public static double PoundForceToDynes(this double x) => Units.Force.PoundForce.toDynes(x);
    public static double PoundForceToKips(this double x) => Units.Force.PoundForce.toKips(x);
}

public static class DyneExtensions
{
    public static double DyneToNewtons(this double x) => Units.Force.Dyne.toNewtons(x);
    public static double DyneToPoundForce(this double x) => Units.Force.Dyne.toPoundForce(x);
    public static double DyneToKips(this double x) => Units.Force.Dyne.toKips(x);
}

public static class KipExtensions
{
    public static double KipToNewtons(this double x) => Units.Force.Kip.toNewtons(x);
    public static double KipToPoundForce(this double x) => Units.Force.Kip.toPoundForce(x);
    public static double KipToDynes(this double x) => Units.Force.Kip.toDynes(x);
}