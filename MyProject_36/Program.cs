using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/*
 * 
 * Arrays. Real work #SimpleCode LINQ methods 
 * 
 */

namespace MyProject_36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Original declared one-dimension array:
            int[] myArray = { 14, 45, 41, -22, 24, 1, 1, 53, 22, 4, -2, 3, 41, 4 };
            Console.WriteLine("=========================================================================================");

            Console.Write("\nOriginal declared one-dimension array: ");
            for (int i = 0;i < myArray.Length; i++) 
            {
                Console.Write("{0} ",myArray[i]);
            }
            Console.WriteLine();
            Console.WriteLine("\n=========================================================================================");

            // Length of an array:
            Console.WriteLine("\nLength of an array: {0}", myArray.Length);
            Console.WriteLine("\n=========================================================================================");

            // MIN and MAX values of an array:
            Console.WriteLine("\nMIN value of an array: {0}",myArray.Min());
            Console.WriteLine("MAX value of an array: {0}", myArray.Max());
            Console.WriteLine("\n=========================================================================================");

            // SUM of ALL, EVEN and ODD values in an array:
            Console.WriteLine("\nSUM of ALL values in an array: {0}", myArray.Sum());
            Console.WriteLine("SUM of EVEN values in an array: {0}", myArray.Where(i => i % 2 == 0).Sum());
            Console.WriteLine("SUM of ODD values in an array: {0}", myArray.Where(i => i % 2 != 0).Sum());
            Console.WriteLine("\n=========================================================================================");

            // The smallest and biggest EVEN and ODD values in an array:
            Console.WriteLine("\nThe smallest EVEN value in an array: {0}", myArray.Where(i => i % 2 == 0).Min());
            Console.WriteLine("The biggest EVEN value in an array: {0}", myArray.Where(i => i % 2 == 0).Max());
            Console.WriteLine("The smallest ODD value in an array: {0}", myArray.Where(i => i % 2 != 0).Min());
            Console.WriteLine("The biggest ODD value in an array: {0}", myArray.Where(i => i % 2 != 0).Max());
            Console.WriteLine("\n=========================================================================================");

            // Show only UNIQUE elements in an array:
            Console.Write("\nUnique elements in array: ");

            int[] resultUnique = myArray.Distinct().ToArray();
            try
            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write("{0} ", resultUnique[i]);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("");
            }
            Console.WriteLine("\n=========================================================================================");


            // Sorting elements by descending and ascending in an array:

            int[] resultSortDesc = myArray.OrderByDescending(i => i).ToArray();
            int[] resultSortAsc = myArray.OrderBy(i => i).ToArray();

            Console.WriteLine("\nSorting array by descending and ascending: ");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("\t\t\t{0}\t\t{1}", resultSortDesc[i], resultSortAsc[i]);
            }
            Console.WriteLine("\n=========================================================================================");

            // Find values in an array less THEN...\\

            // Method Find starts action from beginning of the array

            Console.Write("\nValues in array less THEN 35 (Method Find): ");
            int resultFind1 = Array.Find(myArray, i => i < 35); 
            Console.Write(resultFind1);

            // Method FindLast starts action from ending of the array

            Console.Write("\nValues in array less THEN 35 (Method FindLast): ");
            int resultFind2 = Array.FindLast(myArray, i => i < 35); 
            Console.Write(resultFind2);

            // Method FindAll finds all elements that are able to statement

            Console.Write("\nValues in array less THEN 35 (Method FindAll): ");
            int[] resultFind3 = Array.FindAll(myArray, i => i < 35);

            try
            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write("{0} ", resultFind3[i]);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("");
            }
            Console.WriteLine("\n=========================================================================================");

            // Method FindIndex obtains position number of an element with defined value from BEGINNING of an array

            int resultIndex1 = Array.FindIndex(myArray, i => i == 41);
            Console.WriteLine("\n(Method FindIndex) Element from BEGIN of array, that has value 41 is on position {0}", resultIndex1);

            // Method FindLastIndex obtains position number of an element with defined value from ENDING of an array

            int resultIndex2 = Array.FindLastIndex(myArray, i => i == 41);
            Console.WriteLine("(Method FindLastIndex) Element from END of array, that has value 41 is on position {0}", resultIndex2);
            
            Console.WriteLine("\n=========================================================================================");

            // LINQ methods. Obtain number of an element with defined value from BEGINNING of an array
            int resultFirst = myArray.Where(i => i > 34).First();
            Console.WriteLine("\nElement from BEGIN of array, that has value 34 is {0}", resultFirst);

            // Method FirstOrDefault returns default value (for int is 0), if it did't find value on condition
            int resultFirstOrDefault = myArray.Where(i => i > 340).FirstOrDefault();
            Console.WriteLine("Element from BEGIN of array, that has value 340 is {0}", resultFirstOrDefault);

            Console.WriteLine("\n=========================================================================================");
            // LINQ methods. Obtain number of an element with defined value from ENDING of an array

            int resultLast = myArray.Where(i => i > 34).Last();
            Console.WriteLine("\nElement from END of array, that has value 34 is {0}", resultLast);

            // Method LastOrDefault return default value (for int is 0), if it did't find value on condition
            int resultLastOrDefault = myArray.Where(i => i > 340).LastOrDefault();
            Console.WriteLine("Element from END of array, that has value 340 is {0}", resultLastOrDefault);
            
            Console.WriteLine("\n=========================================================================================");

            //==============================================================================//
            Console.WriteLine("\n");
        }
    }
}

int resFirst = myArr.Where(i => i > 34).First();
int resLast = myArr.Where(i => i > 34).Last();

int resFirstOrDef = myArr.Where(i => i > 340).FirstOrDefault();
int resLastOrDef = myArr.Where(i => i > 340).LastOrDefault();


