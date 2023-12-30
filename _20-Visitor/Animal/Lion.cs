namespace _20_Visitor.Animal;

class Lion : IAnimal
{
	public void Roar()
	{
		Console.WriteLine("Roaar!");
	}

	public void Accept(IAnimalOperation animalOperation)
	{
		animalOperation.VisitLion(this);
	}
}
