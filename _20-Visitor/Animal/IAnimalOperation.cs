namespace _20_Visitor.Animal;

// Visitor
interface IAnimalOperation
{
	void VisitMonkey(Monkey monkey);
	void VisitLion(Lion lion);
	void VisitDolphin(Dolphin dolphin);
}