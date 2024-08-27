namespace DesignPatterns.Behavioral_Patterns.Template_Method;

public class TemplateMethodClient
{
    public void Menu()
    {
        bool continueMenu = true;

        while (continueMenu)
        {
            Console.Clear();

            Console.WriteLine("Como deseja pegar dados?\n1)XML\n2)JSON\n3)Sair");
            var option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ConsumeEndpointXML();
                    break;
                case 2:
                    ConsumeEndpointJSON();
                    break;
                case 3:
                    Console.WriteLine("Saindo....");
                    break;
                default:
                    Console.WriteLine("Insira uma opção valida!!!");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para prosseguir!!");
            Console.ReadKey();
            continueMenu = option != 3;
        }
    }

    private void ConsumeEndpointXML()
    {
        Console.WriteLine("\n_________________XML_________________");

        var xml = GetDataApi.EndpointXML();

        ConvertXML convertXML = new ConvertXML(xml);

        convertXML.ProcessXML();
    }

    private void ConsumeEndpointJSON()
    {
        Console.WriteLine("\n_________________JSON_________________");

        var json = GetDataApi.EndpointJSON();

        ConvertJSON convertJSON = new ConvertJSON(json);

        convertJSON.ProcessJSON();
    }
}