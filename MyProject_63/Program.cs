using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ================================
 * Recursion in C# | HOMEWORK #8_01
 * ================================
 * 
 *  -!- Create an application which realize the array output with a recursive methods.
 *      
 */

namespace MyProject_63
{
    class Program
    {
        /// <summary>
        /// Print array to console
        /// </summary>
        /// <param name="array"></param>
        /// <param name="i"></param>
        static void PrintArray(int[] array, int i = 0)
        {
            if (i < array.Length)
            {
                Console.WriteLine(array[i]);
                PrintArray(array, i + 1);
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 8, 3, 6 };

            PrintArray(array);
        }
    }
}
