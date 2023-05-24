using SwitchExpressions;

// C# 8 feature
static Chest Manipulate(Chest chest, SwitchExpressions.Action toPerform, bool haveKey) =>
	(chest, toPerform, haveKey) switch
	{
		(Chest.Locked, SwitchExpressions.Action.Open, true) => Chest.Opened,
		(Chest.Closed, SwitchExpressions.Action.Open, _) => Chest.Opened,
		(Chest.Opened, SwitchExpressions.Action.Close, true) => Chest.Locked,
		(Chest.Opened, SwitchExpressions.Action.Close, false) => Chest.Closed,
		_ => chest
	};

var chest = Chest.Locked;
Console.WriteLine($"Chest is {chest}");

chest = Manipulate(chest, SwitchExpressions.Action.Open, true);
Console.WriteLine($"Chest is {chest}");

chest = Manipulate(chest, SwitchExpressions.Action.Close, false);
Console.WriteLine($"Chest is {chest}");

chest = Manipulate(chest, SwitchExpressions.Action.Close, false);
Console.WriteLine($"Chest is {chest}");
