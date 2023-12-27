namespace _13_Proxy
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var door = new SecuredDoor(new LabDoor());
			door.Open("invalid"); // Big no! It ain't possible.

			door.Open("$ecr@t"); // Opening lab door
			door.Close(); // Closing lab door
		}
	}
}