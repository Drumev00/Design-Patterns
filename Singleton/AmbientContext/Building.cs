using System.Text;

namespace AmbientContext
{
	internal class Building
	{
		public List<Wall> Walls { get; set; }

		public Building()
		{
			Walls = new List<Wall>();
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			foreach (var wall in Walls)
			{
				sb.AppendLine(wall.ToString());
			}

			return sb.ToString();
		}
	}
}
