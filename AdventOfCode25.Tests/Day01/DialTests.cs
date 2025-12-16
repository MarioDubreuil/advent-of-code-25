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
    public void RotateLeft_ThrowsArgumentOutOfRangeException_WhenDistanceIsLessThan1()
    {
        var dial = new Dial();
        var act = () => dial.RotateLeft(0);
        act.Should().Throw<ArgumentOutOfRangeException>();
    }

    [Fact]
    public void RotateLeft_ThrowsArgumentOutOfRangeException_WhenDistanceIsGreaterThan99()
    {
        var dial = new Dial();
        var act = () => dial.RotateLeft(100);
        act.Should().Throw<ArgumentOutOfRangeException>();
    }

    [Fact]
    public void RotateRight_ThrowsArgumentOutOfRangeException_WhenDistanceIsLessThan1()
    {
        var dial = new Dial();
        var act = () => dial.RotateRight(0);
        act.Should().Throw<ArgumentOutOfRangeException>();
    }

    [Fact]
    public void RotateRight_ThrowsArgumentOutOfRangeException_WhenDistanceIsGreaterThan99()
    {
        var dial = new Dial();
        var act = () => dial.RotateRight(100);
        act.Should().Throw<ArgumentOutOfRangeException>();
    }

    [Theory]
    [InlineData(10, 40)]
    [InlineData(50, 0)]
    [InlineData(60, 90)]
    [InlineData(99, 51)]
    public void RotateLeft_ReducesPositionCorrectly(int distance, int expected)
    {
        var dial = new Dial();
        dial.RotateLeft(distance);
        dial.Position.Should().Be(expected);
    }

    [Theory]
    [InlineData(10, 60)]
    [InlineData(50, 0)]
    [InlineData(60, 10)]
    [InlineData(99, 49)]
    public void RotateRight_IncreasesPositionCorrectly(int distance, int expected)
    {
        var dial = new Dial();
        dial.RotateRight(distance);
        dial.Position.Should().Be(expected);
    }
}
