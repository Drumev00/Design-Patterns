using CommandPattern;
using Action = CommandPattern.Action;

var account = new BankAccount();
var commands = new List<BankAccountCommand>
{
	new BankAccountCommand(account, Action.Deposit, 100),
	new BankAccountCommand(account, Action.Withdraw, 50),
};

foreach (var command in commands)
{
	command.Call();
}
Console.WriteLine(account);
