using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * =================================================================
 * Enumeration types | enum in C# | System.Enum type and Constraint.
 * =================================================================
 * 
 *      An enum is a special "class" that represents a group of constants (unchangeable / read-only variables).
 *      
 *      An enumeration type (or enum type) is a value type defined by a set of named constants of the underlying integral numeric type. To define an enumeration type, use
 *  the \enum keyword and specify the names of enum members:
 *  
 *                  enum Season
 *                  {
 *                      Spring,
 *                      Summer,
 *                      Autumn,
 *                      Winter
 *                  }
 *                  
 *      By default, the associated constant values of enum members are of type int; they start with zero and increase by one following the definition text order. You can
 *  explicitly specify any other integral numeric type as an underlying type of an enumeration type. You can also explicitly specify the associated constant values, as the
 *  following example shows:
 *  
 *                  enum ErrorCode : ushort
 *                  {
 *                      None = 0,
 *                      Unknown = 1,
 *                      ConnectionLost = 100,
 *                      OutlierReading = 200
 *                  }
 *                  
 *      You cannot define a method inside the definition of an enumeration type. To add functionality to an enumeration type, create an extenstion method.
 *      
 *      The default value of an enumeration type E is the value produced by expression (E)0, even if zero doesn't have the corresponding enum member.
 *      
 *      You use an enumeration type to represent a choice from a set of mutually exclusive values or a combination of choices. To represent a combination
 *  of choices, define an enumeration type as bit flags.
 * 
 *  #NOTE: Enum is short for "enumerations", which means "specifially listed"
 * 
 *  -?- Why And When To Use Enums? -?-
 *  Use enums when you have values that you know aren't going to change, like month, days, colors, deck of cards, etc.

 *  
 *  =========================================
 *  The System.Enum type and enum constraint:
 *  =========================================
 *  
 *      The System.Enum type is the abstract base class of all enumeration types. It provides a number of methods to get information about an enumeration type an its values.
 *  
 *      You can use System.Enum in a base class constraint (that is known as the enum constraint) to specify that a type parameter is an enumeration type. Any enumeration
 *  type also satisfies the struct constraint, which is used to specify that a type parameter is a non-nullable value type.
 *  
 *  ============
 *  Conversions:
 *  ============
 *  
 *      For any enumeration type, there exist explicit conversions between the enumeration type and its underlying intergral type. If you cast an enum value to its underlying
 *  type, the result is the associated integral value of an enum member.
 *  
 *      Use the Enum.IsDefined method to determine whether an enumeration type contains an enum member with the certain associated value.
 *      
 *      For any enumeration type, there exist boxing and unboxing conversions to an from the Sytem.Enum type, respectively.
 *  
 */

namespace MyProject_70
{
    public enum Season
    {
        Spring, // 0
        Summer, // 1
        Autumn, // 2
        Winter // 3
    }
    internal class EnumConversionExample
    {
        static void Main()
        {
            Season a = Season.Autumn;
            Console.WriteLine($"Integral value of {a} is {(int) a}"); // output: Integral

            var b = (Season) 1;
            Console.WriteLine(b); // output: Summer

            var c = (Season) 4;
            Console.WriteLine(c); // output: 4
        }
    }
}
