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
            reverseNumber();
        }
        public static void reverseNumber()
        {
            int revnum, reverse = 0, rem;
            Console.Write("Enter a number: ");
            revnum = int.Parse(Console.ReadLine());
            while (revnum != 0)
            {
                rem = revnum % 10;
                reverse = reverse * 10 + rem;
                revnum /= 10;
            }
            Console.Write("Reversed Number: " + reverse);





        }
    }
}
