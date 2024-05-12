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
 *  #SimpleCode_HOMEWORK #5 (03).
 *  
 *  - Print the sum of even values in an array.
 *  
 * ======================================================================================================================================================
 *  
 */

namespace MyProject_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Original array: ");

            int[] myArray = { 21, 244, 215, 512, 2, 4421, 2, 343, 344, 11 };

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("{0} ",myArray[i]);
            }

            int result = 0;
            Console.Write("\n\nSum of EVEN numbers of an original array: ");

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                    result += myArray[i];
            }
            Console.Write(result);


            Console.WriteLine("\n");
        }
    }
}
