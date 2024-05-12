using BenchmarkDotNet.Attributes;

namespace MyProject_130
{
    [MemoryDiagnoser]
    public class SwapsBenchmark
    {
        [Benchmark]
        public void GenericSwapBenchmark()
        {
            double a = 1;
            double b = 5.6;
            SwapTestClass.GenericSwap(ref a, ref b);
        }

        [Benchmark]
        public void SwapBenchmark()
        {
            object p1 = 2;
            object p2 = 4;
            SwapTestClass.Swap(ref p1, ref p2);
        }
    }
}
