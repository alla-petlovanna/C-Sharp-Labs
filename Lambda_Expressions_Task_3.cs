using System;

namespace Lab15_3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the number:");
			int number = Convert.ToInt32(Console.ReadLine());
			Predicate<int> divisibleBy3 = delegate (int x)
			{
				if (number % 3 == 0)
				{
					Console.WriteLine("The number is divisible by 3");
					return true;
				}
				else
				{
					Console.WriteLine("The number is not divisible by 3");
					return false;
				}
			};
			divisibleBy3(number);
			Console.ReadKey();
		}
	}
}
