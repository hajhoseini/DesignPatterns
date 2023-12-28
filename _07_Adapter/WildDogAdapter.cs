using _07_Adapter.Lion;

namespace _07_Adapter;

class WildDogAdapter : ILion
{
    private WildDog _dog;

    public WildDogAdapter(WildDog dog)
    {
		_dog = dog;
	}

    public void Roar()
	{
		_dog.bark();
	}
}
