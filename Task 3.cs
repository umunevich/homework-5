using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void WriteAnArray(int[,] arr, int num_l, int num_c)
        {
            for (int i = 0; i < num_l; i++)
            {
                for (int j = 0; j < num_c; j++)
                {
                    Console.Write($"{arr[i, j]} " );
                }
                Console.WriteLine();
            }
        }
        static int[,] ChangeArray(int[,] arr, int num_l, int num_c)
        {
            int[,] newarr = new int[num_l, num_c];
            for (int i = 0; i<num_c; i++)
            {
                newarr[0, i]= arr[num_l-1, i];
            }
            for (int i = 1; i<num_l; i++)
            {
                for (int j = 0; j<num_c; j++)
                {
                    newarr[i, j] = arr[i-1, j];
                }
            }

            return newarr;
        }
        static void Main(string[] args)
        {
            int Lines, Columns;
            Console.WriteLine("Enter a size of 2 dimensional array: ");
            Console.Write("Number of lines - ");
            Lines = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of columns - ");
            Columns = Convert.ToInt32(Console.ReadLine());
            int[,] array2D = new int[Lines, Columns];

            Console.WriteLine("Enter an array: ");
            for (int i = 0; i < Lines; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    array2D[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Entered array: ");
            WriteAnArray(array2D, Lines, Columns);

            int[,] ChangedArray = ChangeArray(array2D, Lines, Columns);

            Console.WriteLine("Changed array: ");
            WriteAnArray(ChangedArray, Lines, Columns);

            Console.ReadKey(false);
        }
    }
}
