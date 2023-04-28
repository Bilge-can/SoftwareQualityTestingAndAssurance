using System;
using System.Diagnostics;

namespace FibonacciPerformans
{
    class Program
    {
        static void Main(string[] args)
        {
            long x = 0;
            long y = 1;
            long z = 0;
            int adimSayisi = 150;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < adimSayisi - 2; i++)
            {
                z = x + y;
                x = y;
                y = z;
            }
            stopwatch.Stop();
            Console.WriteLine("For düngüsü ile toplam geçen zaman: " + stopwatch.Elapsed);

            long a = 0;
            long b = 1;
            long c = 0;
            int j = 0;
            stopwatch.Start();
            while (j < adimSayisi - 2)
            {
                c = a + b;
                a = b;
                b = c;
                j++;
            }
            stopwatch.Stop();
            Console.WriteLine("While döngüsü ile toplam geçen zaman: " + stopwatch.Elapsed);
            Console.ReadLine();
        }
    }
}
