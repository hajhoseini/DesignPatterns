namespace _01_SimpleFactory
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var door = DoorFactory.MakeDoor(80, 30);
			Console.WriteLine($"Height of Door : {door.GetHeight()}");
			Console.WriteLine($"Width of Door : {door.GetWidth()}");

		}
	}
}