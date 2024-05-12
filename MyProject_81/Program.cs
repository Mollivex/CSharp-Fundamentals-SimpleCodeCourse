using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ===================
 * OOP | Encapsulation
 * ===================
 * 
 *      Encapsulation, in the context of C#, refers to an object's ability to hide data and behavior that are not necessary to its user. Encapsulation enables a group of
 *  properties, methods and other members to be considered a single unit or object.
 *  
 *  #The following are the benifits of encapsulation:
 *      
 *      -!- Protection of data from accidental corruption.
 *      
 *      -!- Specification of the accessibility of each of the members of a class to the code outside the class.
 *      
 *      -!- Flexibility and extensibility of the code and reduction in complexity.
 *      
 *      -!- Lower coupling between objects and hence improvement in code maintainability.
 *      
 *     Encapsulation is used to restrict access to the members of a class so as to prevent the user of a given class from manipulating objects in ways that aren't intended
 *  by the designer. While encapsulation hides the internal implementation of the functionalities of class without affecting the overall functioning of the system, it allows 
 *  the class to service a request for functionality and add or modify its internal structure (data or methods) to suit changing requirements.
 * 
 *     Encapsulation is a fundamental concept in object-oriented programming (OOP) that refers to the bundling of data and the methods that operate on that data wihthin a 
 *  single unit. In C#, this is typically achieved through the use of classes.
 *  
 *     The idea behind encapsulation is to keep the implementation details of a class hidden from the outside world, and to only expose a public interface that allows users
 *  to interact with the class in a controlled and safe manner. This helps to promote modularity, maintainability, and flexibility in the design of software systems.
 */

namespace MyProject_81
{
    class Gun
    {
        private  bool isLoaded;

        private void Reload()
        {
            Console.WriteLine("Reloading...");
            isLoaded = true;
            Console.WriteLine("Reloaded!");
        }
        public void Shoot()
        {
            if (!isLoaded)
            {
                Console.WriteLine("Gun isn't reloaded!");
                Reload();
            }
            Console.WriteLine("Fire!");
            Console.WriteLine("Bang - Bang!\n");
            isLoaded = true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun();
            gun.Shoot();
        }
    }
}
