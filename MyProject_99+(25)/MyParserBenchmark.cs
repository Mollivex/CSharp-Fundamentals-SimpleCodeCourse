using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using MyProject_123;

namespace MyProject_124
{
    [MemoryDiagnoser]
    [RankColumn]
    public class MyParserBenchmark
    {
        private const string STRING_TO_PARSE_WITH_ERROR = "qwerty22";
        private const string STRING_TO_PARSE = "54";

        private readonly MyParser _myParser = new MyParser();

        [Benchmark] 
        public void TryCatchParseTestWithError()
        {
            int result = _myParser.TryCatchParse(STRING_TO_PARSE_WITH_ERROR);
        }

        [Benchmark] 
        public void TryParseTestWithError()
        {
            int result = _myParser.TryParse(STRING_TO_PARSE_WITH_ERROR);
        }
        
        [Benchmark]
        public void TryParseFixedTestWithError()
        {
            int result = _myParser.TryParseFixed(STRING_TO_PARSE_WITH_ERROR);
        }

        [Benchmark] 
        public void TryCatchParseTest()
        {
            int result = _myParser.TryParse(STRING_TO_PARSE);
        }

        [Benchmark]
        public void TryParseTest()
        {
            int result = _myParser.TryParse(STRING_TO_PARSE);
        }

        [Benchmark] 
        public void TryParseFixed()
        {
            int result = _myParser.TryParseFixed(STRING_TO_PARSE);
        }
    }
}
