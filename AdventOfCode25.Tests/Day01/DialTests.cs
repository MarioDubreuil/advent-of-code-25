using AdventOfCode25.Day01;

namespace AdventOfCode25.Tests.Day01;

public class DialTests
{
    [Fact]
    public void Constructor_InitializesPositionTo50()
    {
        var dial = new Dial();
        Assert.Equal(50, dial.Position);
    }

    [Fact]
    public void RotateLeft_WrapsAroundAtZero()
    {
        var dial = new Dial();
        dial.RotateLeft(60);
        Assert.Equal(90, dial.Position);
    }

    [Fact]
    public void RotateRight_WrapsAroundAt100()
    {
        var dial = new Dial();
        dial.RotateRight(60);
        Assert.Equal(10, dial.Position);
    }

    [Theory]
    [InlineData(10, 40)]
    [InlineData(50, 0)]
    [InlineData(60, 90)]
    public void RotateLeft_ReducesPositionCorrectly(int distance, int expected)
    {
        var dial = new Dial();
        dial.RotateLeft(distance);
        Assert.Equal(expected, dial.Position);
    }

    [Theory]
    [InlineData(10, 60)]
    [InlineData(50, 0)]
    [InlineData(60, 10)]
    public void RotateRight_IncreasesPositionCorrectly(int distance, int expected)
    {
        var dial = new Dial();
        dial.RotateRight(distance);
        Assert.Equal(expected, dial.Position);
    }
}