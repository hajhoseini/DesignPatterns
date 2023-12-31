namespace _20_Visitor.Animal;

class Jump : IAnimalOperation
{
	public void VisitDolphin(Dolphin dolphin)
	{
		Console.WriteLine("Walked on water a little and disappeared!");
	}

	public void VisitLion(Lion lion)
	{
		Console.WriteLine("Jumped 7 feet! Back on the ground!");
	}

	public void VisitMonkey(Monkey monkey)
	{
		Console.WriteLine("Jumped 20 feet high! on to the tree!");
	}
}