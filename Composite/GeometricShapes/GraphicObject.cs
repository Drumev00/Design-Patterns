using System.Text;

namespace GeometricShapes
{
	internal class GraphicObject
	{
		private Lazy<List<GraphicObject>> _children = new Lazy<List<GraphicObject>>();

		public List<GraphicObject> Children => _children.Value;

		public string Color { get; set; }

		public virtual string Name { get; set; } = "Group";

		// because we are building composite tree of objects
		private void Print(StringBuilder sb, int depth)
		{
			sb.Append(new string('*', depth))
				.Append(string.IsNullOrWhiteSpace(Color) ? string.Empty : $"{Color} ")
				.AppendLine(Name);

			foreach (var child in _children.Value)
			{
				child.Print(sb, depth + 1);
			}
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			Print(sb, 0);
			return sb.ToString();
		}

	}
}
