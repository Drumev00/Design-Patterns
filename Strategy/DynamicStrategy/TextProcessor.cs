using DynamicStrategy.Abstractions;
using System.Text;

namespace DynamicStrategy
{
	internal class TextProcessor
	{
		private readonly StringBuilder _sb = new();
		private IListStrategy _listStrategy;

		public void SetOutputFormat(OutputFormat format)
		{
			switch (format)
			{
				case OutputFormat.Markdown:
					_listStrategy = new MarkdownListStrategy();
					break;
				case OutputFormat.Html:
					_listStrategy = new HtmlListStrategy();
					break;
				default: 
					throw new ArgumentOutOfRangeException(nameof(format));
			}
		}

		public void AppendList(IEnumerable<string> items) 
		{
			_listStrategy.Start(_sb);
			foreach (var item in items)
			{
				_listStrategy.AddListItem(_sb, item);
			}
			_listStrategy.End(_sb);
		}

		public override string ToString()
		{
			return _sb.ToString();
		}

		public StringBuilder Clear()
		{
			return _sb.Clear();
		}
	}
}
