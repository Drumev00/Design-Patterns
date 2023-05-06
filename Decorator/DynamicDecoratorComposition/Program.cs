using DynamicDecoratorComposition;


// we have decorator on decorator of some class

var square = new Square(1.23f);
Console.WriteLine(square.AsString());

var redSquare = new ColoredShape(square, "Red");
Console.WriteLine(redSquare.AsString());

var redHalfTransparentSquare = new TransparentShape(redSquare, 0.5f);
Console.WriteLine(redHalfTransparentSquare.AsString());
