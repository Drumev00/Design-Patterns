using DynamicStrategy.Abstractions;
using System.Text;

namespace DynamicStrategy
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
