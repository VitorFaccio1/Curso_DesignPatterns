namespace DesignPatterns.Strutural_Patterns.Adapter;

public class BusinessLegacy
{
    public string ExecuteRoutineBillsToPay(string month)
    {
        var result = AcessSQL.GetBillsToPay(month);

        //Aplica regras

        return result;
    }

    public string ExecuteRoutineBillsToRecieve(string month)
    {
        var result = AcessSQL.GetBillsToRecieve(month);

        //Aplica regras

        return result;
    }
}

public class AcessSQL
{
    public static string GetBillsToPay(string month)
    {
        Dictionary<string, string> dic = new()
        {
            { "junho", "CNPJ: 1231232131231\nRazão social: Lojas Americanas\nValor: 1200.00\n" },
            { "julho", "CNPJ: 5464565465464\nRazão social: Lojas Mexicanas\nValor: 1500.00\n" },
            { "agosto", "CNPJ: 8909i0988908\nRazão social: Lojas Brasileiras\nValor: 2000.00\n" }
        };

        return dic[month];
    }

    public static string GetBillsToRecieve(string month)
    {
        Dictionary<string, string> dic = new()
        {
            { "junho", "CNPJ: 1231232131231\nRazão social: Lojas Americanas\nValor: 1200.00\n" },
            { "julho", "CNPJ: 5464565465464\nRazão social: Lojas Mexicanas\nValor: 1500.00\n" },
            { "agosto", "CNPJ: 8909i0988908\nRazão social: Lojas Brasileiras\nValor: 2000.00\n" }
        };

        return dic[month];
    }
}
