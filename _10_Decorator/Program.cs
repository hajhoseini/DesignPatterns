﻿using _10_Decorator.Coffee;

namespace _10_Decorator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var myCoffee = new SimpleCoffee();
			Console.WriteLine($"{myCoffee.GetCost():c}"); // $ 5.00
			Console.WriteLine(myCoffee.GetDescription()); // Simple Coffee

			var milkCoffee = new MilkCoffee(myCoffee);
			Console.WriteLine($"{milkCoffee.GetCost():c}"); // $ 6.00
			Console.WriteLine(milkCoffee.GetDescription()); // Simple Coffee, milk

			var whipCoffee = new WhipCoffee(milkCoffee);
			Console.WriteLine($"{whipCoffee.GetCost():c}"); // $ 7.00
			Console.WriteLine(whipCoffee.GetDescription()); // Simple Coffee, milk, whip

			var vanillaCoffee = new VanillaCoffee(whipCoffee);
			Console.WriteLine($"{vanillaCoffee.GetCost():c}"); // $ 8.00
			Console.WriteLine(vanillaCoffee.GetDescription()); // Simple Coffee, milk, whip, vanilla
		}
	}
}