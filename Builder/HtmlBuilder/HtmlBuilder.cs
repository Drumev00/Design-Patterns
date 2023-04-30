namespace HtmlBuilder
{
	internal class HtmlBuilder
	{
		private readonly string _rootName;
		HtmlElement root = new HtmlElement();

		public HtmlBuilder(string rootName)
		{
			_rootName = rootName;
			root.Name = rootName;
		}

		// Fluent interface - returning the same type to chain calls
		public HtmlBuilder AddChild(string childName, string childText)
		{
			var element = new HtmlElement(childName, childText);
			root.Children.Add(element);
			return this;
		}

		public override string ToString()
		{
			return root.ToString();
		}

		public void Clear()
		{
			root = new HtmlElement { Name = _rootName };
		}
	}
}
