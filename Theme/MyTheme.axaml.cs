using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace Theme;

public sealed class MyTheme : Styles
{
	public MyTheme(IServiceProvider? serviceProvider = null)
	{
		AvaloniaXamlLoader.Load(serviceProvider, this);
	}
}