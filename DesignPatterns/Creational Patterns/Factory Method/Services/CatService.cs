using DesignPatterns.Creational_Patterns.Factory_Method.Interfaces;

namespace DesignPatterns.Creational_Patterns.Factory_Method.Services;

public class CatService : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("\nMiau!");
    }
}