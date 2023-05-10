using System.Text;

namespace TextFormatting
{
	internal class BetterFormattedText
	{
		private string _plainText;
		private List<TextRange> _formatting = new();

		public BetterFormattedText(string plainText)
		{
			_plainText = plainText;
		}

		public TextRange GetRange(int start, int end)
		{
			var range = new TextRange(start, end);
			_formatting.Add(range);
			return range;
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			for (int i = 0; i < _plainText.Length; i++)
			{
				var character = _plainText[i];
				foreach (var range in _formatting)
				{
					if (range.Covers(i) && range.Capitalize)
					{
						character = char.ToUpper(character);
					}
				}

				sb.Append(character);
			}

			return sb.ToString();
		}
	}
}
