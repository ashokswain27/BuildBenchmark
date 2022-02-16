using BenchmarkDotNet.Running;

namespace BuildBenchmark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The below methods are used for BenchMarkDotnet
            // var Iteratesummary = BenchmarkRunner.Run<IterationBenchmark>();
            //  var InsertSummary = BenchmarkRunner.Run<InsertBenchmark>();
            //  var DeleteSummary = BenchmarkRunner.Run<DeleteBenchmark>();
            // var DeleteItemSummary = BenchmarkRunner.Run<DeleteSingleItemBenchmark>();
            var SearchSummary = BenchmarkRunner.Run<SearchBenchmark>();

            // var SearchSummary = BenchmarkRunner.Run<SearchBenchmark>();

            // The below method is used for StopWatch
            /*  BenchmarkCollection objBenchmarkCollection = new BenchmarkCollection();
              obj.BenchmarkTest();     */
        }
    }
}
