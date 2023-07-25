// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.Energy;

public static class JouleExtensions
{
    public static double JouleToKilojoules(this double x) => Units.Energy.Joule.toKilojoules(x);
    public static double JouleToBritishThermalUnits(this double x) => Units.Energy.Joule.toBritishThermalUnits(x);
    public static double JouleToCalories(this double x) => Units.Energy.Joule.toCalories(x);
    public static double JouleToQuads(this double x) => Units.Energy.Joule.toQuads(x);
    public static double JouleToQs(this double x) => Units.Energy.Joule.toQs(x);
}

public static class KilojouleExtensions
{
    public static double KilojouleToJoules(this double x) => Units.Energy.Kilojoule.toJoules(x);
    public static double KilojouleToBritishThermalUnits(this double x) => Units.Energy.Kilojoule.toBritishThermalUnits(x);
    public static double KilojouleToCalories(this double x) => Units.Energy.Kilojoule.toCalories(x);
    public static double KilojouleToQuads(this double x) => Units.Energy.Kilojoule.toQuads(x);
    public static double KilojouleToQs(this double x) => Units.Energy.Kilojoule.toQs(x);
}

public static class BritishThermalUnitExtensions
{
    public static double BritishThermalUnitToJoules(this double x) => Units.Energy.BritishThermalUnit.toJoules(x);
    public static double BritishThermalUnitToKilojoules(this double x) => Units.Energy.BritishThermalUnit.toKilojoules(x);
    public static double BritishThermalUnitToCalories(this double x) => Units.Energy.BritishThermalUnit.toCalories(x);
    public static double BritishThermalUnitToQuads(this double x) => Units.Energy.BritishThermalUnit.toQuads(x);
    public static double BritishThermalUnitToQs(this double x) => Units.Energy.BritishThermalUnit.toQs(x);
}

public static class CalorieExtensions
{
    public static double CalorieToJoules(this double x) => Units.Energy.Calorie.toJoules(x);
    public static double CalorieToKilojoules(this double x) => Units.Energy.Calorie.toKilojoules(x);
    public static double CalorieToBritishThermalUnits(this double x) => Units.Energy.Calorie.toBritishThermalUnits(x);
    public static double CalorieToQuads(this double x) => Units.Energy.Calorie.toQuads(x);
    public static double CalorieToQs(this double x) => Units.Energy.Calorie.toQs(x);
}

public static class QuadExtensions
{
    public static double QuadToJoules(this double x) => Units.Energy.Quad.toJoules(x);
    public static double QuadToKilojoules(this double x) => Units.Energy.Quad.toKilojoules(x);
    public static double QuadToBritishThermalUnits(this double x) => Units.Energy.Quad.toBritishThermalUnits(x);
    public static double QuadToCalories(this double x) => Units.Energy.Quad.toCalories(x);
    public static double QuadToQs(this double x) => Units.Energy.Quad.toQs(x);
}

public static class QExtensions
{
    public static double QToJoules(this double x) => Units.Energy.QModule.toJoules(x);
    public static double QToKilojoules(this double x) => Units.Energy.QModule.toKilojoules(x);
    public static double QToBritishThermalUnits(this double x) => Units.Energy.QModule.toBritishThermalUnits(x);
    public static double QToCalories(this double x) => Units.Energy.QModule.toCalories(x);
    public static double QToQuads(this double x) => Units.Energy.QModule.toQuads(x);
}