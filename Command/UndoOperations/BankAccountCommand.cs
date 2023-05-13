using UndoOperations.Abstractions;

namespace UndoOperations
{
	internal class BankAccountCommand : ICommand
	{
		private BankAccount _account;
		private Action _action;
		private int _amount;
		private bool _succeeded;

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
					_succeeded = _account.Withdraw(_amount);
					break;
				case Action.Deposit:
					_account.Deposit(_amount);
					_succeeded = true;
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}
		}

		public void Undo()
		{
			if (!_succeeded) return;
			switch (_action)
			{
				case Action.Withdraw:
					_account.Deposit(_amount);
					break;
				case Action.Deposit:
					_account.Withdraw(_amount);
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}
		}
	}
}
