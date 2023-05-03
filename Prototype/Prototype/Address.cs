namespace Prototype
{
	public class Address
	{
		public string StreetName { get; set; }

		public int HouseNumber { get; set; }

		public Address()
		{

		}

		public Address(string streetName, int houseNumber)
		{
			StreetName = streetName ?? throw new ArgumentNullException(nameof(streetName));
			HouseNumber = houseNumber;
		}

		public Address(Address other)
		{
			StreetName = other.StreetName;
			HouseNumber = other.HouseNumber;
		}

		public override string ToString()
		{
			return $"{nameof(StreetName)}: {StreetName}, {nameof(HouseNumber)}: {HouseNumber}";
		}

		//public Address DeepCopy()
		//{
		//	return new Address(StreetName, HouseNumber);
		//}
	}
}
