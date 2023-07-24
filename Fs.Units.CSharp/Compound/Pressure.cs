// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.Pressure;

public static class PascalExtensions
{
    public static double PascalToPoundsPerSquareInch(this double x) => Units.Pressure.Pascal.toPoundsPerSquareInch(x);
}

public static class PoundPerSquareInchExtensions
{
    public static double PoundPerSquareInchToPascals(this double x) => Units.Pressure.PoundPerSquareInch.toPascals(x);
}