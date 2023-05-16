namespace EventBroker
{
	internal class Actor
	{
		protected EventBroker broker;

		public Actor(EventBroker broker)
		{
			this.broker = broker ?? throw new ArgumentNullException(nameof(broker));
		}
	}
}
