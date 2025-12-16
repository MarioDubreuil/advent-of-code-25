namespace AdventOfCode25.Day01;

public class Dial
{
    private int _position = 50;
    
    public int Position => _position;
    
    public void RotateLeft(int distance)
    {
        _position -= distance;
        if (_position < 0)
        {
            _position += 100;
        }
    }
    
    public void RotateRight(int distance)
    {
        _position += distance;
        if (_position >= 100)
        {
            _position -= 100;
        }
    }
}