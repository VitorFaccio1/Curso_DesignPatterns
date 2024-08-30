namespace DesignPatterns.Behavioral_Patterns.Command;

public class CommandClient
{
    public void Menu()
    {
        bool continueMenu = true;
        var application = new Application();

        while (continueMenu)
        {
            application.SetClipboard("Teste");
            application.Paste();
            application.Copy();
            application.Cut();
            application.Undo();

            Console.WriteLine("\nDeseja entender o funcionamento do Command novamente?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            Console.Write("Digite sua escolha: ");
            continueMenu = Convert.ToInt32(Console.ReadLine()) == 1;
        }
    }
}