using StaticDecoratorComposition;

var redSquare = new ColoredShape<Square>("red");
Console.WriteLine(redSquare.AsString());

/*
 * here we can give just one argument and the other two
 * will remain default. That's why we can't have static
 * decorator composition in C# or at least it's not the best option
 */ 
var circle = new TransparentShape<ColoredShape<Circle>>(0.5f);
Console.WriteLine(circle.AsString());
