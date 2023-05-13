namespace MethodChain
{
	// for stopping the chain of responsibility
	internal class NoBonusesModifier : CreatureModifier
	{
		public NoBonusesModifier(Creature creature) : base(creature)
		{
		}

		// base.Handle is not called so the chain is stopped
		public override void Handle()
		{
			
		}
	}
}
