namespace DesignPatterns.Creational_Patterns.Singleton;

public class ContextoDB
{
    private ContextoDB()
    {
    }

    private static ContextoDB _instance;

    public static ContextoDB GetInstance()
    {
        Console.WriteLine("\nInstância criada com sucesso!");
        return _instance ??= new ContextoDB();
    }

    public void ExecuteQuery(string query)
    {
        Console.WriteLine(query);
    }
}