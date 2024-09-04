using DesignPatterns.Behavioral_Patterns.Chain_of_Responsability.Models;

namespace DesignPatterns.Behavioral_Patterns.Chain_of_Responsability;

public class ChainofResponsabilityClient
{
    public void Menu()
    {
        bool continueMenu = true;

        while (continueMenu)
        {
            Console.Clear();

            var manager = new Manager();
            var director = new Director();
            var vicePresident = new VicePresident();

            manager.SetNextHandler(director);
            director.SetNextHandler(vicePresident);

            decimal[] expenses = { 500, 1500, 6000, 12000 };

            foreach (var amount in expenses)
            {
                manager.HandleRequest(amount);
            }

            Console.WriteLine("\nDeseja entender o funcionamento do Chain of Responsability novamente?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            Console.Write("Digite sua escolha: ");
            continueMenu = Convert.ToInt32(Console.ReadLine()) == 1;
        }
    }
}