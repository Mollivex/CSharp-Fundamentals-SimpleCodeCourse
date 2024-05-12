using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Net.NetworkInformation;

/*
 * ========================================================
 * Access modifiers C# | private modifier | public modifier
 * ========================================================
 * 
 *          All types and type members have an accessibility level. The accessibility level controls whether they can be used from other code in your assembly or
 *      other assemblies. An assembly is a .dll or .exe create by compiling one or more .cs files in a single compilation. To specify the accessibility of a type
 *      or member when you declare it is used the following access modifiers:
 *      
 * ---------------------------------------
 * |C# has the folowing access modifiers:|
 * -------------------------------------------------------------------------------------------------------------------
 *      - public     |   The code is accessible for all classes.
 *                   |
 *      - private    |   The code is only accessible within the same class or struct.
 *                   |      
 *      - protected  |   The code is accessible within the same class, or in a class that is iherited from that class.
 *                   |      
 *      - internal   |   The code is only accessible within its own assembly, but not from another assembly.
 *  
 *  -!- There's also two combinations:
 *  
 *      - protected internal   |   The type or member can be accessed by any code in the assembly in which it's 
 *                                 declared, or from within a derived class in another assembly.
 *                                 
 *      - private protected    |   The type or member can be accessed by types derived from the class that are declared
 *                                 within its containing assembly.
 * -------------------------------------------------------------------------------------------------------------------
 *  NOTE: Not all access modifiers are valid for all types or members in all contexts. In some cases, the acccesibility
 *        of a type member is limited by the accessibility of its containing type.
 * -------------------------------------------------------------------------------------------------------------------
 * 
 * ----------------
 * Private Modifier:
 * ----------------
 * 
 *      If you declare a field with a private access modifier, it can only be accessed within the same class:
 *  
 *                          class Car
 *                          {
 *                              private string model = "Mustang";
 *                          
 *                              static void Main(string[] args)
 *                              {
 *                                  Car myObj = new Car();
 *                                  Console.WriteLine(myObj.model);
 *                              }
 *                          }
 *    
 * ---------------------------------------------------------------------------------------
 *  #NOTE: If you try to access private class field outside the class, an error will occur:
 *         
 *         'Object_Name' is inaccessible due to its protection level.
 *          The field 'Object_Name' is assigned but its value is never used
 * ---------------------------------------------------------------------------------------
 * 
 * ----------------
 * Public Modifier:
 * ----------------
 *      The \public keyword is an access modifier, which is used to set the access level/visibility for classes, fields, methods and proprities.
 *  If you declare a field with a public access modifier, it is accessible for all classes.
 *      
 * ----------------------------
 * -?- Why Access Modifiers -?-
 * ----------------------------
 *      To control the visibility of class members (the security level of each individual class and class member).
 *      
 *      To achive "Encapsulation" - which is the process of making sure that "sensitive" data is hidden from users. It is done by declaring field as private.
 *      
 * -----------------------------------------------------------------------------------------------
 *  #NOTE: By default, all members of a class are private if you don't specify an access modifier:
 *  
 *                          class Car
 *                          {
 *                              string model; // private
 *                              string year; // private
 *                          }
 * -----------------------------------------------------------------------------------------------
 * 
 * -------------------
 * -!- Other types -!-
 * -------------------
 * 
 *          - Interfaces declared directly within a namespace can be \public or \internal and, just like classes and stucts, interfaces default to \internal access. 
 *      Interface members are \public by default because the purpose of an interface is to enable other types to access a class or struct. Interface member declarations
 *      may include any access modifiers. This is most useful for static methods to provide common implementations needed by all implementors of a class.
 *      
 *          - Enumeration members are always \public, and no access modifiers can be applied.
 *          
 *          - Delegates behave like classes and structs. By default, they have \internal access when declared directly within a namespace, and \private access when nested.
 * 
 */

namespace MyProject_80
{
    class Point
    {
        int z = 3; // private field by default

        public int x = 1;

        private int y = 44;

        private void PrintX()
        {
            Console.WriteLine($"X: {x}");
        }
        public void PrintY()
        {
            Console.WriteLine($"Y: {y}");
        }
        public void PrintPoint()
        {
            PrintX();
            PrintY();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Access Modifiers Example
            Point point = new Point();
            point.PrintPoint();

            Console.WriteLine();

            // Reflection Example
            var typeInfo = typeof(Point).
                GetFields(BindingFlags.Instance |
                BindingFlags.NonPublic |
                BindingFlags.Public);

            foreach (var item in typeInfo)
            {
                Console.WriteLine($"{item.Name}\t IsPrivate: {item.IsPrivate}\t IsPublic: {item.IsPublic}");
            }

            Console.WriteLine();
        }
    }
}
