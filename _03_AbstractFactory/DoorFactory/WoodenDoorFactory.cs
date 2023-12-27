using _03_AbstractFactory.Door;
using _03_AbstractFactory.DoorFittingExpert;

namespace _03_AbstractFactory.DoorFactory;

class WoodenDoorFactory : IDoorFactory
{
	public IDoor MakeDoor()
	{
		return new WoodenDoor();
	}

	public IDoorFittingExpert MakeDoorFittingExpert()
	{
		return new Carpenter();
	}
}
