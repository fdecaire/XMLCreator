using System.Collections.Generic;
using XMLCreator;
using XMLCreator.XMLTemplate;
using Xunit;

namespace XMLCreatorTests
{
    public class HouseUnitTests
    {
        [Fact]
        public void TestOneWallOneWindow()
        {
			var house = new House { Size = 2000 };
	        house.Walls.Add(new Wall
	        {
		        Windows = new List<Window>()
	        });
			house.Walls[0].Windows.Add(new Window
			{
				Type = "square"
			});

	        Assert.Equal(XmlResultCompare.ReadExpectedXml("XMLCreatorTests.TestData.XMLHouseOneWallOneWindow.xml"), house.Serialize().RemoveWhiteSpace());
		}

	    [Fact]
	    public void TestOneWallNoWindow()
	    {
			// one wall, no windows
		    var house = new House { Size = 2000 };
		    house.Walls.Add(new Wall());

		    Assert.Equal(XmlResultCompare.ReadExpectedXml("XMLCreatorTests.TestData.XMLHouseOneWallNoWindow.xml"), house.Serialize().RemoveWhiteSpace());
		}

	    [Fact]
	    public void TestHouseWitRoof()
	    {
			var house = new House { Size = 2000 };
			house.Roofs.Add(new Roof
			{
				Type = "Shingle"
			});

			Assert.Equal(XmlResultCompare.ReadExpectedXml("XMLCreatorTests.TestData.XMLHouseWithRoof.xml"), house.Serialize().RemoveWhiteSpace());
		}
    }
}
