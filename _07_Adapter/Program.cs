namespace _07_Adapter
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var wildDog = new WildDog();
			var wildDogAdapter = new WildDogAdapter(wildDog);

			var hunter = new Hunter();
			hunter.Hunt(wildDogAdapter);
		}
	}
}