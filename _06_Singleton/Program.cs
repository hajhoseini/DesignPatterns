namespace _06_Singleton
{
	internal class Program
	{
		static void Main(string[] args)
		{
			President a = President.GetInstance();
			President b = President.GetInstance();

			Console.WriteLine(a == b); //Output : true
		}
	}
}