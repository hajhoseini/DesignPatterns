namespace _15_Command;

class TurnOn : ICommand
{
	private Bulb _bulb;

    public TurnOn(Bulb bulb)
    {
		_bulb = bulb ?? throw new ArgumentNullException("Bulb", "Bulb cannot be null");
	}

    public void Execute()
	{
		_bulb.TurnOn();
	}

	public void Redo()
	{
		_bulb.TurnOff();
	}

	public void Undo()
	{
		Execute();
	}
}
