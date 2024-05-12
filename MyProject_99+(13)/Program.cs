using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ==========================================
 * OOP | Abstraction | Classes and Methods #1
 * ==========================================
 * 
 *      In C#, an abstract class is a class that cannot be instantiated. Instead, it serves as a base class for other classes to inherit from. Abstract classes 
 *  are used to define a common set of behaviors or properties that derived classes should have.
 * 
 *      Data abstraction is the process of hiding certain details and showing only essential information to the user.
 *  Abstraction can be achieved with either abstract classes or interfaces.
 *  
 *  ----------------------------------------------------------------------------------------------------------------------------------------------------------
 *      The 'abstract' keyword is used for classes and methods:
 *      
 *          #| Abstract class:  is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).
 *          
 *          #| Abstract method: can only be used in an abstract class, and it doesn't have a body. The body is provided by the derived class(inherited from).
 *  ----------------------------------------------------------------------------------------------------------------------------------------------------------
 *          
 *      An abstract class can have both abstract and regular methods.
 *      
 *      Need to remember, that it's not possible to create an instance of the abstract class.
 *      
 *      To access the abstract class, it must be inherited from another class. It can be realized with Polymorphism.
 *      
 *  ------------------------------------------------------------------------------------------------------------------------------------------------------------------
 *  NOTE: Remember from the Inheritance, that we use the ':' symbol to inherit from a class, and that we use the 'override' keyword to override the base class method.
 *  ------------------------------------------------------------------------------------------------------------------------------------------------------------------
 * 
 * ----------------------------------------------------------
 * -?- Why and When to Use Abstract Classes and Methods -?- | : To achieve security - hide certain details and only show the important details of an object.
 * ----------------------------------------------------------   Note: Abstraction can also be achieved with Interfaces.
 *      
 * ----------------------------------------------------------------------------------------------------
 * NOTE: We can use abstract class only as a base class. This is why abstract classes cannot be sealed.
 * ----------------------------------------------------------------------------------------------------
 * 
 * -----------------------------------
 * Important points about Abstraction:  #|  Generally, we use abstract class at the time of inheritance.
 * -----------------------------------
 *                                      #|  A user must use the override keyword berfore the method is declared as abstract in the child class,
 *                                          the abstract class if used to inherit in the child class.
 *                                          
 *                                      #|  An abstract class cannot be inherited by structures.
 *                                      
 *                                      #|  It can contain constructors and destructors.
 *                                      
 *                                      #|  It can implement functions with non-Abstract methods.
 *                                      
 *                                      #|  It cannot support multiple inheritances.
 *                                      
 *                                      #|  It cannot be static. 
 *                                      
 * ----------------------------------------------------------------------------------------------------
 * NOTE: Unlike the C# inheritance, we cannot use 'virual' with the abstract methods of the base class.
 *       This is because an abstract class is implicitly virtual.
 * ----------------------------------------------------------------------------------------------------
 * 
 */

namespace MyProject_112
{
    abstract class Weapon
    {
        public abstract int Damage { get; } 
        public abstract void Fire();

        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} Damage: {Damage}");
        }
    }
    class Gun : Weapon
    {
        public override int Damage { get { return 5; } }

        public override void Fire()
        {
            Console.WriteLine("Boom-boom!");
        }
    }
    class LaserGun : Weapon
    {
        public override int Damage => 9;

        public override void Fire()
        {
            Console.WriteLine("Bom-bom!");
        }
    }
    class Bow : Weapon
    {
        public override int Damage => 3;

        public override void Fire()
        {
            Console.WriteLine("Bam-bam!");
        }
    }
    class Player
    {
        public void Fire(Weapon weapon)
        {
            weapon.Fire();
        }
        public void CheckInfo(Weapon weapon)
        {
            weapon.ShowInfo();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Weapon[] inventory = {new Gun(), new LaserGun(), new Bow()};

            foreach (var item in inventory)
            {
                player.CheckInfo(item);
                player.Fire(item);
                Console.WriteLine();
            }
        }
    }
}
