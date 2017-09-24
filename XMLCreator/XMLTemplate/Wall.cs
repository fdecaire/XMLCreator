using System.Collections.Generic;
using System.Xml.Serialization;

namespace XMLCreator.XMLTemplate
{
    public class Wall
    {
	    [XmlElement(ElementName = "window")]
		public List<Window> Windows { get; set; }

	    public bool ShouldSerializenullable()
	    {
		    return Windows == null;
	    }
	}
}
