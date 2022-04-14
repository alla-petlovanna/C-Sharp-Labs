using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab10_1
{
	class Program
	{
		static void Main(string[] args)
		{
			StaffMember staff = new StaffMember("Williams", 25, "manager", 3000, 300);
			staff.Name = "Oliver";
			staff.Work_Exp = 4;
			staff.Role();
			staff.WriteAllInf();
			staff.Slr();
			staff.AgeAnalyzer();
			Console.WriteLine("Total income: " + staff.TotalIncome(staff.Work_Exp, staff.allowance));
			staff.SalaryAnalyzer(staff.Surname, staff.Salary);
			Console.WriteLine();

			Worker wrkr = new Worker("Peters", 61, "locksmith", 2000);
			wrkr.Name = "Jacob";
			wrkr.Work_Exp = 40;
			wrkr.Role();
			wrkr.InfAboutPosition(wrkr.Position);
			wrkr.Slr();
			wrkr.AgeAnalyzer();
			wrkr.SalaryAnalyzer(wrkr.Surname, wrkr.Salary);
			Console.WriteLine("Average salary for 6 months: " + wrkr.AverageSalary());
			Console.ReadKey();
		}
	}
}

