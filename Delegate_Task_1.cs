using System;

namespace Lab14_1
{
	public delegate double Method(double x);
	class Program
	{
        public static double Function_1(double x)
        {
            // F1(x) = sin^2*x , x > 0
            return Math.Sin(x) * Math.Sin(x);
        }
        public static double Function_2(double x)
        {
            //F2(x)= 1 - 2 * sin^2*x, x<=0
            return 1 - 2 * Math.Sin(x) * Math.Sin(x);
        }
        public static double Function_3(double x)
        {
            return 0;
        }
        static void Main(string[] args)
		{
            Console.WriteLine("Enter the number:");
            double x = double.Parse(Console.ReadLine());
            Method method;
            if (x > 0)
            {
                method = new Method(Function_1);
            }
            else if (x <= 0)
            {
                method = new Method(Function_2);
            }
            else
            {
                method = new Method(Function_3);
            }
            Console.WriteLine($"F(x) = {method(x)}");
            Console.ReadKey();
        }
    }
}
