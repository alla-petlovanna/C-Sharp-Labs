using System;

namespace lab5_5
{
	class Program
	{
        static void Main(string[] args)
        {
            char[] sumbs = new char[] { '+', '-', '*', '/' };
            string st;
            string[] arr;
            Console.WriteLine("To exit the program, enter exit");
            do
            {
                Console.WriteLine("Calculate: ");
                st = Console.ReadLine();
                try
                {
                    arr = st.Split(sumbs);
                    int i = st.IndexOfAny(sumbs);
                    char ch = st[i];
                    double a = double.Parse(arr[0]);
                    double b = double.Parse(arr[1]);
                    double res = 0;
                    switch (ch)
                    {
                        case '+':
                            res = a + b;
                            break;
                        case '-':
                            res = a - b;
                            break;
                        case '*':
                            res = a * b;
                            break;
                        case '/':
                            res = a / b;
                            break;
                        default:
                            Console.WriteLine("No operation sign found");
                            break;
                    }
                    Console.WriteLine("Result: " + res);
                }
                catch
                {
                    Console.WriteLine("Calculation error");
                }
            }
            while (st != "exit");
        }
    }
}
