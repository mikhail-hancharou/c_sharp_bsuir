using System;

namespace Lab2Part1
{
    class Data
    {
        DateTime now = DateTime.Now;
        int[] AmountOfDigit = new int[10];
        void CalculateAmountOfDigit()
        {
            int[] DataAndTime = new int[6];
            DataAndTime[0] = now.Year;
            DataAndTime[1] = now.Month;
            DataAndTime[2] = now.Day;
            DataAndTime[3] = now.Hour;
            DataAndTime[4] = now.Minute;
            DataAndTime[5] = now.Second;
            for (int i = 0; i < 6; i++)
            {
                int flag = 0;
                while (DataAndTime[i] > 0)
                {
                    flag++;
                    AmountOfDigit[DataAndTime[i] % 10]++;
                    DataAndTime[i] /= 10;
                }
                if (flag == 1)
                {
                    AmountOfDigit[0]++;
                }
            }
        }

        public void ShowDataAndTime()
        {
            Console.WriteLine(now.ToString("dd.MM.yyyy HH:mm:ss"));
            Console.WriteLine(now.ToString("F"));
        }

        public void ShowAmountOfDigit()
        {
            CalculateAmountOfDigit();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Amount of {0}: {1}", i, AmountOfDigit[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Data todayData = new Data();
            todayData.ShowDataAndTime();
            todayData.ShowAmountOfDigit();
            Console.ReadKey();
        }
    }
}