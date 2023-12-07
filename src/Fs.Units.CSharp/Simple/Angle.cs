// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp;

public static class DegreeExtensions
{
    public static double DegreeToRadians(this double x) => Units.Angle.Degree.toRadians(x);
    public static double DegreeToGradians(this double x) => Units.Angle.Degree.toGradians(x);
    public static double DegreeToRevolutions(this double x) => Units.Angle.Degree.toRevolutions(x);
    public static double DegreeToArcMinutes(this double x) => Units.Angle.Degree.toArcMinutes(x);
    public static double DegreeToArcSeconds(this double x) => Units.Angle.Degree.toArcSeconds(x);
}

public static class RadianExtensions
{
    public static double RadianToDegrees(this double x) => Units.Angle.Radian.toDegrees(x);
    public static double RadianToGradians(this double x) => Units.Angle.Radian.toGradians(x);
    public static double RadianToRevolutions(this double x) => Units.Angle.Radian.toRevolutions(x);
    public static double RadianToArcMinutes(this double x) => Units.Angle.Radian.toArcMinutes(x);
    public static double RadianToArcSeconds(this double x) => Units.Angle.Radian.toArcSeconds(x);
}

public static class GradianExtensions
{
    public static double GradianToDegrees(this double x) => Units.Angle.Gradian.toDegrees(x);
    public static double GradianToRadians(this double x) => Units.Angle.Gradian.toRadians(x);
    public static double GradianToRevolutions(this double x) => Units.Angle.Gradian.toRevolutions(x);
    public static double GradianToArcMinutes(this double x) => Units.Angle.Gradian.toArcMinutes(x);
    public static double GradianToArcSeconds(this double x) => Units.Angle.Gradian.toArcSeconds(x);
}

public static class RevolutionExtensions
{
    public static double RevolutionToDegrees(this double x) => Units.Angle.Revolution.toDegrees(x);
    public static double RevolutionToRadians(this double x) => Units.Angle.Revolution.toRadians(x);
    public static double RevolutionToGradians(this double x) => Units.Angle.Revolution.toGradians(x);
    public static double RevolutionToArcMinutes(this double x) => Units.Angle.Revolution.toArcMinutes(x);
    public static double RevolutionToArcSeconds(this double x) => Units.Angle.Revolution.toArcSeconds(x);
}

public static class ArcMinuteExtensions
{
    public static double ArcMinuteToDegrees(this double x) => Units.Angle.ArcMinute.toDegrees(x);
    public static double ArcMinuteToRadians(this double x) => Units.Angle.ArcMinute.toRadians(x);
    public static double ArcMinuteToGradians(this double x) => Units.Angle.ArcMinute.toGradians(x);
    public static double ArcMinuteToRevolutions(this double x) => Units.Angle.ArcMinute.toRevolutions(x);
    public static double ArcMinuteToArcSeconds(this double x) => Units.Angle.ArcMinute.toArcSeconds(x);
}

public static class ArcSecondExtensions
{
    public static double ArcSecondToDegrees(this double x) => Units.Angle.ArcSecond.toDegrees(x);
    public static double ArcSecondToRadians(this double x) => Units.Angle.ArcSecond.toRadians(x);
    public static double ArcSecondToGradians(this double x) => Units.Angle.ArcSecond.toGradians(x);
    public static double ArcSecondToRevolutions(this double x) => Units.Angle.ArcSecond.toRevolutions(x);
    public static double ArcSecondToArcMinutes(this double x) => Units.Angle.ArcSecond.toArcMinutes(x);
}