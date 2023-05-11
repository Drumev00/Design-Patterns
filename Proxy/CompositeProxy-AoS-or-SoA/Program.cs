using CompositeProxy_AoS_or_SoA;
using static CompositeProxy_AoS_or_SoA.Creature;

// AoS
var creatures = new Creature[100];
foreach (var creature in creatures)
{
	creature.X++;
}

// SoA
Creatures creatures2 = new Creatures(100);
foreach (Creatures.CreatureProxy creature in creatures2)
{
	creature.X++;
}

