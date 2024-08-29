using DesignPatterns.Behavioral_Patterns.Observer.Interfaces;
using DesignPatterns.Behavioral_Patterns.Observer.Models;
using DesignPatterns.Behavioral_Patterns.Observer.Observers;
using DesignPatterns.Behavioral_Patterns.Observer.Subjects;

namespace DesignPatterns.Behavioral_Patterns.Observer;

public class ObserverClient
{
    public void EnviaEmail()
    {
        bool continueMenu = true;

        while (continueMenu)
        {
            Console.Clear();

            var msgNaoAssinante = $"Notamos que ainda nao faz parte da nossa assinatura!!";
            var msgAssinante = $"Lançamentos direto do cinema para sua tela!!";

            List<IObservavel> observaveis = new List<IObservavel>()
            {
                new NaoAssinante(new Pessoa(01, "Vitor Faccio", "vitorfaccio6@gmail.com"), msgNaoAssinante),
                new Assinante(new Pessoa(01, "Vitor Ravenna", "vitorravenna6@gmail.com"), msgAssinante)
            };

            PrimeVideo primeVideo = new(observaveis);

            primeVideo.NotificaObservavel();
            Console.WriteLine("\nDeseja entender o funcionamento do Observer novamente?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            Console.Write("Digite sua escolha: ");
            continueMenu = Convert.ToInt32(Console.ReadLine()) == 1;
        }
    }
}