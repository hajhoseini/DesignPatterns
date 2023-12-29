namespace _15_Command;

interface ICommand
{
	void Execute();
	void Undo();
	void Redo();
}
