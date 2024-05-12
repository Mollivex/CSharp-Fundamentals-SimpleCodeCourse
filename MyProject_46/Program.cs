using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

/*
 *  =========================
 *  #_FUNCTIONS AND METHODS_#
 *  =========================
 *  HOMEWORK #6_02:
 *  
 *      - To write the method for finding array's element (array's data type is - int), method must return the first index element found (if it will be found);
 */

namespace MyProject_46
{
    class Program
    {
        static int[] GetRandomArray(uint length, int minValueRange, int maxValueRange)
        {
            Random rnd = new Random();

            int[] arrayName = new int[length];

            for (int i = 0; i < arrayName.Length; i++)
            {
                arrayName[i] = rnd.Next(minValueRange,maxValueRange);
            }
            return arrayName;
        }
        static int IndexOf(int[] arrayName, int indexValue)
        {
            for (int i = 0; i < arrayName.Length; i++)
            {
                if (arrayName[i] == indexValue)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                try
                {
                    Console.Write("Enter the size of your array: ");
                    uint arraySize = uint.Parse(Console.ReadLine());

                    Console.Write("\nEnter the minimal value of an array's range: ");
                    int minRangeValue = int.Parse(Console.ReadLine());

                    Console.Write("\nEnter the maximal value of an array's range: ");
                    int maxRangeValue = int.Parse(Console.ReadLine());

                    Console.Write("\nYour array is: ");
                    int[] myArray = GetRandomArray(arraySize, minRangeValue, maxRangeValue);

                    for (int i = 0; i < myArray.Length; i++)
                    {
                        Console.Write(myArray[i] + " ");
                    }

                    Console.Write("\n\nEnter the number, which index you want to find in your array: ");
                    int indexElement = int.Parse(Console.ReadLine());

                    int result = IndexOf(myArray, indexElement);

                    if (result != -1)
                    {
                        Console.WriteLine("\nIndex of element you need is: " + result);
                    }
                    else
                    {
                        Console.WriteLine("\nElement not found");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nInput error! Please, try again");
                    Console.ReadLine();
                    continue;
                }
                Console.ReadLine();
            }
        }
    }
}
