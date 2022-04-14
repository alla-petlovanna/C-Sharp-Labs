using System;

namespace lab4_2
{
    class Program
    {
        static void Main()
        {
            /* 
               Task:
               Create an array that stores temperature data in one month. 
               Calculate the average temperature in a month.
            */
            double Sum = 0, Avr_temp;
            int days = 31; // There are 31 days in March
            double[] array = new double[days];
            Random rand = new Random();
            
            Console.WriteLine("Temperature in March:");
            for (int i = 0; i < days; i++)
            {
                array[i] = rand.Next(-5, 15);
                if (array[i] > 0) Console.Write("+" + array[i] + " ");
                else Console.Write(array[i] + " ");
                Sum += array[i];
            }
            
            Avr_temp = Sum / days;
            Console.Write("\nThe average temperature is equal to ");
            if (Avr_temp > 0) Console.Write("+");
            Console.Write(Avr_temp);
            Console.ReadKey();
        }
    }
}
