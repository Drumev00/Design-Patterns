using Object_Tracking_And_Bulk_Replacement.Factories;

var factory = new TrackingThemeFactory();
var theme1 = factory.CreateTheme(false);
var theme2 = factory.CreateTheme(true);
Console.WriteLine(factory.Info);


var replaceableFactory = new ReplaceableThemeFactory();
var magicTheme = replaceableFactory.CreateTheme(true);
Console.WriteLine(magicTheme.Value.BgrColor);
replaceableFactory.ReplaceTheme(false);
Console.WriteLine(magicTheme.Value.BgrColor);


