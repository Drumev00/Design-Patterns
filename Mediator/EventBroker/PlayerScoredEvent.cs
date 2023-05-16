namespace EventBroker
{
	internal class PlayerScoredEvent : PlayerEvent
	{
		public PlayerScoredEvent(string playerName, int goals)
		{
			Name = playerName;
			GoalsScored = goals;
		}

		public int GoalsScored { get; set; }
	}
}
