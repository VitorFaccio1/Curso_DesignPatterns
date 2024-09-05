
namespace DesignPatterns.Behavioral_Patterns.Mediator;

public class MediatorClient
{
    public void Menu()
    {
        bool continueMenu = true;

        while (continueMenu)
        {
            Console.Clear();

            var mediador = new MediadorConcreto();

            var atendente = new Atendente(mediador);
            var paciente = new Paciente(mediador);

            mediador.Atendente = atendente;
            mediador.Paciente = paciente;

            Console.WriteLine("Chat: ");
            paciente.EnviarMensagem("Por favor, Eu gostaria de agendar uma consulta.");
            atendente.EnviarMensagem("Sim, Por favor, qual especialidade?");

            paciente.EnviarMensagem("Clínico Geral");
            atendente.EnviarMensagem("Temos vagas para próxima terça nos horário:\n16:30hs\n16:45hs\n17:00hs\n");

            paciente.EnviarMensagem("Pode agendar terça às 16:45");
            atendente.EnviarMensagem("Agendamento concluído com sucesso!");

            paciente.EnviarMensagem("Obrigado...");
            atendente.EnviarMensagem("Nós que agradecemos!");

            Console.WriteLine(new String('-', 40));

            Console.WriteLine("\nDeseja entender o funcionamento do Mediator novamente?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            Console.Write("Digite sua escolha: ");
            continueMenu = Convert.ToInt32(Console.ReadLine()) == 1;
        }
    }
}