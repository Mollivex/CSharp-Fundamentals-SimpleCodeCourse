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
 *  JAGGED arrays. (SHORTENED VERSION)
 *  ======================================================================================================================================================
 *  
 *  - Program to make a random jagged array with max.[20] strings and max.[20] elements with values max.[1000]   
 *  
 */

namespace MyProject_42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Random rnd = new Random();

                int[][] myArray = new int[rnd.Next(20)][];

                for (int i = 0; i < myArray.Length; i++)
                {
                    myArray[i] = new int[rnd.Next(20)];

                    for (int j = 0; j < myArray[i].Length; j++)
                    {
                        myArray[i][j] = rnd.Next(1000);
                        Console.Write(myArray[i][j] + "\t");
                    }
                    Console.WriteLine("\n");
                }
                Console.ReadLine();
            }
        }
    }
}
