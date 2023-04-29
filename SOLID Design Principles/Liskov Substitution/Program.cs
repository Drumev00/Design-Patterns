using Liskov_Substitution;

static int Area(Rectangle rectangle) => rectangle.Width * rectangle.Height;

var rectangle = new Rectangle(12, 8);
Console.WriteLine($"{rectangle} has area {Area(rectangle)}");

Rectangle sq = new Square();
sq.Width = 4;
Console.WriteLine($"{sq} has area {Area(sq)}");

