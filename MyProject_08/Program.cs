using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/*
 *  IF-ELSE-IF Statement

 *      STRUCTURE EXAMPLE #1
 *          
 *          if (statment or expression)
 *          {
 *              Action 1;
 *          }
 *          else
 *          {
 *              Action 2;
 *          }
 *          
 *  ------------------------------------------------------------------------------------------------------------------------------
 *           
 *      STRUCTURE EXAMPLE #2
 *           
 *           if (condition_1)
 *           {
 *           // Statements to Execute if condition_1 is True
 *           }
 *           
 *           else if (condition_2)
 *           {
 *           // Statements to Execute if condition_2 is True
 *           }
 *           
 *           else if (condition_3)
 *           {
 *           // Statements to Execute if condition_3 is True
 *           }
 *           
 *           ....
 *           ....
 *           
 *           else
 *           {
 *           // Statements to Execute if all conditions are False
 *           }
 *           
 *  If you observe the above c# IF-ELSE-IF statement syntax, we defined multiple conditions to execute the required statements.
 * 
 *  Here, the execution of IF-ELSE-IF statement will start from top to bottom, and as soon as the condition returns true, 
 *  then the code inside of if or else if block will be executed, and control will come out of the loop.
 * 
 *  If none of the conditions return true, then the code inside else block will be executed.   
 * 
 */

namespace MyProject_08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // EXAMPLE 1 (Intoxicated or NOT)

            bool isInfected = true;

            if (isInfected) // true statment
            {
                Console.WriteLine("Hero is intoxicated!");
            }
            else // false statement
            {
                Console.WriteLine("Hero is healthy!");
            }

            // EXAMPLE 2 (GREAT OR LESS than 0)

            int a;
            a = int.Parse(Console.ReadLine());

            if (a>0)
            {
                Console.WriteLine("a is GREAT than 0");
            }
            else
            {
                Console.WriteLine("a is LESS than 0");
            }

            // EXAMPLE 3 (Check if a number is EVEN or ODD)

            int number;
            number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Number is EVEN");
            }
            else
            {
                Console.WriteLine("Number is ODD");
            }
        }
    }
}
