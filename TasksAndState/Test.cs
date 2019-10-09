using BenchmarkDotNet.Attributes;
using TasksAndState.Classes;
using TasksAndState.Structs;

namespace TasksAndState
{
    [MemoryDiagnoser]
    [MarkdownExporterAttribute.GitHub]
    public class Test
    {
        private const int Elements = 200000;
        private static int _globalSum;
        private static void AddFunction()
        {
            _globalSum += Data.Default.Value;
        }

        [Benchmark]
        public void ClassCaptureState()
        {
            _globalSum = 0;
            for (int i = 0; i < Elements; ++i)
            {
                var data = new Data { Value = i };
                TaskStubClass.StartNew(() => { _globalSum += data.Value; });
            }
        }

        [Benchmark]
        public void ClassPassStateAsParameter()
        {
            _globalSum = 0;
            for (int i = 0; i < Elements; ++i)
            {
                var data = new Data { Value = i };
                TaskStubClass.StartNew(d => { _globalSum += (d as Data).Value; }, data);
            }
        }

        [Benchmark]
        public void ClassNoCapturedState()
        {
            _globalSum = 0;
            for (int i = 0; i < Elements; ++i)
            {
                TaskStubClass.StartNew(() => { _globalSum += Data.Default.Value; });
            }
        }

        [Benchmark]
        public void ClassNoStateAndNoLambda()
        {
            _globalSum = 0;
            for (int i = 0; i < Elements; ++i)
            {
                TaskStubClass.StartNew(AddFunction);
            }
        }

        [Benchmark]
        public void StructCaptureState()
        {
            _globalSum = 0;
            for (int i = 0; i < Elements; ++i)
            {
                var data = new Data { Value = i };
                TaskStubStruct.StartNew(() => { _globalSum += data.Value; });
            }
        }

        [Benchmark]
        public void StructPassStateAsParameter()
        {
            _globalSum = 0;
            for (int i = 0; i < Elements; ++i)
            {
                var data = new Data { Value = i };
                TaskStubStruct.StartNew(d => { _globalSum += (d as Data).Value; }, data);
            }
        }

        [Benchmark]
        public void StructNoCapturedState()
        {
            _globalSum = 0;
            for (int i = 0; i < Elements; ++i)
            {
                TaskStubStruct.StartNew(() => { _globalSum += Data.Default.Value; });
            }
        }

        [Benchmark]
        public void StructNoStateAndNoLambda()
        {
            _globalSum = 0;
            for (int i = 0; i < Elements; ++i)
            {
                TaskStubStruct.StartNew(AddFunction);
            }
        }
    }
}
