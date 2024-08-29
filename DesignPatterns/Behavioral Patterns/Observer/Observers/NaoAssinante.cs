using DesignPatterns.Behavioral_Patterns.Observer.Interfaces;
using DesignPatterns.Behavioral_Patterns.Observer.Models;

namespace DesignPatterns.Behavioral_Patterns.Observer.Observers;

public class NaoAssinante : IObservavel
{
    public NaoAssinante(Pessoa pessoa, string mensagem)
    {
        Pessoa = pessoa;
        Mensagem = mensagem;
    }

    public Pessoa Pessoa { get; set; }

    public string Mensagem { get; set; }

    public void Update()
    {
        //Simular envio de email para assinante

        Console.WriteLine($"Enviando email para: {Pessoa.Email}\nPrezado {Pessoa.Nome}\n{Mensagem}");
    }
}