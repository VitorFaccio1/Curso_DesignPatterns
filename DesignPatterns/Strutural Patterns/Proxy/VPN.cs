using DesignPatterns.Strutural_Patterns.Proxy.Interfaces;
using DesignPatterns.Strutural_Patterns.Proxy.Model;

namespace DesignPatterns.Strutural_Patterns.Proxy;

public class VPN : IProxy
{
    public void AcessVpn(User user)
    {
        Console.WriteLine("[+] - Acessando VPN\n");
        Thread.Sleep(2000);

        Console.WriteLine($"{user.Name}, você está logado na VPN");
    }
}