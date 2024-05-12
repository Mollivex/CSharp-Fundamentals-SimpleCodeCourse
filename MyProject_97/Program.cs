using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * =================================
 * OOP | Partial Classes and Methods
 * =================================
 * 
 *      It's possible to split the definition of a class, a struct, an interface or a method over two or more source files. Each source file
 *  contains a section of their type or method definition, and all parts are combined when the application is compiled.
 *  
 *  ----------------
 *  Partial Classes:
 *  ----------------
 *  
 *  There are several situations when it's desirable to separate a class definition:
 *      
 *      #| When working on large projects, spreading a class over separate files enables multiple programmer to work on it at the same time.
 *      
 *      #| When working with automatically generated source, code can be added to the class without having to recreate the source file.
 *         Visual Studio uses this approach when it creates Windows Forms, Web service wrapper code, and so on. You can create code that uses
 *         these classes without having to modify the file created by Visual Studio.
 *         
 *      #| When using source generators to generate additional functionaliy in a class.
 *  
 *  -------------------------------------------------------------------------------
 *  To split a class definitopn, use the \partial keyword modifier, as shown here:
 *  
 *              public partial class Employee
 *              {
 *                  public void DoWork()
 *                  {
 *                  }
 *              }
 *              
 *              public partial class Employee
 *              {
 *                  public void GoToLunch()
 *                  {
 *                  }
 *              }
 *  -------------------------------------------------------------------------------
 *  
 *      The \partial keyword indicates that other parts of the class, struct, or interface can be defined in the namespace. 
 *      - All the parts must use the \partial keyword. 
 *      - All the parts must be available at compile time to form the final type. 
 *      - All the parts must have the same accessibility, such public, private, and so on.
 * 
 * ---------------------------------
 * Restrictions for Partial Classes:
 * ---------------------------------
 * 
 * There are several rules to follow when you are working with partial class definitions:
 * 
 *      #| All partial-type definitions meant to be parts of the same type must be modified with partial.
 *      
 *      #| The partial modifier can only appear immediately before the keywords class, struct, or interface.
 *      
 *      #| All partial-type definitions meant to be parts of the same type must be defined in the same assembly
 *         and the same module(.exe or .dll file). Partial definitions cannot span multiple modules.
 *         
 *      #| The following keywords on a partial-type definition are optional, but if present on one partial-type
 *         definition, cannot conflict with the keywords specified on another partial definition for the same type: public, private, protected, internal, abstract, sealed, base class.
 *                                                                                                                 
 *                                                                                                                  
 */

namespace MyProject_97
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Agvain", "Al'Vier");
            person.PrintFullName();
        }
    }
}
