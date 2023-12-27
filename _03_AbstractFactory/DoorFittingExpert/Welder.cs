namespace _03_AbstractFactory.DoorFittingExpert;

class Welder : IDoorFittingExpert
{
	public void GetDescription()
	{
		Console.WriteLine("I can only fit iron doors");
	}
}
