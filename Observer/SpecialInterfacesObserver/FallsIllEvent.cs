namespace SpecialInterfacesObserver
{
	internal class FallsIllEvent : Event
	{
		public string Address { get; set; }

		public FallsIllEvent(string address)
		{
			Address = address;
		}
	}
}
