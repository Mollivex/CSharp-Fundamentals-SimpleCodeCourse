using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * =============================
 * #params keyword | What is it?
 * =============================
 * 
 *      By using the #params keyword, you can specify a method parameter that takes a variable number of arguments. The parameter
 *  must be a single-dimensional array. 
 *  
 *      No additional parameters are permitted after the #params keyword in a method declaration, and only one params keyword is 
 *  permitted in a method declaration.
 * 
 *      If the declared type of the #params parameter in not a single-dimensional array, compiler error CS0225 occurs.
 *      
 *      #When you call a method with a params parameter, you can pass in:
 *      
 *              -!- A comma-separated list of arguments of the type of the array elements;
 *              -!- An array of arguments of the specified type;
 *              -!- No arguments. If you send no arguments, the length of the #params list is zero;
 * 
 *      The #params keyword in C# allows a method to accept a variable number of arguments. #params in C# works as an array of objects.
 *  By using #params keyword in a method argument definition, we can pass a number of arguments.
 *  
 *  ======
 *  #NOTE: There can't be anymore parameters after a #params parameter.
 *  ======
 *  
 *      Using #params, the arguments passed to a method are changed by the compiler to elements in a temporary array, and this array is
 *  then used to retrieve the method parameters by the caller code.
 *  
 *      #params keyword can be used to declare a method that doesn't know the number of parameters. #params are also useful to write "clean code". 
 *  
 *      Instead of using various overloaded methods to pass multiple values, we can simply create an array and pass it as an argument 
 *  or a comma-separated list of values.
 * 
 */

namespace MyProject_59
{
    class Program
    {
        /// <summary>
        /// Using #params parameter to sum elements
        /// </summary>
        /// <param name="message"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        static int Sum(string message, params int[] parameters)
        {
            int result = 0;

            for (int i = 0; i < parameters.Length; i++)
                result += parameters[i];

            return result;
        }

        /// <summary>
        /// Using #params parameter to see data type values
        /// </summary>
        /// <param name="parameters"></param>
        static void Foo(params object[] parameters)
        {
            string message = "Data type: {0}, value: {1}";

            foreach (var item in parameters)
                Console.WriteLine(message, item.GetType(), item);
        }

        static void Main(string[] args)
        {
            // Sum elements using #params parameter:
            int result = Sum("TEST", 12, 20, 42, 52, 56, 97);
            Console.WriteLine("TEST sum is: " + result);

            //#SimpleCode example of use #params parameter:
            Foo("test", 82.3, 5, "q", 5.89f, true);
        }
    }
}
