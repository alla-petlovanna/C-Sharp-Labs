using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_1
{

	class Program
	{
		static void Main(string[] args)
		{
			Student stud = new Student("Alla", 18, 2, 95);
			string stRole = stud.GetRole(2);
			Console.WriteLine("This student is a " + stRole);
			stud.StudentRating(95);
			stud.EditStudent("Alla", 19, 97);
			string studentName = stud.Name;
			Console.WriteLine("Updated data about student:");
			Console.WriteLine("Name - " + stud.Name);
			Console.WriteLine("Age - " + stud.Age);
			Console.WriteLine("Course - " + stud.Course);
			Console.WriteLine("Rating - " + stud.Rating);
			Console.ReadKey();
		}
	}
}
