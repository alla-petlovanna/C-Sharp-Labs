using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_1
{
	class Employee : IComparable
	{
		public string Surname { get; set; }
		public int Age { get; set; }
		public int Length_of_Service { get; set; }
		public Employee(string surname, int age, int length_of_service)
		{
			Surname = surname;
			Age = age;
			Length_of_Service = length_of_service;
		}
		public override string ToString()
		{
			return $"{Surname}, age {Age}, work experience - {Length_of_Service}";
		}
		public int CompareTo(Object obj)
		{
			if (obj is Employee)
			{
				if (Age < (obj as Employee).Age) return -1;
				if (Age == (obj as Employee).Age) return 0;
				if (Age > (obj as Employee).Age) return 1;
			}
			throw new Exception("Unable to compare objects!");
		}
	}
	class Employee_Comparer : IComparer<Employee>
	{
		public int Compare(Employee x, Employee y)
		{
			if (x.Length_of_Service > y.Length_of_Service) return -1;
			if (x.Length_of_Service == y.Length_of_Service) return 0;
			if (x.Length_of_Service < y.Length_of_Service) return 1;
			throw new Exception("Unable to compare objects!");
		}
	}
	class Work_Space : IEnumerable
	{
		public Employee[] employee_mass = new Employee[6];
		public Work_Space()
		{
			employee_mass[0] = new Employee("Williams", 48, 25);
			employee_mass[1] = new Employee("Peters", 36, 13);
			employee_mass[2] = new Employee("Gibson", 30, 5);
			employee_mass[3] = new Employee("Martin", 50, 28);
			employee_mass[4] = new Employee("Jordan", 50, 26);
			employee_mass[5] = new Employee("Grant", 60, 36);
		}
		public IEnumerator GetEnumerator()
		{
			return employee_mass.GetEnumerator();
		}
	}
}
	
