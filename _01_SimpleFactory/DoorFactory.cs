﻿namespace _01_SimpleFactory;

public static class DoorFactory
{
	public static IDoor MakeDoor(int height, int width)
	{
		return new WoodenDoor(height, width);
	}
}
