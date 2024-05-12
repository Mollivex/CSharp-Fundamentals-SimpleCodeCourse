using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

/*
 * ========================================
 * OOP | Static | Classes and Class Members
 * ========================================
 *  
 *      A static class is basically the same as a non-static class, but there is one difference: a static class cannot be instantiated. In other words, you cannot
 *  use the new operator to create a variable of the class type. Because there is no instance variable, you access the members of a static class by using the class
 *  name itself.
 *  
 *      The main purpose of using static classes in C# is to provide blueprints of its inherited classes. A static class is created using the static keyword in C# and .NET.
 *  A static class can contain static members only. You can't create an object for the static class.
 *      
 *      As is the case with all class types, the type information for a static class is loaded by the .NET runtime when the program that references the class is loaded.
 *  The program cannot specify exactly when the class is loaded. However, it's guaranteed to be loaded and to have its fields initialized and its static constructor called
 *  before the class is referenced for the firtst time in your program. A static constructor is only called one time, and a static class remains in memory for the lifetime
 *  of the application domain in which your program resides.
 *  
 *      #The following list provides the main features of a static class:
 *          
 *          #| Contains only static members.
 *          
 *          #| Cannot be created.
 *          
 *          #| Is sealed.
 *          
 *          #| Cannot contain instance constructors
 *  
 *      Creating a static class is therefore basically the same as creating a class that contains only static members and a private constructor. A private constructor prevents
 *  the class from being created. The advantage of using a static class is that the compiler can check to make sure that no instance members are accidentlly added. The compiler
 *  will guarantee that instance of this class cannot be created.
 *  
 *      Static class are sealed and therefore cannot be inherited. They cannot inherit from any class or interface except Object. Static classes cannot contain an instance constructor.
 *  However, they can contain a static constructor. Non-static classes should also define a static constructor if the class conatins static members that require non-trivial initialization.
 *  
 *  -----------------------------
 *  Advantages of Static Classes:   #| You will get an error if you declare any member as a non-static member.
 *  -----------------------------
 *                                  #| When you try to create an instance to the static class, it again generates a compile time error because the static members
 *                                     can be accessed directly with their class name.
 *                                  
 *                                  #| The static keyword is used before the class keyword in a class definition to declare a static class.
 *                                  
 *                                  #| Static class members are accessed by the class name followed by the member name.
 *  
 *  -----------------------------------------------------------------------------------------------------------------------------------------------------------------
 *  EXAMPLE BELOW | Here is an example of a static class that contains two methods that convert temperature from Celsius to Fahrenheit and from Fahrenheit to Celsius
 *  -----------------------------------------------------------------------------------------------------------------------------------------------------------------
 */

namespace MyProject_94
{
    public static class TemperatureConverter
    {
        /// <summary>
        /// Celsius to Fahrenheit Converter
        /// </summary>
        /// <param name="temperatureCelsius"></param>
        /// <returns></returns>
        public static double CelsiusToFahrenheit(string temperatureCelsius)
        {
            // convert argument to double for calculations:
            double celsius = Double.Parse(temperatureCelsius);

            // convert Celsius to Fahrenheit:
            double fahrenheit = (celsius * 9 / 5) + 32;

            return fahrenheit;
        }

        /// <summary>
        /// Fahrenheit to Celsius Converter
        /// </summary>
        /// <param name="temperatureFahrenheit"></param>
        /// <returns></returns>
        public static double FahrenheitToCelsius(string temperatureFahrenheit)
        {
            // convert argument to double for calculations:
            double fahrenheit = Double.Parse(temperatureFahrenheit);

            // convert Fahrenheit to Celsius:
            double celsius = (fahrenheit - 32) * 5 / 9;

            return celsius;
        }
    }
    class TestTemperatureConverter
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please select the convertor direction");
                Console.WriteLine("1. From Celsius to Fahrenheit.");
                Console.WriteLine("2. From Fahrenheit to Celsius.");
                Console.Write("Your choice: ");

                string? selection = Console.ReadLine();
                double F, C = 0;

                switch (selection)
                {
                    case "1":
                        Console.Write("Please enter the Celsius temperature: ");
                        F = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine() ?? "0");
                        Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);
                        break;

                    case "2":
                        Console.Write("Please enter the Fahrenheit temperature: ");
                        C = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine() ?? "0");
                        Console.WriteLine("Temperature in Celsius: {0:F2}", C);
                        break;

                    default:
                        Console.WriteLine("Please select a convertor.");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
