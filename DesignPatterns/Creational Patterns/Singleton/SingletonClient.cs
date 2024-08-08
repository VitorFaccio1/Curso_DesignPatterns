namespace DesignPatterns.Creational_Patterns.Singleton;

public sealed class SingletonClient
{
    public void ConsumeDB()
    {
        bool continueMenu = true;

        while (continueMenu)
        {
            Console.Clear();

            var instance = ContextoDB.GetInstance();
            instance.ExecuteQuery("\nSELECT * FROM X");

            instance = ContextoDB.GetInstance();
            instance.ExecuteQuery("\nINSERT INTO x (nome) VALUES (vitor)");

            var instance2 = ContextoDB.GetInstance();

            if (instance == instance2)
                Console.WriteLine("\nSingleton deu certo, ambas as variáveis têm a mesma instância.");
            else
                Console.WriteLine("\nSingleton falhou, as variáveis têm instâncias diferentes.");


            Console.WriteLine("\nDeseja entender o funcionamento do Singleton novamente?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            Console.Write("Digite sua escolha: ");
            continueMenu = Convert.ToInt32(Console.ReadLine()) == 1;
        }
    }
}