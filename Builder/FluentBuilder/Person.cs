namespace FluentBuilder
{
	internal class Person
	{
		public string Name { get; set; }

		public string Position { get; set; }

		public static Builder New => new Builder();


		public override string ToString()
		{
			return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
		}
	}
}
