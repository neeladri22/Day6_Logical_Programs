using System;
using System.Diagnostics;
using System.Threading;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahre;

            Console.WriteLine("Press 0 to Convert Celsius to Fahrenheit Press 1 for Fahrenheit to Celsius ");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 0:
                    Console.WriteLine("Enter Celcius:");
                    double celsius = double.Parse(Console.ReadLine());
                    fahre = (celsius * 9 / 5) + 32;
                    Console.WriteLine("Fahrenheit: " + fahre);
                    break;

                case 1:
                    Console.WriteLine("Enter Fahrenheit:");
                    double fahrenheit = double.Parse(Console.ReadLine());
                    celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine("Celcius: " + celsius);
                    break;
                default:
                    break;

            }

        }   
    }
}
