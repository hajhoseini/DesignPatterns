namespace _11_Facade;

class ComputerFacade
{
	private readonly Computer _computer;

	public ComputerFacade(Computer computer)
    {
		_computer = computer;
	}

	public void TurnOn()
	{
		_computer.GetElectricShock();
		_computer.MakeSound();
		_computer.ShowLoadingScreen();
		_computer.Bam();
	}

	public void TurnOff()
	{
		_computer.CloseEverything();
		_computer.PullCurrent();
		_computer.Sooth();
	}
}
