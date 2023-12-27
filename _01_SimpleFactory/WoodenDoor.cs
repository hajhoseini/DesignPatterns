namespace _01_SimpleFactory;

public class WoodenDoor : IDoor
{
	private int Height { get; set; }
	private int Width { get; set; }

	public WoodenDoor(int height, int width)
    {
        this.Height = height;
		this.Width = width;
	}

    public int GetHeight()
	{
		return this.Height;
	}

	public int GetWidth()
	{
		return this.Width;
	}
}
