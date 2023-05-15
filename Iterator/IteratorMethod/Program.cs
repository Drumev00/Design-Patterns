using IteratorMethod;

//		1
//	   / \
//	  2   3
// in-order: 213


var root = new Node<int>(1, new Node<int>(2), new Node<int>(3));
var tree = new BinaryTree<int>(root);

foreach (var node in tree)
{
	Console.WriteLine(node.Value);
}
