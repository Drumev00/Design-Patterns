using PrototypeExercise;

var start = new Point(4, 8);
var end = new Point(4, 10);
var line1 = new Line(start, end);

var line2 = line1.DeepCopy();
line2.Start = new Point(2, 1);

Console.WriteLine(line1);
Console.WriteLine(line2);
