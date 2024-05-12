using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics.Contracts;

/*
 * =============================================
 * Attributes in C# | Using Attributes | Targets
 * =============================================
 * 
 *      https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/reflection-and-attributes/
 *      https://www.pluralsight.com/guides/using-attributes-in-c
 * 
 *      Attributes provide metadata for existing .NET code elements. .NET allows assemblies, types, methods, properties, and other types of elements
 *  to be marked with attributes, and these attributes can be queried with reflection. They provide declarative information for code.
 *  
 *      An attribute is simply an object whose class inherits from the Attribute class. However, attributes aren't used in the same way as a typical object.
 *  They are often used to hold a small amount of data such as a name or numberical limit, or to toggle behavior on or off. Some attributes specify functionality.
 *      For example, an attribute may contain a method that defines security behavior. This behavior may be relevant to two separate methods. The calling code can call
 *  the attribute's security method before invoking either method to ensure that both methods are secure.
 * 
 * -----------------
 * Using Attributes:
 * -----------------
 * 
 *      Attributes apply to one or more different attribute targets. The most common targets are types, such as classes and structs, methods and properties.
 *  Attributes can also apply to events, parameters, constructors, delegates and more.
 * 
 *      Attributes can be placed on almost any declaration, through a specific attribute might restrict the types of declarations on which it's valud. In C#, you
 *  specify an attribute by placing the name of the attribute enclosed in square brackets '[]' above the declaration of the entity to which it applies.
 * 
 * ---------------------
 * Attribute parameters:
 * ---------------------
 * 
 *      Many attributes have parameters, which can be positional, unnamed, or named. Any positional parameters must be specified in a certain order and can't be omitted. Named parameters are optional and can be specified in any order.
 *  Positional parameters are specified first. For example, these three attributes are equivalent:
 *  
 *                  [DllImport("user32.dll")]
 *                  [DllImport("user32.dll", SetLastError=false, ExactSpelling=false)]
 *                  [DllImport("user32.dll", ExactSpelling=false, SetLastError=false))]
 *      
 * ------------------
 * Attribute targets:
 * ------------------
 *  
 *      The target of an attribute is the entity that the attribute applies to. For example, an attribute may apply to a class, a particular method, or an entire assembly. By default, an attribute applies to the element that follows it.
 *  But you can also explicitly identify, for example, whether an attribute is applied to a method, or to its parameter, or to its return value.
 * 
 *      To explicitly identify an attribute target, use the following syntax:
 *              
 *                  [target : attribute-list]
 *      
 * ---------------------------
 * Common uses for attributes:   #| Describing your assembly in terms of title, version, description, or trademark.
 * ---------------------------   #| Describing which members of a class to serialize for persistence.
 *                               #| Describing the security requirements for methods.
 *                               #| Specifying characteristics used to enforce security.
 *                               #| Obtaining information about the caller to a method.
 *                               #| Controlling optimization by the just-in-time (JIT) compiler so the code remains easy to debug.
 * 
 */

namespace MyProject_131
{
    // Serializable is a prevalent attribute. This attribute tell the .NET XML serialization
    // engine that the class is valid for serialization.
    [Serializable]
    public class Example
    {
        // Objects of this type can be serialized
    }

    // The following example shows how to apply attributes to methods, method
    // parameters, and method return values in C#:

    public class AttributeTargets
    {
        private class ValidatedContractAttribute : Attribute
        {
            // default: applies to method
            [ValidatedContract]
            public int Method1() { return 0; }

            // applies to method
            [method: ValidatedContract]
            int Method2() { return 0; }

            // applies to parameter
            int Method3([ValidatedContract] string contract) { return 0; }

            // applies to return value
            [return: ValidatedContract]
            int Method4() { return 0; }
        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DefaultValue(" ")]
        public string FullName => FirstName + " " + LastName;
    }
    public class Program : Person
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Alex";
            person.LastName = "Brown";
            Console.WriteLine(person.FullName);
        }
    }
}
