using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ==============================
 * NULL conditional operator (?.)
 * ==============================
 * 
 * #NOTE: Often conditional NULL operator (?.) is used with coalescing NULL operator (??). You can see example below:
 */

namespace MyProject_52
{
    class Program
    {
        /// <summary>
        /// Creates the array with elements 1 to 7
        /// </summary>
        /// <returns></returns>
        static int[] GetArray()
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7 }; // value can be null;
            return myArray;
        }
        static Person GetPerson()
        {
            Person person = new Person() { Contacts = new Contacts() { PhoneNumber = "\n079234662" } };
            return person;
        }
        static void Main(string[] args)
        {
            int[] myArray = GetArray();
            
            // conditional NULL operator ?. checks if variable equal with null or not, and then coalescing NULL operator ?? set current value of element or default value (depends of data type).
            Console.WriteLine("Array elements sum: {0}", (myArray?.Sum() ?? 0));

            Console.WriteLine("\n==============================");

            Person person = GetPerson();
            Console.WriteLine(person?.Contacts?.PhoneNumber ?? "Doesn't exist"); 

            Console.ReadLine();
        }
    }
}
