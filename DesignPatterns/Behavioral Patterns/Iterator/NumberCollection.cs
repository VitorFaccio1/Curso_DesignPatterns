using DesignPatterns.Behavioral_Patterns.Iterator.Interfaces;

namespace DesignPatterns.Behavioral_Patterns.Iterator;

public class NumberCollection
{
    private int[] _numbers;

    public NumberCollection(int[] numbers)
    {
        _numbers = numbers;
    }

    public IIterator CreateIterator()
    {
        return new NumberIterator(_numbers);
    }
}