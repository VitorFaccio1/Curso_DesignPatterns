using DesignPatterns.Behavioral_Patterns.Observer.Interfaces;

namespace DesignPatterns.Behavioral_Patterns.Observer.Subjects;

public class PrimeVideo : ISujeito
{
    public PrimeVideo(List<IObservavel> observavels)
    {
        Observaveis = observavels;
    }

    public List<IObservavel> Observaveis { get; set; }

    public void AddObservavel(IObservavel observavel)
    {
        Observaveis.Add(observavel);
    }

    public void RemoveObservavel(IObservavel observavel)
    {
        Observaveis.Remove(observavel);
    }

    public void NotificaObservavel()
    {
        foreach (var observavel1 in Observaveis)
        {
            observavel1.Update();

            Console.WriteLine(new String('-', 40));
        }
    }
}