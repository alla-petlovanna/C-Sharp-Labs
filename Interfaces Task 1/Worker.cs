using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab10_1
{
	class Worker : Employee, IEmp
	{
		public string Name { get; set; }
		public int Work_Exp { get; set; }
		public Worker(string surname, int age, string position, double salary)
			: base(surname, age, position, salary)
		{
			Surname = surname;
			Age = age;
			Position = position;
			Salary = salary;
		}
		public void Role()
		{
			Console.WriteLine("Information about the worker:\n" + Name + " " + Surname + "\nAge: " + Age + "\nWork experience: " + Work_Exp);
		}
		public void Sal()
		{
			Console.WriteLine("Salary: " + Salary);
		}
		public void InfAboutPosition(string position)
		{
			Console.WriteLine("Position: " + Position);
		}
		public double AverageSalary()
		{
			int sum = 0;
			int[] slr = new int[6] { 1000, 1500, 2000, 5000, 3000, 950 };
			for (int i = 0; i < slr.Length; i++)
			{
				sum += slr[i];
			}
			double avrslr = sum / slr.Length;
			return avrslr;
		}
		public override void AgeAnalyzer()
		{
			if (Age < 16) Console.WriteLine("This worker is a teenager.");
			else if (Age > 60) Console.WriteLine("This worker is a pensioner.");
		}
		public override void SalaryAnalyzer(string surname, double salary)
		{
			if (Salary < 1000) Console.WriteLine("Worker " + Surname + " has a scanty salary.");
			else if (Salary > 3000) Console.WriteLine("Worker " + Surname + " has a good salary.");
			else Console.WriteLine("Worker " + Surname + " has a normal salary.");
		}
	}
}
