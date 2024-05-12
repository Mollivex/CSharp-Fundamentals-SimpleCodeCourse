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
 *  #SimpleCode_HOMEWORK #5 (04).
 *  
 *  - Print the smallest and largest values in an array.
 *  
 * ======================================================================================================================================================
 *  
 */

namespace MyProject_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Original array: ");

            int[] myArray = { 511, 5122, 5213, 24, 235, 36, 537, 48, 92, 140, 121 };

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("{0} ",myArray[i]);
            }    

            Console.Write("\n\nThe smallest value in array: ");

            int minValue = myArray[0];

            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < minValue)
                {
                    minValue = myArray[i];
                }
            }
            Console.Write(minValue);

            Console.Write("\n\nThe largest value in array: ");

            int maxValue = myArray[0];

            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] > minValue)
                {
                    minValue = myArray[i];
                }
            }
            Console.Write(maxValue);

            Console.ReadLine();
        }
    }
}
