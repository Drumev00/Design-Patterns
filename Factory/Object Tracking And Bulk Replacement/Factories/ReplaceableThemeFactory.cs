using Object_Tracking_And_Bulk_Replacement.Abstractions;

namespace Object_Tracking_And_Bulk_Replacement.Factories
{
	internal class ReplaceableThemeFactory
	{
		/* WeakReference because we don't want to increase the lifetime of the constructed object.
		 * Otherwise objects will live as long as the factories live
		 */
		private readonly List<WeakReference<Ref<ITheme>>> _themes = new();
		

		public Ref<ITheme> CreateTheme(bool dark)
		{
			var reference = new Ref<ITheme>(CreateThemeImpl(dark));

			_themes.Add(new WeakReference<Ref<ITheme>>(reference));
			return reference;
		}

		public void ReplaceTheme(bool dark)
		{
			foreach (var wr in _themes)
			{
				if (wr.TryGetTarget(out var reference))
				{
					reference.Value = CreateThemeImpl(dark);
				}
			}
		}

		private ITheme CreateThemeImpl(bool dark)
		{
			return dark ? new DarkTheme() : new LightTheme();
		}
	}
}
