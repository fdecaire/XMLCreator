using System.Collections.Generic;
using XMLCreator;
using XMLCreator.XMLTemplate;
using Xunit;

namespace XMLCreatorTests
{
    public class HouseBadUnitTests
    {
	    [Fact]
	    public void TestOneWallOneWindow()
	    {
		    var house = new XMLCreatorBad.House { Size = 2000 };
		    house.Walls.Add(new XMLCreatorBad.Wall
			{
			    Windows = new List<XMLCreatorBad.Window>()
		    });
		    house.Walls[0].Windows.Add(new XMLCreatorBad.Window
			{
			    Type = "square"
		    });

		    Assert.Equal(XmlResultCompare.ReadExpectedXml("XMLCreatorTests.TestData.XMLHouseOneWallOneWindow.xml"), house.Serialize().RemoveWhiteSpace());
	    }

	    [Fact]
	    public void TestOneWallNoWindow()
	    {
		    // one wall, no windows
		    var house = new XMLCreatorBad.House { Size = 2000 };
		    house.Walls.Add(new XMLCreatorBad.Wall());

		    Assert.Equal(XmlResultCompare.ReadExpectedXml("XMLCreatorTests.TestData.XMLHouseOneWallNoWindow.xml"), house.Serialize().RemoveWhiteSpace());
	    }

	    [Fact]
	    public void TestHouseWitRoof()
	    {
		    var house = new XMLCreatorBad.House { Size = 2000 };
		    house.Roofs.Add(new XMLCreatorBad.Roof
		    {
			    Type = "Shingle"
		    });

		    Assert.Equal(XmlResultCompare.ReadExpectedXml("XMLCreatorTests.TestData.XMLHouseWithRoof.xml"), house.Serialize().RemoveWhiteSpace());
	    }
	}
}
