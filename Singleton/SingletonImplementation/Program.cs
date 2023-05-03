using SingletonImplementation;

var db = SingletonDatabase.Instance;
var city = "Tokyo";

Console.WriteLine($"{city}: has population of {db.GetPopulation(city)} people.");

