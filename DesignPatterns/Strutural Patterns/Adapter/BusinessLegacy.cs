﻿using DesignPatterns.Strutural_Patterns.Adapter.Mock;

namespace DesignPatterns.Strutural_Patterns.Adapter;

public class BusinessLegacy
{
    public string ExecuteRoutineBillsToPay(string month)
    {
        var result = AcessSQL.GetBillsToPay(month);

        return $"Nome: {result.Name} e valor: {result.Value}";
    }

    public string ExecuteRoutineBillsToRecieve(string month)
    {
        var result = AcessSQL.GetBillsToReceive(month);

        return $"Nome: {result.Name} e valor: {result.Value}";
    }
}