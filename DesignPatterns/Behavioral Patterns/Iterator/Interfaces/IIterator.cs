namespace DesignPatterns.Behavioral_Patterns.Iterator.Interfaces;

public interface IIterator
{
    bool HasNext();

    object Next();
}