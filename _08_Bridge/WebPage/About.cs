using _08_Bridge.Theme;

namespace _08_Bridge.WebPage;

class About : IWebPage
{
    protected ITheme _theme;

    public About(ITheme theme)
    {
        _theme = theme;            
    }

    public string GetContent()
	{
		return $"About page in {_theme.GetColor()}";
	}
}
