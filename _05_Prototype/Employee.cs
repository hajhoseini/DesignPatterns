using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace _05_Prototype;

public class Employee : Person
{
	public Manager Manager { get; set; }
	public override string Name { get; set; }

    public Employee(string name, Manager manager)
    {
		Name = name;
		Manager = manager;
    }

    public override Person Clone(bool deepClone = false)
	{
		if (deepClone)
		{
			var objectAsJson = JsonConvert.SerializeObject(this);
			return JsonConvert.DeserializeObject<Employee>(objectAsJson);
		}

		return (Person)MemberwiseClone();
	}
}
