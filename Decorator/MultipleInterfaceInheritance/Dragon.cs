using MultipleInterfaceInheritance.Abstractions;

namespace MultipleInterfaceInheritance
{
	internal class Dragon : IBird, ILizard
	{
		private readonly Bird _bird = new();
		private readonly Lizard _lizard = new();
		private int _weight;

		public int Weight
		{
			get => _weight;
			set
			{
				// necessary if we want proper setter
				_weight = value;
				_bird.Weight = value;
				_lizard.Weight = value;
			} 
		}

		public void Fly()
		{
			_bird.Fly();
		}

		public void Crawl()
		{
			_lizard.Crawl();
		}
	}
}
