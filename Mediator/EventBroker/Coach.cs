using System.Reactive.Linq;

namespace EventBroker
{
	internal class Coach : Actor
	{
		public Coach(EventBroker broker) : base(broker)
		{
			broker.OfType<PlayerScoredEvent>().Subscribe(pe =>
			{
				if (pe.GoalsScored < 3)
				{
					Console.WriteLine($"Coach: Well done, {pe.Name}!");
				}
			});

			broker.OfType<PlayerSentOffEvent>().Subscribe(pe =>
			{
				if (pe.Reason == "Violence")
				{
					Console.WriteLine($"Coach: How could you {pe.Name}?");
				}
			});
		}
	}
}
