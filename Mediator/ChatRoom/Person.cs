namespace ChatRoom
{
	internal class Person
	{
		private List<string> _chatLog = new();
		public string Name { get; set; }

		public ChatRoom Chat { get; set; }

		public Person(string name)
		{
			Name = name;
		}

		public void Say(string message)
		{
			Chat.Broadcast(Name, message);
		}
		public void PrivateMessage(string who, string message)
		{
			Chat.Message(Name, who, message);
		}

		public void Reveive(string sender, string message)
		{
			string text = $"{sender}: {message}";
			_chatLog.Add(text);
			Console.WriteLine($"[{Name}'s chat session]: {text}");
		}
	}
}
