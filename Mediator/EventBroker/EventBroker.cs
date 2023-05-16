using System.Reactive.Subjects;

namespace EventBroker
{
	internal class EventBroker : IObservable<PlayerEvent>
	{
		private Subject<PlayerEvent> _subscriptions = new();

		public IDisposable Subscribe(IObserver<PlayerEvent> observer)
		{
			return _subscriptions.Subscribe(observer);
		}


		public void Publish(PlayerEvent pe)
		{
			_subscriptions.OnNext(pe);
		}
	}
}
