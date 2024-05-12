using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ======================================================
 * Structures in C# | Declaration | Fields | Constructors
 * ======================================================
 * 
 *      A structure in C# is simply a composit data type consisting of a number elements of other types. A C# structure is a value and 
 *  the instances of objects of a structure are created in stack. The structure in C# can contain fields, methods, constants, constructors,
 *  properties, indexers, operator and even other structure types.
 *  
 * ----------------------------------------
 * Structure Declaration & Object Creation:
 * ----------------------------------------
 * 
 *      The keyword 'struct' can be used to declare a structure. The general form of a structure declaration in C# is as follows:
 *                      
 *                      <modifier> struct <struct_name>
 *                      {
 *                          // Structure members;
 *                      }
 *                      
 *      Where the modifier can be private, public or internal. The struct is the required keywod.
 *      
 *      The objects of a struct can be created by using the new operator as follows:
 *                      
 *                      MyStruct myStruct = new MyStruct();
 *                      
 *      If you declare a variable of 'struct' type without using 'new' keyword, it doesn't call any constuctor, so all the members remain
 *  unassigned. Therefor, you must assign values to each member before accessing them, otherwise, it will give a compile-time error.
 * 
 * -----------------
 * Structs & Fields:
 * -----------------
 *      
 *      A struct in C# can contain fields. These fields can be declared as private, public or internal. Remember that inside a struct,
 *  we can only declare a field. We can't initialize a field inside a struct. However we can use constuctor to initialize the structure fields.
 * 
 *      However a struct can contain static fields, which can be initialized inside the struct.
 *  Remember that static fields can't be accessed by an instance of a struct. We can access them only by using the struct name.
 * 
 * -----------------------------------------------------------------------------------------------------------------------------------------------------
 * Struct & Methods: A C# struct can also contain methods. The methods can either static or non-static. But static methods can access only other static 
 * ----------------- members and they can't invoke by using an object of the structure. They can invoke only by using the struct name.------------------
 * 
 * -----------------------
 * Structs & Constructors:
 * -----------------------
 *      
 *      A C# struct can declare constructor, but they must take parameters. A default constructor (constructor wihout any parameters) are always provided to 
 *  initialize the struct fields to their default values. The parameterized constructor inside a struct can also be overloaded
 *  
 *      The 'this' operator can also be used in constructors and parameterized constructor can be chained inside a C# constructor.
 *      
 *      You must include all the members of the struct in the parameterized constructor and assign parameters to members, otherwise, C# compiler will give a 
 *  compile-time error if any members remains unassigned.
 *  
 * ---------------------------------------------------------------------------------------------------------------------
 * C# structs properties: #| A struct is used to improve the performance and clarity of code.
 * ---------------------- #| A struct uses fewer resources in memory than a class.
 *                        #| When we have small and frequent use of some work, we should use structs over classes.
 *                        #| Performance can suffer when using structures in situations where reference types are 
 *                           expected due to boxing and unboxing.
 *                        #| You should pass structs to method as ref parameters in order to avoid the performance
 *                           loss associated with copying data.
 *                        #| Structs reside on the stack, so we should keep them small.
 *                        #| Structs can't be inherited and we can say they are implicitly sealed.
 *                        #| Structure implicitly inherits from System.ValueType, which also inherits from System.Object.
 *                        #| The default constructor of a structure initializes each field to a default value. You cannot
 *                           replace the default constructor of a structure.
 *                        #| You can't define destructor for structs.
 *  
 * 
 */

namespace MyProject_121
{
    class Program
    {
        public struct Student
        {
            int id;
            int zipcode;
            double salary;

            // all the members of the struct has to be initialized in this way
            public Student (int id, int zipcode, double salary)
            {
                this.id = id;
                this.zipcode = zipcode;
                this.salary = salary;
            }

            // all the members of the struct has to be initialized either in this way
            public Student(int id, int zipcode)
            {
                this.id = id;
                this.zipcode = zipcode;
                this.salary = 3400.00;
            }

            // if you left any member of a struct uninitialized it will give error
            // code below will give error, because the zipcode and salary field if left uninitialized
            // {  
            //  this.id = id;  
            // }  
            // struct can also have copy constructor but have to be fully initialzed
            
            public Student(Student studentName)
            {
                this.id = studentName.id;
                this.zipcode = studentName.zipcode;
                this.salary = studentName.salary;
            }
            public void DisplayValues()
            {
                Console.WriteLine("ID: " + this.id.ToString());
                Console.WriteLine("Zipcode : " + this.zipcode.ToString());
                Console.WriteLine("Salary : " + this.salary.ToString());
            }
        }
        static void Main(string[] args)
        {
            Student student = new Student(12, 2023045, 4560.00);
            Student student2 = new Student(student);

            student.DisplayValues();
            Console.WriteLine("Copy constructor values");
            student2.DisplayValues();

            Console.ReadLine();
        }
    }
}
