namespace _10_Decorator.Coffee;

class SimpleCoffee : ICoffee
{
	public int GetCost()
	{
		return 5;
	}

	public string GetDescription()
	{
		return "Simple Coffee";
	}
}
