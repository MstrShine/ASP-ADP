using HAN.ASD.ADP.SortingAlg;
using System.Diagnostics;

namespace HAN.ASD.ADP.Test.Sorting
{
    [TestClass]
    public class SmallArrayTests
    {
        private Stopwatch Watch = new Stopwatch();
        private static int[] _smallArray = new int[100];

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            _smallArray = new int[100];
            var random = new Random();
            for (int i = 0; i < _smallArray.Length; i++)
            {
                _smallArray[i] = random.Next(0, 100);
            }
        }

        [TestMethod]
        public void MergeSort()
        {
            var temp = new int[100];
            Array.Copy(_smallArray, temp, _smallArray.Length);
            var sorter = new MergeSorter();
            Watch.Restart();
            sorter.Sort(temp);
            Watch.Stop();

            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public async Task ParallelMergeSort()
        {
            var temp = new int[100];
            Array.Copy(_smallArray, temp, _smallArray.Length);
            var sorter = new ParallelMergeSorter();
            Watch.Restart();
            await sorter.Sort(temp);
            Watch.Stop();

            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void InsertionSort()
        {
            var temp = new int[100];
            Array.Copy(_smallArray, temp, _smallArray.Length);
            var sorter = new InsertionSorter();
            Watch.Restart();
            sorter.Sort(temp);
            Watch.Stop();

            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void QuickSort()
        {
            var temp = new int[100];
            Array.Copy(_smallArray, temp, _smallArray.Length);
            var sorter = new QuickSorter();
            Watch.Restart();
            sorter.Sort(temp);
            Watch.Stop();

            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void SelectionSort()
        {
            var temp = new int[100];
            Array.Copy(_smallArray, temp, _smallArray.Length);
            var sorter = new SelectionSorter();
            Watch.Restart();
            sorter.Sort(temp);
            Watch.Stop();

            Console.WriteLine(Watch.ToString());
        }
    }
}
