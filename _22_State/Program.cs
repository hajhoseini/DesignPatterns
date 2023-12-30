using _22_State.WritingState;

namespace _22_State
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var editor = new TextEditor();

			editor.Type("First line");

			editor.SetState(new UpperCase());

			editor.Type("Second Line");
			editor.Type("Third Line");

			editor.SetState(new LowerCase());

			editor.Type("Fourth Line");
			editor.Type("Fifthe Line");

			// Output:
			// First line
			// SECOND LINE
			// THIRD LINE
			// fourth line
			// fifth line
		}
	}
}