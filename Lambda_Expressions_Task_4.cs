using System;

namespace Lab15_4
{
	class Program
	{
        delegate bool Del(string word);
        static void Main(string[] args)
		{
            string word = "computer";
            Del del = answer =>
            {
                string text = "A computer is a machine that performs logical and mathematical operations on data and outputs results in a form understood by humans or machines. The first computers were used mainly for mathematical calculations and performed the operations of addition, multiplication, division, etc.";
                if (text.Contains(word))
                {
                    Console.WriteLine("This word is in the text");
                    return true;
                }
                else
                {
                    Console.WriteLine("This word is not in the text");
                    return false;
                }
            };
            del(word);
            Console.ReadKey();
        }
	}
}
