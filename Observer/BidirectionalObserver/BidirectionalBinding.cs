using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

namespace BidirectionalObserver
{
	// connect a with b (a.Prop with b.Prop)
	internal class BidirectionalBinding : IDisposable
	{
		private bool _disposed;

		public BidirectionalBinding(
			INotifyPropertyChanged a,
			Expression<Func<object>> aProperty,
			INotifyPropertyChanged b,
			Expression<Func<object>> bProperty)
		{
			// makes sure x.Foo is an actual member
			if (aProperty.Body is MemberExpression aExp &&
			    bProperty.Body is MemberExpression bExp)
			{
				// not just member but a property
				if (aExp.Member is PropertyInfo aProp &&
				    bExp.Member is PropertyInfo bProp)
				{
					a.PropertyChanged += (sender, args) =>
					{
						if (!_disposed)
						{
							bProp.SetValue(b, aProp.GetValue(a));
						}
					};
					b.PropertyChanged += (sender, args) =>
					{
						if (!_disposed)
						{
							aProp.SetValue(a, bProp.GetValue(b));
						}
					};
				}
			}
		}

		public void Dispose()
		{
			_disposed = true;
		}
	}
}
