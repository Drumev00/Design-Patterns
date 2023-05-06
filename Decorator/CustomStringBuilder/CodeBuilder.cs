using System.Runtime.Serialization;
using System.Text;

namespace CustomStringBuilder
{
	internal class CodeBuilder
	{
		private StringBuilder _sb = new();

		public override string ToString()
		{
			return _sb.ToString();
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			((ISerializable)_sb).GetObjectData(info, context);
		}

		public CodeBuilder Append(bool value)
		{
			_sb.Append(value);
			return this;
		}

		public CodeBuilder Append(byte value)
		{
			_sb.Append(value);
			return this;

		}

		public CodeBuilder Append(char value)
		{
			_sb.Append(value);
			return this;

		}

		public unsafe CodeBuilder Append(char* value, int valueCount)
		{
			_sb.Append(value, valueCount);
			return this;
		}

		public CodeBuilder Append(char value, int repeatCount)
		{
			_sb.Append(value, repeatCount);
			return this;
		}

		public CodeBuilder Append(char[]? value)
		{

			_sb.Append(value);
			return this;
		}

		public CodeBuilder Append(char[]? value, int startIndex, int charCount)
		{

			_sb.Append(value, startIndex, charCount);
			return this;
		}

		public CodeBuilder Append(decimal value)
		{

			_sb.Append(value);
			return this;
		}

		public CodeBuilder Append(double value)
		{

			_sb.Append(value);
			return this;
		}

		public CodeBuilder Append(short value)
		{

			_sb.Append(value);
			return this;
		}

		public CodeBuilder Append(int value)
		{

			_sb.Append(value);
			return this;
		}

		public CodeBuilder Append(long value)
		{

			_sb.Append(value);
			return this;
		}

		public CodeBuilder Append(object? value)
		{

			_sb.Append(value);
			return this;
		}

		public CodeBuilder Append(ReadOnlyMemory<char> value)
		{

			_sb.Append(value);
			return this;
		}

		public CodeBuilder Append(ReadOnlySpan<char> value)
		{

			_sb.Append(value);
			return this;
		}

		public CodeBuilder Append(sbyte value)
		{

			_sb.Append(value);
			return this;
		}

		public CodeBuilder Append(float value)
		{

			_sb.Append(value);
			return this;
		}

		public CodeBuilder Append(string? value)
		{

			_sb.Append(value);
			return this;
		}

		public CodeBuilder Append(string? value, int startIndex, int count)
		{

			_sb.Append(value, startIndex, count);
			return this;
		}

		public CodeBuilder Append(CodeBuilder? value)
		{

			_sb.Append(value);
			return this;
		}

		public CodeBuilder Append(ushort value)
		{

			_sb.Append(value);
			return this;
		}

		public CodeBuilder Append(uint value)
		{

			_sb.Append(value);
			return this;
		}

		public CodeBuilder Append(ulong value)
		{

			_sb.Append(value);
			return this;
		}

		public CodeBuilder AppendFormat(IFormatProvider? provider, string format, object? arg0)
		{

			_sb.AppendFormat(provider, format, arg0);
			return this;
		}

		public CodeBuilder AppendFormat(IFormatProvider? provider, string format, object? arg0, object? arg1)
		{

			_sb.AppendFormat(provider, format, arg0, arg1);
			return this;
		}

		public CodeBuilder AppendFormat(IFormatProvider? provider, string format, object? arg0, object? arg1, object? arg2)
		{

			_sb.AppendFormat(provider, format, arg0, arg1, arg2);
			return this;
		}

		public CodeBuilder AppendFormat(IFormatProvider? provider, string format, params object?[] args)
		{

			_sb.AppendFormat(provider, format, args);
			return this;
		}

		public CodeBuilder AppendFormat(string format, object? arg0)
		{

			_sb.AppendFormat(format, arg0);
			return this;
		}

		public CodeBuilder AppendFormat(string format, object? arg0, object? arg1)
		{

			_sb.AppendFormat(format, arg0, arg1);
			return this;
		}

		public CodeBuilder AppendFormat(string format, object? arg0, object? arg1, object? arg2)
		{

			_sb.AppendFormat(format, arg0, arg1, arg2);
			return this;
		}

		public CodeBuilder AppendFormat(string format, params object?[] args)
		{

			_sb.AppendFormat(format, args);
			return this;
		}

		public CodeBuilder AppendJoin(char separator, params object?[] values)
		{

			_sb.AppendJoin(separator, values);
			return this;
		}

		public CodeBuilder AppendJoin(char separator, params string?[] values)
		{

			_sb.AppendJoin(separator, values);
			return this;
		}

		public CodeBuilder AppendJoin(string? separator, params object?[] values)
		{

			_sb.AppendJoin(separator, values);
			return this;
		}

		public CodeBuilder AppendJoin(string? separator, params string?[] values)
		{

			_sb.AppendJoin(separator, values);
			return this;
		}

		public CodeBuilder AppendJoin<T>(char separator, IEnumerable<T> values)
		{

			_sb.AppendJoin(separator, values);
			return this;
		}

		public CodeBuilder AppendJoin<T>(string? separator, IEnumerable<T> values)
		{

			_sb.AppendJoin(separator, values);
			return this;
		}

		public CodeBuilder AppendLine()
		{

			_sb.AppendLine();
			return this;
		}

		public CodeBuilder AppendLine(string? value)
		{

			_sb.AppendLine(value);
			return this;
		}


		public CodeBuilder Clear()
		{

			_sb.Clear();
			return this;
		}

		public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
		{
			_sb.CopyTo(sourceIndex, destination, destinationIndex, count);
		}

		public void CopyTo(int sourceIndex, Span<char> destination, int count)
		{
			_sb.CopyTo(sourceIndex, destination, count);
		}

		public int EnsureCapacity(int capacity)
		{
			return _sb.EnsureCapacity(capacity);
		}

		public bool Equals(ReadOnlySpan<char> span)
		{
			return _sb.Equals(span);
		}

		public bool Equals(CodeBuilder? sb)
		{
			return _sb.Equals(sb);
		}


		public CodeBuilder Insert(int index, bool value)
		{

			_sb.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, byte value)
		{

			_sb.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, char value)
		{

			_sb.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, char[]? value)
		{

			_sb.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, char[]? value, int startIndex, int charCount)
		{

			_sb.Insert(index, value, startIndex, charCount);
			return this;
		}

		public CodeBuilder Insert(int index, decimal value)
		{

			_sb.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, double value)
		{

			_sb.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, short value)
		{

			_sb.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, int value)
		{

			_sb.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, long value)
		{

			_sb.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, object? value)
		{

			_sb.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, ReadOnlySpan<char> value)
		{

			_sb.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, sbyte value)
		{

			_sb.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, float value)
		{

			_sb.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, string? value)
		{

			_sb.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, string? value, int count)
		{

			_sb.Insert(index, value, count);
			return this;
		}

		public CodeBuilder Insert(int index, ushort value)
		{

			_sb.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, uint value)
		{

			_sb.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, ulong value)
		{

			_sb.Insert(index, value);
			return this;
		}

		public CodeBuilder Remove(int startIndex, int length)
		{

			_sb.Remove(startIndex, length);
			return this;
		}

		public CodeBuilder Replace(char oldChar, char newChar)
		{

			_sb.Replace(oldChar, newChar);
			return this;
		}

		public CodeBuilder Replace(char oldChar, char newChar, int startIndex, int count)
		{

			_sb.Replace(oldChar, newChar, startIndex, count);
			return this;
		}

		public CodeBuilder Replace(string oldValue, string? newValue)
		{

			_sb.Replace(oldValue, newValue);
			return this;
		}

		public CodeBuilder Replace(string oldValue, string? newValue, int startIndex, int count)
		{

			_sb.Replace(oldValue, newValue, startIndex, count);
			return this;
		}

		public string ToString(int startIndex, int length)
		{
			return _sb.ToString(startIndex, length);
		}

		public int Capacity
		{
			get => _sb.Capacity;
			set => _sb.Capacity = value;
		}

		public char this[int index]
		{
			get => _sb[index];
			set => _sb[index] = value;
		}

		public int Length
		{
			get => _sb.Length;
			set => _sb.Length = value;
		}

		public int MaxCapacity => _sb.MaxCapacity;
	}
}
