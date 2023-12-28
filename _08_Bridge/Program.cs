﻿using _08_Bridge.Theme;
using _08_Bridge.WebPage;

namespace _08_Bridge
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var darkTheme = new DarkTheme();
			var lightTheme = new LightTheme();

			var about = new About(darkTheme);
			var careers = new Careers(lightTheme);

			Console.WriteLine(about.GetContent()); //Output: About page in Dark Black
			Console.WriteLine(careers.GetContent()); //Output: Careers page in Off White
		}
	}
}