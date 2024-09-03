using DesignPatterns.Behavioral_Patterns.Strategy.Enums;
using DesignPatterns.Behavioral_Patterns.Strategy.Interfaces;

namespace DesignPatterns.Behavioral_Patterns.Strategy.Strategies;

public class CreditCardStrategy : IPaymentStrategy
{
    public PaymentType Type => PaymentType.CreditCard;

    public bool Validate()
    {
        //regras de negocio para cartão

        return true;
    }
}