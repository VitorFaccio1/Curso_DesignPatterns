using DesignPatterns.Strutural_Patterns.Proxy.Interfaces;
using DesignPatterns.Strutural_Patterns.Proxy.Model;
using DesignPatterns.Strutural_Patterns.Proxy.Sql;

namespace DesignPatterns.Strutural_Patterns.Proxy;

public class VPNProxy : IProxy
{
    public void AcessVpn(User user)
    {
        DatabaseConnection databaseConnection = new();

        databaseConnection.RegisterAccessVPN(user);

        Console.WriteLine(new String('-', 40));

        VPN vpn = new VPN();

        vpn.AcessVpn(user);
    }
}