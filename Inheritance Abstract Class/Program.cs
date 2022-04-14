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
        Make the Employee class abstract and transfer the implementation of methods to derived classes.
      */
			StaffMember staff = new StaffMember("Williams", 25, "manager", 2500, 3, 300);
			staff.WriteAllInf();
			staff.AgeAnalyzer();
			Console.WriteLine("Total income: " + staff.TotalIncome(staff.length_of_service, staff.allowance));
			staff.SalaryAnalyzer(staff.Surname, staff.Salary);

			Worker wrkr = new Worker("Peters", 61, "locksmith", 3000);
			Console.WriteLine("\nInformation about the employee:");
			wrkr.AgeAnalyzer();
			wrkr.InfAboutPositionAndSalary(wrkr.Position, wrkr.Salary);
			wrkr.SalaryAnalyzer(wrkr.Surname, wrkr.Salary);
			Console.WriteLine("The average salary for 6 months: " + wrkr.AverageSalary());
			Console.ReadKey();
		}
	}
}

