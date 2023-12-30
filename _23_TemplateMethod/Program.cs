using _23_TemplateMethod.Builder;

namespace _23_TemplateMethod
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var androidBuilder = new AndroidBuilder();
			androidBuilder.Build();

			// Output:
			// Running android tests
			// Linting the android code
			// Assembling the android build
			// Deploying android build to server

			var iosBuilder = new IosBuilder();
			iosBuilder.Build();

			// Output:
			// Running ios tests
			// Linting the ios code
			// Assembling the ios build
			// Deploying ios build to server
		}
	}
}