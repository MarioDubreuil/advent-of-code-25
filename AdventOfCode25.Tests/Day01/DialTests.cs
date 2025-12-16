using AdventOfCode25.Day01;
using FluentAssertions;

namespace AdventOfCode25.Tests.Day01;

public class DialTests
{
    [Fact]
    public void Constructor_InitializesPositionTo50()
    {
        var dial = new Dial();
        dial.Position.Should().Be(50);
    }

    [Fact]
    public void RotateLeft_WrapsAroundAtZero()
    {
        var dial = new Dial();
        dial.RotateLeft(60);
        dial.Position.Should().Be(90);
    }

    [Fact]
    public void RotateRight_WrapsAroundAt100()
    {
        var dial = new Dial();
        dial.RotateRight(60);
        dial.Position.Should().Be(10);
    }

    [Fact]
    public void RotateLeft_ThrowsArgumentException_WhenDistanceIsNegative()
    {
        var dial = new Dial();
        var act = () => dial.RotateLeft(-1);
        act.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void RotateRight_ThrowsArgumentException_WhenDistanceIsNegative()
    {
        var dial = new Dial();
        var act = () => dial.RotateRight(-1);
        act.Should().Throw<ArgumentException>();
    }

    [Theory]
    [InlineData(0, 50)]
    [InlineData(1, 49)]
    [InlineData(10, 40)]
    [InlineData(50, 0)]
    [InlineData(60, 90)]
    [InlineData(99, 51)]
    [InlineData(100, 50)]
    [InlineData(101, 49)]
    [InlineData(110, 40)]
    [InlineData(150, 0)]
    [InlineData(160, 90)]
    [InlineData(199, 51)]
    [InlineData(200, 50)]
    [InlineData(201, 49)]
    [InlineData(210, 40)]
    [InlineData(250, 0)]
    [InlineData(260, 90)]
    [InlineData(299, 51)]
    public void RotateLeft_ReducesPositionCorrectly(int distance, int expected)
    {
        var dial = new Dial();
        dial.RotateLeft(distance);
        dial.Position.Should().Be(expected);
    }

    [Theory]
    [InlineData(0, 50)]
    [InlineData(1, 51)]
    [InlineData(10, 60)]
    [InlineData(50, 0)]
    [InlineData(60, 10)]
    [InlineData(99, 49)]
    [InlineData(100, 50)]
    [InlineData(101, 51)]
    [InlineData(110, 60)]
    [InlineData(150, 0)]
    [InlineData(160, 10)]
    [InlineData(199, 49)]
    [InlineData(200, 50)]
    [InlineData(201, 51)]
    [InlineData(210, 60)]
    [InlineData(250, 0)]
    [InlineData(260, 10)]
    [InlineData(299, 49)]
    public void RotateRight_IncreasesPositionCorrectly(int distance, int expected)
    {
        var dial = new Dial();
        dial.RotateRight(distance);
        dial.Position.Should().Be(expected);
    }
}
