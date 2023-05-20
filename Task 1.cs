using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static double ArithmeticMean(double num1, double num2)
        {
            return (num1+num2)/2;
        }
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The arithmetic mean of this numbers is {ArithmeticMean(num1, num2)}");

            Console.ReadKey(false);
        }
    }
}
