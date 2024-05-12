using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ========================================
 * Continue Statement (Jump statement type)
 * ========================================
 * 
 *    The continue statement starts a new iteration of the closest enclosing iteration statement
 *    (that is: for, foreach, while or do loop)
 * 
 *    The continue statement is applied inside the loop body. 
 * 
 *    The operator stops the current iteration and proceeds to the next iteration (the next step of the loop). 
 * 
 *    Using the continue statement in a loop is effective if you need to skip some iterations depending on 
 *    the condition.
 * 
 */

namespace MyProject_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 2)
                {
                    continue; // when i-value will be 2, then it will be skipped and loop continue until the end
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
