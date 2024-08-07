using DesignPatterns.Creational_Patterns.Factory_Method.Interfaces;
using DesignPatterns.Creational_Patterns.Factory_Method.Services;

namespace DesignPatterns.Creational_Patterns.Factory_Method;

public class AnimalService : AnimalFactory
{
    public override IAnimal CreateAnimal(int animalType)
    {
        switch (animalType)
        {
            case 0:
                return new CowService();
            case 1:
                return new CatService();
            case 2:
                return new DogService();
            default:
                Console.WriteLine("\nDigite uma opção valida.");
                return null;
        }
    }
}