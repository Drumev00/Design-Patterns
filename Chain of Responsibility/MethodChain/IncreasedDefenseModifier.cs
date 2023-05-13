namespace MethodChain
{
	internal class IncreasedDefenseModifier : CreatureModifier
	{
		public IncreasedDefenseModifier(Creature creature) : base(creature)
		{
		}

		public override void Handle()
		{
			Console.WriteLine($"Increasing {creature.Name}'s defense");
			creature.Defense += 3;
			base.Handle();
		}
	}
}
