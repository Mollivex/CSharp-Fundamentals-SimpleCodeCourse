using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ===================
 * #ref. HOWEWORK 7 #1
 * ===================
 * 
 *   - Write a Resize method, that modify number of the elements of the array.
 *    (the method must be able to increase and decrease the number of array elements)
 * 
 */

namespace MyProject_54
{
    public class Program
    {
        /// <summary>
        /// Modify number of elements of the random elements array
        /// </summary>
        /// <param name="arrayName"></param>
        /// <param name="sizeOfArray"></param>
        static void ResizeRandom(ref int[] arrayName, int sizeOfArray)
        {
            arrayName = new int[sizeOfArray];
        }

        /// <summary>
        /// Modify (to increase / to decrease) number of elemets array 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="newSize"></param>
        static void ResizeSimple<T>(ref T[] array, int newSize)
        {
            T[] newArray = new T[newSize];
            for (int i = 0; i < array.Length && i < newArray.Length; i++)
            {
                newArray[i] = array[i]; 
            }
            array = newArray;
            //THIS METHOD IS GENERIC TYPE - CAN MAKE ARRAYS FOR ANY DATA TYPES, NOT ONLY INT TYPES!!!
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Random rnd = new Random();

                //Homework_01. (DONE by myself, and it's actually differs from #SimpleCode version)
                Console.Write("Enter the size of an original array: ");
                int sizeOrigArr = int.Parse(Console.ReadLine());
                int[] origArray = new int[sizeOrigArr];

                Console.WriteLine("\nThe original array is: ");
                for (int i = 0; i < origArray.Length; i++)
                {
                    origArray[i] = rnd.Next(100);
                    Console.Write("{0} ", origArray[i]);
                }

                Console.Write("\n\nEnter the new size of your: ");
                int sizeOfNew = int.Parse(Console.ReadLine());

                ResizeRandom(ref origArray, sizeOfNew);

                Console.WriteLine("\nThe new array is: ");
                for (int i = 0; i < origArray.Length; i++)
                {
                    origArray[i] = rnd.Next(100);
                    Console.Write("{0} ", origArray[i]);
                }

                //#SimpleCode Version example Homework_01 (modifying an current array - to increase/ to decrease the number of elements)
                Console.WriteLine("\n=======================================");
                Console.WriteLine("#SimpleCode Homework_01 EXAMPLE");

                Console.WriteLine("\n#simpleArray is: ");
                int[] simpleArray = { 23, 41, 5, 2 };

                for (int i = 0; i < simpleArray.Length; i++)
                {
                    Console.Write(simpleArray[i] + " ");
                }

                Console.Write("\n\nEnter new number of elements of #simpleArray: ");
                int newSize = int.Parse(Console.ReadLine());

                ResizeSimple(ref simpleArray, newSize);

                Console.WriteLine("\nNEW #simpleArray is: ");
                for (int i = 0; i < simpleArray.Length; i++)
                {
                    Console.Write(simpleArray[i] + " ");
                }
                Console.ReadLine();
            }
        }
    }
}
