using DesignPatterns.Creational_Patterns.Abstract_Factory.Factories;
using DesignPatterns.Creational_Patterns.Abstract_Factory.Interfaces;

namespace DesignPatterns.Creational_Patterns.Abstract_Factory;

public class RoutineClient
{
    public void GetRoutine()
    {
        var continueMenu = true;

        while (continueMenu)
        {
            Console.Clear();

            IFactory factory = null;

            Console.WriteLine("1 - Domingo");
            Console.WriteLine("2 - Segunda");
            Console.WriteLine("3 - Sair");
            Console.Write("Selecione a rotina desejada: ");
            var option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    factory = new SundayFactory();
                    break;
                case 2:
                    factory = new MondayFactory();
                    break;
                default:
                    break;
            }

            Console.WriteLine("\nDeseja ver outra rotina?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            Console.Write("Selecione a opção desejada: ");
            continueMenu = Convert.ToInt32(Console.ReadLine()) == 1;
        }
    }
}