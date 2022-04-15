using System;
using System.Collections;

namespace Lab13_2
{
	class Program
	{
		static void Main(string[] args)
		{
            /*
              Task: 
              Write a generic max and min element search method in an array of integers and in an array of valid numbers.
            */
            (T max, T min) MinMax<T>(T[] numbers)
            {
                T min = numbers[0]; 
                T max = numbers[0];
                // max
                for (int i = 0; i < numbers.Length; i++)
                {
                    if ((numbers[i] as IComparable).CompareTo(max) > 0) max = numbers[i];
                }
                //min
                for (int i = 0; i < numbers.Length; i++)
                {
                    if ((numbers[i] as IComparable).CompareTo(min) < 0) min = numbers[i];
                }
                return (max, min);
            }

            int[] numbersInt = { 8, 10, 3, 6 };
            (int max, int min) i_pair = MinMax(numbersInt);
            Console.WriteLine("int:");
            Console.WriteLine($"max = {i_pair.max}, min = {i_pair.min}");

            double[] numbersDouble = { 0.1, 0.5, 1.8, 0.3 };
            (double max, double min) d_pair = MinMax(numbersDouble);
            Console.WriteLine("double:");
            Console.WriteLine($"max = {d_pair.max}, min = {d_pair.min}");
            Console.ReadKey();
        }
	}
}
