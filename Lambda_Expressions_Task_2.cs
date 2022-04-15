using System;

namespace Lab15_2
{
	class Program
	{
		static void Main()
		{
			Func<int, int, int, int> sum = (x1, x2, x3) => x1 + x2 + x3;
			Console.WriteLine("Result: " + sum(1, 2, 3));
			Console.ReadKey();
		}
    }
}
