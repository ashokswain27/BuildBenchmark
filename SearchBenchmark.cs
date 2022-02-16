using BenchmarkDotNet.Attributes;

namespace BuildBenchmark
{
    [RPlotExporter]
    [MemoryDiagnoser]
    [CpuDiagnoser]
    public class SearchBenchmark
    {
        private IList<int> list = new List<int>();
        private HashSet<int> hashSet = new HashSet<int>();
        private SortedSet<int> sortedSet = new SortedSet<int>();
        private Dictionary<int, int> dictionary = new Dictionary<int, int>();

        [Params(1000,10000, 100000, 1000000)]
        public int N;

        [IterationSetup]
        public void Setup()
        {

            for (int i = 0; i < N; i++)
            {
                list.Add(i);
            }
            for (int i = 0; i < N; i++)
            {
                hashSet.Add(i);
            }
            for (int i = 0; i < N; i++)
            { 
                 sortedSet.Add(i);
            }
            for (int i = 0; i < N; i++)
            {
                dictionary[i] = i;
            }
        }


        [Benchmark]
        public void Search_List()
        {
            list.Contains(1000);
        }

        [Benchmark]
        public void Search_HashSet()
        {
            hashSet.Contains(1000);
        }

        [Benchmark]
        public void Search_SortedSet()
        {
            sortedSet.Contains(1000);
        }

        [Benchmark]
        public void Search_Dictionary()
        {
            dictionary.TryGetValue(1000, out int value);
        }


    }
}
