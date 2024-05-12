using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ================================
 * Recursion in C# | HOMEWORK #8_02
 * ================================
 * 
 *  -!- Create an application which finds the array elemets SUM with a recursive methods.
 * 
 */

namespace MyProject_64
{
    class Program
    {

        static int Sum(int[] array, int i = 0)
        {
            if (i >= array.Length)
                return 0;

            return array[i] + Sum(array, i + 1);
        }

        static void Main(string[] args)
        {
            int[] array = { 2 , 5, 8, 7 };
            Console.WriteLine(Sum(array));
        }
    }
}
