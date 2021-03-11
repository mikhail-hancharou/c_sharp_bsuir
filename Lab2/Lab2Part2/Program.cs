using System;

namespace Lab2Part2
{
    class Program
    {
        static void Main()
        {
            ulong firstDigit = 0, secondDigit = 0, powAmount = 0;
            Console.Write("Enter the first digit: ");
            while (!ulong.TryParse(Console.ReadLine(), out firstDigit))
            {
                Console.WriteLine("Try again");
            }
            Console.Write("Enter the second digit(more then the first): ");
            while (!ulong.TryParse(Console.ReadLine(), out secondDigit))
            {
                Console.WriteLine("Try again");
            }
            for (ulong i = 1; i < 64; i++)
            {
                if (firstDigit != 0)
                {
                    powAmount += FindPow(firstDigit - 1, i, secondDigit);
                }
                else
                {
                    powAmount += FindPow(firstDigit, i, secondDigit);
                }
            }
            Console.WriteLine("Max degree of 2 is {0}", powAmount);
            Console.ReadKey();
        }

        static ulong FindPow(ulong value, ulong i, ulong valueEnd)
        {
            ulong amount = 0;
            ulong helpDegree = 1;
            for (ulong n = 0; n < i; n++)
            {
                helpDegree *= 2;
            }
            for (ulong n = 1; n < 64; n++)
            {
                if (value + 1 <= valueEnd)
                {
                    value++;
                }
                else
                {
                    break;
                }
                if (value % helpDegree == 0)
                {
                    amount = ((valueEnd - value) / helpDegree) + 1;
                    break;
                }
            }
            return amount;
        }
    }
}
