namespace _20_Visitor.Animal;

// Visitee
interface IAnimal
{
	void Accept(IAnimalOperation animalOperation);
}
