namespace EventBroker
{
	internal class PlayerSentOffEvent : PlayerEvent
	{
		public string Reason { get; set; }

		public PlayerSentOffEvent(string playerName, string reason)
		{
			Name = playerName;
			Reason = reason;
		}
	}
}
