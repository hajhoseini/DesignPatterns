namespace _03_AbstractFactory.Door
{
	class IronDoor : IDoor
	{
		public void GetDescription()
		{
			Console.WriteLine("I am an iron door");
		}
	}
}
