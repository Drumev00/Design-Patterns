//		1
//	   / \
//	  2   3
// in-order: 213

using IteratorObject;

var root = new Node<int>(1, new Node<int>(2), new Node<int>(3));
var iterator = new InOrderIterator<int>(root);
while (iterator.MoveNext())
{
	Console.Write(iterator.Current.Value);
	Console.Write(",");
}

Console.WriteLine();
