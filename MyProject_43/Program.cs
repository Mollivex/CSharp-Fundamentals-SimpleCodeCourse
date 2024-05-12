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
 *  MULTI-Dimensional arrays. 2D, 3D, 4D, 5D..ND etc. Jagged arrays
 *  ======================================================================================================================================================
 *  
 *  C# supports multidimensional arrays up to 32 dimensions. The multidimensional array can be declared by adding commas in the square brackets. 
 *      For example, [,] declares two-dimensional array, [, ,] declares three-dimensional array, [, , ,] declares four-dimensional array, and so on. 
 *      So, in a multidimensional array, no of commas = No of Dimensions - 1.
 *      
 *  The following declares multidimensional arrays:
 *  
 *                   int[,] array2D; // two-dimensional array
 *                   
 *                   int[, ,] array3D; // three-dimensional array
 *                   
 *                   int[, , ,] array4D ; // four-dimensional array
 *                   
 *                   int[, , , ,] array5D; // five-dimensional array
 *          
 *  Syntax EXAMPLE of 3D array:
 *  
 *                          int[,,] myArray = 
 *                          {
 *                              {
 *                                  {
 *                                     { 23, 42, 5 },
 *                                     { 51, 2, 3 }
 *                                  },
 *                          
 *                                  {
 *                                     { 3, 42, 85 },
 *                                    { 1, 82, 33 }
 *                                  },
 *                          
 *                                  {
 *                                     { 33, 32, 55 },
 *                                     { 21, 22, 37 }
 *                                  }
 *                              },
 *                      
 *                              {
 *                                  {
 *                                     { 83, 42, 5 },
 *                                     { 51, 2, 3 }
 *                                  },
 *                          
 *                                  {
 *                                     { 33, 2, 8 },
 *                                     { 13, 2, 33 }
 *                                  },
 *                          
 *                                  {
 *                                     { 3, 23, 55 },
 *                                     { 21, 22, 35 }
 *                                  }
 *                              }
 *                          };
 *  
 *  NOTE: Multi-dimensional array needs number of nested FOR loops equal to number of dimensions of an array (3D,4D,5D...)
 *  
 */

namespace MyProject_43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Random rnd = new Random();

                int[,,,] myArray = new int[rnd.Next(5), rnd.Next(10), rnd.Next(10), rnd.Next(10)];

                for (int i = 0; i < myArray.GetLength(0); i++)
                {
                    for (int j = 0; j < myArray.GetLength(1); j++)
                    {
                        for (int k = 0; k < myArray.GetLength(2); k++)
                        {
                            for(int l = 0; l < myArray.GetLength(3); l++)
                            {
                                myArray[i, j, k, l] = rnd.Next(100);
                            }
                        }
                    }
                }

                for (int i = 0; i < myArray.GetLength(0); i++)
                {
                    Console.WriteLine("\n========");
                    Console.WriteLine("Book " + (i+1));
                    Console.WriteLine("========");

                    for (int j = 0; j < myArray.GetLength(1); j++)
                    {
                        Console.WriteLine("\nPage " + (j + 1));

                        for (int k = 0; k < myArray.GetLength(2); k++)
                        {
                            for (int l = 0; l < myArray.GetLength(3); l++)
                            {
                                Console.Write(myArray[i, j, k, l] + " ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}
