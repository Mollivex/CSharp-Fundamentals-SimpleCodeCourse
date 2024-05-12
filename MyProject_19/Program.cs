using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ==========
 *  for Loop
 * ==========
 * 
 *    Case #2. 
 *       
 *    Reverse loop.
 * 
 */

namespace MyProject_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());

            for (; i >= 0; i--)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(500);
            }

            Console.ReadLine();
        }
    }
}
