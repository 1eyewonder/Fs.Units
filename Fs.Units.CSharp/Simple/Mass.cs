// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.Mass;

public static class MilligramExtensions
{
    public static double MilligramToGrams(this double x) => Milligram.toGrams(x);
    public static double MilligramToKilograms(this double x) => Milligram.toKilograms(x);
    public static double MilligramToPoundMass(this double x) => Milligram.toPoundMass(x);
}

public static class GramExtensions
{
    public static double GramToMilligrams(this double x) => Gram.toMilligrams(x);
    public static double GramToKilograms(this double x) => Gram.toKilograms(x);
    public static double GramToPoundMass(this double x) => Gram.toPoundMass(x);
}

public static class KilogramExtensions
{
    public static double KilogramToMilligrams(this double x) => Kilogram.toMilligrams(x);
    public static double KilogramToGrams(this double x) => Kilogram.toGrams(x);
    public static double KilogramToPoundMass(this double x) => Kilogram.toPoundMass(x);
}

public static class PoundMassExtensions
{
    public static double PoundMassToMilligrams(this double x) => PoundMass.toMilligrams(x);
    public static double PoundMassToGrams(this double x) => PoundMass.toGrams(x);
    public static double PoundMassToKilograms(this double x) => PoundMass.toKilograms(x);
}