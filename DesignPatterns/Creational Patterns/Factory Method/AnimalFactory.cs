using DesignPatterns.Creational_Patterns.Factory_Method.Interfaces;

namespace DesignPatterns.Creational_Patterns.Factory_Method;

public abstract class AnimalFactory
{
    public abstract IAnimal CreateAnimal(int animalType);
}