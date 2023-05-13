namespace BrokerChain
{
	internal class DoubleAttackModifier : CreatureModifier
	{
		public DoubleAttackModifier(Game game, Creature creature) : base(game, creature)
		{
		}

		protected override void Handle(object sender, Query query)
		{
			if (query.CreatureName == creature.Name && query.WhatToQuery == Argument.Attack)
			{
				query.Value *= 2;
			}
		}
	}
}
