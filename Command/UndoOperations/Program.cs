using UndoOperations;
using Action = UndoOperations.Action;

var account = new BankAccount();
var commands = new List<BankAccountCommand>
{
	new BankAccountCommand(account, Action.Deposit, 100),
	new BankAccountCommand(account, Action.Withdraw, 1000),
};

foreach (var command in commands)
{
	command.Call();
}
Console.WriteLine(account);


foreach (var command in Enumerable.Reverse(commands))
{
	command.Undo();
}

Console.WriteLine(account);
