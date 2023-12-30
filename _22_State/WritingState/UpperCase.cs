namespace _22_State.WritingState;

class UpperCase : IWritingState
{
	public void Write(string words)
	{
		Console.WriteLine(words.ToUpper());
	}
}
