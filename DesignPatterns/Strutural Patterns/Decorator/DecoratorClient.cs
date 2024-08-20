using DesignPatterns.Strutural_Patterns.Decorator.Decorators;
using DesignPatterns.Strutural_Patterns.Decorator.Interfaces;
using DesignPatterns.Strutural_Patterns.Decorator.Service;

namespace DesignPatterns.Strutural_Patterns.Decorator;

public class DecoratorClient
{
    public void ConsumeServices()
    {
        bool continueMenu = true;

        while (continueMenu)
        {
            Console.Clear();

            IPet petGrooming = new PetGrooming("Banho e tosa", 45);

            IPet acessorio = new AccessoryDecorator(petGrooming);
            IPet spa = new SpaDecorator(acessorio);

            Console.WriteLine("Resumo dos serviços Pet Shop");
            Console.WriteLine(spa.GetNameService());
            Console.WriteLine($"Valor total {spa.GetValueService()}");

            Console.WriteLine("\nCompra finalizada com sucesso! Deseja comprar novamente?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            continueMenu = Convert.ToInt32(Console.ReadLine()) == 1;
        }
    }
}