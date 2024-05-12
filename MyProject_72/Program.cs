using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * =========================
 * #enum | System.ConsoleKey
 * =========================
 * 
 *  #Program which is using enums with System.ConsoleKey and ReadKey() to print info about pressed keys with displaying it to console
 * 
 */

namespace MyProject_72
{
    internal class ConsoleKeyExample
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;

                // converting data about key values to int
                int keyCode = (int)key;

                Console.WriteLine($"\tEnum {key}\tKey Code {keyCode}");

                if (key == ConsoleKey.Enter)
                {
                    Console.WriteLine("You print Enter!");
                }
            }
        }
    }
}
