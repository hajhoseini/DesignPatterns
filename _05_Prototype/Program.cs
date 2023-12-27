namespace _05_Prototype
{
	internal class Program
	{
		static void Main(string[] args)
		{
			SomeComponent c1 = new SomeComponent();
			c1.someInt = 1;
			c1.someString = "someString1";

			// Perform a shallow copy of c1 and assign it to c2.
			SomeComponent c2 = c1.ShallowCopy();

			// Make a deep copy of c1 and assign it to c3.
			SomeComponent c3 = c1.DeepCopy();

			Console.WriteLine(c1.someInt + ":" + c1.someString); // 1:someString1
			Console.WriteLine(c2.someInt + ":" + c2.someString); // 1:someString1
			Console.WriteLine(c3.someInt + ":" + c3.someString); // 1:someString1

			c1.someInt = 2;
			c1.someString = "someString2";

			Console.WriteLine(c1.someInt + ":" + c1.someString); // 2:someString2
			Console.WriteLine(c2.someInt + ":" + c2.someString); // 1:someString1
			Console.WriteLine(c3.someInt + ":" + c3.someString); // 1:someString1

			var manager = new Manager("Cindey");
			var managerClone = (Manager)manager.Clone(true);

			var employee = new Employee("kevin", managerClone);
			var employeeClone = (Employee)employee.Clone(true);
		}
	}
}