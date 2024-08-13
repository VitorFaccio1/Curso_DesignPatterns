using DesignPatterns.Strutural_Patterns.Adapter.Interfaces;

namespace DesignPatterns.Strutural_Patterns.Adapter;

public class Client
{
    IAdapter adapter;

    public void ProcessBills()
    {
        bool continueMenu = true;

        while (continueMenu)
        {
            Console.Clear();

            Console.WriteLine("Qual mês deseja executar a rotina de contas?\nJunho\nJulho\nAgosto");
            Console.Write("Digite sua escolha: ");
            var month = Console.ReadLine().ToLower();

            Console.WriteLine("--------------REGRA DE NEGOCIO ANTIGA--------------");

            adapter = new Adapter(new BusinessLegacy());

            var result = adapter.ExecuteRotineBillsToPay(month);
            Console.WriteLine("\nProcessando contas a pagar");
            Console.WriteLine(result);

            result = adapter.ExecuteRotineBillsToRecieve(month);
            Console.WriteLine("\nProcessando contas a receber");
            Console.WriteLine(result);

            Console.WriteLine("--------------REGRA DE NEGOCIO NOVA--------------");

            adapter = new Adapter(new BusinessNew());

            result = adapter.ExecuteRotineBillsToPay(month);
            Console.WriteLine("\nProcessando contas a pagar");
            Console.WriteLine(result);

            result = adapter.ExecuteRotineBillsToRecieve(month);
            Console.WriteLine("\nProcessando contas a receber");
            Console.WriteLine(result);

            Console.WriteLine("\nProcesso finalizado com sucesso! Deseja executar rotina de outro mes?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            continueMenu = Convert.ToInt32(Console.ReadLine()) == 1;
        }
    }
}