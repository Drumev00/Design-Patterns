using StaticStrategy.Abstractions;
using System.Text;

namespace StaticStrategy
{
	internal class MarkdownListStrategy : IListStrategy
	{
		public void AddListItem(StringBuilder sb, string item)
		{
			sb.AppendLine($" * {item}");
		}

		public void End(StringBuilder sb)
		{
		}

		public void Start(StringBuilder sb)
		{
		}
	}
}
