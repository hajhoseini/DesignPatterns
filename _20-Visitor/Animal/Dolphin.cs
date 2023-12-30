namespace _20_Visitor.Animal;

class Dolphin : IAnimal
{
	public void Speak()
	{
		Console.WriteLine("Tuut tittu tuutt!");
	}

	public void Accept(IAnimalOperation animalOperation)
	{
		animalOperation.VisitDolphin(this);
	}
}
