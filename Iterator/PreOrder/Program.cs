using PreOrder;

var a = new Node<char>('A', null, null);
var c = new Node<char>('C', null, null);
var e = new Node<char>('E', null, null);
var d = new Node<char>('D', c, e);
var b = new Node<char>('B', a, d);
var h = new Node<char>('H', null, null);
var i = new Node<char>('I', h, null);
var g = new Node<char>('G', null, i);
var f = new Node<char>('F', b, g);

//						F
//					   / \
//					  B   G
//					 / \   \
//					A	D	I
//					   / \ /				
//					  C  E H	

Console.WriteLine(string.Join(' ', f.PreOrder));