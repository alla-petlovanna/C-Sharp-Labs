using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_2_and_3
{
	class Faculty
	{
		public partial class Chair
		{
			public string Faculty_Name { get; set; }
			public int Number_of_Teachers { get; set; }
			public Chair()
			{

			}
		}
		partial class Chair
		{
			public void SetName(string name)
			{
				Faculty_Name = name;
			}
			public void Input_Number_of_Teachers()
			{
				Console.WriteLine("Enter the number of teachers of the department:");
				Number_of_Teachers = Convert.ToInt32(Console.ReadLine());
			}
		}

		Chair[] chr = new Chair[2];

		public Chair this[int index]
		{
			get { return chr[index]; }
			set { chr[index] = value; }
		}
		public Faculty()
		{
			chr[0] = new Chair();
			chr[1] = new Chair();
		}

		public void SetData()
		{
			Console.WriteLine("Enter the name of the first department:");
			chr[0].SetName(Console.ReadLine());
			chr[0].Input_Number_of_Teachers();
			Console.WriteLine("\nEnter the name of the second department:");
			chr[1].SetName(Console.ReadLine());
			chr[1].Input_Number_of_Teachers();
			Console.WriteLine("Faculty: Computer Science");
			Console.WriteLine("Departments: " + chr[0].Faculty_Name + " and " + chr[1].Faculty_Name + ", " + chr[0].Number_of_Teachers + " and " + chr[1].Number_of_Teachers + " teachers.");
		}
	}
}
