using _18_Memento;

class Editor
{
	private string _content;
	private EditorMemento _memento;

    public Editor()
    {
		_memento = new EditorMemento(string.Empty);
    }

	public string Content
	{
		get
		{
			return _content;
		}
	}

	public void Type(string words)
	{
		_content = String.Concat(_content, " ", words);
	}

	public void Save()
	{
		_memento = new EditorMemento(_content);
	}

	public void Restore()
	{
		_content = _memento.Content;
	}
}