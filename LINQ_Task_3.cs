using System;
using System.Linq;

namespace Lab16_4
{
    class Program
    {
        class Auto
        {
            public string Model;
            public double Price;
            public int Year;
            public string Made;
            public Auto(string model, double price, int year, string made) =>
            (Model, Price, Year, Made) = (model, price, year, made);
        }
        static void Main(string[] args)
        {
            Auto[] autos = new Auto[]
            {
                new Auto("Volkswagen Golf", 36600, 2021, "Germany"),
                new Auto("Peugeot 208", 20043, 2021, "France"),
                new Auto("Renault Captur", 24536, 2021, "France"),
                new Auto("KIA Niro", 36000, 2021, "Korea"),
                new Auto("Hyundai Accent", 2500, 1998, "Korea"),
                new Auto("Hyundai Sonata Lux", 2499, 1997, "Korea"),
                new Auto("Hyundai Elantra Gold", 5900, 1998, "Korea"),
                new Auto("Lexus NX 200t F SPORT", 27000, 2016, "Japan"),
                new Auto("Ford Mustang", 25900, 2014, "USA"),
                new Auto("Volkswagen Tiguan", 53280, 2021, "Germany"),
            };
            var selAutos = from a in autos
                where a.Price <= 20000 && a.Year < 2000 && a.Made == "Korea"
                orderby a.Model
                select a;
            foreach (var a in selAutos)
            {
                Console.WriteLine($"Model: {a.Model}");
                Console.WriteLine($"Price: {a.Price}");
                Console.WriteLine($"Year: {a.Year}");
                Console.WriteLine($"Made: {a.Made}");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
