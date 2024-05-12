using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ===========================================
 * Generics in C# | Default <T> | JIT Compiler
 * ===========================================
 * 
 * ------------
 * Default <T>: https://www.c-sharpcorner.com/article/defaultt-in-generics/#:~:text=Default%20represents%20default%20value%20of,default%20keyword%20can%20be%20useful.
 * ------------
 * 
 *      "Default" represents the default value of T parameter in generics instructions. In several cases, the 'default' keyword is absolutely unknown
 *  and we think it's unnecessary or its functionality makes it null. There are many development moments with the generics classes where default keyword
 *  can be useful.'Default' keyword can make our work easier and can make the code safer.
 *      
 *      This keyword returns the default value of type parameter.
 *      These are the default values for the more important types inside of CLR(Common Language Runtime):
 *      
 *          #| Classes -> null.
 *          #| Nullable<T> -> null.
 *          #| Numeric structs(int,double, decimal etc.) -> 0.
 *          #| DateTime structs -> 01/01/0001.
 *          #| Char structs -> empty char.
 *          #| Bool structs -> false.
 * 
 * -------------
 * JIT-compiler: https://www.geeksforgeeks.org/what-is-just-in-time-jit-compiler-in-dot-net/
 * -------------
 *      
 *      Just-In-Time compiler(JIT) is a part of Common Language Runtime(CLR) in .NET which is responsible for managing the execution of .NET programs regardless
 *  of any .NET programming language. A language-specific compiler converts the source code to the intermediate language. This intermediate language is then converted
 *  into the machine code by the Just-In-Time(JIT) compiler. This machine code is specific to the computer environment that the JIT compiler runs on.
 *  
 *      Working of JIT Compiler: The JIT compiler is required to speed up the code execution and provide support for multiple platforms.
 *                               Its working is given as follows: https://media.geeksforgeeks.org/wp-content/uploads/20190410185504/Working-of-JIT-Compiler1.png
 * 
 */

namespace MyProject_127
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1; 
            double b = 5.3;

            Console.WriteLine($"a = {a}\t b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"a = {a}\t b = {b}");

            Console.WriteLine("\n");

            string str1 = "Hello";
            string str2 = "World!";

            Console.WriteLine($"str1 = {str1}\t str2 = {str2}");
            Swap(ref str1, ref str2);
            Console.WriteLine($"str1 = {str1}\t str2 = {str2}");

            Console.WriteLine("\n");

            string result = Foo<string>(); // null
            Console.WriteLine(result);
        }
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static T Foo<T>()
        {
            return default(T);
        }
    }
}
