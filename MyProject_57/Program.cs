using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*
 * =========================================================
 * #out keyword | Difference between #out and #ref keywords.
 * =========================================================
 * 
 *      #The out keyword can be used with variables and method parameters. The out parameters are always passed by reference for both,
 *  the value type and the reference type data types.
 *  
 *  ==================
 *  #IMPORTANT POINTS:
 *  ==================
 *  
 *  -!- It is similar to #ref keyword. But the main diference between #ref and #out keywords is that ref needs that the variable must be initialized
 *  before it passed to the method. But #out parameter doesn't require the variables to be initialized before it passed to the method. But before
 *  it returns a value to the calling method, the variable must be initialized in the called method.
 *  
 *  -!- For using #out keyword as a parameter both the method definition and calling method must use the #out keyword explicity.
 *  
 *  -!- There can be more than one #out parameters in a method.
 *  
 *  -!- At the time of method call, #out parameter can be declared inline. But the inline #out parameters can be accessed in the same 
 *  block of code where it calls.
 *  
 *  -!- Method overloading can also be done using #out parameters.
 *  
 *  -!- Properties cannot be passed as #out parameters as these are not variables.
 *  
 *  -!- Up to C# 6.0, a user first declares the variable then it can only pass as an #out argument. But from C# 7.0, excepting a separate variable
 *  declaration, the user can also declare the #out variable in the argument list of the method call:
 *  
 *  -!- Declaration of #out parameter:  
 *
 *                // No need to initialize the variable here:
 *                        data_type variable_name;
 *                        Method_Name(out variable_name);
 *
 *                // you can also convert both above two lines of codes as follows fromC# 7.0 onwards:
 *                        Method_Name(out data_type variable_name);
 *                        
 *                // Here the value of variable_name must be initialized in the called method before it returns a valuel.
 *  
 *  =============================================
 *  #You can use the #out keyword in two contexts:
 *  =============================================
 *  - As a parameter modifier, which lets you pass an argument to a method by reference rather than by value;
 *  - In generic type parameter declarations for interfaces and delegates, which specifies that a type parameter is covariant;
 * 
 * ========
 * NOTE_#1: #out and #ref keywords actually are the same. But they have some difference between their logic. 
 * ======== They both work as a reference to some data variable (int, int[] etc.), but: - #ref keyword doesn't need to have a initialized value in the returned variable;
 *                                                                                      - #out keyword must to have some kind of returned value;
 *                                          
 * ========
 * NOTE_#2: Method with #out keyword must return some value in variable. Another way code won't compile.
 * ======== Unlike #ref keyword, which doesn't require any value in the variable to run the code.
 * 
 * ========
 * NOTE_#3: #out keyword used in the method ensures, that variable has and returns some value.
 * ========
 */

namespace MyProject_57
{
    class Program
    {
        static void Foo(ref int value)
        {
            // for #ref parameter code block can be empty
        }
        static void Bar(out int value)
        {
            value = 5;
        }
        static void Main(string[] args)
        {
            int refValue = 10;
            Foo(ref refValue);
            Console.WriteLine("#ref value is: " + refValue);

            Bar(out int outValue);
            Console.WriteLine("#out value is: " + outValue);

            // #SimpleCode TryParse Example:
            string str = Console.ReadLine();
            int.TryParse(str, out int result);

            // If the TryParse method cannot parse the inserted value, the output will be the default value (0);
            // If the TryParse method will can parse value, the output will be that value;
            Console.WriteLine(result);
        }
    }
}
