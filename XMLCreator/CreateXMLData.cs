using System.Xml;
using System.Xml.Serialization;
using XMLCreator.XMLTemplate;

namespace XMLCreator
{
    public static class CreateXMLData
    {
	    public static string Serialize(this House house)
	    {
		    var xmlSerializer = new XmlSerializer(typeof(House));

		    var settings = new XmlWriterSettings
		    {
			    NewLineHandling = NewLineHandling.Entitize,
			    IndentChars = "\t",
			    Indent = true
		    };

		    using (var stringWriter = new Utf8StringWriter())
		    {
			    var writer = XmlWriter.Create(stringWriter, settings);
			    xmlSerializer.Serialize(writer, house);

			    return stringWriter.GetStringBuilder().ToString();
		    }
		}
    }
}
