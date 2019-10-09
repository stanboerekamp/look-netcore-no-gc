using BenchmarkDotNet.Attributes;
using System.Linq;

namespace LINQ
{
    [MemoryDiagnoser]
    [MarkdownExporterAttribute.GitHub]
    public class Test
    {
        private const int Minimum = 10000;
        private const int Maximum = 99999 + 1;

        [Benchmark]
        public static double CalculateWithLoops()
        {
            int sum = 0;

            for (int i = Minimum; i < Maximum; i++)
            {
                var digits = new int[10];
                var number = i;
                while (number > 0)
                {
                    digits[number % 10] += 1;
                    number /= 10;
                }

                for (int d = 0; d < digits.Length; d++)
                    if (digits[d] == 1) sum++;
            }

            return (double)sum / (Maximum - Minimum);
        }

        [Benchmark]
        public static double CalculateWithLoopsAndString()
        {
            int sum = 0;
            for (int i = Minimum; i < Maximum; i++)
            {
                var digits = new int[10];
                var s = i.ToString();
                for (var k = 0; k < s.Length; k++)
                    digits[s[k] - '0'] += 1;
                for (int d = 0; d < digits.Length; d++)
                    if (digits[d] == 1)
                        sum++;
            }
            return (double)sum / (Maximum - Minimum);
        }

        [Benchmark]
        public static double CalculateWithLinq()
        {
            return Enumerable.Range(Minimum, Maximum - Minimum)
                .Select(i => i.ToString()
                                .AsEnumerable()
                                .GroupBy(
                                c => c,
                                c => c,
                                (k, g) => new
                                {
                                    Character = k,
                                    Count = g.Count()
                                })
                                .Count(g => g.Count == 1))
                .Average();
        }
    }
}
