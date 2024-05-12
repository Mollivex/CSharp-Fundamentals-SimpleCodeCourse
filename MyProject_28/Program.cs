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
 *  ONE-dimensional arrays
 *  ======================================================================================================================================================
 *  
 *      The one dimensional array or single dimensional array in C# is the simplest type of array that contains 
 *  only one row for storing data. It has single set of square bracket (“[]”).
 *  
 *      Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value.
 *  To declare an array, define the variable type with square brackets:
 *  
 *                  string[] cars;
 *                  
 *      We have now declared a variable that holds an array of strings.To insert values to it, we can use an array 
 *  literal - place the values in a comma-separated list, inside curly braces:
 *  
 *                  string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
 *   
 *      To create an array of integers, you could write:
 * 
 *                  int[] myNum = {10, 20, 30, 40};
 * 
 * ======================================================================================================================================================
 *   Access the Elements of an Array
 * ======================================================================================================================================================  
 *   
 *      You access an array element by referring to the index number. This statement accesses the value of the first element in cars:
 *      
 *                  string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
 *                  
 *                  Console.WriteLine(cars[0]); // Outputs Volvo
 * 
 *      Note: Array indexes start with 0: [0] is the first element. [1] is the second element, etc.
 *      
 * ======================================================================================================================================================
 *   Change an Array Element
 * ======================================================================================================================================================
 * 
 *      To change the value of a specific element, refer to the index number: cars[0] = "Opel";
 * 
 *                  string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
 *                  cars[0] = "Opel";
 *                  Console.WriteLine(cars[0]);
 *                  // Now outputs Opel instead of Volvo
 * 
 * ======================================================================================================================================================
 *   Array Length
 * ======================================================================================================================================================
 * 
 *      To find out how many elements an array has, use the Length property:
 *      
 *                  string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
 *                  Console.WriteLine(cars.Length);
 *                  // Outputs 4
 * 
 * ======================================================================================================================================================
 *   Other Ways to Create an Array
 * ======================================================================================================================================================
 * 
 *      If you are familiar with C#, you might have seen arrays created with the new keyword, and perhaps you have seen arrays with a specified size as well. 
 *  In C#, there are different ways to create an array:
 * 
 *                  // Create an array of four elements, and add values later
 *                  string[] cars = new string[4];
 * 
 *                  // Create an array of four elements and add values right away 
 *                  string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};
 * 
 *                  // Create an array of four elements without specifying the size 
 *                  string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};
 * 
 *                  // Create an array of four elements, omitting the new keyword, and without specifying the size
 *                  string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
 * 
 *      It is up to you which option you choose. In our tutorial, we will often use the last option, as it is faster and easier to read.
 *  However, you should note that if you declare an array and initialize it later, you have to use the new keyword:
 * 
 *                  // Declare an array
 *                  string[] cars;
 *                  
 *                  // Add values, using new
 *                  cars = new string[] {"Volvo", "BMW", "Ford"};
 *                  
 *                  // Add values without using new (this will cause an error)
 *                  cars = {"Volvo", "BMW", "Ford"};
 * 
 */

namespace MyProject_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray;

            myArray = new int[5];

            myArray[1] = 1313;

            int secondElementArray = myArray[1];

            Console.WriteLine("Value of second element of array: " + ++secondElementArray);
            
            Console.WriteLine("Lenght of array is: " + myArray.Length);
            
            Console.ReadLine();
        }
    }
}
