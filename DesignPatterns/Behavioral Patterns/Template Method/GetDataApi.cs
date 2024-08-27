using DesignPatterns.Behavioral_Patterns.Template_Method.Model;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace DesignPatterns.Behavioral_Patterns.Template_Method;

public class GetDataApi
{
    public static string EndpointXML()
    {
        var people = GetPeople();

        XmlSerializer serializer = new(people.GetType());

        var xml = string.Empty;

        using (var sw = new StringWriter())
        {
            serializer.Serialize(sw, people);
            xml = sw.ToString();
        }

        return xml;
    }

    public static string EndpointJSON()
    {
        var people = GetPeople();

        return JsonConvert.SerializeObject(people);
    }

    private static List<Person> GetPeople()
    {
        return new List<Person>()
        {
            new Person()
            {
                Name = "Vitor",
                Cpf = "123.456.789-10",
                Actions = new List<Model.Action>()
                {
                    new Model.Action("WEG3", 50, 15.99),
                    new Model.Action("IRBR4", 50, 5.99)
                }
            },
            new Person()
            {
                Name = "Ravenna",
                Cpf = "123.456.789-01",
                Actions = new List<Model.Action>()
                {
                    new Model.Action("OIBR3", 100, 0.99),
                    new Model.Action("BSB4", 50, 10.99)
                }
            }
        };
    }
}