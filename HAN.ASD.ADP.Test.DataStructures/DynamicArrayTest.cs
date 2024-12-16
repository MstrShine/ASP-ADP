using HAN.ASD.ADP.DataStructures.DArray;
using System.Diagnostics;

namespace HAN.ASD.ADP.Test.DataStructures
{
    [TestClass]
    public class DynamicArrayTest
    {
        private Stopwatch Watch = new Stopwatch();

        [TestMethod]
        public void Adding10DeletingOnElement10Start0()
        {
            var dArray = new DynamicArray<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                dArray.Add(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 10: {Watch}");
            Assert.IsTrue(dArray.Size() == 10);

            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                dArray.Remove(element: i);
            }
            Watch.Stop();
            Console.WriteLine($"Deleting 10: {Watch}");
            Assert.IsTrue(dArray.Size() == 0);
        }

        [TestMethod]
        public void Adding10DeletingOnElement10Start10()
        {
            var dArray = new DynamicArray<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                dArray.Add(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 10: {Watch}");
            Assert.IsTrue(dArray.Size() == 10);

            Watch.Restart();
            for (int i = 9; i > -1; i--)
            {
                dArray.Remove(element: i);
            }
            Watch.Stop();
            Console.WriteLine($"Deleting 10: {Watch}");
            Assert.IsTrue(dArray.Size() == 0);
        }

        [TestMethod]
        public void Adding10DeletingOnIndex10Start0()
        {
            var dArray = new DynamicArray<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                dArray.Add(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 10: {Watch}");
            Assert.IsTrue(dArray.Size() == 10);

            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                dArray.Remove(index: 0);
            }
            Watch.Stop();
            Console.WriteLine($"Deleting 10: {Watch}");
            Assert.IsTrue(dArray.Size() == 0);
        }

        [TestMethod]
        public void Adding10DeletingOnIndex10Start10()
        {
            var dArray = new DynamicArray<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                dArray.Add(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 10: {Watch}");
            Assert.IsTrue(dArray.Size() == 10);

            Watch.Restart();
            for (int i = 9; i > -1; i--)
            {
                dArray.Remove(index: i);
            }
            Watch.Stop();
            Console.WriteLine($"Deleting 10: {Watch}");
            Assert.IsTrue(dArray.Size() == 0);
        }

        [TestMethod]
        public void Adding10CheckingContainsAll10()
        {
            var dArray = new DynamicArray<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                dArray.Add(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 10: {Watch}");
            Assert.IsTrue(dArray.Size() == 10);

            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                Assert.IsTrue(dArray.Contains(i));
            }
            Watch.Stop();
            Console.WriteLine($"Checking all 10: {Watch}");
        }

        [TestMethod]
        public void Adding10Getting10ByIndex()
        {
            var dArray = new DynamicArray<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                dArray.Add(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 10: {Watch}");
            Assert.IsTrue(dArray.Size() == 10);

            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                Assert.IsTrue(dArray.Get(i) == i);
            }
            Watch.Stop();
            Console.WriteLine($"Getting all 10: {Watch}");
        }

        [TestMethod]
        public void Adding10GettingIndexOf10()
        {
            var dArray = new DynamicArray<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                dArray.Add(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 10: {Watch}");
            Assert.IsTrue(dArray.Size() == 10);

            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                Assert.IsTrue(dArray.IndexOf(i) == i);
            }
            Watch.Stop();
            Console.WriteLine($"Getting index of all 10: {Watch}");
        }

        [TestMethod]
        public void Adding10SettingNewValueForAllTo10()
        {
            var dArray = new DynamicArray<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                dArray.Add(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 10: {Watch}");
            Assert.IsTrue(dArray.Size() == 10);

            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                dArray.Set(i, 10);
            }
            Watch.Stop();
            Console.WriteLine($"Setting all to 10: {Watch}");

            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                var val = dArray.Get(i);
                Assert.AreEqual(10, val);
            }
            Watch.Stop();
            Console.WriteLine($"Getting all 10: {Watch}");
        }

        [TestMethod]
        public void PerformanceTest_Adding100000AndDeletingThemByElement_Integers_NotPropperSize()
        {
            var dArray = new DynamicArray<int>();
            Watch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                dArray.Add(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 100000: {Watch}");

            Watch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                dArray.Remove(element: i);
            }
            Watch.Stop();
            Console.WriteLine($"Deleting 100000: {Watch}");

            Assert.AreEqual(0, dArray.Size());
        }

        [TestMethod]
        public void PerformanceTest_Adding100000AndDeletingThemByLastIndex_Integers_NotPropperSize()
        {
            var dArray = new DynamicArray<int>();
            Watch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                dArray.Add(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 100000: {Watch}");

            Watch.Restart();
            while (dArray.Size() != 0)
            {
                dArray.Remove(index: dArray.Size() - 1);
            }
            Watch.Stop();
            Console.WriteLine($"Deleting 100000: {Watch}");

            Assert.AreEqual(0, dArray.Size());
        }

        [TestMethod]
        public void PerformanceTest_Adding100000AndDeletingThemByIndex0_Integers_NotPropperSize()
        {
            var dArray = new DynamicArray<int>();
            Watch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                dArray.Add(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 100000: {Watch}");

            Watch.Restart();
            while (dArray.Size() != 0)
            {
                dArray.Remove(index: 0);
            }
            Watch.Stop();
            Console.WriteLine($"Deleting 100000: {Watch}");

            Assert.AreEqual(0, dArray.Size());
        }

        [TestMethod]
        public void PerformanceTest_Adding100000AndDeletingThemByElement_Integers_PropperSize()
        {
            var dArray = new DynamicArray<int>(100000);
            Watch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                dArray.Add(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 100000: {Watch}");

            Watch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                dArray.Remove(element: i);
            }
            Watch.Stop();
            Console.WriteLine($"Deleting 100000: {Watch}");

            Assert.AreEqual(0, dArray.Size());
        }

        [TestMethod]
        public void PerformanceTest_Adding100000AndDeletingThemByLastIndex_Integers_PropperSize()
        {
            var dArray = new DynamicArray<int>(100000);
            Watch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                dArray.Add(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 100000: {Watch}");

            Watch.Restart();
            while (dArray.Size() != 0)
            {
                dArray.Remove(index: dArray.Size() - 1);
            }
            Watch.Stop();
            Console.WriteLine($"Deleting 100000: {Watch}");

            Assert.AreEqual(0, dArray.Size());
        }

        [TestMethod]
        public void PerformanceTest_Adding100000AndDeletingThemByIndex0_Integers_PropperSize()
        {
            var dArray = new DynamicArray<int>(100000);
            Watch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                dArray.Add(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 100000: {Watch}");

            Watch.Restart();
            while (dArray.Size() != 0)
            {
                dArray.Remove(index: 0);
            }
            Watch.Stop();
            Console.WriteLine($"Deleting 100000: {Watch}");

            Assert.AreEqual(0, dArray.Size());
        }
    }
}
