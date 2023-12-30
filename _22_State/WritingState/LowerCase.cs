namespace _22_State.WritingState;

class LowerCase : IWritingState
{
	public void Write(string words)
	{
		Console.WriteLine(words.ToLower());
	}
}
