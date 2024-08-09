using DesignPatterns.Creational_Patterns.Builder.Builders;
using DesignPatterns.Creational_Patterns.Builder.Carros;

namespace DesignPatterns.Creational_Patterns.Builder;

public class BuilderClient
{
    public void CreateCars()
    {
        var continueMenu = true;

        while (continueMenu)
        {
            Console.Clear();

            Director director = new();
            Car car;

            var ferrariBuilder = new FerrariBuilder();
            director.DoCar(ferrariBuilder);
            car = ferrariBuilder.GetCar();

            WriteCar(car);

            var mustangBuilder = new MustangBuilder();
            director.DoCarWithoutColor(mustangBuilder);
            car = mustangBuilder.GetCar();

            WriteCar(car);

            Console.WriteLine("\nDeseja criar os carros novamente?\n1 - Sim\n2 - Não");
            Console.Write("Digite a opção que deseja: ");
            continueMenu = Convert.ToInt32(Console.ReadLine()) == 1;
        }
    }

    private static void WriteCar(Car car)
    {
        Console.WriteLine($"\nVoce criou um(a): {car.Name}" +
            $"\nMotor: {car.Engine}" +
            $"\nCor: {car.Color ?? "Não tem"}" +
            $"\nNumero de assentos: {car.SeatsNumber}");
    }
}