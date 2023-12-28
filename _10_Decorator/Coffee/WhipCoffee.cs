namespace _10_Decorator.Coffee
{
	class WhipCoffee : ICoffee
	{
		private readonly ICoffee _coffee;

		public WhipCoffee(ICoffee coffee)
		{
			_coffee = coffee ?? throw new ArgumentNullException("coffee", "coffee should not be null");
		}

		public int GetCost()
		{
			return _coffee.GetCost() + 1;
		}

		public string GetDescription()
		{
			return String.Concat(_coffee.GetDescription(), ", Whip");
		}
	}
}
