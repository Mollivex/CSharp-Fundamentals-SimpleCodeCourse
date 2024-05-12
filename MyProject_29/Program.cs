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
 *  One dimensional arrays. Types of initialization of arrays.
 *  ======================================================================================================================================================
 *  
 *      You can initialize the elements of an array when you declare the array. The length specifier isn't needed because it's inferred by the number 
 *  of elements in the initialization list. For example:
 *  
 *                                          int[] array1 = new int[] { 1, 3, 5, 7, 9 };
 * 
 *      The following code shows a declaration of a string array where each array element is initialized by a name of a day:
 * 
 *                                          string[] weekDays = new string[] {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};
 * 
 *      You can avoid the new expression and the array type when you initialize an array upon declaration, as shown in the following code. 
 *  This is called an implicitly typed array. For example:
 * 
 *                                          int[] array2 = { 1, 3, 5, 7, 9 };
 *                                          string[] weekDays2 = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
 * 
 *      You can declare an array variable without creating it, but you must use the new operator when you assign a new array to this variable. For example:
 *      
 *                                          int[] array3;
 *                                          array3 = new int[] { 1, 3, 5, 7, 9 };   // OK
 *                                          //array3 = {1, 3, 5, 7, 9};   // Error
 * 
 */

namespace MyProject_29
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] myArrayOne = Enumerable.Repeat(4,5).ToArray(); // Creates an array of elements with the same value (Ex: 5 elements with value 4)

            int[] myArrayTwo = Enumerable.Range(5, 5).ToArray(); /* Creates an array of elements with increasing values for 1, starting 
                                                                  * from input number (Ex: 5 elements with increasing values for 1, start with 5) */

            Console.ReadLine();
        }
    }
}
