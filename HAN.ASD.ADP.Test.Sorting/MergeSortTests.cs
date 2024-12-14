using HAN.ASD.ADP.SortingAlg;
using HAN.ASD.ADP.SortingAlg.Interfaces;

namespace HAN.ASD.ADP.Test.Sorting
{
    [TestClass]
    public class MergeSortTests : BaseSortTester
    {
        protected override ISorter Sorter => new MergeSorter();
    }
}
