namespace Fs.Units.CSharp.Tests.Benchmark;

using Fs.Units;

public interface IMeasure
{
    public double Value { get; }
}

public interface IInch : IMeasure { }
public interface IFoot : IMeasure { }

public class Inch : IInch
{
    public double Value { get; }

    public Inch(double value) => Value = value;
}

public class Foot : IFoot
{
    public double Value { get; }

    public Foot(double value) => Value = value;
}

public static class InchExtensions
{
    public static IInch Inches(this double x) => new Inch(x);
    public static IFoot ToFeet(this IInch x) => new Foot(Length.Inch.toFeet(x.Value));
}

public static class FootExtensions
{
    public static IFoot Feet(this double x) => new Foot(x);
    public static IInch ToInches(this IFoot x) => new Inch(Length.Foot.toInches(x.Value));
}