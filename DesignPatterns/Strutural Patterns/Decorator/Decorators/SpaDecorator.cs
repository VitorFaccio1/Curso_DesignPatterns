using DesignPatterns.Strutural_Patterns.Decorator.Interfaces;

namespace DesignPatterns.Strutural_Patterns.Decorator.Decorators;

public class SpaDecorator : PetDecorator
{
    public SpaDecorator(IPet pet) : base(pet)
    {
    }

    public override double GetValueService()
    {
        return base.GetValueService() + 100;
    }

    public override string GetNameService()
    {
        return base.GetNameService() + "\n[+] Spa";
    }
}