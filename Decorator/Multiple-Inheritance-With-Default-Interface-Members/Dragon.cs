using Multiple_Inheritance_With_Default_Interface_Members.Abstractions;

namespace Multiple_Inheritance_With_Default_Interface_Members
{
	// inherit Organism so we can't inherit more classes
	internal class Dragon : Organism, IBird, ILizard
	{
		public int Age { get; set; }


	}
}
