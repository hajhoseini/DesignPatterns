namespace _15_Command;

class TurnOff : ICommand
{
	private Bulb _bulb;

    public TurnOff(Bulb bulb)
    {
		_bulb = bulb ?? throw new ArgumentNullException("Bulb", "Bulb cannot be null");
	}

    public void Execute()
	{
		_bulb.TurnOff();		
	}

	public void Redo()
	{
		_bulb.TurnOn();
	}

	public void Undo()
	{
		Execute();
	}
}