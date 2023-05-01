using System.Text;

namespace BuilderExercise
{
	internal class CodeBuilder
	{
		private StringBuilder _sb;
		private const int _indentSpaceTimes = 2;

		public CodeBuilder(string className)
		{
			_sb = new StringBuilder();

			_sb.AppendLine($"public class {className}");
			_sb.AppendLine("{");
		}

		public CodeBuilder AddField(string fieldName, string fieldType) 
		{
			_sb.AppendLine($"{new string(' ', _indentSpaceTimes)}public {fieldType} {fieldName};");

			return this;
		}

		public override string ToString()
		{
			_sb.AppendLine("}");
			return _sb.ToString();
		}
	}
}
