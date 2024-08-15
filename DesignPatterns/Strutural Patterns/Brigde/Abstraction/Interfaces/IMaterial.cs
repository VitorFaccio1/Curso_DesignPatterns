using DesignPatterns.Strutural_Patterns.Brigde.Implementation.Interfaces;

namespace DesignPatterns.Strutural_Patterns.Brigde.Abstraction.Interfaces;

public interface IMaterial
{
    public IColor ColorImplementation { get; set; }

    string GetFromStock();
}