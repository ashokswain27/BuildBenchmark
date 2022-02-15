// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;

namespace BuildBenchmark
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  var Iteratesummary = BenchmarkRunner.Run<IterationBenchmark>();
            //  var InsertSummary = BenchmarkRunner.Run<InsertBenchmark>();
            // var DeleteSummary = BenchmarkRunner.Run<DeleteBenchmark>();
            var SearchSummary = BenchmarkRunner.Run<SearchBenchmark>();

            /*  Insert obj = new Insert();
              obj.InsertTest();     */
        }
    }
}
