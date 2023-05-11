namespace PropertyProxy
{
	internal class Creature
	{
		// replaces mutating behavior

		//public Property<int> Agility { get; set; }

		private Property<int> _agility = new();

		public int Agility
		{
			get => _agility.Value;
			set => _agility.Value = value;
		}

	}
}
