using BidirectionalObserver;

var product = new Product("Book");
var window = new Window("Book"); // represents info about the product

using var binding = new BidirectionalBinding(
	product,
	() => product.Name,
	window,
	() => window.ProductName);


product.Name = "Chair";
Console.WriteLine(product);
Console.WriteLine(window);

window.ProductName = "Pillow";
Console.WriteLine(product);
Console.WriteLine(window);

// without BidirectionalBinding class V

//product.PropertyChanged += (sender, args) =>
//{
//	if (args.PropertyName == "Name")
//	{
//		Console.WriteLine($"Name was changed in Product");
//		window.ProductName = product.Name;
//	}
//};

//window.PropertyChanged += (sender, args) =>
//{
//	if (args.PropertyName == "ProductName")
//	{
//		Console.WriteLine($"Name was changed in Window");
//		product.Name = window.ProductName;
//	}
//};