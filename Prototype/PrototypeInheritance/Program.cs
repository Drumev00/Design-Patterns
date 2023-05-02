using PrototypeInheritance;

var john = new Employee();
john.Names = new[] { "John", "Doe" };
john.Address = new Address
{
	HouseNumber = 123,
	StreetName = "London Road"
};
john.Salary = 1234;

var copy = john.DeepCopy();

// these lines work as well

//Employee employeeCopy = john.DeepCopy<Employee>();
//Person personCopy = john.DeepCopy<Person>();

copy.Names[1] = "Smith";
copy.Address.HouseNumber++;
copy.Salary++;

Console.WriteLine(john);
Console.WriteLine(copy);

