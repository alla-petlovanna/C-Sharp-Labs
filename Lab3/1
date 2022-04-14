using System;

namespace Lab3
{
    class Program
    {
        static void Main()
        {
            double a, b, res;
            char check;
            do
            {
                Console.WriteLine("Enter the first operand:");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the operation sign:");
                char op = (char)Console.Read();
                Console.ReadLine();
                Console.WriteLine("Enter the second operand:");
                b = double.Parse(Console.ReadLine());
               
                bool ok = true;
                switch (op)
                {
                    case '+': res = a + b; break;
                    case '-': res = a - b; break;
                    case '*': res = a * b; break;
                    case '/': res = a / b; break;
                    default: res = double.NaN; ok = false; break;
                }
                
                if (ok) Console.WriteLine("Result: " + res);
                else Console.WriteLine("Invalid operation");
                
                Console.WriteLine("Finish work? Enter y, otherwise enter");
                check = (char)Console.Read();
                Console.ReadLine();
            } while (check != 'y');
        }
    }
}
