using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_123
{
    public class MyParser
    {
        public int TryCatchParse(string str)
        {
            int result;
            try
            {
                result = int.Parse(str);
            }
            catch (Exception)
            {
                result = 0;
            }
            return result; 
        }
        public int TryParse(string str)
        {
            int result;
            if (!int.TryParse(str, out result))
            {
                result = 0;
            }
            return result;
        }
        public int TryParseFixed(string str)
        {
            int result;
            int.TryParse(str, out result);
            return result;
        }
    }
}
