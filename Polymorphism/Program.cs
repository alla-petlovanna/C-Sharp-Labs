using System;

namespace Lab8_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee emp = new Employee();
			emp.Surname = "Petlovanna";
			emp.Age = 19;
			emp.Position = "trainee";
			emp.Salary = 1000;

			emp.SalaryAnalyzer(emp.Surname, emp.Position, emp.Salary);
			emp.AgeAnalyzer();
			emp.SalaryAnalyzer(emp.Surname, emp.Salary);
			Console.ReadKey();
		}
	}
}

