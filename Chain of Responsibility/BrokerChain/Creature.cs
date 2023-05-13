namespace BrokerChain
{
	internal class Creature
	{
		private Game _game;
		private int _attack, _defense;

		public string Name { get; set; }


		public int Attack
		{
			get
			{
				var query = new Query(Name, Argument.Attack, _attack);
				_game.PerformQuery(this, query);
				return query.Value;
			}
		}
		public int Defense
		{
			get
			{
				var query = new Query(Name, Argument.Defense, _defense);
				_game.PerformQuery(this, query);
				return query.Value;
			}
		}

		public Creature(Game game, int attack, int defense, string name)
		{
			_game = game ?? throw new ArgumentNullException(nameof(game));
			_attack = attack;
			_defense = defense;
			Name = name ?? throw new ArgumentNullException(nameof(name));
		}


		public override string ToString()
		{
			return $"{nameof(Name)}: {Name}, {nameof(Attack)}: {Attack}, {nameof(Defense)}: {Defense}";
		}
	}
}
