using MyProject_114;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_114
{
    interface IDataProcessor
    {
        void ProcessData(IDataProvider dataProvider);
    }
}
