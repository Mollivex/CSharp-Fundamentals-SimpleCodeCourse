using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 *  Arrays
 *  
 *  ======================================================================================================================================================
 *  TWO-dimensional arrays. 
 *  ======================================================================================================================================================
 *  
 *  - Insert of random range of numbers.
 *  
 */

namespace MyProject_39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                int height, width, numberRange;
                try
                {
                    Console.Write("\nInsert the height of an array: ");
                    height = int.Parse(Console.ReadLine());

                    Console.Write("\nInsert the width of an array: ");
                    width = int.Parse(Console.ReadLine());

                    Console.Write("\nInsert the range of random numbers of an array: ");
                    numberRange = int.Parse(Console.ReadLine());    
                }
                catch (Exception)
                {
                    Console.WriteLine("\nInsert error! Try again!");
                    Console.ReadLine();
                    continue;
                }

                int[,] myArray = new int[height, width];

                Random random = new Random();

                for (int i = 0; i < myArray.GetLength(0); i++)
                {
                    for (int j = 0; j < myArray.GetLength(1); j++)
                    {
                        myArray[i, j] = random.Next(numberRange);
                    }
                }

                for (int y = 0; y < myArray.GetLength(0); y++)
                {
                    for (int x = 0; x < myArray.GetLength(1); x++)
                    {
                        Console.Write(myArray[y, x] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}
