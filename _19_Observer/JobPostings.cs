namespace _19_Observer
{
	class JobPostings : IObservable<JobPost>
	{
		private List<IObserver<JobPost>> _observers;
		private List<JobPost> _jobPosts;

        public JobPostings()
        {
			_observers = new List<IObserver<JobPost>>();
			_jobPosts = new List<JobPost>();
        }

        public IDisposable Subscribe(IObserver<JobPost> observer)
		{
			if(!_observers.Contains(observer))
			{
				_observers.Add(observer);
			}

			return new Unsubscriber<JobPost>(_observers, observer);
		}

		private void Notify(JobPost jobPost)
		{
			foreach(var observer in _observers)
			{
				observer.OnNext(jobPost);
			}
		}

		public void AddJob(JobPost jobPost)
		{
			_jobPosts.Add(jobPost);
			Notify(jobPost);
		}
	}
}