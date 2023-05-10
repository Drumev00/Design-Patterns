namespace RepeatingUsernames
{
	internal class BetterUser
	{
		private static List<string> _strings = new List<string>();
		private int[] _names;

		public BetterUser(string fullName)
		{
			int getOrAdd(string text)
			{
				int index = _strings.IndexOf(text);
				if (index != -1)
				{
					return index;
				}
				else
				{
					_strings.Add(text);
					return _strings.Count - 1;
				}
			}

			_names = fullName.Split(' ').Select(getOrAdd).ToArray();
		}

		public string FullName => string.Join(" ", _names.Select(i => _strings[i]));
	}
}
