using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_1
{
	abstract class Employee
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
		public abstract void AgeAnalyzer();
		public abstract void SalaryAnalyzer(string surname, double salary);
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
			Console.WriteLine("Iнформацiя про службовця:\nФамiлiя: " + Surname + "\nВiк: " + Age + "\nПосада: " + Position + "\nЗарплата: " + Salary + "\nСтаж роботи: " + length_of_service + "\nНадбавка за стаж: " + allowance);
		}
		public double TotalIncome(int length_of_service, double allowance)
		{
			double total_income = 0;
			total_income = length_of_service * allowance + Salary;
			return total_income;
		}
		public override void AgeAnalyzer()
		{
			if (Age < 16) Console.WriteLine("Цей службовець пiдлiток");
			else if (Age > 60) Console.WriteLine("Цей службовець пенсiонер");
		}
		public override void SalaryAnalyzer(string surname, double salary)
		{
			if (Salary < 5000) Console.WriteLine("Службовець " + Surname + " має мiзерну зарплату");
			else if (Salary > 15000) Console.WriteLine("Службовець " + Surname + " має непогану зарплату");
			else Console.WriteLine("Службовець " + Surname + "  має таку собi зарплату");
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
			Console.WriteLine("Посада: " + Position + "\nЗарплата: " + Salary);
		}
		public double AverageSalary()
		{
			int sum = 0;
			int[] slr = new int[6] { 10000, 10500, 11000, 10300, 10600, 10600 };
			for (int i = 0; i < slr.Length; i++)
			{
				sum += slr[i];
			}
			double avrslr = sum / slr.Length;
			return avrslr;
		}
		public override void AgeAnalyzer()
		{
			if (Age < 16) Console.WriteLine("Цей робочий пiдлiток");
			else if (Age > 60) Console.WriteLine("Цей робочий пенсiонер");
		}
		public override void SalaryAnalyzer(string surname, double salary)
		{
			if (Salary < 5000) Console.WriteLine("Робочий " + Surname + " має мiзерну зарплату");
			else if (Salary > 15000) Console.WriteLine("Робочий " + Surname + " має непогану зарплату");
			else Console.WriteLine("Робочий " + Surname + " має таку собi зарплату");
		}
	}
}
