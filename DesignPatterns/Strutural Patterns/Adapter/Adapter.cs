using DesignPatterns.Strutural_Patterns.Adapter.Interfaces;

namespace DesignPatterns.Strutural_Patterns.Adapter;

public class Adapter : IAdapter
{
    BusinessLegacy legacy;
    BusinessNew newBussines;

    public Adapter(BusinessLegacy legacy)
    {
        this.legacy = legacy;
    }

    public Adapter(BusinessNew business)
    {
        this.newBussines = business;
    }

    public string ExecuteRotineBillsToPay(string month)
    {
        return legacy != null
            ? legacy.ExecuteRoutineBillsToPay(month)
            : newBussines.ExecuteRoutineBillsToPay(month);
    }

    public string ExecuteRotineBillsToRecieve(string month)
    {
        return legacy != null
            ? legacy.ExecuteRoutineBillsToRecieve(month)
            : newBussines.ExecuteRoutineBillsToRecieve(month);
    }
}