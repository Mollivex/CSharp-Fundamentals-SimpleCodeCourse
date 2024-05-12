using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ===============================================
 * OOP | Properties | Get and Set | #value Keyword
 * ===============================================
 * 
 *      #Before explaining properties, it should be a basic understanting of Encapsulation.
 *      
 *      The meaning of Encapsulation, ism to make sure that "sensitive" data is hidden from users. To achive this, you must:
 *              - declare fields/variables as private;
 *              - provide public \get and \set methods, through properties, to access and update the value of a private field.
 * 
 * -----------
 * Properties:
 * -----------
 *      In C#, properties can contain one or two code blocks called accessors, and those are called a \get accessor and \set accessor.
 *  By using \get and \set accessors, we can change the internal implementation of class variables and expose them without affecting the external way of accessing it based on our requirements.
 * 
 *      As we know the private variables can only be accessed within the same class (an outside class has no access to it). However, sometimes we need to access them - and it can be done with properties.
 * 
 * ----------
 * Syntax C#:  Following is the syntax of defining a property with \get and \set accessor in C# programming language.
 * ----------               
 *                          <access_modified> <return_type> <property_name>
 *                          {
 *                              get
 *                              {
 *                                  // Return the property value
 *                              }
 *                              set
 *                              {
 *                                  // Set a new value
 *                              }
 *                          }
 * 
 *             We used an access modifier and return type to define a property along with \get and \set accessors to make required modifications to the class variables based on our requirements.
 * 
 * ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------    
 *  #EXAMPLE:    A property is like a combination of a variable and a method, and it has two methods: a \get and a \set method
 *                          
 *                          class Person
 *                          {
 *                              private string name; // field
 *                              
 *                              public string Name; // property
 *                              {
 *                                  get { return name;} // get method
 *                                  set { name = value; } // set method
 *                              }
 *                          }
 * -!- Example explained: The Name property is associated with the name field. It is a good practice to use the same name for both the property and the private field, but with an uppercase first letter.
 * 
 *                        The \get method returns the value of the variable name.
 *                        
 *                        The \set method assigns a value to the name variable. The value keyword represents the value we assign to the property.
 * --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
 * 
 *  In C#, the properties are categorized into three type, those are:
 *  
 *  ### Read-Write   |   A property that contains a both \get and \set accessors, then we will call it a read-write property.
 *  
 *  ### Read-Only    |   A property that contains only \get accessor, then we will call it a read-only property.
 *  
 *  ### Write-Only   |   A property that contains only \set accessor, then we will call it a write-only property.
 *  
 * -------------------------------------------------
 * C# Properties Overview | Imporant points TO KNOW:
 * -------------------------------------------------
 * 
 *      The following  are the important points that we need to remember about properties in the C# programming language:
 *      
 *          -!- In C#, properties will enable class variables to expose in a public way using \get and \set accessors by hiding implementation details.
 *          
 *          -!- In properties, a \get accessor is used to return a property value and a \set accessor is used to assign a new value.
 *          
 *          -!- The #value keyword in \set accessor is used to define a value that is going to be assigned by the \set accessor.
 *          
 *          -!- In C#, the properties are categorized as read-write, read-only, or write-only.
 *  
 *  
 *  NOTE: -propfull | snippet for creating properties syntax C#
 *        -prop     | snippet for creating automatic properties C#
 *        -ctor     | snippet for creating constructor syntax C#
 */

namespace MyProject_87
{
    class Point
    {
        private int x;
        public void SetX(int x) // Setter
        {
            if (x < 1)
            {
                this.x = 1;
                return;
            }
            if (x > 5)
            {
                this.x = 5;
                return;
            }
            this.x = x;
        }
        public int GetX() // Getter
        {
            return x;
        }

        private int y;
        public int Y
        {
            get // get accessor
            { 
                return y;
            }
            set // set accessor
            {
                if (value < 1)
                {
                    y = 1;
                    return;
                }
                if (value > 5)
                {
                    y = 5;
                    return;
                }
                y = value;
            }
        }

        private int z;
        public int Z 
        {
            get
            {
                return z;
            }
            set
            {
                if(value < 1)
                {
                    z = 1;
                    return;
                }
                if(value > 5)
                {
                    z = 5;
                    return;
                }
            }
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();

            point.GetX();   // accessors like a methods
            point.SetX(10); // setters like a methods

            point.Y = 10; // with help of the set accessor we can set a defined value for the class object
            int y = point.Y; // with help of the get accessor we can get info about the class object

            point.Z = 10; // set
            int z = point.Z; // get
        }
    }
}
