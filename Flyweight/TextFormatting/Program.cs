using System.Text;
using TextFormatting;

var ft = new FormattedText("This is a brave new world.");
ft.Capitalize(10, 15);

Console.WriteLine(ft);

var bft = new BetterFormattedText("This is a brave new world.");
bft.GetRange(10, 15).Capitalize = true;
Console.WriteLine(bft);