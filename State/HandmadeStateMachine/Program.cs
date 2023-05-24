using HandmadeStateMachine;

Dictionary<State, List<(Trigger, State)>> rules = new()
{
	[State.OffHook] = new List<(Trigger, State)>()
	{
		(Trigger.CallDialed, State.Connecting)
	},

	[State.Connecting] = new List<(Trigger, State)>()
	{
		(Trigger.HungUp, State.OffHook),
		(Trigger.CallConnected, State.Connected)
	},
	[State.Connected] = new List<(Trigger, State)>()
	{
		(Trigger.LeftMessage, State.OffHook),
		(Trigger.HungUp, State.OffHook),
		(Trigger.PlacedOnHold, State.OnHold)
	},
	[State.OnHold] = new List<(Trigger, State)>()
	{
		(Trigger.TakenOffHold, State.Connected),
		(Trigger.HungUp, State.OffHook)
	}
};

var state = State.OffHook;
while (true)
{
	Console.WriteLine($"The phone is currently {state}");
	Console.WriteLine("Select a trigger:");

	for (var i = 0; i < rules[state].Count; i++)
	{
		var (t, _) = rules[state][i];
		Console.WriteLine($"{i}. {t}");
	}

	int input = int.Parse(Console.ReadLine());
	var (_, s) = rules[state][input];
	state = s;
}
