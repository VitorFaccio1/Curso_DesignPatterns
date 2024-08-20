using DesignPatterns.Strutural_Patterns.Decorator.Interfaces;

namespace DesignPatterns.Strutural_Patterns.Decorator.Decorators;

public class AccessoryDecorator : PetDecorator
{
    public AccessoryDecorator(IPet pet) : base(pet)
    {
    }

    public override double GetValueService()
    {
        return base.GetValueService() + 30;
    }

    public override string GetNameService()
    {
        return base.GetNameService() + "\n[+] Acessório";
    }
}