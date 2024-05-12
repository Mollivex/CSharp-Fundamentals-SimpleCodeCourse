using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*
 * =====================
 *  ** do while LOOP **
 * =====================
 * 
 * The do while Loop is the same as while Loop except that it executes the code block at least once.
 *  
 *      Syntax:
 *               do
 *               {
 *               
 *                 //code block to be executed
 *                 
 *               } while(condition);
 * 
 *      The do-while Loop starts with the do keyword followed by a code block and a boolean expression with the while keyword. 
 *  The do while Loop stops execution exits when a boolean condition evaluates to false. Because the while(condition) specified 
 *  at the end of the block, it certainly executes the code block at least once.
 * 
 *      Do not forget to increase the variable used in the condition, otherwise the loop will never end!
 * 
 *      If a code block only contains a single statement, then you don't need to 
 *  wrap it inside curly brackets { }, as shown below.
 * 
 */

namespace MyProject_15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input your number in range of 1 to 10:"); 
            int a = int.Parse(Console.ReadLine());

            do
            {
                a++;
                Console.WriteLine(a);
                Thread.Sleep(500); // slowdown speed of loop execution to 500ms 

            } while (a < 10);

            Console.WriteLine("Your value is:" + a);

            Console.ReadLine();
        }
    }
}
