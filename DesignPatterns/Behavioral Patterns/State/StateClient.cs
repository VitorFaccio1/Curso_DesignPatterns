using DesignPatterns.Behavioral_Patterns.State.States;

namespace DesignPatterns.Behavioral_Patterns.State;

public class StateClient
{
    public void Execute()
    {
        bool continueMenu = true;

        while (continueMenu)
        {
            Console.Clear();
            var context = new Context(new StateA());

            context.Change();
            context.Change();
            Console.WriteLine("\nDeseja entender o funcionamento do Strategy novamente?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            Console.Write("Digite sua escolha: ");

            continueMenu = Convert.ToInt32(Console.ReadLine()) == 1;
        }
    }
}