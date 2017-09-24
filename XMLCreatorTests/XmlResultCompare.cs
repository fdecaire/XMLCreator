using System.IO;
using System.Reflection;

namespace XMLCreatorTests
{
    public static class XmlResultCompare
    {
	    public static string ReadExpectedXml(string expectedDataFile)
	    {
		    var assembly = Assembly.GetExecutingAssembly();
		    using (var stream = assembly.GetManifestResourceStream(expectedDataFile))
		    {
			    using (var reader = new StreamReader(stream))
			    {
				    return reader.ReadToEnd().RemoveWhiteSpace();
			    }
		    }
	    }

	    public static string RemoveWhiteSpace(this string s)
	    {
		    s = s.Replace("\t", "");
		    s = s.Replace("\r", "");
		    s = s.Replace("\n", "");
			return s;
	    }
    }
}
