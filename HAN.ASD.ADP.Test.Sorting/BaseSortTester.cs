using HAN.ASD.ADP.Helpers;
using HAN.ASD.ADP.SortingAlg.Interfaces;
using HAN.ASD.ADP.Test.Sorting.Interfaces;
using System.Diagnostics;

namespace HAN.ASD.ADP.Test.Sorting
{
    public abstract class BaseSortTester : ISortingDatasetTests
    {
        protected Datasets.SortingDataset SortingData = new();

        protected Stopwatch Watch = new();

        protected abstract ISorter Sorter { get; }

        protected Datasets.SortingDataset GetSortingData()
        {
            var dataset = JsonHelper.LoadJson<Datasets.SortingDataset>(".\\Datasets\\Raw\\sorting.json");
            if (dataset == null)
            {
                return new Datasets.SortingDataset();
            }

            return dataset;
        }

        [TestInitialize]
        public void Initialize()
        {
            SortingData = GetSortingData();
        }

        [TestMethod]
        public void SimpleTestSort10()
        {
            var testArr = new int[] { 5, 10, 55, 16, 20, 48, 66, 102, 33, 40 };

            Watch.Restart();
            Sorter.Sort(testArr);
            Watch.Stop();

            Console.WriteLine(Watch.ToString());

            var sortedTestArr = new int[] { 5, 10, 16, 20, 33, 40, 48, 55, 66, 102 };
            CollectionAssert.AreEqual(sortedTestArr, testArr);
        }

        [TestMethod]
        public void LijstOplopend10000()
        {
            Watch.Restart();
            Sorter.Sort(SortingData.lijst_oplopend_10000);
            Watch.Stop();

            Console.WriteLine(Watch.ToString());

            var compare = GetSortingData();
            CollectionAssert.AreEqual(SortingData.lijst_oplopend_10000, compare.lijst_oplopend_10000);
        }

        [TestMethod]
        public void SortAflopend2()
        {
            Watch.Restart();
            Sorter.Sort(SortingData.lijst_aflopend_2);
            Watch.Stop();

            Console.WriteLine(Watch.ToString());

            var compare = GetSortingData();
            CollectionAssert.AreNotEqual(SortingData.lijst_aflopend_2, compare.lijst_aflopend_2);
        }

        [TestMethod]
        public void SortFloat8001()
        {
            Watch.Restart();
            Sorter.Sort(SortingData.lijst_float_8001);
            Watch.Stop();

            Console.WriteLine(Watch.ToString());

            var compare = GetSortingData();
            CollectionAssert.AreNotEqual(SortingData.lijst_float_8001, compare.lijst_float_8001);
        }

        [TestMethod]
        public void SortGesorteerdAflopend3()
        {
            Watch.Restart();
            Sorter.Sort(SortingData.lijst_gesorteerd_aflopend_3);
            Watch.Stop();

            Console.WriteLine(Watch.ToString());

            var compare = GetSortingData();
            CollectionAssert.AreNotEqual(SortingData.lijst_gesorteerd_aflopend_3, compare.lijst_gesorteerd_aflopend_3);
        }

        [TestMethod]
        public void SortGesorteerdOplopend3()
        {
            Watch.Restart();
            Sorter.Sort(SortingData.lijst_gesorteerd_oplopend_3);
            Watch.Stop();

            Console.WriteLine(Watch.ToString());

            var compare = GetSortingData();
            CollectionAssert.AreEqual(SortingData.lijst_gesorteerd_oplopend_3, compare.lijst_gesorteerd_oplopend_3);
        }

        [TestMethod]
        public void SortLeeg0()
        {
            Watch.Restart();
            Sorter.Sort(SortingData.lijst_leeg_0);
            Watch.Stop();

            Console.WriteLine(Watch.ToString());

            var compare = GetSortingData();
            CollectionAssert.AreEqual(SortingData.lijst_leeg_0, compare.lijst_leeg_0);
        }

        [TestMethod]
        public void SortLijstHerhaald1000()
        {
            Watch.Restart();
            Sorter.Sort(SortingData.lijst_herhaald_1000);
            Watch.Stop();

            Console.WriteLine(Watch.ToString());

            var compare = GetSortingData();
            CollectionAssert.AreNotEqual(SortingData.lijst_herhaald_1000, compare.lijst_herhaald_1000);
        }

        [TestMethod]
        public void SortNull1()
        {
            //Watch.Restart();
            //Sorter.Sort(SortingData.lijst_null_1);
            //Watch.Stop();

            //Console.WriteLine(Watch.ToString());

            //var compare = GetSortingData();
            //CollectionAssert.AreNotEqual(SortingData.lijst_null_1, compare.lijst_null_1);
        }

        [TestMethod]
        public void SortNull3()
        {
            //Watch.Restart();
            //Sorter.Sort(SortingData.lijst_null_3);
            //Watch.Stop();

            //Console.WriteLine(Watch.ToString());

            //var compare = GetSortingData();
            //CollectionAssert.AreNotEqual(SortingData.lijst_null_3, compare.lijst_null_3);
        }

        [TestMethod]
        public void SortOnsorteerbaar3()
        {
            //Watch.Restart();
            //Sorter.Sort(SortingData.lijst_onsorteerbaar_3);
            //Watch.Stop();

            //Console.WriteLine(Watch.ToString());

            //var compare = GetSortingData();
            //CollectionAssert.AreNotEqual(SortingData.lijst_onsorteerbaar_3, compare.lijst_onsorteerbaar_3);
        }

        [TestMethod]
        public void SortOplopend2()
        {
            Watch.Restart();
            Sorter.Sort(SortingData.lijst_oplopend_2);
            Watch.Stop();

            Console.WriteLine(Watch.ToString());

            var compare = GetSortingData();
            CollectionAssert.AreEqual(SortingData.lijst_oplopend_2, compare.lijst_oplopend_2);
        }

        [TestMethod]
        public void SortWillekeurig1000()
        {
            Watch.Restart();
            Sorter.Sort(SortingData.lijst_willekeurig_10000);
            Watch.Stop();

            Console.WriteLine(Watch.ToString());

            var compare = GetSortingData();
            CollectionAssert.AreNotEqual(SortingData.lijst_willekeurig_10000, compare.lijst_willekeurig_10000);
        }

        [TestMethod]
        public void SortWillekeurig3()
        {
            Watch.Restart();
            Sorter.Sort(SortingData.lijst_willekeurig_3);
            Watch.Stop();

            Console.WriteLine(Watch.ToString());

            var compare = GetSortingData();
            CollectionAssert.AreNotEqual(SortingData.lijst_willekeurig_3, compare.lijst_willekeurig_3);
        }

        [TestMethod]

        public void SortPizzas()
        {
            Watch.Restart();
            Sorter.Sort(SortingData.lijst_pizzas);
            Watch.Stop();

            Console.WriteLine(Watch.ToString());

            var compare = GetSortingData();
            CollectionAssert.AreNotEqual(SortingData.lijst_pizzas, compare.lijst_pizzas);
        }
    }
}
