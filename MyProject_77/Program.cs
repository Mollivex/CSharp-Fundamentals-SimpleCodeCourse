using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MyProject_77Test; If we have different named namespaces, we must use link for another subproject Student.cs to use class Student here

/*
 * ======================================
 * OOP | Class methods | Multiple Classes
 * ======================================
 * --------------
 * Object Methods
 * --------------
 *      Methods normally belongs to a class, and they define how an object of a class behaves.
 *      
 *      Just like with fields, you can access methods with the dot syntax. However, note that the method must be public. And remember that we use the 
 *  name of the method followed by two parantheses () and a semicolon ; to call (execute) the method.
 *  
 *  #NOTE to REMEMBER: a \static method can be accessed without creating an object of the class, while \public methods can only be accessed by objects.
 *  
 * --------------------------------
 *  -!- Using Multiple Classes -!-
 * --------------------------------
 *      You can also create an object of a class and access it in another class. This is often used for better organization of classes
 *  (one class has all the fields and methods, while the other class holds the Main() method(code to be executed)).
 *      
 *      - prog2.cs
 *      - prog.cs
 *--------------------------------------------------------------------
 *  /*| prog2.cs |*\
 *  
 *              class Car
 *              {
 *                  public string color = "red";
 *              }
 *  
 *  /*| prog.cs |*\
 *              
 *              class Program
 *              {
 *                  static void Main(string[] args)
 *                  {
 *                      Car myObj = new Car();
 *                      Console.WriteLine(myObj.color);
 *                  }
 *              }
 *--------------------------------------------------------------------
 *  #NOTE: Did you notice the \public keyword? It's called an access modifier, which specifies that the \color variable/field of \Car is accessible
 *         for other classes as well, such as \Program.
 * 
 */

namespace MyProject_77
{
    class Program
    {
        // We create the class Student in another separate subproject Student.cs 
        /// <summary>
        /// Info about student
        /// </summary>
        /// <returns></returns>
        static Student GetStudent()
        {
            Student student = new Student();

            student.firstName = "Alexandr";
            student.lastName = "Cocier";
            student.middleName = "Oleg";
            student.age = 25;
            student.id = Guid.NewGuid();
            student.group = "CIC-1601";

            return student;
        }

        /// <summary>
        /// Print info about student
        /// </summary>
        /// <param name="student"></param>
        static void Print(Student student)
        {
            Console.WriteLine("Information about the student:");
            Console.WriteLine($"ID: {student.id}");
            Console.WriteLine($"Last Name: {student.lastName}");
            Console.WriteLine($"First Name: {student.firstName}");
            Console.WriteLine($"Middle Name: {student.middleName}");
            Console.WriteLine($"Age: {student.age}");
            Console.WriteLine($"Group: {student.group}");
        }

        static void Main(string[] args)
        {
            var firstStudent = GetStudent();

            Print(firstStudent);
        }
    }
}
