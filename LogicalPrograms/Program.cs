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
            primeNumber();
        }
        public static void primeNumber()
        {
            Console.Write("Enter a Number : ");
            int number1 = int.Parse(Console.ReadLine());
            bool IsPrime = true;
            for (int i = 2; i < number1 / 2; i++)
            {
                if (number1 % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime)
            {
                Console.Write("Number is Prime.");
            }
            else
            {
                Console.Write("Number is not Prime.");
            }






        }
    }
}
