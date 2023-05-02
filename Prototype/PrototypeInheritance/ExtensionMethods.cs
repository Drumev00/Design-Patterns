using PrototypeInheritance.Abstractions;

namespace PrototypeInheritance
{
	internal static class ExtensionMethods
	{
		// can't invoke the original because it's predefined so we create an extension method
		public static T DeepCopy<T>(this IDeepCopyable<T> item) where T : new()
		{
			return item.DeepCopy();
		}

		public static T DeepCopy<T>(this T person) where T : Person, new() 
		{
			return ((IDeepCopyable<T>)person).DeepCopy();
		}
	}
}
