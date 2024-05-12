using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ====================================
 * #ref parameter keyword | What is it?
 * ====================================
 * 
 *      #The ref keyword indicates that a variable is a reference, or an alias for another object. It's used in five different contexts:
 *      
 *      - In a method signature and in a method call, to pass an argument to a method by reference.
 *      
 *      - In a method signature, to return a value to the caller by reference.
 *      
 *      - In a member body, to indicate that a reference return value is stored locally as a reference that the caller inteds to modify.
 *        Or to indicate that a local variable accesses another value by reference.
 *      
 *      - In a struct declaration, to declare a ref struct or a readonly ref struct.
 *      
 *      - In a ref struct declaration, to declare that a field is a reference.
 * 
 * =================================
 * #Passing an argument by reference
 * =================================
 * 
 *      #When used in a method's parameters list, the ref keyword indicates that an argument is passed by reference, not by value. The ref keyword makes the formal parameter 
 *  an alias for the argument, which must be a variable. In other word, any operation on the parameter is made on the argument.
 *  
 *      #For example, suppose the caller passes a local variable expression or an array element access expression. The called method can then replace the object to which the
 *  ref parameter refers. In that case, the caller's local variable or the array element refers to the new object when the method returns.
 * 
 * #NOTE: Don't confuse the concept of passing by reference with the concept of reference types. The two concepts are not the same. A method parameter can be modified
 *        by ref regardless of whether it is a value type or a reference type. There is no boxing of a value type when it is passed by reference.
 *        
 *      #To use a ref parameter, both the method definition and the calling method must explicity use the ref keyword, as shown in the following example
 *  (Except that the calling method can omit ref when making a COM call)
 *      
 *      #An argument that is passed to a ref of in parameter must be initialized before it's passed. This requirement differs from out parameters, whose
 *  arguments don't have to be explicitly initialized before they're passed.
 *      
 *      #Members of a class can't have signatures that differs only by ref, in or out. A compiler error occurs if the only difference between two members 
 *  of a type is that one of them has a ref parameter and the other has an out, or in parameter.
 */

namespace MyProject_53
{
    class Program

    {
        static void Method(ref int refArgument)
        {
            refArgument = refArgument + 44;
        }
        static void Main(string[] args)
        {
            int number = 1;

            Method(ref number);

            Console.WriteLine(number);
        }
    }
}
