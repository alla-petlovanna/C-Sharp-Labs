using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_1
{
	class Student
	{
		string name;
		int age;
		string role;
		int course;
		double rating;
		public Student(string name, int age, int course, double rating)
		{
			this.name = name;
			this.age = age;
			this.course = course;
			this.rating = rating;
		}
		public void EditStudent(string name, int age, double rating)
		{
			this.name = name;
			this.age = age;
			this.rating = rating;
		}
		public string GetRole(int course)
		{
			if (course <= 4)
				role = "bachelor";
			else if (course == 5 || course == 6)
				role = "master";
			else role = "not a student";
			return role;
		}
		public void StudentRating(double rating)
		{
			Console.WriteLine("Rating - " + rating);
		}
		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}
		public int Age
		{
			get
			{
				return age;
			}
			set
			{
				age = value;
			}
		}
		public int Course
		{
			get
			{
				return course;
			}
			set
			{
				course = value;
			}
		}
		public double Rating
		{
			get
			{
				return rating;
			}
			set
			{
				rating = value;
			}
		}
	} 
}
