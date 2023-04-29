using Open_Closed;
using Open_Closed.Enums;
using Open_Closed.Specifications;

var apple = new Product("Apple", Color.Green, Size.Small);
var tree = new Product("Tree", Color.Green, Size.Large);
var house = new Product("House", Color.Red, Size.Huge);

Product[] products = { apple, tree, house };

var filter = new ProductFilter();

Console.WriteLine("Green products (old): ");
foreach (var p in filter.FilterByColor(products, Color.Green))
{
	Console.WriteLine($" - {p.Name} is green");
}

// End of old way. Start of Specification pattern:

var bfilter = new BetterFilter();
Console.WriteLine("Green products (new): ");

foreach (var p in bfilter.Filter(products, new ColorSpecification(Color.Green)))
{
	Console.WriteLine($" - {p.Name} is green");
}


Console.WriteLine("Large red items: ");

foreach (var p in bfilter.Filter(products, new AndSpecification<Product>(
	new ColorSpecification(Color.Red),
	new SizeSpecification(Size.Huge)))
	)
{
	Console.WriteLine($" - {p.Name} is red and huge");

}
