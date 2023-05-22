namespace SpecialInterfacesObserver
{
	internal class Friend : IObserver<Event>
	{
		// when no more events can be generated (lets say the person is dead - then he cannot fall ill)
		public void OnCompleted()
		{
			
		}

		// when an exception occurs
		public void OnError(Exception error)
		{
		}

		// when event is triggered - person falls ill in this case
		public void OnNext(Event value)
		{
			if (value is FallsIllEvent args)
			{
				Console.WriteLine($"A doctor is required at {args.Address}");
			}
		}
	}
}
