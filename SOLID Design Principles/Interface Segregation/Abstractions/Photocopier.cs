namespace Interface_Segregation.Abstractions
{
	internal class Photocopier : IPrinter, IScanner
	{
		public void Print(Document document)
		{
			throw new NotImplementedException();
		}

		public void Scan(Document document)
		{
			throw new NotImplementedException();
		}
	}
}
