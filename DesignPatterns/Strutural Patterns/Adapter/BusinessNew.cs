using DesignPatterns.Strutural_Patterns.Adapter.Mock;

namespace DesignPatterns.Strutural_Patterns.Adapter.Interfaces;

public class BusinessNew
{
    public string ExecuteRoutineBillsToPay(string month)
    {
        var result = AcessSQL.GetBillsToPay(month);

        //nova regra de negocio
        result.Value += result.Value * 0.1M;

        return $"Nome: {result.Name} e valor: {result.Value}";
    }

    public string ExecuteRoutineBillsToRecieve(string month)
    {
        var result = AcessSQL.GetBillsToReceive(month);

        //nova regra de negocio
        result.Value += result.Value * 0.1M;

        return $"Nome: {result.Name} e valor: {result.Value}";
    }
}