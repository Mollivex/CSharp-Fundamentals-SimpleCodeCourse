using System;
using BenchmarkDotNet.Running;
using MyProject_123;

namespace MyProject_124
{
    public  class Benchmark
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<MyParserBenchmark>();
        }
    }
}
