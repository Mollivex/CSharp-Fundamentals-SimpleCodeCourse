using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

/*
 * =========================================
 * OOP | Objects initialization syntax in C#
 * =========================================
 * 
 *      You can simplify the code and make it more readable with a such objects initialization syntax in C#.
 *      
 *      It make possible to declare a class object with the parameters at once.
 * 
 * -----------------------------------------------------------------------------------------------------------------------------
 *  -!- To make use of object initialization in C#, we have to follow some rules, which are defined as follows:
 *      
 *          #| We first have to create the object of the class or collection which we want, as we normally do in C#.
 *             To create the new object in C#, we make use of the 'new' keyword.
 *          
 *          #| Immediately after the object creation, we are bound to assign the values to the class variable if you
 *             want to implement object initialization in C#.
 *          
 *          #| For this, we have to make use of '{}' braces in C#. Inside these {} braces, we can pass out variable, which
 *             we want to give values. It's not mandatory to pass or assign values to all the variables to the object
 *             initialization; it depends upon the requirement. We have given force here because we aren't using any 
 *             constructor here to assign them values.
 *             
 *          #| Object initialization also reduces the lines of code that is required to initialize the variable. Also we
 *             don't require to create the default and parameterized constructor for this. It also makes our code more readable
 *             and less in the number of lines.
 *             
 *          #| After this, we can assign any type of variable to it. Whether it's a string, number, or anything.
 *          
 *          #| Also, at the end of the {} braces, we have to end this with a ';' semicolon to make it work. Otherwise, it will
 *             give a compile-time error saying missing or expected ';' at the end.
 * -----------------------------------------------------------------------------------------------------------------------------
 * 
 */

namespace MyProject_100
{
    class Cat
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Cat()
        {
            
        }
        public Cat(string name)
        {
            Name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Cat initialization EXAMPLE
            Cat cat1 = new Cat();
            cat1.Age = 5;
            cat1.Name = "Phoenix";

            Cat cat2 = new Cat
            {
                Age = 5,
                Name = "Phoenix"
            };

            Cat cat3 = new Cat("Phoenix");
            cat3.Age = 5;

            Cat cat4 = new Cat("Phoenix") 
            {
                Age= 5,
            };

            Cat cat5 = new Cat("Phoenix")
            {
                Age = 5,
                Name = "Universum"
            };

            // Person initialization EXAMPLE
            
            // this is a wrong way to initialize object in C#. It make code hard to read and understand
            Person person1 = new Person();
            person1.FirstName = "John";
            person1.LastName = "Smith";
            person1.Id = 1245151;    
            Address address = new Address();
            address.Country = "Germany";
            address.City = "Berlin";
            address.Region = "Doichland";
            address.Fax = 25534124;
            address.HomePage = "google.com";
            address.CountryCode = 2849;
            person1.Address = address;

            // it's the most use and right way to initialize object in C#. This way make code more readable, unlike the way above
            Person person2 = new Person()
            {
                FirstName = "John",
                LastName = "Smith",
                Id = 512454,
                Address = new Address
                {
                    Country = "Germany",
                    City = "Munchen",
                    Region = "Dusseldorf",
                    CountryCode = 523,
                    PostalCode = 2345,
                    Fax = 41412512,
                    Phone = 345451256,
                }
            };
        }
    }
}
