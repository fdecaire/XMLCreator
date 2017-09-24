using System.Collections.Generic;
using System.Xml.Serialization;

namespace XMLCreator.XMLTemplate
{
    public class House
    {
	    [XmlElement(ElementName = "wall")]
		public List<Wall> Walls = new List<Wall>();

	    [XmlElement(ElementName = "roof")]
		public List<Roof> Roofs = new List<Roof>();

	    [XmlElement(ElementName = "size")]
		public int Size { get; set; }
    }
}
