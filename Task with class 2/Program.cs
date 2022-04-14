using System;

namespace Lab7_2
{
	class Program
	{
		static void Main(string[] args)
		{
      /*
         Task:
         Develop an Employee class with 4 fields: surname, age, position, salary and two methods.
         The first method displays a concatenated string on the console entered data.
         The second method checks the age and displays various consoles messages.
         Implement access to fields via get and set. Implement the constructor without parameters, and initialize the fields due to properties in the program code.
      */
			Employee emp = new Employee();
			emp.Surname = "Petlovanna";
			emp.Age = 19;
			emp.Position = "trainee";
			emp.Salary = 1500;

			emp.InfOutput(emp.Surname);
			emp.AgeAnalyzer();
			Console.WriteLine("Position: " + emp.Position);
			Console.WriteLine("Salary: " + emp.Salary);
			Console.ReadKey();
		}
	}
}
