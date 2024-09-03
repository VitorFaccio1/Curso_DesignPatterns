using DesignPatterns.Behavioral_Patterns.Strategy.Enums;

namespace DesignPatterns.Behavioral_Patterns.Strategy.Interfaces;

public interface IPaymentStrategy
{
    PaymentType Type { get; }

    public bool Validate();
}