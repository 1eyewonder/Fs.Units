// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.Pressure;

public static class PascalExtensions
{
    public static double PascalToPoundsPerSquareInch(this double x) => Pascal.toPoundsPerSquareInch(x);
}

public static class PoundPerSquareInchExtensions
{
    public static double PoundPerSquareInchToPascals(this double x) => PoundPerSquareInch.toPascals(x);
}