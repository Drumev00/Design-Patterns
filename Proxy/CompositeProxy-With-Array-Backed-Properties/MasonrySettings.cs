﻿namespace CompositeProxy_With_Array_Backed_Properties
{
	internal class MasonrySettings
	{
		// without array-backed property

		//public bool Pillars, Walls, Floors;

		//// composite-proxy property
		//public bool? All
		//{
		//	get
		//	{
		//		if (Pillars == Walls && Walls == Floors)
		//		{
		//			return Pillars;
		//		}

		//		return null;
		//	}
		//	set
		//	{
		//		if (!value.HasValue) return;

		//		Pillars = value.Value;
		//		Walls = value.Value;
		//		Floors = value.Value;
		//	}
		//}


		// with array-backed property
		private readonly bool[] _flags = new bool[3];

		public bool Pillars
		{
			get => _flags[0];
			set => _flags[0] = value;
		}
		public bool Walls
		{
			get => _flags[1];
			set => _flags[1] = value;
		}
		public bool Floors
		{
			get => _flags[2];
			set => _flags[2] = value;
		}

		public bool? All
		{
			get
			{
				if (_flags.Skip(1).All(f => f == _flags[0]))
				{
					return _flags[0];
				}

				return null;
			}
			set
			{
				if (!value.HasValue) return;

				for (int i = 0; i < _flags.Length; i++)
				{
					_flags[i] = value.Value;
				}
			}
		}
	}
}
