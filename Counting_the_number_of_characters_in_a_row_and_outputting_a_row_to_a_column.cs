using System;

namespace lab5_1
{
	class Program
	{
		static void Main(string[] args)
		{
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
