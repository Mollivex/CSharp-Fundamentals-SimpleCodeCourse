using MyProject_114;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_114
{
    class ConsoleDataProcessor : IDataProcessor
    {
        public void ProcessData(IDataProvider dataProvider)
        {
            Console.WriteLine(dataProvider.GetData());
        }
    }
}
