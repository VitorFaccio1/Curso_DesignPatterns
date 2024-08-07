using DesignPatterns.Creational_Patterns.Abstract_Factory;
using DesignPatterns.Creational_Patterns.Factory_Method;

var designPatternOption = 1;

while (designPatternOption != 0)
{
    Console.Clear();

    Console.WriteLine("Selecione o design pattern que deseja entender: " +
        "\n-------Creational Patterns-------" +
        "\n1)Factory Method" +
        "\n2)Abstract Factory");

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
        default:
            break;
    }
}