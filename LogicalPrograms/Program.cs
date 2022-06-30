using System;
using System.Diagnostics;
using System.Threading;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = dayofweek(05, 10, 2000);

            switch (day)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;

            }

            Console.Write(day);

        }

        private static int dayofweek(int d, int m, int y)
        {
            int[] t = { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };

            y -= (m < 3) ? 1 : 0;

            return (y + y / 4 - y / 100 + y / 400 + t[m - 1] + d) % 7;
        }
    }
}
