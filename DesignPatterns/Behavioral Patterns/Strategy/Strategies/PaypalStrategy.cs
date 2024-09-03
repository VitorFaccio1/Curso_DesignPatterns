using DesignPatterns.Behavioral_Patterns.Strategy.Enums;
using DesignPatterns.Behavioral_Patterns.Strategy.Interfaces;

namespace DesignPatterns.Behavioral_Patterns.Strategy.Strategies;

public class PaypalStrategy : IPaymentStrategy
{
    public PaymentType Type => PaymentType.Paypal;

    public bool Validate()
    {
        //regras de negocio para paypal

        return true;
    }
}