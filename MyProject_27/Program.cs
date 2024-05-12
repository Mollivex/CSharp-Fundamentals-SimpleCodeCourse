using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ================
 * Ternary operator
 * ================
 * 
 *      There is also a short-hand if else, which is known as the ternary operator because it consists of three operands. 
 *  It can be used to replace multiple lines of code with a single line. 
 * 
 *      C# includes a decision-making operator ?: which is called the conditional operator or ternary operator. 
 *  It is the short form of the if-else conditions.
 *  
 *  ===============
 *  Syntax EXAMPLE:
 *  ======================================================================================                    
 *  
 *  [operand #1 condition] ? [operand #2 if_true] : [operand #3 if_false]
 *  
 *  ======================================================================================
 *  
 *      The ternary operator starts with a boolean condition. If this condition evaluates to true then it will 
 *  execute the first statement after ?, otherwise the second statement after : will be executed.
 *  
 *  NOTE: It's useful to use ternary operator when you have small one-line operations or statements. If it's doesn't, instead of the ternary operator you should use the IF-ELSE-IF statement.
 * 
 */

namespace MyProject_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                try
                {
                    //===================================================================================================
                    // Example #1
                    //===================================================================================================

                    bool accesAllowed;

                    Console.Write("Enter your password: ");

                    string savedPassword = "qwerty";
                    string enteredPassword = Console.ReadLine();

                    // if-else resolve method

                    //if (enteredPassword == savedPassword)
                    //{
                    //    accesAllowed=true;
                    //}
                    //else
                    //{
                    //    accesAllowed=false;
                    //}

                    // Ternary operator resolve method

                    accesAllowed = savedPassword == enteredPassword ? true : false;

                    Console.WriteLine(accesAllowed);

                    //===================================================================================================
                    // Example #2
                    //===================================================================================================

                    Console.Write("Enter positive number: ");

                    int inputData = int.Parse(Console.ReadLine());
                    int outputData = (inputData < 0) ? 0 : inputData;

                    Console.WriteLine(outputData);

                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Input error!!!");
                    Console.ReadLine();
                }
            }
        }
    }
}
