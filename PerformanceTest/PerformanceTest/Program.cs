using System;
using System.Diagnostics;

namespace perfomans1
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 1; i<=100; i++)
            {
                toplam = toplam + i;

            }
            Console.WriteLine("1den 100e kadar olan tam sayıların toplamı={0}, toplam");
            stopwatch.Stop();

            Console.WriteLine("for dongüsü gecen süre: " + stopwatch.Elapsed);
    

        }
    }
}