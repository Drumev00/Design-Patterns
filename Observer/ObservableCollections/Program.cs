using System.ComponentModel;
using ObservableCollections;

var market = new Market();
market.Prices.ListChanged += (sender, args) =>
{
	if (args.ListChangedType == ListChangedType.ItemAdded)
	{
		float price = ((BindingList<float>)sender)[args.NewIndex];
		Console.WriteLine($"BindingList got a price of {price}");
	}
};
market.AddPrice(123);