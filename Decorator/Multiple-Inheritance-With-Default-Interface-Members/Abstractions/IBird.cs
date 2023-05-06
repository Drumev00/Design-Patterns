namespace Multiple_Inheritance_With_Default_Interface_Members.Abstractions
{
	internal interface IBird : ICreature
	{
		void Fly()
		{
			if (Age >= 10)
			{
				Console.WriteLine("I am flying.");
			}
		}
	}
}
