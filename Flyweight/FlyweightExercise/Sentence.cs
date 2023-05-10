using System.Text;

public class Sentence
{
	private readonly string[] _words;
	private readonly List<WordToken> _tokens = new List<WordToken>();

	public Sentence(string plainText)
	{
		_words = plainText.Split(' ');
		foreach (var word in _words)
		{
			var token = new WordToken();
			_tokens.Add(token);
		}
	}

	public WordToken this[int index] => _tokens[index];
	

	public override string ToString()
	{
		var sb = new StringBuilder();

		for (int i = 0; i < _words.Length; i++)
		{
			if (!_tokens[i].Capitalize)
			{
				sb.Append($"{_words[i]} ");
			}
			else
			{
				sb.Append($"{_words[i].ToUpper()} ");
			}
		}

		return sb.ToString().Trim();
	}
}