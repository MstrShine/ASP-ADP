using HAN.ASD.ADP.SortingAlg;
using HAN.ASD.ADP.SortingAlg.Interfaces;

namespace HAN.ASD.ADP.Test.Sorting
{
    [TestClass]
    public class ParallelMergeSortTests : AsyncBaseSortTester
    {
        protected override IAsyncSorter Sorter => new ParallelMergeSorter();
    }
}
