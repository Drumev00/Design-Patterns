using Object_Tracking_And_Bulk_Replacement.Abstractions;
using System.Text;

namespace Object_Tracking_And_Bulk_Replacement.Factories
{
    internal class TrackingThemeFactory
    {
		/* WeakReference because we don't want to increase the lifetime of the constructed object.
		 * Otherwise objects will live as long as the factories live
		 */
		private readonly List<WeakReference<ITheme>> _themes = new();

        public ITheme CreateTheme(bool dark)
        {
            ITheme theme = dark ? new DarkTheme() : new LightTheme();
            _themes.Add(new WeakReference<ITheme>(theme));
            return theme;
        }

        public string Info
        {
            get
            {
                var sb = new StringBuilder();
                foreach (var reference in _themes)
                {
                    if (reference.TryGetTarget(out var theme))
                    {
                        bool isDark = theme is DarkTheme;
                        sb.Append(isDark ? "Dark" : "Light")
                            .AppendLine(" theme");
                    }
                }

                return sb.ToString();
            }
        }
    }
}
