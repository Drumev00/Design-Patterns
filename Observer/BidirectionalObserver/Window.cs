using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace BidirectionalObserver
{
	internal class Window : INotifyPropertyChanged
	{
		private string _productName;

		public Window(string productName)
		{
			_productName = productName;
		}

		// I want it to be as Product's Name value
		public string ProductName
		{
			get => _productName;
			set
			{
				if (value == _productName) return;
				_productName = value;
				OnPropertyChanged();
			}
		}


		public event PropertyChangedEventHandler? PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public override string ToString()
		{
			return $"Window: {ProductName}";
		}
	}
}
