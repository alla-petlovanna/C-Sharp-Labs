using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab10_1
{
	class Employee
	{
		public string Surname { get; set; }
		public int Age { get; set; }
		public string Position { get; set; }
		public double Salary { get; set; }
		public Employee(string surname, int age, string position, double salary)
		{
			Surname = surname;
			Age = age;
			Position = position;
			Salary = salary;
		}
		public virtual void AgeAnalyzer() { return; }
		public virtual void SalaryAnalyzer(string surname, double salary) { return; }
	}
}
