using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Завдання 1");
            Console.WriteLine("Введiть перше число:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть друге число:");
            double b = Convert.ToDouble(Console.ReadLine());
            Zavdannia_1(a, b);
            Console.WriteLine("Завдання 2");
            double c = Zavdannia_1(a, b);
            Zavdannia_2(a, b, c);
            Console.WriteLine("Завдання 3");
            Zavdannia_3();
            Console.WriteLine("Завдання 4");
            Zavdannia_4();
            Console.WriteLine("Завдання 5");
            Zavdannia_5();
            Console.ReadKey();
        }
        
        static double Zavdannia_1(double a, double b)
        {
            double c = a / b;
            Console.WriteLine("Частка двох дiйсних чисел = " + c);
            return c;
        }

        static void Zavdannia_2(double a, double b, double c)
        {
            double k = Math.Pow(c, 3.0);
            Console.WriteLine("Куб частки двох дiйсних чисел " + a + " i " + b + " = " + k);
        }

        static void Zavdannia_3()
        {
            Console.WriteLine("Введiть x:");
            double x = Convert.ToDouble(Console.ReadLine());
            double p = 3.5 * Math.Pow(x, 4.0) + 3 * Math.Pow(x, 3.0) + 10 * Math.Pow(x, 2.0) + 8.3;
            Console.WriteLine("Значення полiному p = " + p);
        }

        static void Zavdannia_4()
        {
            Console.WriteLine("Введiть вартiсть покупки:");
            double v = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть суму, що сплачує покупець:");
            double s = Convert.ToDouble(Console.ReadLine());
            double r = s - v;
            Console.WriteLine("Решта: " + r);
        }

        static void Zavdannia_5()
        {
            string surname = "Петльованна";
            string name = "Алла";
            int age = 18;
            string group = "I-02";
            int course = 2;
            string s = "Прiзвище: " + surname + ", iм'я: " + name + ", вiк: " + age + ", група: " + group + ", курс: " + course;
            Console.WriteLine(s);
        }
    }
}
