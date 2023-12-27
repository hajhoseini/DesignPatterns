using _9_Composite.Employee;

namespace _9_Composite
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Arrange Employees, Organization and add employees
			var developer = new Developer("John", 5000);
			var designer = new Designer("Arya", 5500);

			var organization = new Organization();
			organization.AddEmployee(developer);
			organization.AddEmployee(designer);

			Console.WriteLine($"Net Salary of Employees in Organization is {organization.GetNetSalaries():c}");
			//Ouptut: Net Salary of Employees in Organization is $10500.00
		}
	}
}