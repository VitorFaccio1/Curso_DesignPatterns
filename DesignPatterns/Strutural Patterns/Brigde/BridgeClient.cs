using DesignPatterns.Strutural_Patterns.Brigde.Abstraction;
using DesignPatterns.Strutural_Patterns.Brigde.Abstraction.Interfaces;
using DesignPatterns.Strutural_Patterns.Brigde.Implementation;

namespace DesignPatterns.Strutural_Patterns.Brigde;

public class BridgeClient
{
    public IMaterial Material { get; set; }

    public void GetPensPincelsFromStock()
    {
        bool continueMenu = true;

        while (continueMenu)
        {
            Console.Clear();

            Console.WriteLine("Voce deseja qual material?\n1)Pincel\n2)Caneta\nDigite sua escolha: ");
            var materialOption = Convert.ToInt32(Console.ReadLine());

            Material = materialOption == 1
                ? new Pincel()
                : new Pen();

            Console.WriteLine("Voce deseja qual cor?\n1)Preto\n2)Vermelho\nDigite sua escolha: ");
            var colorOption = Convert.ToInt32(Console.ReadLine());

            Material.ColorImplementation = colorOption == 1
                ? new Black()
                : new Red();

            Console.WriteLine(Material.GetFromStock());

            Console.WriteLine("\nProcesso finalizado com sucesso! Deseja executar rotina de outro mes?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            continueMenu = Convert.ToInt32(Console.ReadLine()) == 1;
        }
    }
}