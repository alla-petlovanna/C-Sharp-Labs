using System;

namespace Lab3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            double c = double.Parse(Console.ReadLine());
            
            if (a != b & a != c & b != c)
            {
                if (a > b & a > c)
                    Console.WriteLine("The product of the two smallest numbers b and c: " + b * c);
                else if (b > a & b > c)
                    Console.WriteLine("The product of the two smallest numbers a and c: " + a * c);
                else Console.WriteLine("The product of the two smallest numbers a and b: " + a * b);
            }
            else Console.WriteLine("The numbers must be different");
            Console.ReadKey();
        }
    }
}
