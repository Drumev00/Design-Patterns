namespace PropertyProxy
{
	// I want if value = 10 and try assign it to 10 again to do nothing
	internal class Property<T> : IEquatable<Property<T>> where T : new()
	{
		private T _value;

		public T Value
		{
			get => _value;
			set
			{
				if (Equals(_value, value))
				{
					return;
				}

				_value = value;
				Console.WriteLine($"Assigning value to {_value}");
			}
		}

		// if T is reference type I want to set whatever default value it has
		public Property() : this(Activator.CreateInstance<T>())
		{
			
		}

		public Property(T value)
		{
			_value = value;
		}

		public static implicit operator T(Property<T> property)
		{
			return property._value; // int num = Property<int>();
		}

		public static implicit operator Property<T>(T value)
		{
			return new Property<T>(value); // Property<int> p = 123;
		}

		public bool Equals(Property<T>? other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return EqualityComparer<T>.Default.Equals(_value, other._value);
		}

		public override bool Equals(object? obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((Property<T>)obj);
		}

		public override int GetHashCode()
		{
			return EqualityComparer<T>.Default.GetHashCode(_value);
		}

		public static bool operator ==(Property<T>? left, Property<T>? right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(Property<T>? left, Property<T>? right)
		{
			return !Equals(left, right);
		}
	}
}
