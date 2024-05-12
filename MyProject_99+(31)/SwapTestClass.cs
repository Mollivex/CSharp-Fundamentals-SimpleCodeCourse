using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_130
{
    public class SwapTestClass
    {
        // generic Swap version
        public static void GenericSwap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        // non-generic Swap version
        public static void Swap(ref object a, ref object b)
        {
            object temp = a;
            a = b;
            b = temp;
        }
    }
}
