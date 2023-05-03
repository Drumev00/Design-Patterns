using Monostate;

var ceo = new CEO();
ceo.Name = "John Doe";
ceo.Age = 33;

// Monostate approach to singleton pattern
var ceo2 = new CEO();
Console.WriteLine(ceo2);
