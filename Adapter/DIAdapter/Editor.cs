namespace DIAdapter
{
	internal class Editor
	{
		private IEnumerable<Button> _buttons;

		public Editor(IEnumerable<Button> buttons)
		{
			_buttons = buttons ?? throw new ArgumentNullException(nameof(buttons));
		}

		public IEnumerable<Button> Buttons => _buttons;

		public void ClickAll()
		{
			foreach (var btn in _buttons)
			{
				btn.Click();
			}
		}
	}
}
