using System;

namespace lab5_3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a first last name:");
			string a = Console.ReadLine();

			Console.WriteLine("Enter a second last name:");
			string b = Console.ReadLine();

			if (a.Length > b.Length) Console.WriteLine("The longest last name of the two: " + a + "\nLength of the last name: " + a.Length);
			if (a.Length < b.Length) Console.WriteLine("The longest last name of the two: " + b + "\nLength of the last name: " + b.Length);
			if (a.Length == b.Length) Console.WriteLine("Last names are equal in length");
			Console.ReadKey();
		}
	}
}
