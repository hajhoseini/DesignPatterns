namespace _15_Command;

class RemoteControl
{
	public void Submit(ICommand command)
	{
		command.Execute();
	}
}
