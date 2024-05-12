using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * =================================
 * OOP | Inheritance | What is it #2
 * =================================
 * 
 *      Inheritance,together with encapsulation and polymorphism, is one of the three primary characteristics of object-oriented programming. 
 *      
 *      Inheritance enables you to create new classes that reuse, extend, and modify the behavior defined in other classes. 
 *      
 *      The class whose members are inherited is called the 'base' class, and the class that inherits those members is called the 'derived' class. 
 *      
 *      The derived class can have only one direct base class. However, inheritance is transitive. 
 *      
 *      For example, if ClassC is derived from ClassB, and ClassB is derived from ClassA, ClassC iherits the members declared in ClassB and ClassA.
 *  
 *  ----------------------------------------------------------------------------------------------------------------------------------------------------------------
 *  Types of Inheritance:   #| Single Inheritance: Subclasses inherit the features of one superclass.
 *  ---------------------
 *                          #| Multilevel Inheritance: A derived class will be inheriting a base class and the class also act as the base class to other classes.
 *                                                     
 *                          #| Multiple Inheritance (Through Interfaces): C# doesn't support multiple inheritance with classes. One class can have more than one
 *                                                                        superclass & inherit features from all parent classes. We can achieve multiple inheritance 
 *                                                                        only through Interfaces.
 *  ---------------------------------------------------------------------------------------------------------------------------------------------------------------
 *  
 */

namespace MyProject_102
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher {FirstName = "Martin", LastName = "Duglas"};
            Student student = new Student {FirstName = "Mike", LastName = "Wazovski"};
            Person[] people = {teacher, student};

            PrintPeople(people);
        }
        static void PrintPeople(Person[] people)
        {
            foreach (var person in people)
            {
                person.PrintFullName();
            }
        }
    }
}
