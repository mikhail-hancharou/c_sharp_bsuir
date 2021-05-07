using System;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Fraction : IComparable<Fraction>, IFormattable, IConvertible
    {
        private long Numerator;
        private long Denumerator;

        public Fraction(long num, long denum)
        {
            NumeratorReal = Numerator = num;
            DenumeratorReal = Denumerator = denum;
        }

        public Fraction(long num)
        {
            NumeratorReal = Numerator = num;
            DenumeratorReal = Denumerator = 1;
        }

        private long num;
        public long NumeratorReal
        {
            get => num;
            set
            {
                num = value;
                if (denum != 0 && num != 0)
                {
                    long gcd = GCD(Math.Abs(denum), Math.Abs(num));
                    denum /= gcd;
                    num /= gcd;
                }
            }
        }

        private long denum;
        public long DenumeratorReal
        {
            get => denum;
            set
            {
                denum = value;
                if (denum == 0)
                    throw new ArgumentException("division by zero impossible");
                if (num != 0)
                {
                    long gcd = GCD(Math.Abs(denum), Math.Abs(num));
                    denum /= gcd;
                    num /= gcd;
                }
            }
        }

        private static long GCD(long firstDigit, long secondDigit)
        {
            long min = Min(firstDigit, secondDigit);
            long max = Max(firstDigit, secondDigit);
            if (min != 0)
                return GCD(max - min, min);
            return max;
        }

        private static long SCM(long firstDigit, long secondDigit)
        {
            return (firstDigit * secondDigit) / GCD(firstDigit, secondDigit);
        }

        private static long Min(long lhs, long rhs) => lhs < rhs ? lhs : rhs;

        private static long Max(long firstDigit, long secondDigit)
        {
            return firstDigit > secondDigit ? firstDigit : secondDigit;
        }

        public override string ToString()
        {
            return ToString("F", null);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (string.IsNullOrEmpty(format))
            {
                format = "F";
            }
            if (format == "F")
            {
                double output = (double)num / denum;
                return output.ToString();
            }
            else if (format == "D")
            {
                long output = num / denum;
                return output.ToString();
            }
            else if (new Regex(@"F\d*").IsMatch(format))
            {
                double output = (double)num / denum;
                return output.ToString("F" + format[1..]);
            }
            else if (new Regex(@"D\d*").IsMatch(format))
            {
                long output = num / denum;
                return output.ToString("D" + format[1..]);
            }
            else
            {
                throw new ArgumentException("incorrect format");
            }
        }

        public static explicit operator sbyte(Fraction fract)
        {
            return fract.ToSByte(null);
        }
        public static explicit operator short(Fraction fract)
        {
            return fract.ToInt16(null);
        }
        public static explicit operator int(Fraction fract)
        {
            return fract.ToInt32(null);
        }
        public static explicit operator long(Fraction fract)
        {
            return fract.ToInt64(null);
        }
        public static explicit operator float(Fraction fract)
        {
            return fract.ToSingle(null);
        }
        public static explicit operator double(Fraction fract)
        {
            return fract.ToDouble(null);
        }
        public static explicit operator decimal(Fraction fract)
        {
            return fract.ToDecimal(null);
        }

        public static Fraction Parse(string number)
        {
            Fraction fraction;
            if (TryParse(number, out fraction))
            {
                return fraction;
            }
            else
            {
                throw new ArgumentException("incorrect format");
            }
        }

        public static bool TryParse(string number, out Fraction f)
        {
            f = null;
            string pattern1 = @"^(\d*)/(\d*)$";
            string pattern2 = @"^\d*$";
            string pattern3 = @"^(\d*)\.|\,(\d*)$";
            if (Regex.IsMatch(number, pattern1))
            {
                string[] words = number.Split(new char[] { '/' });
                long numerator = long.Parse(words[0]);
                long denumerator = long.Parse(words[1]);
                f = new Fraction(numerator, denumerator);
                return true;
            }
            else if (Regex.IsMatch(number, pattern2))
            {
                long numerator = long.Parse(number);
                long denumerator = 1;
                f = new Fraction(numerator, denumerator);
                return true;
            }
            else if (Regex.IsMatch(number, pattern3))
            {
                string[] words = number.Split(new char[] { '.', ',' });
                int size = words[1].Length;
                long numerator = long.Parse(words[0]);
                long denumerator = long.Parse(words[1]);
                numerator = (numerator * (long)Math.Pow(10, size) + denumerator);
                f = new Fraction(numerator, (long)Math.Pow(10, size));
                return true;
            }
            else
            {
                return false;
            }
        }

        public double GetDoubleType()
        {
            return (double)num / denum;
        }

        public int CompareTo(Fraction fraction)
        {
            long numHelpOne, numHelpTwo;
            long scm = SCM(DenumeratorReal, fraction.DenumeratorReal);
            numHelpOne = scm / DenumeratorReal * NumeratorReal;
            numHelpTwo = scm / fraction.DenumeratorReal * fraction.NumeratorReal;
            return numHelpOne > numHelpTwo ? 1 :
                numHelpOne < numHelpTwo ? -1 : 0;
        }

        public void Show()
        {
            Console.WriteLine("{0}, {1}, {2}, {3}", Numerator, Denumerator, NumeratorReal, DenumeratorReal);
        }

        public override bool Equals(object obj)
        {
            if (obj is Fraction fraction && CompareTo(fraction) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            int hashCode;
            hashCode = 10032003 * num.GetHashCode();
            hashCode /= 385;
            return hashCode;
        }

        public TypeCode GetTypeCode()
        {
            return TypeCode.Object;
        }

        public static Fraction operator *(Fraction lhs, int rhs)
        {
            return new Fraction(lhs.Numerator * rhs, lhs.Denumerator);
        }

        public static Fraction operator *(Fraction lhs, Fraction rhs)
        {
            return new Fraction(lhs.Numerator * rhs.Numerator, lhs.Denumerator * rhs.Denumerator);
        }

        public static Fraction operator /(Fraction lhs, Fraction rhs)
        {
            return new Fraction(lhs.Numerator * rhs.Denumerator, rhs.Numerator * lhs.Denumerator);
        }

        public static Fraction operator /(Fraction lhs, int rhs)
        {
            return new Fraction(lhs.Numerator, rhs * lhs.Denumerator);
        }

        public static Fraction operator -(Fraction rhs)
        {
            return rhs * new Fraction(-1);
        }

        public static Fraction operator +(Fraction lhs, Fraction rhs)
        {
            long numHelp;
            long scm = SCM(lhs.DenumeratorReal, rhs.DenumeratorReal);
            numHelp = (scm / lhs.DenumeratorReal * lhs.NumeratorReal) + (scm / rhs.DenumeratorReal * rhs.NumeratorReal);
            return new Fraction(numHelp, scm);
        }

        public static Fraction operator -(Fraction lhs, Fraction rhs) => lhs + (-rhs);

        public static bool operator <(Fraction lhs, Fraction rhs) => lhs.CompareTo(rhs) < 0;

        public static bool operator <=(Fraction lhs, Fraction rhs) => lhs.CompareTo(rhs) <= 0;

        public static bool operator >(Fraction lhs, Fraction rhs) => lhs.CompareTo(rhs) > 0;

        public static bool operator >=(Fraction lhs, Fraction rhs) => lhs.CompareTo(rhs) >= 0;

        public static bool operator ==(Fraction lhs, Fraction rhs) => lhs.CompareTo(rhs) == 0;

        public static bool operator !=(Fraction lhs, Fraction rhs) => lhs.CompareTo(rhs) != 0;

        public bool ToBoolean(IFormatProvider provider) => Numerator != 0;

        public byte ToByte(IFormatProvider provider) => Convert.ToByte(GetDoubleType());

        public char ToChar(IFormatProvider provider) => Convert.ToChar(GetDoubleType());

        public DateTime ToDateTime(IFormatProvider provider) => Convert.ToDateTime(GetDoubleType());

        public decimal ToDecimal(IFormatProvider provider) => Convert.ToDecimal(GetDoubleType());

        public double ToDouble(IFormatProvider provider) => GetDoubleType();

        public short ToInt16(IFormatProvider provider) => Convert.ToInt16(GetDoubleType());

        public int ToInt32(IFormatProvider provider) => Convert.ToInt32(GetDoubleType());

        public long ToInt64(IFormatProvider provider) => Convert.ToInt64(GetDoubleType());

        public sbyte ToSByte(IFormatProvider provider) => Convert.ToSByte(GetDoubleType());

        public float ToSingle(IFormatProvider provider) => Convert.ToSingle(GetDoubleType());

        public string ToString(IFormatProvider provider) => ToString("F", provider);

        public object ToType(Type conversionType, IFormatProvider provider) => Convert.ChangeType(GetDoubleType(), conversionType);

        public ushort ToUInt16(IFormatProvider provider) => Convert.ToUInt16(GetDoubleType());

        public uint ToUInt32(IFormatProvider provider) => Convert.ToUInt32(GetDoubleType());

        public ulong ToUInt64(IFormatProvider provider) => Convert.ToUInt64(GetDoubleType());
    }
}