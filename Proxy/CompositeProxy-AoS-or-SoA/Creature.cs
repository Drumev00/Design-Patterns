namespace CompositeProxy_AoS_or_SoA
{
	internal class Creature
	{
		public byte Age { get; set; }

		public int X, Y;

		internal class Creatures
		{
			private readonly int _size;
			private byte[] _ages;
			private int[] _x, _y;

			public Creatures(int size)
			{
				_size = size;
				_ages = new byte[size];
				_x = new int[size];
				_y = new int[size];
			}


			internal struct CreatureProxy
			{
				private readonly Creatures _creatures;

				// can be exposed as public
				private readonly int _index;

				public CreatureProxy(Creatures creatures, int index)
				{
					_creatures = creatures;
					_index = index;
				}

				// reference to age of particular creature
				public ref byte Age => ref _creatures._ages[_index];
				public ref int X => ref _creatures._x[_index];
				public ref int Y => ref _creatures._y[_index];

			}
			public IEnumerator<CreatureProxy> GetEnumerator()
			{
				for (int pos = 0; pos < _size; ++pos)
				{
					yield return new CreatureProxy(this, pos);
				}
			}
		}
	}
}
