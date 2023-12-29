namespace _18_Memento
{
	class EditorMemento
	{
		private string _content;

        public EditorMemento(string content)
        {
			_content = content;
        }

		public string Content
		{
			get { return _content; }
		}
    }
}