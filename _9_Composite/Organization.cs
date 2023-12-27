﻿using _9_Composite.Employee;

namespace _9_Composite
{
	class Organization
	{
        protected List<IEmployee> employees;

        public Organization()
        {
			employees = new List<IEmployee>();
		}

		public void AddEmployee(IEmployee employee)
		{
			employees.Add(employee);
		}

		public float GetNetSalaries()
		{
			float sum = 0;
			foreach(IEmployee employee in employees)
			{
				sum += employee.GetSalary();
			}

			return sum;
		}
    }
}
