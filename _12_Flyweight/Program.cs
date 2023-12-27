namespace _12_Flyweight
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var teaMaker = new TeaMaker();
			var teaShop = new TeaShop(teaMaker);

			teaShop.TakeOrder("less sugar", 1);
			teaShop.TakeOrder("more milk", 2);
			teaShop.TakeOrder("without sugar", 5);

			teaShop.Serve();
			// Serving tea to table# 1
			// Serving tea to table# 2
			// Serving tea to table# 5
		}
	}
}