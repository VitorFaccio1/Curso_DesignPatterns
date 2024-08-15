using DesignPatterns.Strutural_Patterns.Brigde.Implementation.Interfaces;

namespace DesignPatterns.Strutural_Patterns.Brigde.Implementation;

public class Red : IColor
{
    public string GetQuantityColor(string typeAbstraction)
    {
        var random = new Random();

        var quantity = random.Next(0, 255);

        return $"\nExistem {quantity} {typeAbstraction} de cor Vermelha no estoque";
    }
}