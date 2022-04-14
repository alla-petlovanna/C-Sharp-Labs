using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab4_1
{
	class Program
	{
		static void Main()
		{
			/* 
			   Task:
			   Implement the function of finding all prime numbers in the range from 1 to 51. 
			   Save the generated numbers in an array. Display the elements of the array on the console. 
			   When implementing, use the Eratosthenes algorithm.
			*/
			bool[] table = new bool[51];
			int i, j;
      
			for (i = 0; i < table.Length; i++)
				table[i] = true;
        
			for (i = 2; i * i < table.Length; i++)
				if (table[i])
					for (j = 2 * i; j < table.Length; j += i)
						table[j] = false;
            
			Console.WriteLine("Prime numbers in the range from 1 to 51:");
			for (i = 1; i < table.Length; i++)
			{
				if (table[i])
					Console.WriteLine(i);
			}
			Console.ReadKey();
		}
	}
}
