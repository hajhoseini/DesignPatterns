namespace _09_Composite.Employee;

class Developer : IEmployee
{
	private string _name;
	private float _salary;

    public Developer(string name, float salary)
    {
		_name = name;
		_salary = salary;
    }

    public string GetName()
	{
		return this._name;
	}

	public string GetRole()
	{
		return "Developer";
	}

	public float GetSalary()
	{
		return this._salary;
	}
}
