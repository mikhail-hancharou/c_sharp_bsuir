using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fr = new Fraction(5, 15);
            fr.Show();
            Fraction fr1 = new Fraction(10, 30);
            fr1.Show();
            if (fr.CompareTo(fr1) == 0)
            {
                Console.WriteLine("== 0");
            }
            fr *= 3;
            fr.Show();
            fr /= 3;
            fr.Show();
            fr = -fr;
            fr.Show();
            fr = -fr;
            fr.Show();
            fr += fr1;
            fr.Show();
            Fraction.TryParse("55/66", out fr);
            fr.Show();
            Fraction.TryParse("55.77", out fr);
            fr.Show();
            Fraction.TryParse("55,88", out fr);
            fr.Show();
            Fraction.TryParse("55", out fr);
            fr.Show();
            Console.WriteLine(fr1.ToString("F", null));
            Console.WriteLine(fr1.ToString("F4", null));
            //Console.WriteLine(fr.ToDateTime());
        }
    }
}
