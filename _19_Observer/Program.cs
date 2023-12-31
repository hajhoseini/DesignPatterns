namespace _19_Observer
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Create Subscribers
			var johnDoe = new JobSeeker("John Doe");
			var janeDoe = new JobSeeker("Jane Doe");

			//Create publisher and attch subscribers
			var jobPostings = new JobPostings();
			jobPostings.Subscribe(johnDoe);
			jobPostings.Subscribe(janeDoe);

			//Add a new job and see if subscribers get notified
			jobPostings.AddJob(new JobPost("Software Engineer"));

			//Output
			// Hi John Doe! New job posted: Software Engineer
			// Hi Jane Doe! New job posted: Software Engineer

			Console.ReadLine();
		}
	}
}