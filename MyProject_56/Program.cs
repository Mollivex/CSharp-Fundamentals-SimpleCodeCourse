using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ===================
 * #ref. HOWEWORK 7 #3
 * ===================
 * 
 *   - Write a methods to remove the first element, last element and defined element by index from an array
 * 
 */

namespace MyProject_56
{
    public class Program
    {
        /// <summary>
        /// Remove element from the array by specified index position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index"></param>
        static void RemoveAt(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
                newArray[i] = array[i];

            for (int i = index + 1; i < array.Length; i++)
                newArray[i - 1] = array[i];

            array = newArray;
        }

        /// <summary>
        /// Remove the first element from the array
        /// </summary>
        /// <param name="array"></param>
        static void RemoveFirst (ref int[] array)
        {
            RemoveAt(ref array, 0);
        }

        /// <summary>
        /// Remove the last element from the array
        /// </summary>
        /// <param name="array"></param>
        static void RemoveLast (ref int[] array)
        {
            RemoveAt(ref array, array.Length);
        }

        // We delegate RemoveAt method logic to the RemoveFirst and RemoveLast methods, which use the same logic and remove the first and the last element from the array.
        // See example above.

        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5 };

            RemoveAt(ref myArray, 2);
            RemoveFirst(ref myArray);
            RemoveLast(ref myArray);
        }
    }
}
