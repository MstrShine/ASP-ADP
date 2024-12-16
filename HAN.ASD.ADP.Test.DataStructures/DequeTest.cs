using HAN.ASD.ADP.DataStructures.Deque;
using System.Diagnostics;

namespace HAN.ASD.ADP.Test.DataStructures
{
    [TestClass]
    public class DequeTest
    {
        private Stopwatch Watch = new Stopwatch();

        [TestMethod]
        public void InsertRightDeleteLeft_NotPropperSize()
        {
            var deque = new Deque<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                deque.InsertRight(i);
            }
            Watch.Stop();

            Console.WriteLine($"Inserting 10x: {Watch}");

            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                var deleted = deque.DeleteLeft();
                Assert.IsTrue(deleted == i);
            }
            Watch.Stop();

            Console.WriteLine($"Deleting 10x: {Watch}");
        }

        [TestMethod]
        public void InsertRightDeleteRight_NotPropperSize()
        {
            var deque = new Deque<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                deque.InsertRight(i);
            }
            Watch.Stop();

            Console.WriteLine($"Inserting 10x: {Watch}");

            Watch.Restart();
            for (int i = 9; i != 0; i--)
            {
                var deleted = deque.DeleteRight();
                Assert.IsTrue(deleted == i);
            }
            Watch.Stop();

            Console.WriteLine($"Deleting 10x: {Watch}");
        }

        [TestMethod]
        public void InsertRightDeleteLeft_PropperSize()
        {
            var deque = new Deque<int>(10);
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                deque.InsertRight(i);
            }
            Watch.Stop();

            Console.WriteLine($"Inserting 10x: {Watch}");

            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                var deleted = deque.DeleteLeft();
                Assert.IsTrue(deleted == i);
            }
            Watch.Stop();

            Console.WriteLine($"Deleting 10x: {Watch}");
        }

        [TestMethod]
        public void InsertRightDeleteRight_PropperSize()
        {
            var deque = new Deque<int>(10);
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                deque.InsertRight(i);
            }
            Watch.Stop();

            Console.WriteLine($"Inserting 10x: {Watch}");

            Watch.Restart();
            for (int i = 9; i != 0; i--)
            {
                var deleted = deque.DeleteRight();
                Assert.IsTrue(deleted == i);
            }
            Watch.Stop();

            Console.WriteLine($"Deleting 10x: {Watch}");
        }

        [TestMethod]
        public void InsertLeftDeleteRight_NoPropperSize()
        {
            var deque = new Deque<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                deque.InsertLeft(i);
            }
            Watch.Stop();

            Console.WriteLine($"Inserting 10x: {Watch}");

            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                var deleted = deque.DeleteRight();
                Assert.IsTrue(deleted == i);
            }
            Watch.Stop();

            Console.WriteLine($"Deleting 10x: {Watch}");
        }

        [TestMethod]
        public void InsertLeftDeleteLeft_NoPropperSize()
        {
            var deque = new Deque<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                deque.InsertLeft(i);
            }
            Watch.Stop();

            Console.WriteLine($"Inserting 10x: {Watch}");

            Watch.Restart();
            for (int i = 9; i != 0; i--)
            {
                var deleted = deque.DeleteLeft();
                Assert.IsTrue(deleted == i);
            }
            Watch.Stop();

            Console.WriteLine($"Deleting 10x: {Watch}");
        }

        [TestMethod]
        public void InsertLeftDeleteRight_PropperSize()
        {
            var deque = new Deque<int>(10);
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                deque.InsertLeft(i);
            }
            Watch.Stop();

            Console.WriteLine($"Inserting 10x: {Watch}");

            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                var deleted = deque.DeleteRight();
                if (i == 0)
                {
                    Assert.IsTrue(deleted == 9);
                }
                else
                {
                    Assert.IsTrue(deleted == i);
                }
            }
            Watch.Stop();

            Console.WriteLine($"Deleting 10x: {Watch}");
        }

        [TestMethod]
        public void InsertLeftDeleteLeft_PropperSize()
        {
            var deque = new Deque<int>(10);
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                deque.InsertLeft(i);
            }
            Watch.Stop();

            Console.WriteLine($"Inserting 10x: {Watch}");

            Watch.Restart();
            for (int i = 9; i != 0; i--)
            {
                var deleted = deque.DeleteLeft();
                Assert.IsTrue(deleted == i);
            }
            Watch.Stop();

            Console.WriteLine($"Deleting 10x: {Watch}");
        }

        [TestMethod]
        public void PerformanceTest_InsertLeft100000DeletingLeft_PropperSize()
        {
            var deque = new Deque<int>(100000);
            Watch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                deque.InsertLeft(i);
            }
            Watch.Stop();

            Console.WriteLine($"Inserting 100000: {Watch}");

            Watch.Restart();
            while (deque.Size() != 0)
            {
                var deleted = deque.DeleteLeft();
                Assert.IsTrue(deleted == deque.Size());
            }
            Watch.Stop();

            Console.WriteLine($"Deleting 100000: {Watch}");
        }

        [TestMethod]
        public void PerformanceTest_InsertLeft100000DeleteRight_PropperSize()
        {
            var deque = new Deque<int>(100000);
            Watch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                deque.InsertLeft(i);
            }
            Watch.Stop();

            Console.WriteLine($"Inserting 10x: {Watch}");

            Watch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                var deleted = deque.DeleteRight();
                if (i == 0)
                {
                    Assert.IsTrue(deleted == 100000 - 1);
                }
                else
                {
                    Assert.IsTrue(deleted == i);
                }
            }
            Watch.Stop();

            Console.WriteLine($"Deleting 10x: {Watch}");
        }

        [TestMethod]
        public void PerformanceTest_InsertLeft100000DeletingLeft_NotPropperSize()
        {
            var deque = new Deque<int>();
            Watch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                deque.InsertLeft(i);
            }
            Watch.Stop();

            Console.WriteLine($"Inserting 100000: {Watch}");

            Watch.Restart();
            while (deque.Size() != 0)
            {
                var deleted = deque.DeleteLeft();
                Assert.IsTrue(deleted == deque.Size());
            }
            Watch.Stop();

            Console.WriteLine($"Deleting 100000: {Watch}");
        }

        [TestMethod]
        public void PerformanceTest_InsertLeft100000DeleteRight_NotPropperSize()
        {
            var deque = new Deque<int>();
            Watch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                deque.InsertLeft(i);
            }
            Watch.Stop();

            Console.WriteLine($"Inserting 100000: {Watch}");

            Watch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                var deleted = deque.DeleteRight();
                Assert.IsTrue(deleted == i);
            }
            Watch.Stop();

            Console.WriteLine($"Deleting 100000: {Watch}");
        }

        [TestMethod]
        public void PerformanceTest_InsertRight100000DeleteLeft_NotPropperSize()
        {
            var deque = new Deque<int>();
            Watch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                deque.InsertRight(i);
            }
            Watch.Stop();

            Console.WriteLine($"Inserting 100000: {Watch}");

            Watch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                var deleted = deque.DeleteLeft();
                Assert.IsTrue(deleted == i);
            }
            Watch.Stop();

            Console.WriteLine($"Deleting 100000: {Watch}");
        }

        [TestMethod]
        public void PerformanceTest_InsertRight100000DeleteRight_NotPropperSize()
        {
            var deque = new Deque<int>();
            Watch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                deque.InsertRight(i);
            }
            Watch.Stop();

            Console.WriteLine($"Inserting 100000: {Watch}");

            Watch.Restart();
            while (deque.Size() != 0)
            {
                var deleted = deque.DeleteRight();
                Assert.IsTrue(deleted == deque.Size());
            }
            Watch.Stop();

            Console.WriteLine($"Deleting 100000: {Watch}");
        }

        [TestMethod]
        public void PerformanceTest_InsertRight100000DeleteLeft_PropperSize()
        {
            var deque = new Deque<int>(100000);
            Watch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                deque.InsertRight(i);
            }
            Watch.Stop();

            Console.WriteLine($"Inserting 100000: {Watch}");

            Watch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                var deleted = deque.DeleteLeft();
                Assert.IsTrue(deleted == i);
            }
            Watch.Stop();

            Console.WriteLine($"Deleting 100000: {Watch}");
        }

        [TestMethod]
        public void PerformanceTest_InsertRight100000DeleteRight_PropperSize()
        {
            var deque = new Deque<int>(100000);
            Watch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                deque.InsertRight(i);
            }
            Watch.Stop();

            Console.WriteLine($"Inserting 100000: {Watch}");

            Watch.Restart();
            while (deque.Size() != 0)
            {
                var deleted = deque.DeleteRight();
                Assert.IsTrue(deleted == deque.Size());
            }
            Watch.Stop();

            Console.WriteLine($"Deleting 100000: {Watch}");
        }
    }
}
