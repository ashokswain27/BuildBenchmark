using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildBenchmark
{
    [RPlotExporter]
    public class InsertBenchmark
    {
       

        [Params(1000, 1000000)]
        public int N;


        public InsertBenchmark()
        {
           // CreateWorkload();
        }

        [IterationSetup]
        public void Setup()
        {
          //  CreateWorkload();
        }

      

        [Benchmark]
        public void Array()
        {
            var array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = i;
            }
        }

        [Benchmark]
        public void List()
        {
            var list = new List<int>();
            for (int i = 0; i < N; i++)
            {
                list.Add(i);
            }
        }

        [Benchmark]
        public void HashSet()
        {
            var set = new HashSet<int>();
            for (int i = 0; i < N; i++)
            {
                set.Add(i);
            }
        }

        [Benchmark]
        public void SortedSet()
        {
            var sortedSet = new SortedSet<int>();
            for (int i = 0; i < N; i++)
            {
                sortedSet.Add(i);
            }
        }

        [Benchmark]
        public void Dictionary()
        {
            var dictionary = new Dictionary<int,int>();
            for (int i = 0; i < N; i++)
            {
                dictionary.Add(i,i);
            }
        }
    }
}
