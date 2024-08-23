namespace DesignPatterns.Strutural_Patterns.Proxy.Model;

public class User
{
    public User(string name, string password)
    {
        Name = name;
        Password = password;
    }

    public string Name { get; private set; }
    public string Password { get; private set; }
}