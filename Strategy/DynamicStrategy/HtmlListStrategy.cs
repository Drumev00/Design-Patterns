using DynamicStrategy.Abstractions;
using System.Text;

namespace DynamicStrategy
{
	internal class HtmlListStrategy : IListStrategy
	{
		public void AddListItem(StringBuilder sb, string item)
		{
			sb.AppendLine($"  <li>{item}</li>");
		}

		public void End(StringBuilder sb)
		{
			sb.AppendLine("</ul>");
		}

		public void Start(StringBuilder sb)
		{
			sb.AppendLine("<ul>");
		}
	}
}
