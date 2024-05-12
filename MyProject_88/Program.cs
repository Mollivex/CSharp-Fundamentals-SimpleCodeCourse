using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * =================================
 * Automatic Properties (Short Hand)
 * =================================
 * 
 *      C# also provides a way to use short-hand / automatic properties, where you don't have to define the field for the property, 
 *  and you only have to write \get; and \set inside the property.
 *  
 *  ----------------------------------------------------------------------------------------------------------------
 *  -?- Why Encapsulation -?-
 *  
 *      - Better control of class members (reduce the possibility of yourself(or others) to mess up the code).
 *      
 *      - Fields can be made read-only (if you only use the \get method), or write-only (if you use the \set method).
 *      
 *      - Flexible: the programmer can change one part of the code without affecting other parts.
 *      
 *      - Increased security of data.
 *  ----------------------------------------------------------------------------------------------------------------
 * 
 *      In C#, a property is called an auto-implemented property when it contains accessors (get,set) without having any logic implementation.
 *      
 *      Generally, the auto-implemented properties are useful whenever there is no logic implementation required in property accessors.
 *      
 *  NOTE: -propfull | snippet for creating properties syntax C#
 *        -prop     | snippet for creating automatic properties C#
 *        -ctor     | snippet for creating constructor syntax C#  
 */

namespace MyProject_88
{
    class Person
    {
        public string Name { get; set; } // property
    }
    class User
    {
        public string Name { get; set; } // property
        public string Location { get; set; } // property
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Name = "Michael Smith";
            user.Location = "New York city";

            Console.WriteLine("Name: " + user.Name);
            Console.WriteLine("Location: " + user.Location);
            Console.ReadLine();

            Person person = new Person();
            person.Name = "Liam";
            Console.WriteLine(person.Name);

        }
    }
}
