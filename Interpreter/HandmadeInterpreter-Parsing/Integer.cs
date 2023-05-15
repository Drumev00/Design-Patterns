using HandmadeInterpreter_Parsing.Abstractions;

namespace HandmadeInterpreter_Parsing
{
	internal class Integer : IElement
	{
		public Integer(int value)
		{
			Value = value;
		}
		public int Value { get; }
	}
}
