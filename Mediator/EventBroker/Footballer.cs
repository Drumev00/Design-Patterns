using System.Reactive.Linq;

namespace EventBroker
{
	internal class Footballer : Actor
	{
		public string Name { get; set; }

		public int GoalsScored { get; set; }

		public Footballer(EventBroker broker, string name) : base(broker)
		{
			Name = name ?? throw new ArgumentNullException(nameof(name));

			broker.OfType<PlayerScoredEvent>()
				.Where(ps => !ps.Name.Equals(Name))
				.Subscribe(ps => Console.WriteLine($"{Name}: Nicely done, {ps.Name}! It's your {ps.GoalsScored} goal."));

			broker.OfType<PlayerSentOffEvent>()
				.Where(ps => !ps.Name.Equals(Name))
				.Subscribe(ps => Console.WriteLine($"{Name}: See you in the lockers, {ps.Name}."));
		}

		public void Score()
		{
			GoalsScored++;
			broker.Publish(new PlayerScoredEvent(this.Name, this.GoalsScored));
		}

		public void AssaultReferee()
		{
			broker.Publish(new PlayerSentOffEvent(this.Name, "Violence"));
		}
	}
}
