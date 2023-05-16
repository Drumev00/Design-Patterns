namespace ChatRoom
{
	internal class ChatRoom
	{
		private List<Person> _people = new();

		public void Join(Person person)
		{
			string joinMsg = $"{person.Name} joins the chat";
			Broadcast("room", joinMsg);

			person.Chat = this;
			_people.Add(person);
		}


		public void Message(string source, string destination, string message)
		{
			_people.FirstOrDefault(p => p.Name == destination)?.Reveive(source, message);
		}
		public void Broadcast(string source, string message)
		{
			foreach (var person in _people)
			{
				if (person.Name != source)
				{
					person.Reveive(source, message);
				}
			}
		}
	}
}
