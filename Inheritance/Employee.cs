using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_1
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
	class StaffMember : Employee
	{
		public int length_of_service;
		public double allowance;
		public StaffMember(string surname, int age, string position, double salary, int length_of_service, double allowance)
			: base(surname, age, position, salary)
		{
			Surname = surname;
			Age = age;
			Position = position;
			Salary = salary;
			this.length_of_service = length_of_service;
			this.allowance = allowance;
		}
		public void WriteAllInf()
		{
			Console.WriteLine("Information about the employee:\nSurname: " + Surname + "\nAge: " + Age + "\nPosition: " + Position + "\nSalary: " + Salary + "\nLength of service: " + length_of_service + "\nWork experience allowance: " + allowance);
		}
		public double TotalIncome(int length_of_service, double allowance)
		{
			double total_income = 0;
			total_income = length_of_service * allowance + Salary;
			return total_income;
		}
		public override void AgeAnalyzer()
		{
			if (Age< 16) Console.WriteLine("This employee is a teenager");
			else if (Age > 60) Console.WriteLine("This employee is retired");
		}
		public override void SalaryAnalyzer(string surname, double salary)
		{
			if (Salary < 1000) Console.WriteLine("Employee " + Surname + " has a meager salary");
			else if (Salary > 3000) Console.WriteLine("Employee "+ Surname + " has a good salary");
			else Console.WriteLine("Employee " + Surname + "  has a normal salary");
		}
	}
	class Worker : Employee
	{
		public Worker(string surname, int age, string position, double salary)
			: base(surname, age, position, salary)
		{
			Surname = surname;
			Age = age;
			Position = position;
			Salary = salary;
		}
		public void InfAboutPositionAndSalary(string position, double salary)
		{
			Console.WriteLine("Position: " + Position + "\nSalary: " + Salary);
		}
		public double AverageSalary()
		{
			int sum = 0;
			int[] slr = new int[6] { 1000, 2500, 5000, 3000, 1600, 950};
			for(int i = 0; i<slr.Length; i++)
			{
				sum += slr[i];
			}
			double avrslr = sum/slr.Length;
			return avrslr;
		}
		public override void AgeAnalyzer()
		{
			if (Age < 16) Console.WriteLine("This employee is a teenager");
			else if (Age > 60) Console.WriteLine("This employee is retired");
		}
		public override void SalaryAnalyzer(string surname, double salary)
		{
			if (Salary < 1000) Console.WriteLine("Employee " + Surname + " has a meager salary");
			else if (Salary > 3000) Console.WriteLine("Employee " + Surname + " has a good salary");
			else Console.WriteLine("Employee " + Surname + " has a normal salary");
		}
	}
}
