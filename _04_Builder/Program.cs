namespace _04_Builder
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//var burger = new Burger(20, true , true, true, true);

			var burger = new BurgerBuilder(50)
							.AddCheese()
							.AddPepperoni()
							.AddLettuce()
							.AddTomato()
							.Build();

			Console.WriteLine(burger.GetDescription());
		}
	}
}