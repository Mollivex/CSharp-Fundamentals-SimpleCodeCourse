using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*
 * =========================================
 * OOP | Interfaces in C# | Example of using
 * =========================================
 * 
 *      An interface defines a contract. Any class or struct that implements that contract must provide an implementation of the members
 *  defined in the interface. An interface may define a default implementation for members. It may also define static members in order to
 *  provide a single implementation for common functionality.
 *  
 *      To access the interface methods, the interface must be implemented by another class. To implement an interface, use the ':' symbol.
 *  The body of the interface method is provided by the implement class. Note that you don't have to use the 'override' keyword when
 *  implementing an interface.
 *  
 * ----------------------------------------------------------------------------------------------------------------------------------------------
 *      It's considered good practice to start with the letter "I" at the beginning of an interface, as it makes it easier for yourself and other
 *  to remember that it's an interface and not a class.
 *  
 *      By default, members of an interface are abstract and public.
 *      
 *      NOTE: Interfaces can contain properties and methods, but not fields
 * ----------------------------------------------------------------------------------------------------------------------------------------------
 * 
 *  -!-!- In the example below, we just modified the previous example using 'Abstraction' and implemented the interfaces -!-!-
 * 
 */

namespace MyProject_115
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Weapon[] inventory = { new Gun(), new LaserGun(), new Bow() };

            foreach (var item in inventory)
            {
                player.CheckInfo(item);
                player.Fire(item);
                Console.WriteLine();
            }
            player.CheckInfo(new Box());
            player.CheckInfo(new Door());

            Console.WriteLine();
        }
    }
}
