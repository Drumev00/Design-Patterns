namespace UndoAndRedo
{
	internal class Memento
	{
		public int Balance { get; }

		public Memento(int balance)
		{
			Balance = balance;
		}
	}
}
