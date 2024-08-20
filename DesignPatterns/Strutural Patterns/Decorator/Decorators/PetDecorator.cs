using DesignPatterns.Strutural_Patterns.Decorator.Interfaces;

namespace DesignPatterns.Strutural_Patterns.Decorator.Decorators;

public class PetDecorator : IPet
{
    private IPet _pet;

    public PetDecorator(IPet pet)
    {
        _pet = pet;
    }

    public virtual double GetValueService()
    {
        return _pet.GetValueService();
    }

    public virtual string GetNameService()
    {
        return _pet.GetNameService();
    }
}