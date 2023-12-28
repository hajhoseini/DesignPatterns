using _08_Bridge.Theme;

namespace _08_Bridge.WebPage;

class Careers : IWebPage
{
	protected ITheme _theme;

	public Careers(ITheme theme)
	{
		_theme = theme;
	}

	public string GetContent()
	{
		return $"Careers page in {_theme.GetColor()}";
	}
}
