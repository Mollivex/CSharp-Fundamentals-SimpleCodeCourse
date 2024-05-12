using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/* 
 *
 *   LOGICAL OPERATORS
 *
 *       &&  - AND (It returns true if both operands are non-zero)
 *   
 *       ||  - OR (It returns true if any one operand becomes a non-zero)
 *   
 *       !   - NOT (It will return the reverse of a logical state that means if both operands are non-zero, it will return false)
 *
 *   - Logical Operators are useful to perform the logical operation between two operands like AND, OR, and NOT based on our requirements. 
 *   - The Logical Operators will always work with Boolean expressions (true or false) and return Boolean values. 
 *   - The operands in logical operators must always contain only Boolean values.
 *
 */

namespace MyProject_09
{
    internal class Program
    {
        public static bool GetTemperature()
        {
            return true;
        }
        public static bool GetCooling()
        {
            return true;
        }
        static void Main(string[] args)
        {
            int fanSpeed = 3000;

            bool isHighTemperature = false;

            bool hasNoCooling = fanSpeed <= 0;

            if (isHighTemperature || hasNoCooling)
            {
                Console.WriteLine("Danger of PC explosion!");
            }

            if (GetCooling() || GetTemperature())
            {
                Console.WriteLine("Danger!! PC Explosion appereance");
            }
        }
        
    }
}
