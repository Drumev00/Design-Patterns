using BrokerChain;

var game = new Game();
var goblin = new Creature(game, 3, 3, "Strong Goblin");
Console.WriteLine(goblin);

using (new DoubleAttackModifier(game, goblin))
{
	Console.WriteLine(goblin);
	using (new IncreasedDefenseModifier(game, goblin))
	{
		Console.WriteLine(goblin);
	}
}
Console.WriteLine(goblin);
