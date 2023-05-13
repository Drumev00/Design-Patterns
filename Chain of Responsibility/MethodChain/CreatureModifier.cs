namespace MethodChain
{
	internal class CreatureModifier
	{
		protected Creature creature;
		protected CreatureModifier next;

		public CreatureModifier(Creature creature)
		{
			this.creature = creature ?? throw new ArgumentNullException(nameof(creature));
		}

		public void Add(CreatureModifier modifier)
		{
			if (next != null)
			{
				next.Add(modifier);
			}
			else
			{
				next = modifier;
			}
		}

		public virtual void Handle() => next?.Handle();
	}
}
