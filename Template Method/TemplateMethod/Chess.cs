namespace TemplateMethod
{
	internal class Chess : Game
	{
		private int _turn = 1;
		private int _maxTurns = 10;

		public Chess() : base(2)
		{
		}

		protected override bool HaveWinner => _turn == _maxTurns;

		protected override int WinningPlayer => currentPlayer;

		protected override void Start()
		{
			Console.WriteLine($"Starting a game of chess with {numberOfPlayers} players.");
		}

		protected override void TakeTurn()
		{
			Console.WriteLine($"Turn {_turn++} taken by player {currentPlayer}.");
			currentPlayer = (currentPlayer + 1) % numberOfPlayers;
		}
	}
}
