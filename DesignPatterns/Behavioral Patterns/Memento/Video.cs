namespace DesignPatterns.Behavioral_Patterns.Memento;

public class Video
{
    public void Execute()
    {
        bool continueMenu = true;

        while (continueMenu)
        {
            Console.Clear();
            var originator = new Originator
            {
                State = "Iniciar"
            };

            var careTaker = new CareTaker();
            careTaker.AddSnapshot(originator.CreateSnapshot());

            originator.State = "Pausar";

            originator.Restore(careTaker.GetSnapshot());

            Console.WriteLine("\nDeseja entender o funcionamento do Memento novamente?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            Console.Write("Digite sua escolha: ");
            continueMenu = Convert.ToInt32(Console.ReadLine()) == 1;
        }
    }
}
