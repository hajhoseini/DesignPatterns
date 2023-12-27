namespace _05_Prototype;

public class SomeComponent
{
	public int someInt;
	public string? someString;

	public SomeComponent ShallowCopy()
	{
		return (SomeComponent)this.MemberwiseClone();
	}

	public SomeComponent DeepCopy()
	{
		SomeComponent clone = (SomeComponent)this.MemberwiseClone();
		clone.someInt = someInt;
		clone.someString = someString;
		return clone;
	}
}
