using BasicCompositeExample;

var containers = new List<IValueContainer>();

var v1 = new SingleValue { Value = 7 };
var v2 = new SingleValue { Value = 7 };
var v3 = new ManyValues { 2, 3, 4};
var v4 = new ManyValues { 5, 6, 7 };

containers.Add(v1);
containers.Add(v2);
containers.Add(v3);
containers.Add(v4);

var result = 0;

foreach (var container in containers)
{
	foreach (var item in container)
	{
		result += item;
	}
}

Console.WriteLine(result);
