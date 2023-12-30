using _22_State.WritingState;

namespace _22_State
{
	class TextEditor
	{
		private IWritingState _writingState;

        public TextEditor()
        {
			_writingState = new DefaultText();
		}

		public void SetState(IWritingState writingState)
		{
			_writingState = writingState;
		}

		public void Type(string words)
		{
			_writingState.Write(words);
		}
    }
}