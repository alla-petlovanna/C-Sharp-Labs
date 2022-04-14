using System;

namespace Lab3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the first side of the triangle:");
            double side_a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the other side of the triangle:");
            double side_b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the third side of the triangle:");
            double side_с = double.Parse(Console.ReadLine());
            
            if (side_a + side_b < side_с | side_a + side_с < side_b | side_b + side_с < side_a)
                Console.WriteLine("It is impossible to construct a triangle");
            else
            {
                if (side_a == side_b & side_a == side_с & side_b == side_с)
                    Console.WriteLine("The triangle is equilateral");
                else if (side_a == side_b | side_a == side_с | side_b == side_с)
                    Console.WriteLine("The triangle is isosceles");
                else Console.WriteLine("The triangle is multifaceted");
            }
            Console.ReadKey();
        }
    }
}
