using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 *  Nested Loops
 * 
 *  EXAMPLE #1
 * 
 */

namespace MyProject_23
{
    class Program
    {
        static int[,] GetRandomArray(int rows, int columns)
        {
            Random rnd = new Random();
            var result = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = rnd.Next(100);
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int rows = 5;
            int columns = 10;
            var myArray = GetRandomArray(rows, columns);

            for (int i = 0;i < rows; i++)
            {
                for(int j = 0;j < columns; j++)
                {
                    Console.Write($"{myArray[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
