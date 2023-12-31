namespace _19_Observer
{
	internal class Unsubscriber<JobPost> : IDisposable
	{
		private List<IObserver<JobPost>> _observers;
		private IObserver<JobPost> _observer;

        public Unsubscriber(List<IObserver<JobPost>> observers, IObserver<JobPost> observer)
        {
            this._observers = observers;
			this._observer = observer;
        }

        public void Dispose()
		{
			if(_observers.Contains(_observer))
			{
				_observers.Remove(_observer);
			}
		}
	}
}