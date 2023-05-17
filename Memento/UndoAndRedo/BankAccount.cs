namespace UndoAndRedo
{
	internal class BankAccount
	{
		private int _balance;
		private List<Memento> _changes;
		private int _current;

		public BankAccount(int balance)
		{
			_balance = balance;
			_changes = new List<Memento>
			{
				new Memento(_balance)
			};
		}

		public Memento Deposit(int amount)
		{
			_balance += amount;
			var memento =  new Memento(_balance);
			_changes.Add(memento);
			++_current;
			return memento;
		}

		public Memento Restore(Memento memento)
		{
			if (memento != null)
			{
				_balance = memento.Balance;
				_changes.Add(memento);
				return memento;
			}

			return null;
		}

		public Memento Undo()
		{
			if (_current > 0)
			{
				var memento = _changes[--_current];
				_balance = memento.Balance;
				return memento;
			}

			return null;
		}

		public Memento Redo()
		{
			if (_current + 1 < _changes.Count)
			{
				var memento = _changes[++_current];
				_balance = memento.Balance;
				return memento;
			}

			return null;
		}

		public override string ToString()
		{
			return $"{nameof(_balance)}: {_balance}";
		}
	}
}
