using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Work_Space Work = new Work_Space();
			Console.WriteLine("Employees:");
			foreach (Employee empl in Work)
			{
				Console.WriteLine(empl);
			}
			Console.WriteLine();
			Array.Sort(Work.employee_mass, new Employee_Comparer());
			Console.WriteLine("Sorted by work experience at this company:");
			foreach (Employee empl in Work)
			{
				Console.WriteLine(empl);
			}
			Console.ReadKey();
		}
	}
}
