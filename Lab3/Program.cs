using System;

namespace Lab3
{
    class Program
    {
        static void Main()
        {
            double a, b, res;
            char proverka;
            do
            {
                Console.WriteLine("Введiть перший операнд:");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введiть знак операцiї");
                char op = (char)Console.Read();
                Console.ReadLine();
                Console.WriteLine("Введiть другий операнд:");
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
                if (ok) Console.WriteLine("Результат: " + res);
                else Console.WriteLine("Неприпустима операцiя");
                Console.WriteLine("Завершити роботу? Введiть y, iнакше enter");
                proverka = (char)Console.Read();
                Console.ReadLine();
            } while (proverka != 'y');



        }
    }
}