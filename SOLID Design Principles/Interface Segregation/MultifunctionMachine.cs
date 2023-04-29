using Interface_Segregation.Abstractions;

namespace Interface_Segregation
{
	internal class MultifunctionMachine : IMultifunctionDevice
	{
		private IPrinter _printer;
		private IScanner _scanner;

		public MultifunctionMachine(IPrinter printer, IScanner scanner)
		{
			if (printer == null)
			{
				throw new ArgumentNullException(nameof(printer));
			}
			if (scanner == null)
			{
				throw new ArgumentNullException(nameof(scanner));
			}
			_printer = printer;
			_scanner = scanner;
		}

		// Delegating the calls
		public void Print(Document document)
		{
			_printer.Print(document);
		}

		public void Scan(Document document)
		{
			_scanner.Scan(document);
		} // Decorator pattern
	}
}
