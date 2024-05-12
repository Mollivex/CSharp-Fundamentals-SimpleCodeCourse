using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * =========================================
 * Nested loops (loops within another loops)
 * =========================================
 * 
 *   A loop within another loop is called nested loop. This is how a nested loop looks like:
 *   
 *       Outer-Loop 
 *       {
 *           // body of outer-loop
 *          
 *           Inner-Loop
 *           {
 *               // body of inner-loop
 *           }
 *            ... ... ...
 *        }
 *      
 *   - As you can see, the outer loop encloses the inner loop. 
 *   
 *   - The inner loop is a part of the outer loop and must start and finish within the body of outer loop.
 *   
 *   - On each iteration of outer loop, the inner loop is executed completely.
 *  ____________________________________________________________________________________________
 *   Syntax EXAMPLE:
 *  ____________________________________________________________________________________________
 *    The syntax for a nested for loop statement in C# is as follows −
 *
 *        for ( init; condition; increment ) 
 *        {
 *           for ( init; condition; increment ) 
 *           {
 *             statement(s);
 *           }
 *          statement(s);
 *        }
 *  ____________________________________________________________________________________________
 *    The syntax for a nested while loop statement in C# is as follows:
 *  ____________________________________________________________________________________________
 *       while(condition) 
 *       {
 *          while(condition) 
 *          {
 *           statement(s);
 *          }
 *         statement(s);
 *       }
 * ____________________________________________________________________________________________
 *    The syntax for a nested do...while loop statement in C# is as follows −
 * ____________________________________________________________________________________________
 *       do 
 *       {
 *         statement(s);
 *         do 
 *         {
 *          statement(s);
 *         }
 *         while(condition);
 *       }
 *       while(condition);
 *  ____________________________________________________________________________________________
 *    A final note on loop nesting is that you can put any type of loop inside of any other type of loop.
 * 
 */

namespace MyProject_22
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the height of your rectangle: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Enter the width of your rectangle: ");
            int width = int.Parse(Console.ReadLine());


            // Outer loop
            for (int i = 1; i <= height; i++) 
            {
                // Inner loop
                for (int j = 1; j <= width; j++) 
                {
                    Console.Write("#"); // executes n-number times according with value of (WIDTH * HEIGHT)
                }
                Console.WriteLine(); // executes n-number times according with value of HEIGHT
            }
            
            Console.WriteLine();
            Console.WriteLine("Press enter to take an example of nested loops:");
            Console.ReadLine();

            for (int a = 0; a < 3; a++)
            {
                Console.WriteLine("Loop #1:"); // executes 3 times
                for (int b = 0; b < 3; b++)
                {
                    Console.WriteLine("\tLoop #2"); // executes 3*3 = 9 times
                    for(int c = 0; c < 2; c++)
                    {
                        Console.WriteLine("\t\tLoop #3"); // executes 3*3*2 = 18 times
                        for (int d = 0; d < 2; d++)
                        {
                            Console.WriteLine("\t\t\tLoop #4"); // executes 3*3*2*2 = 36 times
                        }
                    }
                }
            }

        }
    }
}
