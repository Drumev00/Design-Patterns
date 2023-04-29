using Interface_Segregation.Abstractions;

namespace Interface_Segregation
{
	// No problem with using this interface
	internal class ModernPrinter : IMachine
	{
		public void Fax(Document document)
		{
			// Can fax
		}

		public void Print(Document document)
		{
			// Can print
		}

		public void Scan(Document document)
		{
			// Can scan
		}
	}
}
