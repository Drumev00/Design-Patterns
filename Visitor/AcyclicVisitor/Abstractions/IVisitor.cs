namespace AcyclicVisitor.Abstractions
{
	internal interface IVisitor<TVisitable>
	{
		void Visit(TVisitable visitable);
	}

	internal interface IVisitor { }
}
