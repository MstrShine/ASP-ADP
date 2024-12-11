using HAN.ASD.ADP.Helpers;
using HAN.ASD.ADP.SortingAlg;
using System.Diagnostics;

namespace HAN.ASD.ADP.Test.Sorting
{
    [TestClass]
    public class InsertionSortTests
    {
        private Datasets.Sorting SortingData { get; set; }
        private Stopwatch Watch { get; set; } = new Stopwatch();

        [TestInitialize]
        public void Initialize()
        {
            SortingData = JsonHelper.LoadJson<Datasets.Sorting>(".\\Datasets\\Raw\\sorting.json");
        }

        [TestMethod]
        public void SortFloat8001()
        {
            Watch.Restart();
            InsertionSorter.Sort(SortingData.lijst_float_8001);
            Watch.Stop();

            Console.WriteLine(Watch.ToString());

            var compare = JsonHelper.LoadJson<Datasets.Sorting>(".\\Datasets\\Raw\\sorting.json");
            CollectionAssert.AreNotEqual(SortingData.lijst_float_8001, compare.lijst_float_8001);
        }

        [TestMethod]
        public void SortWillekeurig1000()
        {
            Watch.Restart();
            InsertionSorter.Sort(SortingData.lijst_willekeurig_10000);
            Watch.Stop();

            Console.WriteLine(Watch.ToString());

            var compare = JsonHelper.LoadJson<Datasets.Sorting>(".\\Datasets\\Raw\\sorting.json");

        }
    }
}