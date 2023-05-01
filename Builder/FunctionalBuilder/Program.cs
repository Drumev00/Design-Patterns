using FunctionalBuilder;

var person = new PersonBuilder()
	.Called("Alex")
	.WorksAs("Developer")
	.Build();

Console.WriteLine(person);
