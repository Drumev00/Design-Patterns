using Single_Responsibility;

var j = new Journal();

j.AddEntry("I cried today");
j.AddEntry("I ate a bug");
Console.WriteLine(j);

// If prersistence needed DON'T put the logic in the journal class: 

var p = new Persistence();
string filename = "path example";
p.SaveToFile(j, filename);

// Separation of concerns achieved

