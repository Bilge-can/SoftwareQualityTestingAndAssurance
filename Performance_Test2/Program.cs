using System;
using System.Diagnostics;

namespace performans1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, toplam = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while(i <= 100)
            {
                toplam = toplam + i;
                i++;

            }
            Console.WriteLine("1den 100e kadar olan tam sayıların toplamı={0}", toplam);
            stopwatch.Stop();

            Console.WriteLine("while döngüsü gecen süre:" + stopwatch.Elapsed);


        }
    }
}

