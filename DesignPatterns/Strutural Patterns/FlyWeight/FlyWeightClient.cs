namespace DesignPatterns.Strutural_Patterns.FlyWeight;

public class FlyWeightClient
{
    List<string> colorSizes = new()
    {
        "blue:small", "red:big",
        "blue:big", "red:small"
    };


    public void Consume()
    {
        bool continueMenu = true;

        while (continueMenu)
        {
            Console.Clear();

            FlyWeightFactory flyWeightFactory = new();

            foreach (var item in colorSizes)
            {
                var color = item.Split(":")[0];
                var size = item.Split(":")[1];

                var spaceship = flyWeightFactory.GetSpaceship(color);

                spaceship.Show(color, size);
            }

            Console.WriteLine("\nProcesso finalizado com sucesso! Deseja executar novamente?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            continueMenu = Convert.ToInt32(Console.ReadLine()) == 1;
        }
    }
}