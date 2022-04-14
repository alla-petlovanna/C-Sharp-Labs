using System;

namespace lab5_2
{
    class Program
    {
        static bool isFloat(string str)
        {
            float n;
            return float.TryParse(String.Join("", str), out n) ? true : false;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the source text: ");
            string str = Console.ReadLine();
            Console.WriteLine("Is this text a floating point number: " + isFloat(str));
            Console.ReadKey(true);
        }
    }
}
