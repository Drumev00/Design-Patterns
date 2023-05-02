
using PrototypeInheritance.Abstractions;

namespace PrototypeInheritance
{
	internal class Address : IDeepCopyable<Address>
	{
		public string StreetName { get; set; }

		public int HouseNumber { get; set; }

		public Address()
		{

		}

		public Address(string streetName, int houseNumber)
		{
			StreetName = streetName;
			HouseNumber = houseNumber;
		}

		public override string ToString()
		{
			return $"{nameof(StreetName)}: {StreetName}, {nameof(HouseNumber)}: {HouseNumber}";
		}

		public void CopyTo(Address target)
		{
			target.StreetName = StreetName;
			target.HouseNumber = HouseNumber;
		}
	}
}
