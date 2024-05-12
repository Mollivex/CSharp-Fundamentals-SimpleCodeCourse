using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject_96_MyExtensions; // we need to connect a namespaces with different names to use the extension methods. For that we need to make a link for using it
using MyProject_96_Student;

/*
 * ==========================
 * OOP | Extension Methods C#
 * ==========================
 * 
 *      A C# extenstion method allows developers to extend the functionality of an existing type without creating a new derived type,
 *  recompiling, or otherwise modifying the original type. C# extenstion method is a special kind of static method that is called as
 *  if it was an instance method on the extended type.
 *  
 *      C# extension method is a static method of a static class, where the "this" modifier is applied to the first parameter.
 *  The type of the first parameter will be the tyoe that is extended.
 *  
 *      Extension methods are only in scope when you explicitly import the namespace into your source code with a using directive.
 *      
 *  ------------------------------
 *  Benefits of extension methods:  #| Extension methods allow existing classes to be extended without relying on inheritance or
 *  ------------------------------     changing the class's source code.
 * 
 *                                  #| It the class is sealed, there is no concept of extending its functionality. For this, a new
 *                                     concept is introduced, in other words, extenstion methods.
 *                                     
 *                                  #| This feature is important for all developers, especially if you would like to use the dynamism
 *                                     of the C# improvements in your class's design
 *                                     
 *  ---------------------------------------------------
 *  Important points for the use of extenstion methods:   #| An extension method must be defined in a top-level static class.
 *  ---------------------------------------------------
 *                                                        #| An extension method with the same name and signature as an instance method will not be called.
 *                                                        
 *                                                        #| Extension methods cannot be used to override existing methods.
 *                                                        
 *                                                        #| The concept of extension methods cannot be applied to fields, properties, or events.
 *                                                        
 *                                                        #| Overuse of extension methods is not a good practice style of programming.
 *                                                        
 */

namespace MyProject_96
{
    class Program
    {
        static void Main(string[] args)
        {
            // We can use extension method for DateTime structure to display date time
            DateTime currentDateTime = DateTime.Now;
            currentDateTime.Print();
            DateTime.Now.Print(); // or we can do it in thats way

            Console.WriteLine();

            // Also we can display if now is the defined day of week with extension method for DateTime structure
            Console.WriteLine(currentDateTime.IsDayOfWeek(DayOfWeek.Sunday));

            Console.WriteLine();

            // Another example with Student Class
            Student student = new Student() {FirstName = "Martin", LastName = "Smith"};
            string fullName = student.GetFullName();
        }
    }
}
