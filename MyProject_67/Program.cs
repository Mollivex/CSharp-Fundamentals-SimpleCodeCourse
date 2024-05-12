using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ========================================================
 * Arithmetic overflow | Keywords checked and unchecked C#.
 * ========================================================
 * 
 *      Arithmetic overflow happens when you perform an operation with a data type and the result of this operation exceeds the size of a
 *  storage for this datatype. For example, when you add two large 32-bit integers together and the result cannot fit into Int32 and overflows.
 * 
 *      Overflow is an operation that occurs when a calculation produces a result that is greater in magnitude than that which a given 
 *  register or storage location can store or represent.
 *  
 *  #NOTE: We can use keywords \checked and \unchecked to verify value for overflow or underflow exceptions. It can be applied for the defined cases and for the hole project.
 *  
 *         Properties of the project -> Build -> Advanced -> Check for arithmetic overflow / underflow (set for a hole project)
 *         
 *         \checked - verify the project for overflow or underflow exceptions
 *         \unchecked  - don't verify project for overflow or underflow exceptions
 *         
 *                      checked
 *                      {
 *                          int first = Int32.MaxValue;
 *                          int second = first + 1;
 *                      }
 *
 *                      unchecked
 *                      {
 *                          decimal first = Decimal.MaxValue;
 *                          decimal second = first + 1;
 *                      }
 * 
 * ====================
 *  #Practical advices: So, what are the best practices with an overflow?
 * ====================
 * 
 *  - First of all, you should use \checked switch for development and, because it adds little extra overhead, turn it off in production.
 *  
 *  - Secondly, state explicitly \checked and \unchecked blocks of code in your solution where it matters and you expect input values
 *    to cause an overflow issue.
 *    
 *  - The last advice also applies to the first one and if you don't care about overflow at all, it's not neccesary to switch the 
 *    compiler even for development.
 * 
 */

namespace MyProject_67
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nuclear Gandhi (Civilization game) 
            byte agression = 1;
            byte democracyModifier = 2;

            try
            {
                // We can use keyword #checked and #unchecked for the defined data types(values) in the project
                agression = checked((byte)(agression - democracyModifier));
                Console.WriteLine(agression); // agression = 255
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow error!");
            }

            // Overflow (over the upper bound)
            int a = int.MaxValue;
            a = a + 1;
            Console.WriteLine(a); // MaxValue + 1 = MinValue

            // Underflow (through the lower bound)
            int b = int.MinValue;
            b = b - 1;
            Console.WriteLine(b); // MinValue - 1 = MaxValue

            // Nonintegral data types - double, float etc.
            // Are those types that represent numbers with both integer and fractional parts.
            double d = 1.0 / 0.0;
            Console.WriteLine(double.IsInfinity(d)); // output: True

            double e = 0.0 / 0.0;
            Console.WriteLine(double.IsNaN(e)); // output: True

            double f = double.MaxValue + double.MaxValue;
            Console.WriteLine(double.IsInfinity(f)); // output: True

            // Data type - decimal
            decimal k = decimal.MaxValue;
            decimal l = decimal.MaxValue;
            decimal r = unchecked(a + b); // For decimal type operands, arithmetic overflow will still return #System.OverflowException anyway

            // Decimal type it's exact type and is used for financial transactions - transferring, deposits etc.
        }
    }
}
