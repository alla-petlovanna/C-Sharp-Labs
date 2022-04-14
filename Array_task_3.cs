using System;

namespace lab4_3
{
	class Program
	{
		static void Main()
		{
			/*
			  Task:
			  Create a rectangular array of integers and initialize it when creating.
			  For each row of the array, calculate the number of elements that are over 10.
			*/
			Console.WriteLine("Enter the number of rows:");
			int n = int.Parse(Console.ReadLine());
      
			if (n > 0)
			{
				Console.WriteLine("Enter the number of columns:");
				int m = int.Parse(Console.ReadLine());
				if (m > 0)
				{
					int[,] array = new int[n, m];
					Random rand = new Random();
					int count = 0;
					Console.WriteLine("Array:");
					for (int i = 0; i < n; i++)
					{
						for (int j = 0; j < m; j++)
						{
							array[i, j] = rand.Next(-50, 50);
							Console.WriteLine("array [" + i + "," + j + "] = " + array[i, j]);
							if (array[i, j] > 10) count++;
						}
					}
					Console.WriteLine("Number of elements over 10: " + count);
					Console.ReadKey();
				}
				else
				{
					Console.WriteLine("Error");
					Console.ReadKey();
				}
			}
			else
			{
				Console.WriteLine("Error");
				Console.ReadKey();
			}
		}
	}
}
