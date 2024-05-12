using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * =========================================================
 * Optional(default) and Named method parameters(arguments).
 * =========================================================
 *
 *   -!- Named arguments enable you to specify an argument for a parameter by matching the argument with its name rather than
 *       with its position in the parameter list.
 *      
 *   -!- Optional arguments enable you to omit arguments for some parameters which you choose.
 * 
 *      Both techniques can be used with methods, indexers, constuctors, and delegates.
 *  
 *      When you use named and optional arguments, the arguments are evaluated in the order in which they appear in the argument
 *  list, not the parameter list.
 *  
 *      Named and optional parameters enable you to supply arguments for selected parameters. This capability greatly eases readability of code.
 * 
 * ================
 * Named arguments:
 * ================
 * 
 *      Named arguments free you form matching the order of arguments to the order of parameters in the parameter lists of called methods.
 *  The argument for each parameter can be specified by parameter name. 
 *  
 *      For example, a function that prints order details (such as, seller
 *  name, order number and product name) can be called by sending arguments by position, in the order defined by the function.
 *  
 *                      PrintOrderDetails("Gift Shop",31,"Red mug");
 * 
 *      If you don't remember the order of the parameters, but know their names, you can send the arguments in any order.
 *      
 *               This one:       PrintOrderDetails(orderNum: 31, productName: "Red mug", sellerName: "Gift Shop");
 *               Can be like:    PrintOrderDetails(productName: "Red mug", sellerName: "Gift Shop", orderNum: 31);
 *                      
 *      Named arguments also improve the readibility of your code by identifying what each argument represents.
 *      
 */

namespace MyProject_60
{
    class Program
    {
        /// <summary>
        /// Optional(default)/Named method parameters of Sum elements
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="enableLogging"></param>
        /// <returns></returns>
        static int Sum(int a, int b, bool enableLogging = false)
        {
            int result = a + b;

            if (enableLogging)
            {
                Console.WriteLine("Variable value a = " +  a);
                Console.WriteLine("Variable value b = " + b);
                Console.WriteLine("Sum result a + b = " + result);
            }
            return result;

        }

        static void Main(string[] args)
        {
            //Optional parameter example:
            int result = Sum(5, 2, true);
            Console.WriteLine();

            //Named parameter example:
            int firstValue = 5;
            int secondValue = 2;
            int resultValue = Sum(enableLogging : true, b : secondValue, a : firstValue);


        }
    }
}
