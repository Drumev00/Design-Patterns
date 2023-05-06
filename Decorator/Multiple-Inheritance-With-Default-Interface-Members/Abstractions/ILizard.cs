namespace Multiple_Inheritance_With_Default_Interface_Members.Abstractions
{
	internal interface ILizard : ICreature
	{
		void Crawl()
		{
			if (Age < 10)
			{
				Console.WriteLine("I am crawling.");
			}
		}
	}
}
