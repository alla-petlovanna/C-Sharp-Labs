using System;

namespace Lab15_1
{
    class Program
    {
        delegate double Del(double i);
        static void Main(string[] args)
        {
            double i;
            Console.WriteLine("Enter x:");
            while (!double.TryParse(Console.ReadLine(), out i))
            {
                Console.WriteLine("You had to enter a number");
                Environment.Exit(0);
            }
            Del del;
            if (i > 0)
            {
                del = i => Math.Sin(i) * Math.Sin(i);
            }
            else
            {
                del = i => 1 - 2 * Math.Sin(i) * Math.Sin(i);
            }
            Console.WriteLine($"F(x) = {del(i)}");
            Console.ReadKey();
        }
    }
}
