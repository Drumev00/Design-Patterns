namespace HandmadeInterpreter_Parsing
{
	internal class Token
	{
		public TokenType Type { get; set; }

		public string Text { get; set; }

		public Token(TokenType type, string text)
		{
			Type = type;
			Text = text ?? throw new ArgumentNullException(nameof(text));
		}

		public override string ToString()
		{
			return $"`{Text}`";
		}
	}
}
