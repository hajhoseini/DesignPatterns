namespace _03_AbstractFactory.Door;

class WoodenDoor : IDoor
{
	public void GetDescription()
	{
		Console.WriteLine("I am a wooden door");
	}
}
