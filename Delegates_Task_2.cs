using System;

namespace Lab14_2
{
	delegate void Method(string[] day_of_the_week);
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Enter the number of week day:");
            int num_of_the_day = int.Parse(Console.ReadLine());
            string[] schedule =
            {
                "1) Operating Systems\n2) Operating Systems",
                "1) Web-based Software Development\n2) Web-based Software Development\n3) Numerical Methods",
                "1) Algorithms and Data Structures\n2) Object-oriented Programming\n3) Algorithms and data structures",
                "1) Foreign Language\n2) Operating Systems",
                "1) Web-based Software Development\n2) Ecology",
                "Weekend",
                "Weekend"
            };
            Method name_of_the_day;
            switch (num_of_the_day)
            {
                case 1:
                    name_of_the_day = Monday;
                    break;
                case 2:
                    name_of_the_day = Tuesday;
                    break;
                case 3:
                    name_of_the_day = Wednesday;
                    break;
                case 4:
                    name_of_the_day = Thursday;
                    break;
                case 5:
                    name_of_the_day = Friday;
                    break;
                case 6:
                    name_of_the_day = Saturday;
                    break;
                case 7:
                    name_of_the_day = Sunday;
                    break;
                default:
                    name_of_the_day = Error;
                    break;
            }
            name_of_the_day(schedule);
            Console.ReadKey();
        }
        static void Monday(string[] schedule)
        {
            Console.WriteLine("Weekday: Monday");
            Console.WriteLine($"Timetable:\n{ schedule[0] }");
        }

        static void Tuesday(string[] schedule)
        {
            Console.WriteLine("Weekday: Tuesday");
            Console.WriteLine($"Timetable:\n{ schedule[1] }");
        }

        static void Wednesday(string[] schedule)
        {
            Console.WriteLine("Weekday: Wednesday");
            Console.WriteLine($"Timetable:\n{ schedule[2] }");
        }

        static void Thursday(string[] schedule)
        {
            Console.WriteLine("Weekday: Thursday");
            Console.WriteLine($"Timetable:\n{ schedule[3] }");
        }

        static void Friday(string[] schedule)
        {
            Console.WriteLine("Weekday: Friday");
            Console.WriteLine($"Timetable:\n{ schedule[4] }");
        }

        static void Saturday(string[] schedule)
        {
            Console.WriteLine("Weekday: Saturday");
            Console.WriteLine($"Timetable:\n{ schedule[5] }");
        }

        static void Sunday(string[] schedule)
        {
            Console.WriteLine("Weekday: Sunday");
            Console.WriteLine($"Timetable:\n{ schedule[6] }");
        }
        static void Error(string[] schedule)
        {
            Console.WriteLine("Wrong number");
        }
    }
}
