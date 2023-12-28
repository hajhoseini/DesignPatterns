using System.Collections;

namespace _16_Iterator;

class StationList : IEnumerable<RadioStation>
{
	List<RadioStation> mStations = new List<RadioStation>();

	public RadioStation this[int index]
	{
		get { return mStations[index]; }
		set { mStations.Insert(index, value); }
	}

	public void Add(RadioStation station)
	{
		mStations.Add(station);
	}

	public void Remove(RadioStation station)
	{
		mStations.Remove(station);
	}

	public IEnumerator<RadioStation> GetEnumerator()
	{
		return this.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		//Use can switch to this internal collection if you do not want to transform
		//return mStations.GetEnumerator();

		//use this if you want to transform the object before rendering
		foreach (var x in mStations)
		{
			yield return x;
		}
	}
}
