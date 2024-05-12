using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ===================
 * #ref. HOWEWORK 7 #2
 * ===================
 * 
 *   - Write a methods, that ADD elements to the beginning, to the ending and to specified index position in the array
 * 
 */

namespace MyProject_55
{
    public class Program
    {
        /// <summary>
        /// Insert element by specified index position in the array
        /// </summary>
        /// <param name="arrayName"></param>
        /// <param name="elementIndex"></param>
        /// <param name="newElement"></param>
        static void Insert(ref int[] arrayName, int elementIndex, int newElement)
        {
            int[] newArray = new int[arrayName.Length + 1];
            newArray[elementIndex] = newElement;

            for (int i = 0; i < elementIndex; i++)
                newArray[i] = arrayName[i];
            for (int i = elementIndex; i < newArray.Length - 1; i++)
                newArray[i + 1] = arrayName[i];

            arrayName = newArray;
        }

        /// <summary>
        /// Adding element to the beginning in the array
        /// </summary>
        /// <param name="arrayName"></param>
        /// <param name="newElement"></param>
        static void AddFirst(ref int[] arrayName, int newElement)
        {
            int[] newArray = new int[arrayName.Length + 1];
            newArray[0] = newElement;

            for (int i = 0; i < arrayName.Length && i < newArray.Length; i++)
                newArray[i + 1] = arrayName[i];

            arrayName = newArray;
        }
        static void AddFirstSimple(ref int[] arrayName, int newElement)
        {
            Insert(ref arrayName, 0, newElement);
        }

        /// <summary>
        /// Adding element to the ending in the array
        /// </summary>
        /// <param name="arrayName"></param>
        /// <param name="newElement"></param>
        static void AddLast(ref int[] arrayName, int newElement)
        {
            int[] newArray = new int[arrayName.Length + 1];
            newArray[newArray.Length - 1] = newElement;

            for (int i = 0; i < arrayName.Length && i < newArray.Length; i++)
                newArray[i] = arrayName[i];

            arrayName = newArray;
        }
        static void AddLastSimple(ref int[] arrayName, int newElement)
        {
            Insert(ref arrayName, arrayName.Length, newElement);
        }

        // Insert method logic can be used in the AddFirst and AddLast methods to add elements to the beginning and ending of an array.
        // It is neccesary to make a connection between by the reference to the Insert method. See example above AddFirstSimple/AddLastSimple

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                int[] myArray1 = { 41, 22, 3, 62, 34, 43, 1, 23, 98 };
                int[] myArray2 = myArray1;
                int[] myArray3 = myArray2;
                int addValue, addIndex;

                try
                {
                    Console.Write("\nEnter the value you want to add: ");
                    addValue = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Input error! Try again!");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("\nFirst method - Adding element to the beginning in the array: ");
                AddFirst(ref myArray1, addValue);
                for (int i = 0; i < myArray1.Length; i++)
                {
                    Console.Write(myArray1[i] + " ");
                }
                Console.WriteLine("");

                Console.WriteLine("\n\nSecond method - Adding element to the ending in the array: ");
                AddLast(ref myArray2, addValue);
                for (int i = 0; i < myArray2.Length; i++)
                {
                    Console.Write(myArray2[i] + " ");
                }

                try
                {
                    Console.Write("\n\nEnter the index number to add element: ");
                    addIndex = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Input error! Try again!");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("\nThird method - Adding element by specified index position in the array: ");
                Insert(ref myArray3, addIndex, addValue);
                for (int i = 0; i < myArray3.Length; i++)
                {
                    Console.Write(myArray3[i] + " ");
                }

                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
