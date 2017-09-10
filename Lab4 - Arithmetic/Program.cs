using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4___Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first integer: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter second integer: ");
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine($"sum is: {first + second}");
            Console.WriteLine($"product is: {first * second}");
            Console.WriteLine($"difference is: {first - second}");
            Console.WriteLine($"quotient is: {first / second}");
            Console.WriteLine($"remainder is: {first % second}");




        }
    }
}
