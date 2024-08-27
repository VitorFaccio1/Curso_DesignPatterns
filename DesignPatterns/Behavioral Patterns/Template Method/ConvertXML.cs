using DesignPatterns.Behavioral_Patterns.Template_Method.Model;
using System.Xml;
using System.Xml.Serialization;

namespace DesignPatterns.Behavioral_Patterns.Template_Method;

public class ConvertXML : ProcessData
{
    public ConvertXML(string xml) : base(xml: xml)
    {
    }

    public override void ProcessXML()
    {
        XmlSerializer xmlSerializer = new XmlSerializer(this.people.GetType());

        var stringReader = new StringReader(xml);

        using (var reader = XmlReader.Create(stringReader))
        {
            this.people = (List<Person>)xmlSerializer.Deserialize(reader);
        }

        this.ShowValues();
    }
}