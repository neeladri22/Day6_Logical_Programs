using System;
using System.Diagnostics;
using System.Threading;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            couponNumbers();
        }
        public static void couponNumbers()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[6];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            Console.WriteLine(stringChars);

        }
    }
}
