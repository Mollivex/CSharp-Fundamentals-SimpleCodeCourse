using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * =====================================================
 * Structures in C# | Methods | Properties | Inheritance
 * =====================================================
 * 
 * --------------------------------------------------------------------------------------------------------------------------------------------------
 * Structs & Methods:  A C# struct can also contain methods. The methods can be either static or non-static. But static methods can access only
 * ------------------  other static members and they can't invoke by using an object of the structure. They can invoke only by using the struct name.
 *                     The methods inside a struct can also be overloaded as like inside a class.
 * 
 * -------------------------------------------------------------------------------------------------------------------------------------------
 * Structs & Properties:  In C# structs can implement automatically properties (or auto-property for short).
 * ---------------------  Automatically implemented properties use hidden backing fields, which are only accessible to the property accessors.
 *      
 * #| NOTE: This access restriction means that constructors in structs containing automatically imlemented properties often need
 *          an explicit constructor initializer where they wouldn't otherwise need one, to satisfy the requirement of all fields 
 *          being definitely assigned before any function member is invoked or the constructor returns.
 * 
 * ----------------------
 * Structs & Inheritance:
 * ----------------------
 * 
 *      Structs don't provide inheritance. It's impossible to inherit from a struct and a struct can't derive from any class.
 *  Similar to other types in .NET, struct is also derived from the class System.Object class and provides its functionality.
 *  
 *     In C# all types are directly and indirectly inheriting from the supe base class System.Object and hence the structure also.
 *  Since structs doesn't support inheritance, we can't use the keywords: virtual, override, new, abstract etc. with a struct methods.
 *  C# struct types are never abstract and always implicitly sealed. The abstract or sealed modifiers are not permitted in a struct declaration.
 *  
 *      Since inheritance isn't supported for structs, the declared accessibility of a struct member can't be protected or protected internal.
 *  Since all struct types are implicitly inherit from System.Object class, it's possible to override the methods of the class inside a struct
 *  by using the keyword override (Remember that this is a special case in C# structs)
 * 
 * ------------------------------------------------------------------------------------------------------------------------------
 * Summary: #| struct can include constructors, constants, fields, methods, properties, indexers, operator, events & nested types.
 * -------- #| struct cannot include a parameterless constructor or a destructor.
 *          #| struct can implement interfaces, same as a class.
 *          #| struct cannot inherit another structure or class, and it cannot be the base of a class.
 *          #| struct members cannot be specified as abstract, sealed, virtual or protected.
 * 
 * -----------
 * Conclusion:  Structs and classes are fundamental concepts in C#, and understanding the differences between them is critical when building your code.
 * -----------  By understanding their differences, you canmake informed decisions about when to use which type and how to optimize your code for performance
 *              and maintainability.
 * 
 */

namespace MyProject_122
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
