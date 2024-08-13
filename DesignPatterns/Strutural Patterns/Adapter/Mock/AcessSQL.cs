namespace DesignPatterns.Strutural_Patterns.Adapter.Mock;

public class AcessSQL
{
    public static Bill GetBillsToPay(string month)
    {
        Dictionary<string, Bill> dic = new()
        {
            { "junho", new Bill { Name = "Lojas Americanas", Value = 100 } },
            { "julho",  new Bill { Name = "Lojas Mexicanas", Value = 500 } },
            { "agosto",  new Bill { Name = "Lojas Brasileiras", Value = 200 } }
        };

        return dic[month];
    }

    public static Bill GetBillsToReceive(string month)
    {
        Dictionary<string, Bill> dic = new()
        {
            { "junho", new Bill { Name = "Lojas Americanas", Value = 1200 } },
            { "julho",  new Bill { Name = "Lojas Mexicanas", Value = 1500 } },
            { "agosto",  new Bill { Name = "Lojas Brasileiras", Value = 2000 } }
        };

        return dic[month];
    }
}