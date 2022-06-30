using System;
using System.Diagnostics;
using System.Threading;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Amount for Change needed");
            int amount = int.Parse(Console.ReadLine());
            countCurrency(amount);
        }
        public static void countCurrency(int amount)
        {
            int[] notes = new int[] { 1000, 500, 200, 100, 50, 10, 5, 2, 1 };
            int[] noteCounter = new int[9];

            // count notes 
            for (int i = 0; i < 9; i++)
            {
                if (amount >= notes[i])
                {
                    noteCounter[i] = amount / notes[i];
                    amount = amount - noteCounter[i] * notes[i];
                }
            }

            // Print notes
            Console.WriteLine("Currency Count -");
            for (int i = 0; i < 9; i++)
            {
                if (noteCounter[i] != 0)
                {
                    Console.WriteLine(notes[i] + " : "
                        + noteCounter[i]);
                }
            }
        }
    }
}
