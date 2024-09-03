using DesignPatterns.Behavioral_Patterns.Strategy.Enums;
using DesignPatterns.Behavioral_Patterns.Strategy.Interfaces;
using DesignPatterns.Behavioral_Patterns.Strategy.Strategies;

namespace DesignPatterns.Behavioral_Patterns.Strategy;

public class StrategyClient
{
    public void Menu()
    {
        var strategies = new List<IPaymentStrategy>()
        {
            new CreditCardStrategy(),
            new PaypalStrategy(),
            new PixStrategy()
        };

        bool continueMenu = true;

        while (continueMenu)
        {
            Console.WriteLine("\nDeseja pagar como?");
            Console.WriteLine("1 - Cartão");
            Console.WriteLine("2 - Paypal");
            Console.WriteLine("3 - Pix");   
            int option = Convert.ToInt32(Console.ReadLine());

            var strategy = strategies.FirstOrDefault(x => x.Type.Equals((PaymentType)option));

            strategy.Validate();

            Console.WriteLine("\nDeseja entender o funcionamento do Strategy novamente?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            Console.Write("Digite sua escolha: ");
            continueMenu = Convert.ToInt32(Console.ReadLine()) == 1;
        }
    }
}