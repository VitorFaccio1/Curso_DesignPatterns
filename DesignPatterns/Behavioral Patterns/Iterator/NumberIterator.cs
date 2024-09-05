using DesignPatterns.Behavioral_Patterns.Iterator.Interfaces;

namespace DesignPatterns.Behavioral_Patterns.Iterator;

public class NumberIterator : IIterator
{
    private int[] _numbers;
    private int _position = 0;

    public NumberIterator(int[] numbers)
    {
        _numbers = numbers;
    }

    public bool HasNext()
    {
        return _position < _numbers.Length;
    }

    public object Next()
    {
        if (HasNext())
            return _numbers[_position++];

        return null;
    }
}