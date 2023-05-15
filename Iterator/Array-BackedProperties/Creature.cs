using System.Collections;

namespace Array_BackedProperties
{
	// i want to iterate over all properties and calculate average statistics
	internal class Creature : IEnumerable<int>
	{
		private int[] stats = new int[3];
		private const int _strength = 0;
		// 1..2...

		public int Strength
		{
			get
			{
				return stats[_strength];
			}
			set
			{
				stats[_strength] = value;
			}
		}

		public int Agility { get; set; }
		public int Intelligence { get; set; }

		public double AverageStat => stats.Average();
		public IEnumerator<int> GetEnumerator()
		{
			return stats.AsEnumerable().GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public int this[int index]
		{
			get => stats[index];
			set => stats[index] = value;
		}
	}
}
