using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab10_1
{
	class StaffMember : Employee, IEmp
	{
		public double allowance;
		public string Name { get; set; }
		public int Work_Exp { get; set; }
		public StaffMember(string surname, int age, string position, double salary, double allowance)
			: base(surname, age, position, salary)
		{
			Surname = surname;
			Age = age;
			Position = position;
			Salary = salary;
			this.allowance = allowance;
		}
		public void Role()
		{
			Console.WriteLine("Information about the employee:\n" + Name + " " + Surname);
		}
		public void Slr()
		{
			Console.WriteLine("Salary: " + Salary);
		}
		public void WriteAllInf()
		{
			Console.WriteLine("Age: " + Age + "\nPosition: " + Position + "\nWork experience: " + Work_Exp + "\nAllowance: " + allowance);
		}
		public double TotalIncome(int Work_Exp, double allowance)
		{
			double total_income = 0;
			total_income = Work_Exp * allowance + Salary;
			return total_income;
		}
		public override void AgeAnalyzer()
		{
			if (Age < 16) Console.WriteLine("This employee is a teenager.");
			else if (Age > 60) Console.WriteLine("This employee is retired.");
		}
		public override void SalaryAnalyzer(string surname, double salary)
		{
			if (Salary < 5000) Console.WriteLine("Employee " + Surname + " має мізерну зарплатуhas a scanty salary.");
			else if (Salary > 15000) Console.WriteLine("Службовець " + Surname + " має непогану зарплату.");
			else Console.WriteLine("Службовець " + Surname + "  має таку собi зарплату.");
		}
	}
}
