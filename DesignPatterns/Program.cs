using DesignPatterns.Behavioral_Patterns.Command;
using DesignPatterns.Behavioral_Patterns.Interpreter.Calculator;
using DesignPatterns.Behavioral_Patterns.Observer;
using DesignPatterns.Behavioral_Patterns.Strategy;
using DesignPatterns.Behavioral_Patterns.Template_Method;
using DesignPatterns.Creational_Patterns.Abstract_Factory;
using DesignPatterns.Creational_Patterns.Builder;
using DesignPatterns.Creational_Patterns.Factory_Method;
using DesignPatterns.Creational_Patterns.Prototype;
using DesignPatterns.Creational_Patterns.Singleton;
using DesignPatterns.Strutural_Patterns.Adapter;
using DesignPatterns.Strutural_Patterns.Brigde;
using DesignPatterns.Strutural_Patterns.Composite;
using DesignPatterns.Strutural_Patterns.Decorator;
using DesignPatterns.Strutural_Patterns.FlyWeight;

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
        "\n6)Adapter" +
        "\n7)FlyWeight" +
        "\n8)Brigde" +
        "\n9)Composite" +
        "\n10)Decorator" +
        "\n\n-------Behavioral Patterns-------" +
        "\n11)Template Method" +
        "\n12)Interpreter" +
        "\n13)Observer" +
        "\n14)Command" +
        "\n15)Strategy");

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
        case 7:
            new FlyWeightClient().Consume();
            break;
        case 8:
            new BridgeClient().GetPensPincelsFromStock();
            break;
        case 9:
            new CompositeClient().Buy();
            break;
        case 10:
            new DecoratorClient().ConsumeServices();
            break;
        case 11:
            new TemplateMethodClient().Menu();
            break;
        case 12:
            new CalculatorClient().Calculate();
            break;
        case 13:
            new ObserverClient().EnviaEmail();
            break;
        case 14:
            new CommandClient().Menu();
            break;
        case 15:
            new StrategyClient().Menu();
            break;
        default:
            break;
    }
}