namespace TextFormatting
{
	public class TextRange
	{
		public int Start, End;

		public bool Capitalize, Bold, Italic;

		public TextRange(int start, int end)
		{
			Start = start;
			End = end;
		}

		public bool Covers(int position)
		{
			return position >= Start && position <= End;
		}
	}
}
