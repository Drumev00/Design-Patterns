using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BidirectionalObserver
{
	internal class Product : INotifyPropertyChanged
	{

		private string _name;
		public Product(string name)
		{
			_name = name;
		}

		public string Name
		{
			get => _name;
			set
			{
				if (value == _name) return;
				_name = value;
				OnPropertyChanged();
			}
		}


		public event PropertyChangedEventHandler? PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public override string ToString()
		{
			return $"Product: {Name}";
		}
	}
}
