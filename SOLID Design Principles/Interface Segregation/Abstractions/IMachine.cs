namespace Interface_Segregation.Abstractions
{
	// Interface is too general and needs separation
	internal interface IMachine
	{
		void Print(Document document);

		void Scan(Document document);

		void Fax(Document document);
	}
}
