using System.ComponentModel;

namespace ObservableCollections
{
	internal class Market
	{
		// has a problem - for example I don't know when I ran out of items (unless create separate event for it)
		public readonly BindingList<float> Prices = new();

		public void AddPrice(float price)
		{
			Prices.Add(price);
		}
	}
}
