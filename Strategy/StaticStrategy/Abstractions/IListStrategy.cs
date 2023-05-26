using System.Text;

namespace StaticStrategy.Abstractions
{
	internal interface IListStrategy
	{
		void Start(StringBuilder sb);
		void End(StringBuilder sb);

		void AddListItem(StringBuilder sb, string item);
	}
}
