using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ==================================================
 * OOP | Inheritance | What is it #1 | sealed Keyword
 * ==================================================
 * 
 *      In C#, inheritance allows us to create a new class from existing class. It's a key feature of Object-Oriented Programming (OOP).
 *      
 *      The class from which a new class is created is known as the base class (parent or superclass). And, the new class is called derived class (child or subclass).
 *      
 *      The derived class inherits the fields and methods of the base class. This helps with the code reusability in C#.
 * 
 *      In C#, it's possible to inherit fields and methods from one class to another. We group the 'inheritance concept' into two categories:
 *      
 *          #| Derived Class (child) - the class that inherits from another class.
 *          
 *          #| Base Class (parent) - the class being inherited from.
 *      
 *  NOTE #1: To inherit from a class, use the ':' symbol. 
 *      
 *  NOTE #2: Inheritance is useful for code resusabilitiy - reuse fields and methods of an existing class when you create a new class.
 *      
 *  NOTE #3: Structs don't support inheritance, but they can implement interfaces.
 *  
 *  ---------------------------------------------------------------------------------------------------------------------------------------
 *  sealed Keyword: If you don't want other classes to inherit from a class, use the 'sealed' keyword. 
 *                  If you will try to access a sealed class, C# will generate an error ('ClassA': cannot derive from sealed type 'ClassB')
 *  ---------------------------------------------------------------------------------------------------------------------------------------
 *  
 */

namespace MyProject_101
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person {FirstName = "Key", LastName = "Altos"};
            person.PrintName();

            Console.WriteLine();

            Student student = new Student {FirstName = "Jacob", Group = "CIC-1601", ID = 9478546};
            student.PrintName();
            student.StudentInfo();

            Console.WriteLine();

            Student stud = new Student { FirstName = "John", LastName = "Kart" };
            stud.Learn();
            PrintFullName(stud);

            Console.WriteLine();
        }
        public static void PrintFullName(Person person)
        {
            Console.WriteLine($"Last name: {person.LastName}\tFirst name: {person.FirstName}");
        }
    }
}
