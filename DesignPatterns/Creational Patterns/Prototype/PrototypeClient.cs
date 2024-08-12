namespace DesignPatterns.Creational_Patterns.Prototype;

public class PrototypeClient
{
    public void Consume()
    {
        var continueMenu = true;
        StudiosManager manager = new StudiosManager();

        while (continueMenu)
        {
            Console.Clear();

            manager["24m"] = new Studio("24m", 100.000M);
            manager["25m"] = new Studio("25m", 110.000M);
            manager["26m"] = new Studio("26m", 120.000M);

            var firstClone = manager["24m"].Clone();
            var firstClone2 = manager["24m"].Clone();
            var secondClone = manager["25m"].Clone();
            var thirdClone = manager["26m"].Clone();

            firstClone.Type = "Teste";
            secondClone.Value = 10M;

            if(firstClone.Type == secondClone.Type)
                Console.WriteLine("Clonagem para diferentes objetos deu errado");

            Console.WriteLine("\nDeseja clonar novamente?\n1 - Sim\n2 - Não");
            Console.Write("Digite a opção que deseja: ");
            continueMenu = Convert.ToInt32(Console.ReadLine()) == 1;
        }

    }
}