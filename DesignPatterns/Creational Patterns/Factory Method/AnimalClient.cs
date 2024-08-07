namespace DesignPatterns.Creational_Patterns.Factory_Method;

public class AnimalClient
{
    public void CreateAnimal()
    {
        var animalService = new AnimalService();
        var continueMenu = true;

        while (continueMenu)
        {
            Console.Clear();

            Console.WriteLine("Selecione o tipo de animal:");
            Console.WriteLine("0 - Vaca");
            Console.WriteLine("1 - Gato");
            Console.WriteLine("2 - Cachorro");
            Console.Write("Digite a opção que deseja: ");
            var option = Convert.ToInt32(Console.ReadLine());

            var animal = animalService.CreateAnimal(option);

            animal?.Speak();

            Console.WriteLine("\nDeseja criar outro animal?\n1 - Sim\n2 - Não");
            Console.Write("Digite a opção que deseja: ");
            continueMenu = Convert.ToInt32(Console.ReadLine()) == 1;
        }
    }
}