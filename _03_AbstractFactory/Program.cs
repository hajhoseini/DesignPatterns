using _03_AbstractFactory.DoorFactory;

namespace _03_AbstractFactory
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region wooden

			var woodenDoorFactory = new WoodenDoorFactory();

			var woodenDoor = woodenDoorFactory.MakeDoor();
			var woodenDoorFittingExpert = woodenDoorFactory.MakeDoorFittingExpert();

			woodenDoor.GetDescription(); //Output : I am a wooden door
			woodenDoorFittingExpert.GetDescription();//Output : I can only fit woooden doors

			#endregion

			#region iron

			var ironDoorFactory = new IronDoorFactory();

			var ironDoor = ironDoorFactory.MakeDoor();
			var ironDoorFittingExpert = ironDoorFactory.MakeDoorFittingExpert();

			ironDoor.GetDescription();//Output : I am a iron door
			ironDoorFittingExpert.GetDescription();//Output : I can only fit iron doors

			#endregion
		}
	}
}