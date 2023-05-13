namespace MethodChain
{
	internal class Creature
	{
		public string Name { get; set; }

		public int Attack { get; set; }

		public int Defense { get; set; }

		public Creature(string name, int attack, int defense)
		{
			Name = name ?? throw new ArgumentNullException(nameof(name));
			Attack = attack;
			Defense = defense;
		}

		public override string ToString()
		{
			return $"{nameof(Name)}: {Name}, {nameof(Attack)}: {Attack}, {nameof(Defense)}: {Defense}";
		}
	}
}
