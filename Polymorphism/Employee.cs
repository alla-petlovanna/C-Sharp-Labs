using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_2
{
	class Employee
	{
		private string surname;
		private int age;
		private string position;
		private double salary;

		public string Surname { get => surname; set => surname = value; }
		public int Age { get => age; set => age = value; }
		public string Position { get => position; set => position = value; }
		public double Salary { get => salary; set => salary = value; }

		public Employee() { }

		public void InfOutput()
		{
			Surname = surname;
			Console.WriteLine("This is an employee: " + surname);
		}

		public void AgeAnalyzer()
		{
			if (Age < 16) Console.WriteLine(Surname + "'s age is " + Age + "- teenager");
			else if (Age > 60) Console.WriteLine(Surname + "'s age is " + Age + "- pensioner");
			else Console.WriteLine(Surname + "'s age is " + Age);
		}

		public void SalaryAnalyzer(string surname, double salary)
		{
			if (Salary < 1000) Console.WriteLine(Surname + " has a meager salary - " + Salary);
			else if (Salary > 3000) Console.WriteLine(Surname + " has a good salary - " + Salary);
			else Console.WriteLine(Surname + " has some salary - " + Salary);
		}

		public void SalaryAnalyzer(string surname, string position, double salary)
		{
			if (Position == "manager" && Salary <= 3000) Console.WriteLine(Surname + " should look for a better job!");
			else Console.WriteLine(Surname + " " + Position + " " + Salary);
		}
	}
}
