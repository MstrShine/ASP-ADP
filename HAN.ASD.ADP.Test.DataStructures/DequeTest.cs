using HAN.ASD.ADP.DataStructures.Deque;
using System.Diagnostics;

namespace HAN.ASD.ADP.Test.DataStructures
{
    [TestClass]
    public class DequeTest
    {
        private Stopwatch Watch = new Stopwatch();

        [TestMethod]
        public void InsertRight_DeleteLeft_NotPropperSize()
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
        public void InsertRight_DeleteRight_NotPropperSize()
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
        public void InsertRight_DeleteLeft_PropperSize()
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
        public void InsertRight_DeleteRight_PropperSize()
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
        public void InsertLeft_DeleteRight_NoPropperSize()
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
        public void InsertLeft_DeleteLeft_NoPropperSize()
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
        public void InsertLeft_DeleteRight_PropperSize()
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
        public void InsertLeft_DeleteLeft_PropperSize()
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
    }
}
