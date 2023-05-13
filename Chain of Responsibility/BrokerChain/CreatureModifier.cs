namespace BrokerChain
{
	internal abstract class CreatureModifier : IDisposable
	{
		protected Game game;
		protected Creature creature;

		protected CreatureModifier(Game game, Creature creature)
		{
			this.game = game ?? throw new ArgumentNullException(nameof(game));
			this.creature = creature ?? throw new ArgumentNullException(nameof(creature));
			game.Queries += Handle;
		}

		protected abstract void Handle(object sender, Query query);

		public void Dispose()
		{
			game.Queries -= Handle;
		}
	}
}
