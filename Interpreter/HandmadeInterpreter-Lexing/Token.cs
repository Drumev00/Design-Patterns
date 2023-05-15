namespace HandmadeInterpreter_Lexing
{
	internal class Token
	{
		public Type Type { get; set; }

		public string Text { get; set; }

		public Token(Type type, string text)
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
