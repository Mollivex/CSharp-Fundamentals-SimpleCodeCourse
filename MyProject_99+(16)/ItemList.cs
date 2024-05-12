using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_115
{
    class Box : IHasInfo
    {
        public void ShowInfo()
        {
            Console.WriteLine("AMA BOX");
        }
    }
    class Door : IHasInfo
    {
        public void ShowInfo()
        {
            Console.WriteLine("AMA DOOR");
        }
    }
}
