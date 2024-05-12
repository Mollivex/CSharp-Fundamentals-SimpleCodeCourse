using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *      Notice that when an indexer's access is evaluated, for example, in a Console.Write statement the get accessor
 *  is invoked. Therefore, if no get acccessor exists, a compile-time error occurs.
 * 
 * 
 */

namespace MyProject_134
{
    /// <summary>
    ///     The following example shows how to declare a private arrat field, temps, and an indexer.
    /// The indexer enables direct access to the instance tempRecord[i]. The alternative to using the indexer
    /// is to declare tge array as a public member and access its members, tempRecord.temps[i], directly.
    /// </summary>
    public class TempRecord
    {
        // Array of temperature values
        float[] temps = new float[10]
        {
            56.2F, 56.7F, 56.5F,56.8F,58.8F,
            61.3F, 65.9F, 62.1F, 59.2F, 57.5F
        };

        // To enable client code to validate input when accessing your indexer
        public int Length => temps.Length;

        // Indexer declaration
        // If index is out of range, the temps array will throw the exception
        public float this[int index]
        {
            get => temps[index];
            set => temps[index] = value;
        }
    }
}
