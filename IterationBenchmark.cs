using BenchmarkDotNet.Attributes;



namespace BuildBenchmark
{
    public class IterationBenchmark
    {
        private const int N = 10000000;
        private const int InsertionValue = 10000001;
        private const int SearchValue = 999;
        private const int DeleteValue = 999;

        List<int> list = new List<int>();
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        HashSet<int> hashSet = new HashSet<int>();
        SortedSet<int> sortedSet = new SortedSet<int>();
       



        public IterationBenchmark()
        {
            CreateWorkload();
        }

        private void CreateWorkload()
        {
            Console.WriteLine("Creating the Workload");

            for (int i = 0; i < N; i++)
            {
                list.Add(i);
            }
            for (int i = 0; i < N; i++)
            {
                dictionary.Add(i, i);
            }
            
            for (int i = 0; i < N; i++)
            {
                hashSet.Add(i);
            }
            for (int i = 0; i < N; i++)
            {
                sortedSet.Add(i);
            }

            Console.WriteLine("Workload creation is finished");

        }

        [Benchmark]
        public void IterateList()
        {
            for (int i = 0; i < list.Count; i++)
            {
                
            }
        }


        [Benchmark]
        public void IterateDictionary()
        {
            for (int i = 0; i < dictionary.Count; i++)
            {
                
            }
        }

        [Benchmark]
        public void IterateHashSet()
        {
            for (int i = 0; i < hashSet.Count; i++)
            {
               
            }
        }

        [Benchmark]
        public void IterateSortedSet()
        {
            for (int i = 0; i < sortedSet.Count; i++)
            {
               
            }
        }



        /*  [Benchmark]
         public void AddListItem()
         {
             list.Add(1001);
         }

          [Benchmark]
           public void DeleteListItem()
           {
               list.RemoveAt(99999);
           }

        [Benchmark]
        public void SearchListItem()
        {
            int listItem = list.FindIndex(x => x == 100);
        }
           
          */

        /*
                [Benchmark]
                public byte[] Sha256() => sha256.ComputeHash(data);

                [Benchmark]
                public byte[] Md5() => md5.ComputeHash(data);
        */
    }
}
