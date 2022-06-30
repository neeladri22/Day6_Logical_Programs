using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FibonacciSeries();
        }
        public static void FibonacciSeries()
        {
            int n1 = 0, n2 = 1, n3, num = 5;
            Console.WriteLine(n1 + " " + n2);

            for (int i = 2; i < num; ++i)
            {
                n3 = n1 + n2;
                Console.WriteLine("print the fibonnaci number :" + n3);
                n1 = n2;
                n2 = n3;
            }


        }
    }
}
