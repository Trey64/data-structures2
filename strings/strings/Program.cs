using System;

namespace data_structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word to be reversed");
            string input = Console.ReadLine();

            string reverse = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse += input[i];
            }
            Console.WriteLine(reverse);
            Console.Read();
        }
    }
}