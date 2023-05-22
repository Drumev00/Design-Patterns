namespace EventObserver
{
	internal class FallsIllEventArgs
	{
		public string Address { get; set; }

		public FallsIllEventArgs(string address)
		{
			Address = address;
		}
	}
}
