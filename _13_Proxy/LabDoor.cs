namespace _13_Proxy;

class LabDoor : IDoor
{
	public void Close()
	{
		Console.WriteLine("Closing lab door");
	}

	public void Open()
	{
		Console.WriteLine("Opening lab door");
	}
}
