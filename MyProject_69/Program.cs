using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * =====================================================
 * Keyword var in C# | Implicitly typed local variables.            -!- var IS NOT A DATA TYPE -!-
 * =====================================================
 * 
 *      Local variables can be declared without giving an explicit type. The var keyword instructs the compiler to infer the type of the variable from the expression on the
 *  right side of the initialization statement. The inferred type may be a built-in type, an anonymous type, a user-defined type or, a type defined in the .NET class library.
 * 
 *      It's important to understand that the var keyword doesn't mean "variant" and doesn't indicate that the variable is loosely typed, or late-bound. It just means that
 *  the compiler determines and assigns the most appropriate data type.
 *  
 *      #The var keyword may be used in the following contexts:
 *  
 *  - On local variables (variables declared at method scope);
 *  
 *  - In a for initialization statement:
 *          
 *          for (var x = 1; x < 10; x++);
 *          
 *  - In a foreach initialization statement:
 *  
 *          foreach (var item in list) {...};
 * 
 *  - In a using statement:
 *  
 *          using (var file = new StreamReader("C:\\myFile.txt")) {...};
 *          
 * ========================
 * var and anonymous types:
 * ========================
 * 
 *      In  many cases the use of var is optional and is just a syntactic convenience (syntactic sugar). However, when a variable is initialized with an anonymous type you 
 *  must declare the variable as var if you need to access the proprities of the object at a later point. This is a common scenario in LINQ query expressions.
 * 
 *      From the perspective of your source code, an anonymous type has no name. Therefore, if a query variable has been initialized with var, then the only way to access
 *  the proprities in the returned sequence of objects is to use var as the type of the iteration variable in the foreach statement. 
 *      
 * ========
 * Remarks: #The following restrictions apply to implicitly-typed variable declarations:
 * ========
 *      
 *  - var can only be used when a local variable is declared and initialized in the same statement; the variable cannot be initialized to null, or to method group
 *    or an anonymous function.
 *    
 *  - var cannot be used on fields at class scope.
 *  
 *  - Variables declared by using var cannot be used in the initialization expresion. In other words, this expression is legal: int i = (i = 20); but this expression
 *    produces compile time error: var i = (i = 20);
 *    
 *  - Multiple implicitly-typed variables cannot be initialized in the same statement.
 *  
 *  - If a type named var is in scope, then the var keyword will resolve to that type name and will not be treated as part of an implicitly typed local variable declaration.
 *  
 *      Implicit typing with the var keyword can only be applied to variables at local method scope. Implicit typying is not available for class fields as the C# compiler would
 *  encounter a logical paradox as it processed the code: the compiler needs to know the type of the field, but it cannot determine the type until the assignment expression is
 *  analyzed, and the expression cannot be evaluated without knowing the data type. Consider the following code:
 *  
 *          private var bookTitles;
 *      
 *      bookTitles is a class field given the type var. As the field has no expression to evaluate, it's impossible for the compiler to infer what type bookTitles is supposed to be.
 *  In addition, adding an expression to the field (like you would for a local variable) is also insufficient:
 *  
 *          private var bookTitles = new List<string>();
 *          
 *      When the compiler encounters fields during code compilationm, it recors each field's type before processing any expressions associated with it. The compiler encounters the
 *  same paradox trying to parse bookTitles: it needs to know the type if the field, but the compiler would normally determine var's type by analyzing the expression, which isn't
 *  possible without knowing the type beforehand.
 *  
 * ======
 * NOTES:
 * ======
 *  
 *  #NOTE: You may find that var can also be useful with query expressions in which the exact constructed type of the query variable is difficult to determine. This can occur with
 *         with grouping and ordering operations.
 *  
 *  #NOTE: The use of var helps simplify your code, but its use should be restricted to cases where it's required, or when it makes your code easier to read.
 * 
 *  #NOTE: Do not use var to declare the data type for the property (properties) as well as the return type of the method in the class.
 * 
 *  #NOTE: The correct type must be used to initialize var variables to assign values to variables.
 *  
 *  #NOTE: The var was introduced to C# with LINQ that uses anonymous types, query expressions, and lambdas. Use of var is useful when the type if a variable is unknown.
 * 
 */

namespace MyProject_69
{
    internal class Program
    {
        static int Sum(int x, int y)
        {
            var result = x + y;
            return result;
        }
        static void Main(string[] args)
        {
            // The following examples show various ways in which local variables can be declared with var:
            // Method GetType exist in Object class and therefore it can be applied to any objects, variables

            // The var can operate on a method that returns a value and then declare the same type in a variable
            var f = Sum(8,3);

            Console.WriteLine("Example Data Types:");
            // i is compiled as an int
            var j = 5;
            Console.WriteLine(j.GetType());

            // s is compiled as a string
            var s = "Hello";
            Console.WriteLine(s.GetType());

            // t is compiled as a float(System.Single) array
            var t = new float[10];
            Console.WriteLine(t.GetType());

            //a is compiled as int[]
            var a = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(a.GetType());

            // anon is compiled as an anonymous type
            var anon = new { Name = "Terry", Age = 34 };
            Console.WriteLine(anon.GetType());

            // list is compiled as List<int>
            var list = new List<int>();
            Console.WriteLine(list.GetType());

            var name1 = "C# Corner"; // Implicitly typed STRING
            string name2 = "C# Corner"; // Explicitly typed STRING
            var age = 30; // Implicitly typed INT

            // We can declare var type variable only once, when we insert there data
            var test = 55;
            //var test = "hello"; // Compile Error: A local variable or function named 'test' is already defined in this scope

            // Example. Program which choose in array elements >15:

            Console.WriteLine("\n#EXAMPLE with LINQ:");
            Console.Write("Program which choose from following array elements with value >15: ");
            int[] array = new int[] { 23, 56, 5, 3, 2, 304, 59, 10, 14 };
            for (int i = 0; i < array.Length; i++)
                Console.Write(" " + array[i]);

            Console.Write("\nResult is: ");
            var result = from i in array where i > 15 orderby i select i;

            foreach (var item in result)
                Console.Write($"{item} ");

            Console.WriteLine($"\nResult data type: {result.GetType()}");

            Console.ReadLine();
        }
    }
}
