using MethodChain;

var goblin = new Creature("Goblin", 2, 2);
Console.WriteLine(goblin);

var root = new CreatureModifier(goblin);
root.Add(new DoubleAttackModifier(goblin));
// root.Add(new NoBonusesModifier(goblin)); <- stopping the chain
root.Add(new IncreasedDefenseModifier(goblin));
root.Handle();
Console.WriteLine(goblin);
