namespace BrokerChain
{
	internal class IncreasedDefenseModifier : CreatureModifier
	{
		public IncreasedDefenseModifier(Game game, Creature creature) : base(game, creature)
		{
		}

		protected override void Handle(object sender, Query query)
		{
			if (query.CreatureName == creature.Name && query.WhatToQuery == Argument.Defense)
			{
				query.Value += 3;
			}
		}
	}
}
