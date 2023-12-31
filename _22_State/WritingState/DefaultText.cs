namespace _22_State.WritingState;

class DefaultText : IWritingState
{
	public void Write(string words)
	{
		Console.WriteLine(words);
	}
}