using Prototype;

var john = new Person(new[] { "John", "Doe" }, new Address("London Road", 123));
var jane = john.DeepCopyXml();
jane.Names = new[] { "Jane", "Doe" };
jane.Address.HouseNumber = 321;

Console.WriteLine(john);
Console.WriteLine(jane);