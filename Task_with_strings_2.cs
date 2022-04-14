using System;

namespace lab5_4
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			  Task:
			  Write an IsFloat procedure that checks for source code a correctly constructed floating point number.
			  Use the StringBuilder class to represent text.
			*/
           		string maxnum = "";
            		Console.WriteLine("Enter a line: ");
            		string s = Console.ReadLine();
            		int max = int.MinValue, val;
           		foreach (char c in s)
            		{
                		if (char.IsDigit(c) || c == '-')
                    			maxnum += c;
                		if (!char.IsDigit(c))
                		{
                    			if (int.TryParse(maxnum, out val))
                        			max = max < val ? val : max;
                    				maxnum = "";
                		}		
            		}
            		Console.WriteLine("The largest number: " + max);
            		Console.ReadKey();
        	}
	}
}
