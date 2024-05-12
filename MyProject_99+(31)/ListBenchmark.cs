using BenchmarkDotNet.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_130
{
    [MemoryDiagnoser]
    public class ListsBenchmark
    {
        [Benchmark]
        public void ArrayListBenchmark()
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < 1000; i++)
            {
                arrayList.Add(i);
            }
        }
        [Benchmark]
        public void ListBenchmark()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(i);
            }
        }
        [Benchmark]
        public void ObjectListBenchmark()
        {
            List<object> list = new List<object>();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(i);
            }
        }
    }
}
