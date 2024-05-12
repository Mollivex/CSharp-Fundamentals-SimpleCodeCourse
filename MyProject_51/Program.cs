using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

/*
 * ==================================================================================
 * NULL coalescing operator ?? | Union assignment operator ??= with value NULL in C#.
 * ==================================================================================
 * 
 *      The null-coalescing operator ?? returns the value of its left-hand operand if it isn't null; otherwise, it evaluates the right-hand operand and returns its result.
 *  
 *      The ?? operator doesn't evaluate its right-hand operand if the left-hand operand evaluates to non-null.
 *  
 *      The null-coalescing union assignment operator ??= assigns the value of its right-hand operand to its left-hand operand only if the left-hand operand evaluates to null. 
 *      The ??= doesn't evaluate its right-hand operand if the left-hand operand evaluates to non-null.
 *   
 * ======================================
 * #SYNTAX (NULL coalescing operator ??):      \\ leftSideOperand ?? rightSideOperand // 
 * ======================================
 *              
 *  It returns the left-side operand if the operand is not null, else it returns the right-side operand.
 *  
 *  !!Operands must have the same data type values!!
 *  
 * ====================================================
 * #NOTE: The operators ?? and ??= can't be overloaded.
 * ====================================================
 */

namespace MyProject_51
{
    internal class Program
    {
        static int[] GetArray()
        {
            int[] myArray = null;
            return myArray;
        }

        static void Main(string[] args)
        {
            //NULL-coalescing operator ?? EXAMPLES:
            Console.WriteLine("- NULL-coalescing operator ?? EXAMPLES:");
            string str1 = "\nTEXT";
            Console.WriteLine(str1 ?? "Data doen't exist");

            string str2 = null;
            string resultStr = str2 ?? string.Empty;
            Console.WriteLine("\nNumber of symbols in the string: {0}", resultStr.Length);
            Console.WriteLine("======================================================");

            //NULL-coalescing union assignment operator ??= EXAMPLE:
            Console.WriteLine("\n- NULL-coalescing union assignment operator ??= EXAMPLES");
            string str3 = null;
            str3 ??= string.Empty;
            Console.WriteLine("\nNumber of symbols in the string: {0}", str3.Length);

            int[] myArray = GetArray();
            myArray ??= new int[0];
            Console.WriteLine("\nNumber of symbols in the array: {0}", myArray.Length);
            
            Console.ReadLine(); 
        }
    }
}
