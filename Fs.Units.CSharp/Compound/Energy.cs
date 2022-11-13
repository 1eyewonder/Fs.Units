// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.Energy;

public static class JouleExtensions
{
    public static double JouleToKilojoules(this double x) => Joule.toKilojoules(x);
    public static double JouleToBritishThermalUnits(this double x) => Joule.toBritishThermalUnits(x);
    public static double JouleToCalories(this double x) => Joule.toCalories(x);
    public static double JouleToQuads(this double x) => Joule.toQuads(x);
    public static double JouleToQs(this double x) => Joule.toQs(x);
}

public static class KilojouleExtensions
{
    public static double KilojouleToJoules(this double x) => Kilojoule.toJoules(x);
    public static double KilojouleToBritishThermalUnits(this double x) => Kilojoule.toBritishThermalUnits(x);
    public static double KilojouleToCalories(this double x) => Kilojoule.toCalories(x);
    public static double KilojouleToQuads(this double x) => Kilojoule.toQuads(x);
    public static double KilojouleToQs(this double x) => Kilojoule.toQs(x);
}

public static class BritishThermalUnitExtensions
{
    public static double BritishThermalUnitToJoules(this double x) => BritishThermalUnit.toJoules(x);
    public static double BritishThermalUnitToKilojoules(this double x) => BritishThermalUnit.toKilojoules(x);
    public static double BritishThermalUnitToCalories(this double x) => BritishThermalUnit.toCalories(x);
    public static double BritishThermalUnitToQuads(this double x) => BritishThermalUnit.toQuads(x);
    public static double BritishThermalUnitToQs(this double x) => BritishThermalUnit.toQs(x);
}

public static class CalorieExtensions
{
    public static double CalorieToJoules(this double x) => Calorie.toJoules(x);
    public static double CalorieToKilojoules(this double x) => Calorie.toKilojoules(x);
    public static double CalorieToBritishThermalUnits(this double x) => Calorie.toBritishThermalUnits(x);
    public static double CalorieToQuads(this double x) => Calorie.toQuads(x);
    public static double CalorieToQs(this double x) => Calorie.toQs(x);
}

public static class QuadExtensions
{
    public static double QuadToJoules(this double x) => Quad.toJoules(x);
    public static double QuadToKilojoules(this double x) => Quad.toKilojoules(x);
    public static double QuadToBritishThermalUnits(this double x) => Quad.toBritishThermalUnits(x);
    public static double QuadToCalories(this double x) => Quad.toCalories(x);
    public static double QuadToQs(this double x) => Quad.toQs(x);
}

public static class QExtensions
{
    public static double QToJoules(this double x) => Q.toJoules(x);
    public static double QToKilojoules(this double x) => Q.toKilojoules(x);
    public static double QToBritishThermalUnits(this double x) => Q.toBritishThermalUnits(x);
    public static double QToCalories(this double x) => Q.toCalories(x);
    public static double QToQuads(this double x) => Q.toQuads(x);
}