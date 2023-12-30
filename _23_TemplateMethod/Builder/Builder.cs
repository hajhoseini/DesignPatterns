namespace _23_TemplateMethod.Builder;

abstract class Builder
{
	// Template method
	public void Build()
	{
		Test(); 
		Lint(); 
		Assemble(); 
		Deploy();
	}

	abstract public void Test();
	abstract public void Lint();
	abstract public void Assemble();
	abstract public void Deploy();
}