using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * Arrays
 * ======================================================================================================================================================
 * Arrays and Loops. Output of array. Iteration of array
 * ======================================================================================================================================================
 * 
 *  For the iterations of arrays we can use every type of Loops , but often used only \for or \foreach Loops.
 * 
 */

namespace MyProject_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 12, 214, 53, 54, 34, 33, 2 };

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.ReadLine();
        }
    }
}
