using DesignPatterns.Creational_Patterns.Abstract_Factory;
using DesignPatterns.Creational_Patterns.Builder;
using DesignPatterns.Creational_Patterns.Factory_Method;
using DesignPatterns.Creational_Patterns.Prototype;
using DesignPatterns.Creational_Patterns.Singleton;
using DesignPatterns.Strutural_Patterns.Adapter;

var designPatternOption = 1;

while (designPatternOption != 0)
{
    Console.Clear();

    Console.WriteLine("Selecione o design pattern que deseja entender: " +
        "\n-------Creational Patterns-------" +
        "\n1)Factory Method" +
        "\n2)Abstract Factory" +
        "\n3)Singleton" +
        "\n4)Builder" +
        "\n5)Prototype" +
        "\n\n-------Strutural Patterns-------" +
        "\n6)Adapter");

    Console.Write("\nDigite a opção que deseja: ");
    designPatternOption = Convert.ToInt32(Console.ReadLine());

    switch (designPatternOption)
    {
        case 0:
            Console.WriteLine("\nSaindo....");
            break;
        case 1:
            new AnimalClient().CreateAnimal();
            break;
        case 2:
            new RoutineClient().GetRoutine();
            break;
        case 3:
            new SingletonClient().ConsumeDB();
            break;
        case 4:
            new BuilderClient().CreateCars();
            break;
        case 5:
            new PrototypeClient().Consume();
            break;
        case 6:
            new Client().ProcessBills();
            break;
        default:
            break;
    }
}