using System.Diagnostics;
using System.Collections.Concurrent;


namespace BuildBenchmark
{
    internal class BenchmarkCollection
    {
        private const int N = 1000;
        private const int InsertionValue = 10000001;
        private const int SearchValue = 999;
        private const int DeleteValue = 999;
        List<int> list = new List<int>();
        Dictionary<int, int> dictInteger = new Dictionary<int, int>();
        HashSet<int> hashSet = new HashSet<int>();
        SortedSet<int> sortedSet = new SortedSet<int>();
        ConcurrentDictionary<int,int> concurrentDict = new ConcurrentDictionary<int, int>();
                

        public void InsertTest()
        {
            CreateWorkload();

            Console.WriteLine("----Test for iterating " + N + " records----");
            IterateListTest();
            IterateDictionaryTest();
            IterateConcurrentDictionaryTest();
            ItearteHashSetTest();
            IterateSortedSetTest();

            Console.WriteLine();
            Console.WriteLine("----Test for adding a single record----");
            Console.WriteLine("Insertion Value: " + InsertionValue);
            InsertListTest();
            InsertConcurrentDictionaryTest();
            InsertDictionaryTest();
            InsertHashSetTest();
            InsertSortedSetTest();

            Console.WriteLine();
            Console.WriteLine("----Test for Searching the record----");
            Console.WriteLine("Search Value: "+ SearchValue);
            SearchListTest();
            SearchConcurrentDictionaryTest();
            SearchDictionaryTest();
            SearchHashSetTest();
            SearchSortedSetTest();

            Console.WriteLine();
            Console.WriteLine("----Test for Deleting the record----");
            Console.WriteLine("Delete Value: " + DeleteValue);
            DeleteListTest();
            DeleteConcurrentDictionaryTest();
            DeleteDictionaryTest();
            DeleteHashSetTest();
            DeleteSortedSetTest();
        }

       

        private void CreateWorkload()
        {
            Console.WriteLine("Creating the Workload");
            
            for (int i=0;i<N;i++)
            {
                list.Add(i);
            }
            for (int i = 0; i < N; i++)
            {
                dictInteger.Add(i, i);
            }
            for (int i = 0; i < N; i++)
            {
                concurrentDict.TryAdd(i, i);
            }
            for (int i = 0; i < N; i++)
            {
                hashSet.Add(i);
            }
            for (int i = 0; i < N; i++)
            {
                sortedSet.Add(i);
            }

            Console.WriteLine("Workload Creation is finished");
            
        }

        private void IterateListTest()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < list.Count; i++)
            {
                
            }
            stopWatch.Stop();
            Console.WriteLine("Time taken for list - {0} ticks", stopWatch.ElapsedTicks);
            // Console.WriteLine("Time taken for list - {0:0.00} ns", stopWatch.ElapsedMilliseconds * 1000000 / N);
            stopWatch.Reset();
        }

        private void InsertListTest()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            list.Add(InsertionValue);
            stopWatch.Stop();
            Console.WriteLine("Time taken for list - {0} ticks" , stopWatch.ElapsedTicks);
          //  Console.WriteLine("Time taken for list - {0:0.00} ns", stopWatch.ElapsedMilliseconds * 1000000 / N);
            stopWatch.Reset();
        }

        private void SearchListTest()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            list.Contains(SearchValue);
            stopWatch.Stop();
            Console.WriteLine("Time taken for list - {0} ticks" , stopWatch.ElapsedTicks);
           // Console.WriteLine("Time taken for list - {0:0.00} ns", stopWatch.ElapsedMilliseconds * 1000000 / N);
            stopWatch.Reset();
        }

        
        private void DeleteListTest()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            list.Remove(DeleteValue);
            stopWatch.Stop();
            Console.WriteLine("Time taken for list - {0} ticks" , stopWatch.ElapsedTicks);
          //  Console.WriteLine("Time taken for list - {0:0.00} ns", stopWatch.ElapsedMilliseconds * 1000000 / N);
            stopWatch.Reset();
        }
        
        private void IterateDictionaryTest()
        {            
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < dictInteger.Count; i++)
            {
                
            }
            stopWatch.Stop();
            Console.WriteLine("Time taken for Dictionary - {0} ticks" , stopWatch.ElapsedTicks);
          //  Console.WriteLine("Time taken for Dictionary - {0:0.00} ns", stopWatch.ElapsedMilliseconds * 1000000 / N);
            stopWatch.Reset();
        }

        private void InsertDictionaryTest()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            dictInteger.Add(InsertionValue,InsertionValue);            
            stopWatch.Stop();
            Console.WriteLine("Time taken for Dictionary - {0} ticks" , stopWatch.ElapsedTicks);
         //   Console.WriteLine("Time taken for Dictionary - {0:0.00} ns", stopWatch.ElapsedMilliseconds * 1000000 / N);
            stopWatch.Reset();
        }

        private void SearchDictionaryTest()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            dictInteger.ContainsValue(SearchValue);
            stopWatch.Stop();
            Console.WriteLine("Time taken for Dictionary - {0} ticks" , stopWatch.ElapsedTicks);
          //  Console.WriteLine("Time taken for Dictionary - {0:0.00} ns", stopWatch.ElapsedMilliseconds * 1000000 / N);
            stopWatch.Reset();
        }

        private void DeleteDictionaryTest()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            dictInteger.Remove(DeleteValue);
            stopWatch.Stop();
            Console.WriteLine("Time taken for Dictionary - {0} ticks" , stopWatch.ElapsedTicks);
          //  Console.WriteLine("Time taken for Dictionary - {0:0.00} ns", stopWatch.ElapsedMilliseconds * 1000000 / N);
            stopWatch.Reset();
        }

        private void IterateConcurrentDictionaryTest()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < concurrentDict.Count; i++)
            {
               
            }
            stopWatch.Stop();
            Console.WriteLine("Time taken for ConcurrentDictionary - {0} ticks", stopWatch.ElapsedTicks);
            //  Console.WriteLine("Time taken for ConcurrentDictionary - {0:0.00} ns", stopWatch.ElapsedMilliseconds * 1000000 / N);
            stopWatch.Reset();
        }

        private void InsertConcurrentDictionaryTest()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            concurrentDict.TryAdd(InsertionValue, InsertionValue);
            stopWatch.Stop();
            Console.WriteLine("Time taken for ConcurrentDictionary - {0} ticks", stopWatch.ElapsedTicks);
            //   Console.WriteLine("Time taken for Dictionary - {0:0.00} ns", stopWatch.ElapsedMilliseconds * 1000000 / N);
            stopWatch.Reset();
        }

        private void SearchConcurrentDictionaryTest()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            concurrentDict.ContainsKey(SearchValue);
            stopWatch.Stop();
            Console.WriteLine("Time taken for ConcurrentDictionary - {0} ticks", stopWatch.ElapsedTicks);
            //  Console.WriteLine("Time taken for Dictionary - {0:0.00} ns", stopWatch.ElapsedMilliseconds * 1000000 / N);
            stopWatch.Reset();
        }

        private void DeleteConcurrentDictionaryTest()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            concurrentDict.TryRemove(DeleteValue, out var result);
            stopWatch.Stop();
            Console.WriteLine("Time taken for ConcurrentDictionary - {0} ticks", stopWatch.ElapsedTicks);
            //  Console.WriteLine("Time taken for Dictionary - {0:0.00} ns", stopWatch.ElapsedMilliseconds * 1000000 / N);
            stopWatch.Reset();
        }

        private void ItearteHashSetTest()
        {
            
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < hashSet.Count; i++)
            {
               
            }
            stopWatch.Stop();
            Console.WriteLine("Time taken for HashSet - {0} ticks" , stopWatch.ElapsedTicks);
          //  Console.WriteLine("Time taken for HashSet - {0:0.00} ns", stopWatch.ElapsedMilliseconds * 1000000 / N);
            stopWatch.Reset();
        }

        private void InsertHashSetTest()
        {

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            hashSet.Add(InsertionValue);
            stopWatch.Stop();
            Console.WriteLine("Time taken for HashSet - {0} ticks" , stopWatch.ElapsedTicks);
          //  Console.WriteLine("Time taken for HashSet - {0:0.00} ns", stopWatch.ElapsedMilliseconds * 1000000 / N);
            stopWatch.Reset();
        }

        private void SearchHashSetTest()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            hashSet.Contains(SearchValue);
            stopWatch.Stop();
            Console.WriteLine("Time taken for HashSet - {0} ticks" , stopWatch.ElapsedTicks);
         //   Console.WriteLine("Time taken for HashSet - {0:0.00} ns", stopWatch.ElapsedMilliseconds * 1000000 / N);
            stopWatch.Reset();
        }

        private void DeleteHashSetTest()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            hashSet.Remove(DeleteValue);
            stopWatch.Stop();
            Console.WriteLine("Time taken for HashSet - {0} ticks:" , stopWatch.ElapsedTicks);
          //  Console.WriteLine("Time taken for HashSet - {0:0.00} ns", stopWatch.ElapsedMilliseconds * 1000000 / N);
            stopWatch.Reset();
        }

        private void IterateSortedSetTest()
        {
            
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < sortedSet.Count; i++)
            {
               
            }
            stopWatch.Stop();
            Console.WriteLine("Time taken for SortedSet - {0} ticks:" , stopWatch.ElapsedTicks);
         //   Console.WriteLine("Time taken for SortedSet - {0:0.00} ns", stopWatch.ElapsedMilliseconds * 1000000 / N);
            stopWatch.Reset();
        }

        private void InsertSortedSetTest()
        {

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            sortedSet.Add(InsertionValue);            
            stopWatch.Stop();
            Console.WriteLine("Time taken for SortedSet - {0} ticks:" , stopWatch.ElapsedTicks);
          //  Console.WriteLine("Time taken for SortedSet - {0:0.00} ns", stopWatch.ElapsedMilliseconds * 1000000 / N);
            stopWatch.Reset();
        }

        private void SearchSortedSetTest()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            sortedSet.Contains(SearchValue);
            stopWatch.Stop();
            Console.WriteLine("Time taken for SortedSet - {0} ticks:" , stopWatch.ElapsedTicks);
          //  Console.WriteLine("Time taken for SortedSet - {0:0.00} ns", stopWatch.ElapsedMilliseconds * 1000000 / N);
            stopWatch.Reset();
        }

        private void DeleteSortedSetTest()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            sortedSet.Remove(DeleteValue);
            stopWatch.Stop();
            Console.WriteLine("Time taken for SortedSet - {0} ticks:" , stopWatch.ElapsedTicks);
         //   Console.WriteLine("Time taken for SortedSet - {0:0.00} ns", stopWatch.ElapsedMilliseconds * 1000000 / N);
            stopWatch.Reset();
        }


    }
}
