namespace SpecialInterfacesObserver
{
	internal class Person : IObservable<Event>
	{
		private readonly HashSet<Subscription> _subscriptions = new();

		public IDisposable Subscribe(IObserver<Event> observer)
		{
			var subscription = new Subscription(this, observer);
			_subscriptions.Add(subscription);
			return subscription;
		}

		public void FallIll()
		{
			foreach (var subscription in _subscriptions)
			{
				subscription.Observer.OnNext(new FallsIllEvent("123 London Road"));
			}
		}

		private class Subscription : IDisposable
		{
			private readonly Person _person;
			public readonly IObserver<Event> Observer;

			// monitoring person for events (person can be IObservable instead)
			public Subscription(Person person, IObserver<Event> observer)
			{
				_person = person;
				Observer = observer;
			}

			public void Dispose()
			{
				_person._subscriptions.Remove(this);
			}
		}
	}
}
