using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * Arrays
 * ======================================================================================================================================================
 * 
 *  #SimpleCode_HOMEWORK #5 (02).
 * 
 *  - Print reverse order of an array.
 *  
 * ======================================================================================================================================================
 *  
 */

namespace MyProject_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 414, 42, 33, 14, 534 };

            Console.Write("\nOriginal array: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("{0} ",myArray[i]);
            }

            Console.WriteLine();

            Console.Write("\nReversed array: ");
            for (int i = myArray.Length - 1; i >=0 ; i--)
            {
                Console.Write("{0} ",myArray[i]);
            }

            Console.WriteLine("\n");

        }
    }
}
