using System.Text;

namespace HtmlBuilder
{
	internal class HtmlElement
	{
		private const int indentSize = 2;

		public string Name { get; set; } = null!;

		public string Text { get; set; } = null!;

		public List<HtmlElement> Children { get; set; }

		public HtmlElement()
		{
			Children = new List<HtmlElement>();
		}

		public HtmlElement(string name, string text)
		{
			Name = name ?? throw new ArgumentNullException(nameof(name));
			Text = text ?? throw new ArgumentNullException(nameof(text));

			Children = new List<HtmlElement>();
		}

		private string ToStringImpl(int indent)
		{
			var sb = new StringBuilder();
			var i = new string(' ', indentSize * indent);
			sb.AppendLine($"{i}<{Name}>");

			if (!string.IsNullOrWhiteSpace(Text))
			{
				sb.Append(new string(' ', indentSize * indent + 1));
				sb.AppendLine(Text);
			}

			foreach (var element in Children)
			{
				sb.Append(element.ToStringImpl(indent + 1));
			}
			sb.AppendLine($"{i}</{Name}>");

			return sb.ToString();
		}

		public override string ToString()
		{
			return ToStringImpl(0);
		}
	}
}
