using _03_AbstractFactory.Door;
using _03_AbstractFactory.DoorFittingExpert;

namespace _03_AbstractFactory.DoorFactory;

class IronDoorFactory : IDoorFactory
{
	public IDoor MakeDoor()
	{
		return new IronDoor();
	}

	public IDoorFittingExpert MakeDoorFittingExpert()
	{
		return new Welder();
	}
}
