using DesignPatterns.Strutural_Patterns.Proxy.Model;

namespace DesignPatterns.Strutural_Patterns.Proxy.Sql;

public class DatabaseConnection
{
    public void RegisterAccessVPN(User user)
    {
        var query = $"INSERT INTO RegistroVPN (User, Password, DataHora)" +
            $"\nVALUES('{user.Name}', '{user.Password}', '{DateTime.Now}'";

        Console.WriteLine("[!] - Registrando acesso a VPN pelo proxy....\n");
        Console.WriteLine(query);
    }
}