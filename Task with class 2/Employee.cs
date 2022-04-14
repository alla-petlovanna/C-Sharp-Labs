using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2
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

		public void InfOutput(string surname)
		{
			Surname = surname;
			Console.WriteLine("This is an employee: " + Surname);
		}

		public void AgeAnalyzer()
		{
			if (Age < 16) Console.WriteLine(Surname + "'s age is " + Age + " - teenager");
			else if (Age > 60) Console.WriteLine(Surname + "'s age is " + Age + " - pensioner");
			else Console.WriteLine(Surname + "'s age is " + Age);
		}
	}
}
			
