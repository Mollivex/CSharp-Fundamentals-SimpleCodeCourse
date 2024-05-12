using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/*
 * 
 * Increment(++) & Decrement(--)
 * PREfix (++1, --1) / POSTfix (1++, 1--)
 * 
 * The following list orders arithmetic operators starting from the highest precedence to the lowest:
 * 
 * Postfix increment x++ and decrement x-- operators; 
 * 
 * Prefix increment ++x and decrement --x and unary + and - operators; 
 * 
 * Multiplicative * , / , and % operators.
 * 
 */

namespace MyProject_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input value for PREfix_Increment:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Input value for POSTfix_Increment:");
            int b = int.Parse(Console.ReadLine());

            a = ++a * a * a; // ++(a * a * a * a)
            Console.WriteLine("PREfix result: " + a);

            b = b++ * b * b; // (b + 1) * (b + 1) * b
            Console.WriteLine("POSTfix result: " + b);

            Console.ReadLine();
        }
    }
}
