using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
namespace Fs.Units.CSharp.Tests.Benchmark;

public static class TestFootExtensions
{
    public static double ToInches(this double value) => Units.Length.Foot.toInches(value);
}

[SimpleJob(RuntimeMoniker.Net60)]
[SimpleJob(RuntimeMoniker.Net70)]
[MemoryDiagnoser]
public class BenchmarkTests
{
    [Benchmark(Baseline = true)]
    public void DirectDoubleConvert()
    {
        var value = 2d.ToInches();
    }

    [Benchmark]
    public void FluentInterfaceConversion1()
    {
        var value = 2d.Feet().ToInches().Value;
    }
}