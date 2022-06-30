using System;
using System.Diagnostics;
using System.Threading;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartAndStopWatch();
        }
        public static void StartAndStopWatch()
        {
            Stopwatch stopW = new Stopwatch();
            stopW.Start();
            Thread.Sleep(1000);
            stopW.Stop();
            TimeSpan tspan = stopW.Elapsed;
            string elapsedTime = String.Format(" {0:00}:{1:00}:{2:00}.{3:00} ",
            tspan.Hours, tspan.Minutes, tspan.Seconds, tspan.Milliseconds / 10);
            Console.WriteLine(" RunTime " + elapsedTime);


        }
    }
}
