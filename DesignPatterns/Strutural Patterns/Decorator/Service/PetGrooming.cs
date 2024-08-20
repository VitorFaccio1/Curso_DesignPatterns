using DesignPatterns.Strutural_Patterns.Decorator.Interfaces;

namespace DesignPatterns.Strutural_Patterns.Decorator.Service;

public class PetGrooming : IPet
{
    private string _nameService;
    private double _valueService;

    public PetGrooming(string nameService, double valueService)
    {
        _nameService = nameService;
        _valueService = valueService;
    }

    public double GetValueService()
    {
        return _valueService;
    }

    public string GetNameService()
    {
        return _nameService;
    }
}