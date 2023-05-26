namespace EqualityAndComparisonStrategies
{
	// can use default or custom strategy
	internal class Person : IComparable<Person>, IComparable
	{
		public Person(int id, string name, int age)
		{
			Id = id;
			Name = name;
			Age = age;
		}

		public int Id { get; set; }

		public string Name { get; set; }

		public int Age { get; set; }

		// default strategy
		public int CompareTo(Person? other)
		{
			if (ReferenceEquals(this, other)) return 0;
			if (ReferenceEquals(null, other)) return 1;
			return Id.CompareTo(other.Id);
		}

		public int CompareTo(object? obj)
		{
			if (ReferenceEquals(null, obj)) return 1;
			if (ReferenceEquals(this, obj)) return 0;
			return obj is Person other ? CompareTo(other) : throw new ArgumentException($"Object must be of type {nameof(Person)}");
		}

		public static bool operator <(Person? left, Person? right)
		{
			return Comparer<Person>.Default.Compare(left, right) < 0;
		}

		public static bool operator >(Person? left, Person? right)
		{
			return Comparer<Person>.Default.Compare(left, right) > 0;
		}

		public static bool operator <=(Person? left, Person? right)
		{
			return Comparer<Person>.Default.Compare(left, right) <= 0;
		}

		public static bool operator >=(Person? left, Person? right)
		{
			return Comparer<Person>.Default.Compare(left, right) >= 0;
		}

		// custom strategy
		private sealed class NameRelationalComparer : IComparer<Person>
		{
			public int Compare(Person x, Person y)
			{
				if (ReferenceEquals(x, y)) return 0;
				if (ReferenceEquals(null, y)) return 1;
				if (ReferenceEquals(null, x)) return -1;
				return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
			}
		}

		public static IComparer<Person> NameComparer { get; } = new NameRelationalComparer();

		public override string ToString()
		{
			return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Age)}: {Age}";
		}
	}
}
