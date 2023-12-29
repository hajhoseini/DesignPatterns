namespace _17_Mediator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var mediator = new ChatRoom();

			var john = new User("John", mediator);
			var jane = new User("Jane", mediator);

			john.Send("Hi there!");
			jane.Send("Hey!");

			//April 14, 20:05[John]:Hi there!
			//April 14, 20:05[Jane]:Hey!
		}
	}
}