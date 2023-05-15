using HandmadeInterpreter_Parsing;
using System.Text;
using HandmadeInterpreter_Parsing.Abstractions;
using TokenType = HandmadeInterpreter_Parsing.TokenType;

static List<Token> Lex(string input)
{
	var result = new List<Token>();
	for (int i = 0; i < input.Length; i++)
	{
		switch (input[i])
		{
			case '+':
				result.Add(new Token(TokenType.Plus, "+"));
				break;
			case '-':
				result.Add(new Token(TokenType.Minus, "-"));
				break;
			case '(':
				result.Add(new Token(TokenType.Lparen, "("));
				break;
			case ')':
				result.Add(new Token(TokenType.Rparent, ")"));
				break;
			default:
				var sb = new StringBuilder(input[i].ToString());
				for (int j = i + 1; j < input.Length; j++)
				{
					if (char.IsDigit(input[j]))
					{
						sb.Append(input[j]);
						++i;
					}
					else
					{
						result.Add(new Token(TokenType.Integer, sb.ToString()));
						break;
					}
				}
				break;
		}
	}

	return result;
}

static IElement Parse(IReadOnlyList<Token> tokens)
{
	var result = new BinaryOperation();
	bool haveLeft = false;

	for (int i = 0; i < tokens.Count; i++)
	{
		var token = tokens[i];
		switch (token.Type)
		{
			case TokenType.Integer:
				var integer = new Integer(int.Parse(token.Text));
				if (!haveLeft)
				{
					result.Left = integer;
					haveLeft = true;
				}
				else
				{
					result.Right = integer;
				}
				break;
			case TokenType.Plus:
				result.Type = OperationType.Addition;
				break;
			case TokenType.Minus:
				result.Type = OperationType.Subtraction;
				break;
			case TokenType.Lparen:
				int j = i;
				for (; j < tokens.Count; ++j)
				{
					if (tokens[j].Type == TokenType.Rparent)
					{
						break;
					}
				}

				var subexpression = tokens.Skip(i + 1).Take(j - i - 1).ToList();
				var element = Parse(subexpression);
				if (!haveLeft)
				{
					result.Left = element;
					haveLeft = true;
				}
				else
				{
					result.Right = element;
				}

				i = j;
				break;
			default:
				throw new ArgumentOutOfRangeException();
		}
	}

	return result;
}

string input = "(13+4)-(12+1)";
var tokens = Lex(input);
Console.WriteLine(string.Join('\t', tokens));

var parsed = Parse(tokens);
Console.WriteLine($"{input} = {parsed.Value}");
