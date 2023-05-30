using System.Text;

namespace IntrusiveVisitor
{
	internal abstract class Expression
	{
		// visitor
		public abstract void Print(StringBuilder sb);
	}
}
