using System;

namespace Lab13_1
{
	class Program
	{
		static void Swap<T>(ref T lhs, ref T rhs)
		{
			T temp;
			temp = lhs;
			lhs = rhs;
			rhs = temp;
		}
		static void Main(string[] args)
		{
			double a = 1.2;
			double b = 2.5;
			Console.WriteLine("Data of type double before conversion:");
			Console.WriteLine("a = " + a + " b = " + b);
			Swap<double> (ref a, ref b);
			Console.WriteLine("Data of type double after conversion:");
			Console.WriteLine("a = " + a + " b = " + b);
			string c = "one";
			string d = "two";
			Console.WriteLine("Data of type string before conversion:");
			Console.WriteLine("c = " + c + " d = " + d);
			Swap<string>(ref c, ref d);
			Console.WriteLine("Data of type string after conversion:");
			Console.WriteLine("c = " + c + " d = " + d);
			Console.ReadKey();
		}
	}
}
