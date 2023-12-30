namespace _19_Observer
{
	class JobSeeker : IObserver<JobPost>
	{
		public string Name {  get; private set; }

        public JobSeeker(string name)
        {
			Name = name;
        }
		
        public void OnCompleted()
		{
			throw new NotImplementedException();
		}

		public void OnError(Exception error)
		{
			throw new NotImplementedException();
		}

		public void OnNext(JobPost value)
		{
			Console.WriteLine($"Hi {Name} ! New job posted: {value.Title}");
		}
	}
}