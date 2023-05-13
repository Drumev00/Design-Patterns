using CommandPattern.Abstractions;

namespace CommandPattern
{
	internal class BankAccountCommand : ICommand
	{
		private BankAccount _account;
		private Action _action;
		private int _amount;

		public BankAccountCommand(BankAccount account, Action action, int amount)
		{
			_account = account ?? throw new ArgumentNullException(nameof(account));
			_action = action;
			_amount = amount;
		}

		public void Call()
		{
			switch (_action)
			{
				case Action.Withdraw:
					_account.Withdraw(_amount);
					break;
				case Action.Deposit:
					_account.Deposit(_amount);
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}
		}
	}
}
