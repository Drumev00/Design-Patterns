using StaticStrategy.Abstractions;
using System.Text;

namespace StaticStrategy
{
	internal class TextProcessor<LS> where LS : IListStrategy, new()
	{
		private readonly StringBuilder _sb = new();
		private IListStrategy _listStrategy = new LS();


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
