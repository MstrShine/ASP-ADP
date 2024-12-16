using HAN.ASD.ADP.DataStructures.DLList;
using System.Diagnostics;

namespace HAN.ASD.ADP.Test.DataStructures
{
    [TestClass]
    public class DoublyLinkedListTest
    {
        private Stopwatch Watch = new Stopwatch();

        [TestMethod]
        public void Adding10DeletingOnElement10Start0()
        {
            var dlist = new DoublyLinkedList<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                dlist.Add(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 10: {Watch}");
            Assert.IsTrue(dlist.Size() == 10);

            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                dlist.Remove(element: i);
            }
            Watch.Stop();
            Console.WriteLine($"Deleting 10: {Watch}");
            Assert.IsTrue(dlist.Size() == 0);
        }

        [TestMethod]
        public void Adding10DeletingOnElement10Start10()
        {
            var dlist = new DoublyLinkedList<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                dlist.Add(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 10: {Watch}");
            Assert.IsTrue(dlist.Size() == 10);

            Watch.Restart();
            for (int i = 9; i > -1; i--)
            {
                dlist.Remove(element: i);
            }
            Watch.Stop();
            Console.WriteLine($"Deleting 10: {Watch}");
            Assert.IsTrue(dlist.Size() == 0);
        }

        [TestMethod]
        public void Adding10DeletingOnIndex10Start0()
        {
            var dlist = new DoublyLinkedList<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                dlist.Add(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 10: {Watch}");
            Assert.IsTrue(dlist.Size() == 10);

            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                dlist.Remove(index: 0);
            }
            Watch.Stop();
            Console.WriteLine($"Deleting 10: {Watch}");
            Assert.IsTrue(dlist.Size() == 0);
        }

        [TestMethod]
        public void Adding10DeletingOnIndex10Start10()
        {
            var dlist = new DoublyLinkedList<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                dlist.Add(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 10: {Watch}");
            Assert.IsTrue(dlist.Size() == 10);

            Watch.Restart();
            for (int i = 9; i > -1; i--)
            {
                dlist.Remove(index: i);
            }
            Watch.Stop();
            Console.WriteLine($"Deleting 10: {Watch}");
            Assert.IsTrue(dlist.Size() == 0);
        }

        [TestMethod]
        public void Adding10CheckingContainsAll10()
        {
            var dlist = new DoublyLinkedList<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                dlist.Add(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 10: {Watch}");
            Assert.IsTrue(dlist.Size() == 10);

            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                Assert.IsTrue(dlist.Contains(i));
            }
            Watch.Stop();
            Console.WriteLine($"Checking all 10: {Watch}");
        }

        [TestMethod]
        public void Adding10Getting10ByIndex()
        {
            var dlist = new DoublyLinkedList<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                dlist.Add(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 10: {Watch}");
            Assert.IsTrue(dlist.Size() == 10);

            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                Assert.IsTrue(dlist.Get(i) == i);
            }
            Watch.Stop();
            Console.WriteLine($"Getting all 10: {Watch}");
        }

        [TestMethod]
        public void Adding10GettingIndexOf10()
        {
            var dlist = new DoublyLinkedList<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                dlist.Add(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 10: {Watch}");
            Assert.IsTrue(dlist.Size() == 10);

            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                Assert.IsTrue(dlist.IndexOf(i) == i);
            }
            Watch.Stop();
            Console.WriteLine($"Getting index of all 10: {Watch}");
        }

        [TestMethod]
        public void Adding10SettingNewValueForAllTo10()
        {
            var dlist = new DoublyLinkedList<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                dlist.Add(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 10: {Watch}");
            Assert.IsTrue(dlist.Size() == 10);

            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                dlist.Set(i, 10);
            }
            Watch.Stop();
            Console.WriteLine($"Setting all to 10: {Watch}");

            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                var val = dlist.Get(i);
                Assert.AreEqual(10, val);
            }
            Watch.Stop();
            Console.WriteLine($"Getting all 10: {Watch}");
        }

        [TestMethod]
        public void PerformanceTest_Adding100000AndDeletingThemByElement_Integers()
        {
            var dlist = new DoublyLinkedList<int>();
            Watch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                dlist.Add(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 100000: {Watch}");

            Watch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                dlist.Remove(element: i);
            }
            Watch.Stop();
            Console.WriteLine($"Deleting 100000: {Watch}");

            Assert.AreEqual(0, dlist.Size());
        }

        [TestMethod]
        public void PerformanceTest_Adding100000AndDeletingThemByLastIndex_Integers()
        {
            var dlist = new DoublyLinkedList<int>();
            Watch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                dlist.Add(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 100000: {Watch}");

            Watch.Restart();
            while (dlist.Size() != 0)
            {
                dlist.Remove(index: dlist.Size() - 1);
            }
            Watch.Stop();
            Console.WriteLine($"Deleting 100000: {Watch}");

            Assert.AreEqual(0, dlist.Size());
        }

        [TestMethod]
        public void PerformanceTest_Adding100000AndDeletingThemByIndex0_Integers()
        {
            var dlist = new DoublyLinkedList<int>();
            Watch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                dlist.Add(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 100000: {Watch}");

            Watch.Restart();
            while (dlist.Size() != 0)
            {
                dlist.Remove(index: 0);
            }
            Watch.Stop();
            Console.WriteLine($"Deleting 100000: {Watch}");

            Assert.AreEqual(0, dlist.Size());
        }
    }
}
