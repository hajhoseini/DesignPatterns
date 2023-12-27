namespace _09_Composite.Employee;

class Designer : IEmployee
{
	private string _name;
	private float _salary;

    public Designer(string name, float salary)
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
		return "Designer";
	}

	public float GetSalary()
	{
		return this._salary;
	}
}
