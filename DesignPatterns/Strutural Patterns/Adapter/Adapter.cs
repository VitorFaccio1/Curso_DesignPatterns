using DesignPatterns.Strutural_Patterns.Adapter.Interfaces;

namespace DesignPatterns.Strutural_Patterns.Adapter;

public class Adapter : IAdapter
{
    BusinessLegacy legacy;

    public Adapter(BusinessLegacy legacy)
    {
        this.legacy = legacy;
    }

    public string ExecuteRotineBillsToPay(string month)
    {
        return legacy.ExecuteRoutineBillsToPay(month);
    }

    public string ExecuteRotineBillsToRecieve(string month)
    {
        return legacy.ExecuteRoutineBillsToRecieve(month);
    }
}