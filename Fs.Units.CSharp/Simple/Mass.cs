// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.Mass;

public static class MilligramExtensions
{
    public static double MilligramToGrams(this double x) => Units.Mass.Milligram.toGrams(x);
    public static double MilligramToKilograms(this double x) => Units.Mass.Milligram.toKilograms(x);
    public static double MilligramToPoundMass(this double x) => Units.Mass.Milligram.toPoundMass(x);
}

public static class GramExtensions
{
    public static double GramToMilligrams(this double x) => Units.Mass.Gram.toMilligrams(x);
    public static double GramToKilograms(this double x) => Units.Mass.Gram.toKilograms(x);
    public static double GramToPoundMass(this double x) => Units.Mass.Gram.toPoundMass(x);
}

public static class KilogramExtensions
{
    public static double KilogramToMilligrams(this double x) => Units.Mass.Kilogram.toMilligrams(x);
    public static double KilogramToGrams(this double x) => Units.Mass.Kilogram.toGrams(x);
    public static double KilogramToPoundMass(this double x) => Units.Mass.Kilogram.toPoundMass(x);
}

public static class PoundMassExtensions
{
    public static double PoundMassToMilligrams(this double x) => Units.Mass.PoundMass.toMilligrams(x);
    public static double PoundMassToGrams(this double x) => Units.Mass.PoundMass.toGrams(x);
    public static double PoundMassToKilograms(this double x) => Units.Mass.PoundMass.toKilograms(x);
}