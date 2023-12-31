namespace _21_Strategy
{
	class BubbleSortStrategy : ISortStrategy
	{
		public List<int> Sort(List<int> dataset)
		{
			Console.WriteLine("Sorting using Bubble Sort !");
			return dataset;
		}
	}
}