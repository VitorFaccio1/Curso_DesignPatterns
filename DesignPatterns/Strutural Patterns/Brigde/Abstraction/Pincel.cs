using DesignPatterns.Strutural_Patterns.Brigde.Abstraction.Interfaces;
using DesignPatterns.Strutural_Patterns.Brigde.Implementation.Interfaces;

namespace DesignPatterns.Strutural_Patterns.Brigde.Abstraction;

public class Pincel : IMaterial
{
    public IColor ColorImplementation { get; set; }

    public string GetFromStock()
    {
        return this.ColorImplementation.GetQuantityColor("Pincel");
    }
}
