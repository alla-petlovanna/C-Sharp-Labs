using System;

namespace Lab14_3
{
	delegate T Del<T>(T first_number, T second_number);
	class Program
	{
		static void Main(string[] args)
		{
            /* 
              Under the condition of the problem, it is necessary to work with integers and real numbers.
              I chose the double type because it allows you to work with both integers and real numbers.
            */
            Del<double> del;
            Console.Write("Enter the first number: ");
            double firstN = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double secondN = double.Parse(Console.ReadLine());
            del = Plus<double>;
            Console.WriteLine($"{firstN} + {secondN} = {del(firstN, secondN)}");
            del = Minus<double>;
            Console.WriteLine($"{firstN} - {secondN} = {del(firstN, secondN)}");
            del = Multiply<double>;
            Console.WriteLine($"{firstN} * {secondN} = {del(firstN, secondN)}");
            del = Divide<double>;
            Console.WriteLine($"{firstN} / {secondN} = {del(firstN, secondN)}");
            Console.ReadKey();
        }
        public static double Plus<T>(T first_number, T second_number)
        {
            return Convert.ToDouble(first_number) + Convert.ToDouble(second_number);
        }
        public static double Minus<T>(T first_number, T second_number)
        {
            return Convert.ToDouble(first_number) - Convert.ToDouble(second_number);
        }
        public static double Multiply<T>(T first_number, T second_number)
        {
            return Convert.ToDouble(first_number) * Convert.ToDouble(second_number);
        }
        public static double Divide<T>(T first_number, T second_number)
        {
            return Convert.ToDouble(first_number) / Convert.ToDouble(second_number);
        }
    }
}
