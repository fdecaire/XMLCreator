using System;
using System.Collections.Generic;
using System.Text;

namespace XMLCreatorBad
{
	public class House
	{
		public List<Wall> Walls = new List<Wall>();

		public List<Roof> Roofs = new List<Roof>();

		public int Size { get; set; }

		public string Serialize()
		{
			var @out = new StringBuilder();

			@out.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
			@out.Append("<House xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">");

			foreach (var wall in Walls)
			{
				wall.Serialize(ref @out);
			}

			foreach (var roof in Roofs)
			{
				roof.Serialize(ref @out);
			}

			@out.Append("<size>");
			@out.Append(Size);
			@out.Append("</size>");

			@out.Append("</House>");

			return @out.ToString();
		}
	}

	public class Wall
	{
		public List<Window> Windows { get; set; }

		public void Serialize(ref StringBuilder @out)
		{
			if (Windows == null || Windows.Count == 0)
			{
				@out.Append("<wall />");
				return;
			}

			@out.Append("<wall>");
			foreach (var window in Windows)
			{
				window.Serialize(ref @out);
			}
			@out.Append("</wall>");
		}
	}

	public class Window
	{
		public string Type { get; set; }

		public void Serialize(ref StringBuilder @out)
		{
			@out.Append("<window>");
			@out.Append("<Type>");
			@out.Append(Type);
			@out.Append("</Type>");
			@out.Append("</window>");
		}
	}

	public class Roof
	{
		public string Type { get; set; }

		public void Serialize(ref StringBuilder @out)
		{
			@out.Append("<roof>");
			@out.Append("<Type>");
			@out.Append(Type);
			@out.Append("</Type>");
			@out.Append("</roof>");
		}
	}


}
