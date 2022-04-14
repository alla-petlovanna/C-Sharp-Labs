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
		public void Salary()
		{
			Console.WriteLine("Salary: " + Salary);
		}
		public void WriteAllInf()
		{
			Console.WriteLine("Вiк: " + Age + "\nПосада: " + Position + "\nСтаж роботи: " + Stag_Rob + "\nНадбавка за стаж: " + allowance);
		}
		public double TotalIncome(int Stag_Rob, double allowance)
		{
			double total_income = 0;
			total_income = Stag_Rob * allowance + Salary;
			return total_income;
		}
		public override void AgeAnalyzer()
		{
			if (Age < 16) Console.WriteLine("Цей службовець пiдлiток.");
			else if (Age > 60) Console.WriteLine("Цей службовець пенсiонер.");
		}
		public override void SalaryAnalyzer(string surname, double salary)
		{
			if (Salary < 5000) Console.WriteLine("Службовець " + Surname + " має мiзерну зарплату.");
			else if (Salary > 15000) Console.WriteLine("Службовець " + Surname + " має непогану зарплату.");
			else Console.WriteLine("Службовець " + Surname + "  має таку собi зарплату.");
		}
	}
}
