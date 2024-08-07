using DesignPatterns.Creational_Patterns.Factory_Method.Interfaces;

namespace DesignPatterns.Creational_Patterns.Factory_Method.Services;

public class DogService : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("\nAu au!");
    }
}