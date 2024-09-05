using DesignPatterns.Behavioral_Patterns.Iterator.Interfaces;

namespace DesignPatterns.Behavioral_Patterns.Iterator;

public class IteratorClient
{
    public void Menu()
    {
        bool continueMenu = true;

        while (continueMenu)
        {
            Console.Clear();

            int[] numbers = { 1, 2, 3, 4, 5 };

            var collection = new NumberCollection(numbers);

            IIterator iterator = collection.CreateIterator();

            while (iterator.HasNext())
                Console.WriteLine(iterator.Next());

            Console.WriteLine("\nDeseja entender o funcionamento do Iterator novamente?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            Console.Write("Digite sua escolha: ");
            continueMenu = Convert.ToInt32(Console.ReadLine()) == 1;
        }
    }
}