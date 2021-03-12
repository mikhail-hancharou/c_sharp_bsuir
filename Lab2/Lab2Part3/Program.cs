using System;
using System.Text;

namespace Lab2Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder helpString = new StringBuilder();
            Console.WriteLine("Enter your string");
            string yourString;
            yourString = Console.ReadLine();
            string[] words = yourString.Split(' ');
            for (int i = words.Length - 1; i >= 0; i--)
            {
                helpString.Append(words[i]);
                helpString.Append(' ');
            }
            yourString = helpString.ToString();
            Console.WriteLine(yourString);
            Console.ReadLine();
        }
    }
}
