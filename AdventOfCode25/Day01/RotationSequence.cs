using Ardalis.GuardClauses;

namespace AdventOfCode25.Day01;

public class RotationSequence
{
    private readonly Dial _dial = new();
    private int _leftPointingAtZero = 0;
    
    public int LeftPointingAtZero => _leftPointingAtZero;
    
    public void ApplySequence(string sequence)
    {
        var steps = sequence.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        foreach (var step in steps)
        {
            var direction = step[0];
            Guard.Against.OutOfRange(direction, nameof(direction), 'L', 'R');
            var distance = int.Parse(step[1..]);
            var rotate = direction == 'L' ? (Action<int>)_dial.RotateLeft : _dial.RotateRight;
            rotate(distance);
            if (_dial.Position == 0)
            {
                _leftPointingAtZero++;
            }
        }
    }
}