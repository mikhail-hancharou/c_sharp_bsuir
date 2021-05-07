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
            Fraction f1 = new Fraction(15, 65);
            Fraction f2 = new Fraction(44, 12);
            Fraction temp;
            temp = f1 * f2;
            Console.WriteLine($"f1 * f2 = {temp.GetDoubleType()}");
            temp = f1 / f2;
            Console.WriteLine($"f1 / f2 = {temp.GetDoubleType()}");
            temp = f1 + f2;
            Console.WriteLine($"f1 + f2 = {temp.GetDoubleType()}");
            temp = f1 - f2;
            Console.WriteLine($"f1 - f2 = {temp.GetDoubleType()}");
            Console.WriteLine($"f1 > f2 = {f1 > f2}");
            Console.WriteLine($"f1 < f2 = {f1 < f2}");
            Console.WriteLine($"f1 >= f2 = {f1 >= f2}");
            Console.WriteLine($"f1 <= f2 = {f1 <= f2}");
            Console.WriteLine($"f1 == f2 = {f1 == f2}");
            Console.WriteLine($"f1 != f2 = {f1 != f2}");
            Console.WriteLine("Testing string to object");
            temp = Fraction.Parse("350/100");
            Console.WriteLine($"testF = 350/150 = {temp.GetDoubleType()}");
            temp = Fraction.Parse("1000");
            Console.WriteLine($"testF = 1000 = {temp.GetDoubleType()}");
            temp = Fraction.Parse("350.100");
            Console.WriteLine($"testF = 350.150 = {temp.GetDoubleType()}");
            temp = Fraction.Parse("350,100");
            Console.WriteLine($"testF = 350,150 = {temp.GetDoubleType()}");
            Console.WriteLine("Testing conversion operators and IConvertible");
            Console.WriteLine($"f1.ToBoolean = {f1.ToBoolean(null)}");
            Console.WriteLine($"f1.GetTypeCode = {f1.GetTypeCode()}");
            Console.WriteLine($"f1.ToDouble = {f1.ToDouble(null)}");
            Console.WriteLine($"f1.ToInt32 = {f1.ToInt32(null)}");
            Console.WriteLine((short)fr);
            Console.WriteLine((int)fr);
            Console.WriteLine((long)fr);
        }
    }
}
