using _21_Strategy;

class Sorter
{
	private ISortStrategy _sortStrategy;

    public Sorter(ISortStrategy sortStrategy)
    {
        _sortStrategy = sortStrategy;
    }

	public List<int> Sort(List<int> unSortedList)
	{
		return _sortStrategy.Sort(unSortedList);
	}
}