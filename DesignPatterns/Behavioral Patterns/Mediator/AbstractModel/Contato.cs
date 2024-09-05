namespace DesignPatterns.Behavioral_Patterns.Mediator.AbstractModel;

public abstract class Contato
{
    protected Mediador Mediador;

    protected Contato(Mediador mediador)
    {
        Mediador = mediador;
    }
}