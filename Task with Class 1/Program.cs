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
			/* Task: 
			   Develop a console application for working with the class Student with fields: name, age, course, rating. Make all fields of the class closed and access them due to properties. Implement a constructor with parameters.
			   Create methods:
			   EditStudent for editing student data. The method has 3 parameters for changing the values of the fields name, age, rating.
			   StudentRating (double rating), which displays the student rating.
			   GetRole (int course) - returns a string: bachelor or master depending on the course. 
			*/
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
