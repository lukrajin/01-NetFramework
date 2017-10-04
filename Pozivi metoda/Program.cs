using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PoziviMetoda
{
    class Program
    {
        static void NekaMetoda()
        {
            int sum = 0;
            for (int i = 0; i < 1000; ++i)
                ++sum;
        }

        static void Main(string[] args)
        {
            // lista u koju pohranjujemo trajanja izvođenja dijelova koda
            List<TimeSpan> timespans = new List<TimeSpan>();
            // štoperica
            Stopwatch stopWatch = new Stopwatch();

            // prvi poziv metode
            stopWatch.Restart();
            NekaMetoda();
            stopWatch.Stop();
            timespans.Add(stopWatch.Elapsed);

            // ponovno pozivamo metodu 50 puta
            stopWatch.Restart();
            for (int i = 0; i < 50; ++i)
                NekaMetoda();
            stopWatch.Stop();
            timespans.Add(stopWatch.Elapsed);

            // još jednom pozivamo metodu
            stopWatch.Restart();
            NekaMetoda();
            stopWatch.Stop();
            timespans.Add(stopWatch.Elapsed);

            // ispisujemo trajanja
            Console.WriteLine("Brojevi otkucaja:");
            foreach (var ts in timespans)
                Console.WriteLine(ts.Ticks);

            Console.ReadKey();
        }
    }
}
