using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_1
{
	class Program
	{
		static void Main(string[] args)
		{
      /*
        Task:
        Develop a hierarchy of classes: Employee, Clerk, Worker. Develop constructors and methods for working with every class. 
        In the base class Employee and in derivatives make a constructor with parameters.
        Develop two virtual methods in the base class and their implementation in each of the derived classes.
        In the derivative class Employee add two properties: work experience and allowance (additional salary).
        Initialize the values of the fields and properties of both the base and derived class in the class constructor (via base).
        Create 2 own methods. The first method without parameters displays all data on the console about the employee (from basic and derivative classes).
        The second method is a function of type double, takes 2 parameters: work experience and allowance. It calculates total income (salary + allowance) and returns the calculated result to main.
        Call all methods from main and display the results on the console. In the derivative class Worker create 2 own methods with parameters.
        The first method: Transfer as parameters the position and salary of the worker and display them on the console.
        The second method is a function without input parameters. Returns 1 double result. Calculates the average salary for 6 months and returns it to main. 
        Create a salary array for 6 months and calculate the average salary. Call method from main and display the result on the console.
        In the program in main create 1 object of derived classes, using constructors with parameters. Call every developed methods (virtual and conventional). 
        Output results on the console.
      */
			StaffMember staff = new StaffMember("Williams", 25, "manager", 2000, 3, 300);
			staff.WriteAllInf();
			staff.AgeAnalyzer();
			Console.WriteLine("Total income: " + staff.TotalIncome(staff.length_of_service, staff.allowance));
			staff.SalaryAnalyzer(staff.Surname, staff.Salary);

			Worker wrkr = new Worker("Peters", 61, "locksmith", 2500);
			Console.WriteLine("\nInformation about the employee:");
			wrkr.AgeAnalyzer();
			wrkr.InfAboutPositionAndSalary(wrkr.Position, wrkr.Salary);
			wrkr.SalaryAnalyzer(wrkr.Surname, wrkr.Salary);
			Console.WriteLine("The average salary for 6 months: " + wrkr.AverageSalary());
			Console.ReadKey();
		}
	}
}

