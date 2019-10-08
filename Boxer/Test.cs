using BenchmarkDotNet.Attributes;
using Boxer.Classes;
using Boxer.Structs;
using System.Collections.Generic;
using System.Linq;

namespace Boxer
{
    [MemoryDiagnoser]
    [MarkdownExporterAttribute.GitHub]
    public class Test
    {
        private const int N = 10000;

        private readonly List<Struct> structs;
        private readonly List<StructWithSpecializedEquals> structWithSpecializedEqualses;
        private readonly List<StructEquatable> structEquatables;

        private readonly List<Class> classes;
        private readonly List<ClassWithReferenceSpecializedEquals> classWithReferenceSpecializedEqualses;
        private readonly List<ClassWithSpecializedEquals> classWithSpecializedEqualses;
        private readonly List<ClassEquatable> classEquatables;

        public Test()
        {
            structs = Enumerable.Range(0, N).Select(v => new Struct { Value = v }).ToList();
            structWithSpecializedEqualses = Enumerable.Range(0, N).Select(v => new StructWithSpecializedEquals { Value = v }).ToList();
            structEquatables = Enumerable.Range(0, N).Select(v => new StructEquatable { Value = v }).ToList();

            classes = Enumerable.Range(0, N).Select(v => new Class { Value = v }).ToList();
            classWithReferenceSpecializedEqualses = Enumerable.Range(0, N).Select(v => new ClassWithReferenceSpecializedEquals { Value = v }).ToList();
            classWithSpecializedEqualses = Enumerable.Range(0, N).Select(v => new ClassWithSpecializedEquals { Value = v }).ToList();
            classEquatables = Enumerable.Range(0, N).Select(v => new ClassEquatable { Value = v }).ToList();
        }

        [Benchmark]
        public bool SearchStruct()
        {
            return structs.Contains(structs.Last());
        }

        [Benchmark]
        public bool SearchStructWithSpecializedEquals()
        {
            return structWithSpecializedEqualses.Contains(structWithSpecializedEqualses.Last());
        }

        [Benchmark]
        public bool SearchStructEquatable()
        {
            return structEquatables.Contains(structEquatables.Last());
        }

        [Benchmark]
        public bool SearchClass()
        {
            return classes.Contains(classes.Last());
        }

        [Benchmark]
        public bool SearchClassWithReferenceSpecializedEquals()
        {
            return classWithReferenceSpecializedEqualses.Contains(classWithReferenceSpecializedEqualses.Last());
        }

        [Benchmark]
        public bool SearchClassWithSpecializedEquals()
        {
            return classWithSpecializedEqualses.Contains(classWithSpecializedEqualses.Last());
        }

        [Benchmark]
        public bool SearchClassEquatable()
        {
            return classEquatables.Contains(classEquatables.Last());
        }
    }
}