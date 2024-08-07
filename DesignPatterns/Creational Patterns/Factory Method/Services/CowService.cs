using DesignPatterns.Creational_Patterns.Factory_Method.Interfaces;

namespace DesignPatterns.Creational_Patterns.Factory_Method.Services;

public class CowService : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("\nMuuu!");
    }
}