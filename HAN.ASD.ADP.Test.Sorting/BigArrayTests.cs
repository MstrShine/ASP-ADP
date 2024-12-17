using HAN.ASD.ADP.SortingAlg;
using System.Diagnostics;

namespace HAN.ASD.ADP.Test.Sorting
{
    [TestClass]
    public class BigArrayTests
    {
        private Stopwatch Watch = new Stopwatch();
        private static int[] _bigArray = new int[100000];

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            _bigArray = new int[100000];
            var random = new Random();
            for (int i = 0; i < _bigArray.Length; i++)
            {
                _bigArray[i] = random.Next(0, 100000);
            }
        }

        [TestMethod]
        public void MergeSort()
        {
            var temp = new int[100000];
            Array.Copy(_bigArray, temp, _bigArray.Length);
            var sorter = new MergeSorter();
            Watch.Restart();
            sorter.Sort(temp);
            Watch.Stop();

            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public async Task ParallelMergeSort()
        {
            var temp = new int[100000];
            Array.Copy(_bigArray, temp, _bigArray.Length);
            var sorter = new ParallelMergeSorter();
            Watch.Restart();
            await sorter.Sort(temp);
            Watch.Stop();

            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void InsertionSort()
        {
            var temp = new int[100000];
            Array.Copy(_bigArray, temp, _bigArray.Length);
            var sorter = new InsertionSorter();
            Watch.Restart();
            sorter.Sort(temp);
            Watch.Stop();

            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void QuickSort()
        {
            var temp = new int[100000];
            Array.Copy(_bigArray, temp, _bigArray.Length);
            var sorter = new QuickSorter();
            Watch.Restart();
            sorter.Sort(temp);
            Watch.Stop();

            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void SelectionSort()
        {
            var temp = new int[100000];
            Array.Copy(_bigArray, temp, _bigArray.Length);
            var sorter = new SelectionSorter();
            Watch.Restart();
            sorter.Sort(temp);
            Watch.Stop();

            Console.WriteLine(Watch.ToString());
        }
    }
}
