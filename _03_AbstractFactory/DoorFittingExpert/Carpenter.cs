namespace _03_AbstractFactory.DoorFittingExpert;

class Carpenter : IDoorFittingExpert
{
	public void GetDescription()
	{
		Console.WriteLine("I can only fit wooden doors");
	}
}
