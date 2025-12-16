using Ardalis.GuardClauses;

namespace AdventOfCode25.Day01;

public class Dial
{
    private int _position = 50;
    
    public int Position => _position;
    
    public void RotateLeft(int distance)
    {
        Guard.Against.OutOfRange(distance, nameof(distance), 1, 99);
        _position -= distance;
        if (_position < 0)
        {
            _position += 100;
        }
    }
    
    public void RotateRight(int distance)
    {
        Guard.Against.OutOfRange(distance, nameof(distance), 1, 99);
        _position += distance;
        if (_position > 99)
        {
            _position -= 100;
        }
    }
}