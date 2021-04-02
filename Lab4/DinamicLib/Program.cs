using System;
using System.Runtime.InteropServices;

namespace MathClient
{
    class Program
    {
        [DllImport("../../UnmanagedCode.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int Sum(int a, int b);
        [DllImport("../../UnmanagedCode.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int Subtraction(int a, int b);
        [DllImport("../../UnmanagedCode.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int Multiply(int a, int b);
        [DllImport("../../UnmanagedCode.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int Division(int a, int b);
        [DllImport("../../UnmanagedCode.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int Pow(int a, int power);
        [DllImport("../../UnmanagedCode.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int Mod(int a, int b);
        [DllImport("../../UnmanagedCode.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Abs(int a);
        [DllImport("../../UnmanagedCode.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Min(int a, int b);
        [DllImport("../../UnmanagedCode.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Max(int a, int b);
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(14, 23));
            Console.WriteLine(Subtraction(10, 30));
            Console.WriteLine(Multiply(8, 4));
            Console.WriteLine(Division(8, 4));
            Console.WriteLine(Pow(2, 2));
            Console.WriteLine(Mod(8, 3));
            Console.WriteLine(Abs(-55));
            Console.WriteLine(Min(44, 33));
            Console.WriteLine(Max(44, 33));
            Console.ReadKey();
        }
    }
}