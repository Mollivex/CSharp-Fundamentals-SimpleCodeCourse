using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * =============================================
 * OOP | Interfaces in C# | Multiple Inheritance
 * =============================================
 * 
 *      By using interfaces, you can, for example, include behavior from multiple sources in a class. That capability is important in C# because
 *  the language doesn't support multiple inheritance of classes. In addition, you must use an interface if you want to simulate inheritance for
 *  for structs, because they can't actually inherit from another struct or class.
 *  
 *      Interfaces can inherit from one or more interfaces. The derived class inherits the members from its base interfaces. A class that implements 
 *  a derived interface must implement all members in the derived interface, including all members of the derived interface's base interfaces.
 *  
 *      That class may be implicitly coverted to the derived interface of any of its base interfaces. A class might include an interface multiple times 
 *  through base classes that it inherits or through interfaces that other interfaces inherit.
 * 
 */

namespace MyProject_116
{
    interface IWeapon
    {
        void Fire();
    }
    interface IThrowingWeapon : IWeapon
    {
        void Throw();
    }
    class Gun : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Boom-boom!");
        }
    }
    class LaserGun : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Pew-pew!");
        }
    }
    class Knife : IThrowingWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Htch!");
        }
        public void Throw()
        {
            Console.WriteLine($"{GetType().Name}: Weee!");
        }
    }
    class Axe : IThrowingWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: HTCH!");
        }
        public void Throw()
        {
            Console.WriteLine($"{GetType().Name}: WEEEE!");
        }
    }
    class Player
    {
        public void Fire(IWeapon weapon)
        {
            weapon.Fire();
        }
        public void Throw(IThrowingWeapon throwingWeapon)
        {
            throwingWeapon.Throw();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            IWeapon[] inventory = { new Gun(), new LaserGun(), new Knife(), new Axe() };

            foreach (var item in inventory)
            {
                player.Fire(item);
                Console.WriteLine();
            }

            player.Throw(new Knife());
            player.Throw(new  Axe());
        }
    }
}
