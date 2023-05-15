using HandmadeInterpreter_Parsing.Abstractions;

namespace HandmadeInterpreter_Parsing
{
	internal class BinaryOperation : IElement
	{

		public OperationType Type { get; set; }

		public IElement Left { get; set; }

		public IElement Right { get; set; }

		public int Value
		{
			get
			{
				switch (Type)
				{
					case OperationType.Addition:
						return Left.Value + Right.Value;
						break;
					case OperationType.Subtraction:
						return Left.Value - Right.Value;
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}
		}
	}
}
