using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/*
 *  Relational Operators
 * 
 * The comparison, also known as relational, operators compare their operands. 
 * 
 * Those operators are supported by all integral and floating-point numeric types.
 *
 *      == Equal
 *      
 *      != No equal
 *      
 *      > Greater than
 *      
 *      < Less than
 *      
 *      >= Greater than or equal
 *      
 *      <= Less than or equal

 */

namespace MyProject_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 4;

            Console.WriteLine(a==b);

            Console.WriteLine(a!=b);

            Console.WriteLine(a>b);

            Console.WriteLine(a<b);

            Console.WriteLine(a>=b);

            Console.WriteLine(a<=b);

            Console.ReadLine();
        }
    }
}
