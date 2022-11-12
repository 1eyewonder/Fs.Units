// ReSharper disable once CheckNamespace
namespace Fs.Units.CSharp.Angle;

public static class DegreeExtensions
{
    public static double DegreeToRadians(this double x) => Degree.toRadians(x);
    public static double DegreeToGradians(this double x) => Degree.toGradians(x);
    public static double DegreeToRevolutions(this double x) => Degree.toRevolutions(x);
    public static double DegreeToArcMinutes(this double x) => Degree.toArcMinutes(x);
    public static double DegreeToArcSeconds(this double x) => Degree.toArcSeconds(x);
}

public static class RadianExtensions
{
    public static double RadianToDegrees(this double x) => Radian.toDegrees(x);
    public static double RadianToGradians(this double x) => Radian.toGradians(x);
    public static double RadianToRevolutions(this double x) => Radian.toRevolutions(x);
    public static double RadianToArcMinutes(this double x) => Radian.toArcMinutes(x);
    public static double RadianToArcSeconds(this double x) => Radian.toArcSeconds(x);
}

public static class GradianExtensions
{
    public static double GradianToDegrees(this double x) => Gradian.toDegrees(x);
    public static double GradianToRadians(this double x) => Gradian.toRadians(x);
    public static double GradianToRevolutions(this double x) => Gradian.toRevolutions(x);
    public static double GradianToArcMinutes(this double x) => Gradian.toArcMinutes(x);
    public static double GradianToArcSeconds(this double x) => Gradian.toArcSeconds(x);
}

public static class RevolutionExtensions
{
    public static double RevolutionToDegrees(this double x) => Revolution.toDegrees(x);
    public static double RevolutionToRadians(this double x) => Revolution.toRadians(x);
    public static double RevolutionToGradians(this double x) => Revolution.toGradians(x);
    public static double RevolutionToArcMinutes(this double x) => Revolution.toArcMinutes(x);
    public static double RevolutionToArcSeconds(this double x) => Revolution.toArcSeconds(x);
}

public static class ArcMinuteExtensions
{
    public static double ArcMinuteToDegrees(this double x) => ArcMinute.toDegrees(x);
    public static double ArcMinuteToRadians(this double x) => ArcMinute.toRadians(x);
    public static double ArcMinuteToGradians(this double x) => ArcMinute.toGradians(x);
    public static double ArcMinuteToRevolutions(this double x) => ArcMinute.toRevolutions(x);
    public static double ArcMinuteToArcSeconds(this double x) => ArcMinute.toArcSeconds(x);
}

public static class ArcSecondExtensions
{
    public static double ArcSecondToDegrees(this double x) => ArcSecond.toDegrees(x);
    public static double ArcSecondToRadians(this double x) => ArcSecond.toRadians(x);
    public static double ArcSecondToGradians(this double x) => ArcSecond.toGradians(x);
    public static double ArcSecondToRevolutions(this double x) => ArcSecond.toRevolutions(x);
    public static double ArcSecondToArcMinutes(this double x) => ArcSecond.toArcMinutes(x);
}