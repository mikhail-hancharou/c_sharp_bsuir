using System;

namespace Lab2Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            string your, help = null;
            Console.WriteLine("Enter your string");
            your = Console.ReadLine();
            int i = your.Length;
            int rightIndex = i, leftIndex;
            while (i > 0)
            {
                if (your[i - 1] == ' ' || i == 1)
                {
                    leftIndex = i - 1;
                    if (i == 1)
                    {
                        help += ' ';
                    }
                    help += your.Substring(leftIndex, rightIndex - leftIndex);
                    rightIndex = leftIndex;
                }
                i--;
            }
            your = help;
            Console.WriteLine(your);
            Console.ReadLine();
        }
    }
}
