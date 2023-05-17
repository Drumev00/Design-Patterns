using NullObjectExample.Abstractions;

namespace NullObjectExample
{
	internal class BankAccount
	{
		private ILog _log;
		private int _balance;

		public BankAccount(ILog log)
		{
			_log = log ?? throw new ArgumentNullException(nameof(log));
		}

		public void Deposit(int amount)
		{
			_balance += amount;
			_log.Info($"Deposited {amount}$, balance is now {_balance}");
		}
	}
}
