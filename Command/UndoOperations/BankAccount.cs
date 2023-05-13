namespace UndoOperations
{
	internal class BankAccount
	{
		private int _balance;
		private int _overDraftLimit = -500;

		public void Deposit(int amount)
		{
			_balance += amount;
			Console.WriteLine($"Deposited: {amount}$, balance is now: {_balance}");
		}

		public bool Withdraw(int amount)
		{
			if (_balance - amount >= _overDraftLimit)
			{
				_balance -= amount;
				Console.WriteLine($"Withdrew {amount}$, balance is now: {_balance}");
				return true;
			}

			return false;
		}

		public override string ToString()
		{
			return $"{nameof(_balance)}: {_balance}";
		}
	}
}
