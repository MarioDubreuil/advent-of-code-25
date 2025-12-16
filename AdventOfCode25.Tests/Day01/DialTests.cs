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
    
    [Fact]
    public void RotateLeft_ThrowsArgumentOutOfRangeException_WhenDistanceIsNegative()
    {
        var dial = new Dial();
        Assert.Throws<ArgumentOutOfRangeException>(() => dial.RotateLeft(-1));
    }
    
    [Fact]
    public void RotateLeft_ThrowsArgumentOutOfRangeException_WhenDistanceIsGreaterThan99()
    {
        var dial = new Dial();
        Assert.Throws<ArgumentOutOfRangeException>(() => dial.RotateLeft(100));
    }
    
    [Fact]
    public void RotateRight_ThrowsArgumentOutOfRangeException_WhenDistanceIsNegative()
    {
        var dial = new Dial();
        Assert.Throws<ArgumentOutOfRangeException>(() => dial.RotateRight(-1));
    }
    
    [Fact]
    public void RotateRight_ThrowsArgumentOutOfRangeException_WhenDistanceIsGreaterThan99()
    {
        var dial = new Dial();
        Assert.Throws<ArgumentOutOfRangeException>(() => dial.RotateRight(100));
    }

    [Theory]
    [InlineData(0, 50)]
    [InlineData(10, 40)]
    [InlineData(50, 0)]
    [InlineData(60, 90)]
    [InlineData(99, 51)]
    public void RotateLeft_ReducesPositionCorrectly(int distance, int expected)
    {
        var dial = new Dial();
        dial.RotateLeft(distance);
        Assert.Equal(expected, dial.Position);
    }

    [Theory]
    [InlineData(0, 50)]
    [InlineData(10, 60)]
    [InlineData(50, 0)]
    [InlineData(60, 10)]
    [InlineData(99, 49)]
    public void RotateRight_IncreasesPositionCorrectly(int distance, int expected)
    {
        var dial = new Dial();
        dial.RotateRight(distance);
        Assert.Equal(expected, dial.Position);
    }
}