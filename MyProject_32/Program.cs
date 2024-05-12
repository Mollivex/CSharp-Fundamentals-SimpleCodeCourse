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
 *  #SimpleCode_HOMEWORK #5 (01).
 * 
 *  - Print entered data in the array by the user.
 *  
 * ======================================================================================================================================================
 *  
 */

namespace MyProject_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of your array: ");
            int elementCount = int.Parse(Console.ReadLine());

            int[] myArray = new int[elementCount];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"\nEnter element number {i}: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nArray output: ");
            for (int i = 0;i < myArray.Length;i++)
            {
                Console.Write("{0} ",myArray[i]);
            }
            Console.WriteLine("\n");
        }

    }
        
}
