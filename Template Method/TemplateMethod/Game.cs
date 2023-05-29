namespace TemplateMethod
{
	internal abstract class Game
	{
		protected int currentPlayer;
		protected readonly int numberOfPlayers;
		protected abstract bool HaveWinner { get; }
		protected abstract int WinningPlayer { get; }

		public Game(int numberOfPlayers)
		{
			this.numberOfPlayers = numberOfPlayers;
		}

		// template method
		public void Run()
		{
			Start();
			while (!HaveWinner)
			{
				TakeTurn();
			}
			Console.WriteLine($"Player {WinningPlayer} wins.");
		}

		protected abstract void Start();
		protected abstract void TakeTurn();

	}
}
