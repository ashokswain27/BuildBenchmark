using BenchmarkDotNet.Attributes;


namespace BuildBenchmark
{
    [RPlotExporter]
    [MemoryDiagnoser]
    [CpuDiagnoser]
    public class DeleteSingleItemBenchmark
    {
       

        private IList<int> list = new List<int>();
        private HashSet<int> hashSet = new HashSet<int>();
        private SortedSet<int> sortedSet = new SortedSet<int>();
        private Dictionary<int, int> dictionary = new Dictionary<int, int>();

        int deleteItem = 999;

        [Params(1000, 10000, 100000)]
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
           /* for (int i = 0; i < N; i++)
            {
                sortedSet.Add(i);
            }*/
            for (int i=0;i<N;i++)
            {
                dictionary[i] = i;
            }
        }

        [Benchmark]
        public void RemoveItem_List()
        {
            var itemToRemove = list.SingleOrDefault(r => r == deleteItem);
            
                list.Remove(itemToRemove);
           
        
        }

        [Benchmark]
        public void RemoveItem_IList_HashSet()
        {
            
             hashSet.Remove(deleteItem);
            
        }

        [Benchmark]
        public void RemoveItem_Dictionary()
        {
           
             dictionary.Remove(deleteItem);
              
        }

      /*  [Benchmark]
        public void RemoveAll_SortedSet()
        {
            foreach (var item in sortedSet)
            {
                if (item > 1000)
                {
                    sortedSet.Remove(item);
                }
            }
        }*/


    }
}
