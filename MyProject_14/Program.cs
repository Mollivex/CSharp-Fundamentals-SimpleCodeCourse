using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*
 * ==================
 *  ** while Loop **
 * ==================     
 *      
 *     In c#, while Loop is used to execute a block of statements until the specified expression return as true.
 *      
 *      Syntax:
 *              while (boolean_expression) 
 *              {
 *               // Statements to Execute
 *              }
 *              
 *      If we are unknown about the number of times to execute the block of statements, then while Loop is the best solution.          
 *  
 *      Here if boolean_expression returns true, then the statements inside of while Loop will be executed. 
 *   After executing the statements, the boolean_expression will be evaluated to execute the statements within the while Loop.
 *
 *      In case the boolean_expression is evaluated to false, then the while Loop stops execution of statements, 
 *   and the program comes out of the loop.
 *   
 *      If a code block only contains a single statement, then you don't need to 
 *   wrap it inside curly brackets { }, as shown below.
 *      
 */

namespace MyProject_14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your first number in range of 1 to 10:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number in range of 10 to 20:");
            int secondNumber = int.Parse(Console.ReadLine());

            while (firstNumber <= secondNumber)
            {
                Console.WriteLine("The first number value is: " + firstNumber++);
                Thread.Sleep(500);
            }
            Console.WriteLine("The first number is equal to the Second number!");

            Console.ReadLine();
        }
    }
}
