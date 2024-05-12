using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 *  ======================================================================================================================================================
 *  TWO-dimensional arrays
 *  ======================================================================================================================================================
 *  
 *  - A multidimensional array is basically an array of arrays. Arrays can have any number of dimensions. The most common are two-dimensional arrays (2D).
 *  
 *  - To create a 2D array, add each array within its own set of curly braces {}, and insert a comma (,) inside the square brackets[]:
 *  
 *                           int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
 *  
 *  - Good to know: 
 *      The single comma [,] specifies that the array is two-dimensional. A three-dimensional array would have two commas: int[,,].
 *  
 *  - numbers is now an array with two arrays as its elements. The first array element contains three elements: 1, 4 and 2, while the second array element contains 3, 6 and 8. 
 *      To visualize it, think of the array as a table with rows and columns:
 *  
 *                                Column1  Column2  Column3
 *                          Row1     1       4       2
 *                          Row2     3       6       8
 *                        
 *  - Access Elements of a 2D Array:
 *      To access an element of a two-dimensional array, you must specify two indexes: one for the array, and one for the element inside that array. 
 *      Or better yet, with the table visualization in mind; one for the row and one for the column (see example below).
 *    
 *  - This statement accesses the value of the element in the first row (0) and third column (2) of the numbers array:
 *  
 *                          int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
 *                          
 *                          Console.WriteLine(numbers[0, 2]);  // Outputs 2
 *  
 *  - Remember that: 
 *      Array indexes start with 0: [0] is the first element. [1] is the second element, etc.
 *  
 *  - Change Elements of a 2D Array:
 *      You can also change the value of an element. The following example will change the value of the element in the first row (0) and first column (0):
 *    
 *                          int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
 *                          
 *                          numbers[0, 0] = 5;  // Change value to 5
 *                          
 *                          Console.WriteLine(numbers[0, 0]); // Outputs 5 instead of 1
 *  
 *  - Loop Through a 2D Array:
 *      You can easily loop through the elements of a two-dimensional array with a foreach Loop:
 *  
 *                          int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
 *                          
 *                          foreach (int i in numbers)
 *                          {
 *                            Console.WriteLine(i);
 *                          } 
 *                          
 *  - You can also use a for Loop. For multidimensional arrays, you need one loop for each of the array's dimensions.
 *      Also note that we have to use GetLength() instead of Length to specify how many times the loop should run:                        
 *                          
 *                          int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
 *                          
 *                          for (int i = 0; i < numbers.GetLength(0); i++) 
 *                          { 
 *                              for (int j = 0; j < numbers.GetLength(1); j++) 
 *                              { 
 *                                 Console.WriteLine(numbers[i, j]); 
 *                              } 
 *                          }  
 */

namespace MyProject_38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration of two-dimensional array:
            //      data_type [,] arrayName;

            int[,] myArray1 = new int[,] // operator new int[,] is not necessary to be written, compiler will create it ownself
            {
                { 123,42,52,32,12 },
                { 43,64,25,8,5 },
                { 41,7,9,9,34 }
            };
            Console.WriteLine(myArray1[0,2]);
            Console.WriteLine();

            // Initializing and printing a two-dimensional (2D) array:
            int[,] myArray2 =
            {
                { 2,42,5,12,45,6,3 },
                { 47,94,2,34,6,6,31 },
                { 41,2,56,84,7,65,4 },
                { 11,3,45,97,6,45,42 },
                { 52,64,78,57,4,23,2 }
            };

            //int height = myArray2.GetLength(0);
            //int width = myArray2.GetLength(1);

            /* nameArray.GetLength(n) - n represents number of dimension of an 2D array:
                                  (0) - is first dimension X (number of rows);
                                  (1) - is second dimension Y (number of columns) etc.;
             */

            for (int x = 0; x < myArray2.GetLength(0); x++)
            {
                for (int y = 0; y < myArray2.GetLength(1); y++)
                {
                    Console.Write(myArray2[x,y] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
