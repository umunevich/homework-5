using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int MaxEl(int[] arr)
        {
            int max = arr[0];
            foreach (int i in arr)
            {
                if (max < i)
                {
                    max = i;
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            int size;
            Console.Write("Enter the size of array: ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter an array: ");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"The element of maximum value is {MaxEl(arr)}");

            Console.ReadKey(false);
        }
    }
}
