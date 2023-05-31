namespace AcyclicVisitor.Abstractions
{
	internal abstract class Expression
	{
		public virtual void Accept(IVisitor visitor)
		{
			if (visitor is IVisitor<Expression> typed)
			{
				typed.Visit(this);
			}
		}
	}
}
