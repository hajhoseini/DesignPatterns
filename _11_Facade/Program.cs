namespace _11_Facade
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var computer = new ComputerFacade(new Computer());

			computer.TurnOn(); // Ouch! Beep beep! Loading.. Ready to be used!
			Console.WriteLine();

			computer.TurnOff();  // Bup bup buzzz! Haah! Zzzzz
			Console.ReadLine();
		}
	}
}