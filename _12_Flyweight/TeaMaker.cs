namespace _12_Flyweight;

class TeaMaker
{
	private Dictionary<string, KarakTea> mAvailableTea = new Dictionary<string, KarakTea>();

	public KarakTea Make(string preference)
	{
		if (!mAvailableTea.ContainsKey(preference))
		{
			mAvailableTea[preference] = new KarakTea();
		}

		return mAvailableTea[preference];
	}
}
