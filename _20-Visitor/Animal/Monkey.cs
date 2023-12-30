namespace _20_Visitor.Animal;

class Monkey : IAnimal
{
	public void Shout()
	{
		Console.WriteLine("Oooh o aa aa!");
	}

	public void Accept(IAnimalOperation animalOperation)
	{
		animalOperation.VisitMonkey(this);
	}
}