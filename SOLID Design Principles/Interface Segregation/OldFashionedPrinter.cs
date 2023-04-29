using Interface_Segregation.Abstractions;

namespace Interface_Segregation
{
	// Interface Segregation principle violated
	internal class OldFashionedPrinter : IMachine
	{
		// Unsupported
		public void Fax(Document document)
		{
			throw new NotImplementedException();
		}

		public void Print(Document document)
		{
			// Can print
		}

		// Unsupported
		public void Scan(Document document)
		{
			throw new NotImplementedException();
		}
	}
}
