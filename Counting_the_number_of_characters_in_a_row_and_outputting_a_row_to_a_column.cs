using System;

namespace lab5_1
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			  Task:
			  Enter the name of the football club. Count the number of characters in it.
			  Display the name of the club on the console in a column (1 character per line).
			*/
			Console.WriteLine("Enter the name of the football club: ");
			string teamName = Console.ReadLine();
      
			Console.WriteLine("Number of characters: " + teamName.Length);
      
			Console.WriteLine("You entered: ");
			int count = 0;
			for (int i = 0; i < teamName.Length; i++)
			{
				Console.WriteLine(teamName[i]);
			}
			Console.ReadKey();
		}
	}
}
