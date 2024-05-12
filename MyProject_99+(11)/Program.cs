using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ======================================
 * OOP | Polymorphism | override Modifier
 * ======================================
 * 
 *      The 'override' modifier is required to extend or modify the abstaract or virtual implementation of an inherited method, property, indexer, or event.
 *      
 *      An override method provides a new implementation of the method inherited from a base class. The method that is overridden by an override declaration
 *  is known as the overriden base method. An override method must have the same signature as the overriden base method. Override methods support covariant 
 *  return types. In particular, the return type of an override method can derive from the return type of the corresponding base method.
 *      
 *      You cannot override a non-virtual, or static method. The overridden base method must be virtual, abstract or override.
 *      
 *      An override declaration cannot change the accessibility of the virtual method. Both the override method and the virtual method must have the same
 *  access level modifier.
 *  
 *      You cannot use the new, static, or virtual modifiers to modifty an override method.
 *      
 *      An overriding property declaration must specify exactly the same access modifier, type, and name as the inherited property. Beginning with C# 9.0,
 *  read-only overriding properties support covariant return types. The overridden property must be virtual, abstract, or override.
 * 
 * ------------------------------------------------------------------------------------------------------------------------------------------------------------------
 * Example:   This example defines a base class named Employee, and a derived class named SalesEmployee. The SalesEmployee class includes an extra filed, salesbonus,
 * --------   and overrides the method CalculatePay in order to take it into account.   -----------------------------------------------------------------------------
 * 
 */

namespace MyProject_110
{
    class TestOverride
    {
        public class Employee
        {
            public string Name { get; }

            // Basepay is defined as protected, so that it may be accessed only by this class and derived classes
            protected decimal basepay;

            // Constructor to set the name and basepay values.
            public Employee(string name, decimal basepay)
            {
                Name = name;
                this.basepay = basepay;
            }

            // Declared virtual so it can be overridden.
            public virtual decimal CalculatePay()
            {
                return basepay;
            }
        }   
        //Derive a new class from Employee.
        public class SalesEmployee : Employee
        {
            // New field that will affect the base pay.
            private decimal salesbonus;

            // The constructor calls the base0class version, and initilizes the salesbonus field.
            public SalesEmployee(string name, decimal basepay, decimal salesbonus) : base(name, basepay)
            {
                this.salesbonus = salesbonus;
            }

            //  Override the CalculatePay method to take bonus into account.
            public override decimal CalculatePay()
            {
                return basepay + salesbonus;
            }
            static void Main(string[] args)
            {
                // Create some new employees.
                var employee1 = new SalesEmployee("Alice", 1000, 500);
                var employee2 = new SalesEmployee("Mike", 1500, 200);
                var employee3 = new Employee("Bob", 1200);

                Console.WriteLine($"Employee1 {employee1.Name} earned: {employee1.CalculatePay()}");
                Console.WriteLine($"Employee1 {employee2.Name} earned: {employee2.CalculatePay()}");
                Console.WriteLine($"Employee1 {employee3.Name} earned: {employee3.CalculatePay()}");
            }
        }
    }
}
