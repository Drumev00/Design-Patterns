namespace EventObserver
{
	internal class Person
	{
		// informs everyone interested in listening to this event
		public event EventHandler<FallsIllEventArgs> FallsIll;

		// If the event needs args - I create a new class specifying them, and change event signature
		public void CatchCold()
		{
			// '?' in case there are no subscribers to this event
			FallsIll?.Invoke(this, new FallsIllEventArgs("123 London Road"));
		}
	}
}
