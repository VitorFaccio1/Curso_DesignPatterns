using DesignPatterns.Strutural_Patterns.Proxy.Model;

namespace DesignPatterns.Strutural_Patterns.Proxy;

public class ProxyClient
{
    public void ConnectClientVPN()
    {
        bool continueMenu = true;

        while (continueMenu)
        {
            Console.Clear();

            VPNProxy proxy = new VPNProxy();

            Console.WriteLine("Digite o nome do usuario");
            var username = Console.ReadLine();

            Console.WriteLine("Digite a senha do usuario");
            var password = Console.ReadLine();

            var user = new User(username, password);

            proxy.AcessVpn(user);

            Console.WriteLine("\nProcesso finalizado com sucesso! Deseja executar novamente?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            continueMenu = Convert.ToInt32(Console.ReadLine()) == 1;
        }
    }
}