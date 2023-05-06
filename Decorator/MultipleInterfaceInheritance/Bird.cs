using MultipleInterfaceInheritance.Abstractions;

namespace MultipleInterfaceInheritance
{
    internal class Bird : IBird
	{
		public int Weight { get; set; }

		public void Fly()
		{
			Console.WriteLine($"Soaring in the sky with weight: {Weight}.");
		}
	}
}
