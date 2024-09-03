using DesignPatterns.Behavioral_Patterns.Strategy.Enums;
using DesignPatterns.Behavioral_Patterns.Strategy.Interfaces;

namespace DesignPatterns.Behavioral_Patterns.Strategy.Strategies;

public class PixStrategy : IPaymentStrategy
{
    public PaymentType Type => PaymentType.Pix;

    public bool Validate()
    {
        //regras de negocio para pix

        return true;
    }
}