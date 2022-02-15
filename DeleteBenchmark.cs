using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Collections.Immutable;

namespace BuildBenchmark
{
    public class DeleteBenchmark
    {
       

        private IList<int> list = new List<int>();
        private HashSet<int> hashSet = new HashSet<int>();
        private SortedSet<int> sortedSet = new SortedSet<int>();
        private Dictionary<int, int> dictionary = new Dictionary<int, int>();

        [Params(1000, 1000000)]
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
        public void RemoveAll_IList()
        {
            for (var index = list.Count - 1; index >= 0; index--) 
            {
                var item = list[index];
                if (item > 1000)
                {
                    list.RemoveAt(index);
                }
            }

            
        }

        [Benchmark]
        public void RemoveAll_HashSet()
        {
            foreach (var item in hashSet)
            {
                if (item > 1000)
                {
                    hashSet.Remove(item);
                }
            }
        }

        [Benchmark]
        public void RemoveAll_Dictionary()
        {
            foreach (var item in dictionary)
            {
                if(item.Value.CompareTo(1000) > 0)
                {
                    dictionary.Remove(item.Key);
                }

            }
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
