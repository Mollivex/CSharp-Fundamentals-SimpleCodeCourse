using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/*
 *  - Inputting data to Console
 *  
 *  - Converting String to Int Methods (Parse /Convert to/ TryParse)
 */

namespace MyProject_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;

            // Parse Method

            str = Console.ReadLine();   
            int a = int.Parse(str);

            // Convert to Method

            str= Console.ReadLine();
            int c = Convert.ToInt32(str);

            // Try-Parse Method

            string numberStr = Console.ReadLine();
            int number;

            bool isParsable = Int32.TryParse(numberStr, out number);
            if (isParsable)
                Console.WriteLine("Number parsed");
            else
                Console.WriteLine("Could not be parsed");
        }
    }
}
