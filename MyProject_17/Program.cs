using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ===============
 * ** for Loop **
 * ===============
 * 
 *      The for keyword indicates a loop in C#. The for loop executes a block of statements repeatedly 
 * until the specified condition returns false.
 * 
 *      Syntax:
 *      
 *          for (initializer; condition; iterator)
 *           {
 *              //code block to be executed
 *           }
 *           
 *   The for Loop contains the following three optional sections, separated by a semicolon:
 *
 *          Initializer: 
 *      
 *      The initializer section is used to initialize a variable that will be local to a for loop and cannot be accessed outside loop.
 *      It can also be zero or more assignment statements, method call, increment or decrement expression e.g., ++i or i++, and await expression.
 *
 *          Condition: 
 *   
 *      The condition is a boolean expression that will return either true or false. If an expression evaluates to true, then it will execute the loop again until the exception.
 *
 *          Iterator: 
 *   
 *      The iterator defines the incremental or decremental of the loop variable.          
 *           
 *   If a code block only contains a single statement, then you don't need to wrap it inside curly brackets { }
 * 
 */

namespace MyProject_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the limit value for your LOOP: ");
            int limit = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 0; i <= limit; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.ReadLine();

            /*  Comparison with while Loop syntax (EXAMPLE)
             *
             *       int limit = int.Parse(Console.ReadLine());
             *
             *       int i = 0;
             *
             *       while (i < limit)
             *       {
             *           i++;
             *           Console.WriteLine(i);
             *       }
             */
        }
    }
}
