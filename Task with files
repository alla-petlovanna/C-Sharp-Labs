using System;
using System.IO;

namespace Lab6_2
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Enter information about the book in the line to write to the file:");
            string text = Console.ReadLine();

            using (FileStream fstream = new FileStream(@"note.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                fstream.Write(array, 0, array.Length);
                Console.WriteLine("The text is saved in the file");
            }

            using (FileStream fstream = File.OpenRead(@"note.txt"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine("Text from the file: {0}", textFromFile);
            }
            Console.ReadKey();
        }
	}
}
