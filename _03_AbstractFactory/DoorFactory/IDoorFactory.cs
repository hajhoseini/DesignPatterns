using _03_AbstractFactory.Door;
using _03_AbstractFactory.DoorFittingExpert;

namespace _03_AbstractFactory.DoorFactory;

interface IDoorFactory
{
	IDoor MakeDoor();
	IDoorFittingExpert MakeDoorFittingExpert();
}
