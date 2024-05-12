using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ======================================
 *  Break Statement (Jump statement type)
 * ======================================
 *  
 *      The break statement terminates the closest enclosing iteration statement 
 *      (that is: for, foreach, while or do loop) or switch statement.
 *      
 *      The break statement transfers control to the statement that follows the terminated statement, if any.
 *  
 *  In C#, the break statement has two main uses:
 *      
 *      in loop statements, the break statement is used to end the cyclic process (interrupting the loop). 
 *      Such an action is necessary when the code needs to interrupt the execution of the cycle 
 *      depending on some condition;
 *      
 *      in the switch statement, the use of the break statement is necessary to implement the 
 *      exit from this statement.
 * 
 */

namespace MyProject_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                string msg = Console.ReadLine();

                if (msg == "exit")
                {
                    break; // stopping the loop after inputting "exit" in console and move to the next statement/operation
                }
                Console.WriteLine(i);
            }

            for (int i = 0;i < 100; i++)
            {
                string msg2 = Console.ReadLine();

                if (msg2 == "exit")
                {
                    break; // stopping the loop after inputting "exit" in console and repeat all, what was written above
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
