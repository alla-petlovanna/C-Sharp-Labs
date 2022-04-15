using System;
using System.Linq;

namespace Lab16_2
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] temp = new int[30];
			Random rand = new Random();
			for (int i = 0; i < temp.Length; i++)
				temp[i] = rand.Next(-5,5);
			Console.WriteLine("Temperature of the month:");
			foreach (int i in temp)
				Console.WriteLine(i);

			var selectedTemp = from i in temp
				where i > 0
				select i;

			Console.WriteLine("\nTemperature over 0:");
			foreach (int i in selectedTemp) Console.WriteLine(i);
			Console.ReadKey();
		}
	}
}
