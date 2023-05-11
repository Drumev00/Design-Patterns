using PropertyProxy;

// if I don't have a backing field in Creature.cs

// creature.Agility = new Property<int>(10);
// creature.set_Agility(10) -> NO


var creature = new Creature();
creature.Agility = 10; 
creature.Agility = 10;

// now with a backing field assignment happens once
