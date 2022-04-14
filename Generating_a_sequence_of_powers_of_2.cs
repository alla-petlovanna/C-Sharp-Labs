using System;

namespace Lab3_4
{
	class Program
	{
		static void Main()
		{
			int number = 2;
			int n;
			double answer;
      
			Console.WriteLine("Enter n:");
			n = int.Parse(Console.ReadLine());
      
			Console.WriteLine("Result:");
			for (int i=1; i<=n; i++)
			{ 
				otvet = Math.Pow(number, i);
				Console.WriteLine(number + " in the "+ i +"rd power = " + answer);
			}
			Console.ReadKey();
		}
	}
}
