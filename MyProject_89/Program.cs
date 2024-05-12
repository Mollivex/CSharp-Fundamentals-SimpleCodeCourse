using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ========================================
 * OOP | Properties | Get and Set | Example
 * ========================================
 * 
 *      Following is an example of defining properties with \get and \set accessors to implement required
 *  validations without affecting the external way of using it in the C# programming language.
 * 
 *                                  ................................
 *                                 | IMAGINE HERE IS THE CODE BELOW |
 *                                  ................................
 *                                  
 *      If you observe the above example, we are extending the behaviour of of private variables (name, location)
 *  using properties (Name, Location) with \get and \set accessors by performing some validations like making sure 
 *  Name value equals to only "Suresh" using \set accessor and converting property text to uppercase with \get accessor.
 *  
 *      If you observe result in Console, our variable text converted to upper case, and even after we set the variable 
 *  text as "Rohini", it displayed text as "Suresh Dasari" because of the set accessor validation fails in the property.
 *  
 *  NOTE: -propfull | snippet for creating properties syntax C#
 *        -prop     | snippet for creating automatic properties C#
 *        -ctor     | snippet for creating constructor syntax C#
 * 
 */

namespace MyProject_89
{
    class User
    {
        private string location;
        private string name = "Suresh Dasari";
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string Name
        {
            get 
            {
                return name.ToUpper();
            }
            set 
            {
                if (value == "Suresh")
                    name = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();

            // set accessor will invoke
            u.Name = "Rohini";

            // set accessor will invoke
            u.Location = "Hyderabad";

            // get accessor will invoke
            Console.WriteLine("Name: " + u.Name);

            // get accessor will invoke
            Console.WriteLine("Location: " + u.Location);

            Console.WriteLine("\nPress Enter Key to Exit...");
            Console.ReadLine();

        }
    }
}
